create table tmp_cabecera_factura(
id_factura      int identity(1,1 )primary key,
codigo_unico	varchar(100),
nombre_cliente  varchar(100),
nombre_vendedor varchar(100),
fecha_venta		datetime,
total_factura   decimal(8,3)
)

create table tmp_detalle_factura(
id_detalle_factura  int identity(1,1) primary key, 
id_factura			int  CONSTRAINT FK_factura_cabecera_detalle foreign key references tmp_cabecera_factura(id_factura),
nombre_producto     varchar(100),
precio_unitario     numeric(8,3),
cantidad		    int,
iva				    numeric(8,3),
subtotal_precio		numeric(8,3)            
)