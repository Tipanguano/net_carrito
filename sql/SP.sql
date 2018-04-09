alter procedure SP_tmp_ingresa_factura_cab
@nombreCliente      varchar(100),
@nombreVendedor		varchar(100),
@codigo_unico		varchar(100)= null,
@idFactura			int output
as
declare @codigo_factura	    int
begin
if  exists( select * 
			from tmp_cabecera_factura t
			where t.nombre_cliente=@nombreCliente 
			and t.nombre_vendedor =@nombreVendedor 
			and convert (varchar,t.fecha_venta,105) = convert (varchar,GETDATE(),105))
begin
  set @codigo_factura= (select  top 1 t.id_factura
			from tmp_cabecera_factura t
			where t.nombre_cliente=@nombreCliente 
			and t.nombre_vendedor =@nombreVendedor 
			and convert (varchar,t.fecha_venta,105) = convert (varchar,GETDATE(),105)
			)
end
else
begin
if @codigo_unico is null
begin
  set @codigo_unico= newid()
end

  insert into tmp_cabecera_factura(codigo_unico,nombre_cliente,nombre_vendedor,fecha_venta) values(@codigo_unico,@nombreCliente,@nombreVendedor,getdate())
  set @codigo_factura=@@identity
end
set @idFactura=@codigo_factura
return @idFactura
end
--------
/*2do sp del detalle*/
alter procedure SP_tmp_ingresa_factura_detalle
@idFactura		    int,
@nombreProducto		varchar(100),
@precio_unitario    numeric(8,3),
@cantidad		    int,
@iva				decimal(8,3)=0.12
as
declare @ivaProducto   decimal(8,3)
begin
if @iva is null or @iva<0.12
begin
	set @iva=0.12
end

set @ivaProducto=(@precio_unitario*@cantidad)*@iva
   insert into tmp_detalle_factura(id_factura,nombre_producto,precio_unitario,cantidad,iva,subtotal_precio) 
   values(@idFactura,@nombreProducto,@precio_unitario,@cantidad, @ivaProducto ,(@precio_unitario*@cantidad)+@ivaProducto)

   update tmp_cabecera_factura set total_factura= (select sum(isnull (subtotal_precio,0)) from tmp_detalle_factura where id_factura=@idFactura)
end

alter procedure SP_consulta_factura
@nombreCliente          varchar(50),
@fechaFactura			datetime
as
begin
	select * 
	from tmp_cabecera_factura where nombre_cliente like '%'+@nombreCliente+'%'
	and  convert(varchar,fecha_venta,105)=convert(varchar,@fechaFactura,105)
end

----------------pruebas----------------
declare @idFactura  int
begin
exec SP_tmp_ingresa_factura_cab 'xavier','juan',null,@idFactura out
select @idFactura
end
----------------
exec SP_tmp_ingresa_factura_detalle 1,'peras',2.3,4,null
----------------
exec SP_consulta_factura 'xav','2018-04-08' 
 
