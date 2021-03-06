﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34209
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.34209.
// 
#pragma warning disable 1591

namespace WebApp_Client_factura.FacturaWs {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="FacturaWSSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BaseRespuesta))]
    public partial class FacturaWS : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback InsertaFacturaCbeceraOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertaFacturaDetalleOperationCompleted;
        
        private System.Threading.SendOrPostCallback ConsultaFacturaOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public FacturaWS() {
            this.Url = global::WebApp_Client_factura.Properties.Settings.Default.WebApp_Client_factura_FacturaWs_FacturaWS;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event InsertaFacturaCbeceraCompletedEventHandler InsertaFacturaCbeceraCompleted;
        
        /// <remarks/>
        public event InsertaFacturaDetalleCompletedEventHandler InsertaFacturaDetalleCompleted;
        
        /// <remarks/>
        public event ConsultaFacturaCompletedEventHandler ConsultaFacturaCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertaFacturaCbecera", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ResponseFacturaInserta InsertaFacturaCbecera(string nombreCliente, string nombreVenvedor) {
            object[] results = this.Invoke("InsertaFacturaCbecera", new object[] {
                        nombreCliente,
                        nombreVenvedor});
            return ((ResponseFacturaInserta)(results[0]));
        }
        
        /// <remarks/>
        public void InsertaFacturaCbeceraAsync(string nombreCliente, string nombreVenvedor) {
            this.InsertaFacturaCbeceraAsync(nombreCliente, nombreVenvedor, null);
        }
        
        /// <remarks/>
        public void InsertaFacturaCbeceraAsync(string nombreCliente, string nombreVenvedor, object userState) {
            if ((this.InsertaFacturaCbeceraOperationCompleted == null)) {
                this.InsertaFacturaCbeceraOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertaFacturaCbeceraOperationCompleted);
            }
            this.InvokeAsync("InsertaFacturaCbecera", new object[] {
                        nombreCliente,
                        nombreVenvedor}, this.InsertaFacturaCbeceraOperationCompleted, userState);
        }
        
        private void OnInsertaFacturaCbeceraOperationCompleted(object arg) {
            if ((this.InsertaFacturaCbeceraCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertaFacturaCbeceraCompleted(this, new InsertaFacturaCbeceraCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertaFacturaDetalle", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string InsertaFacturaDetalle(int idFactura, string nombreProducto, decimal precioUnitario, int cantidad, decimal iva) {
            object[] results = this.Invoke("InsertaFacturaDetalle", new object[] {
                        idFactura,
                        nombreProducto,
                        precioUnitario,
                        cantidad,
                        iva});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void InsertaFacturaDetalleAsync(int idFactura, string nombreProducto, decimal precioUnitario, int cantidad, decimal iva) {
            this.InsertaFacturaDetalleAsync(idFactura, nombreProducto, precioUnitario, cantidad, iva, null);
        }
        
        /// <remarks/>
        public void InsertaFacturaDetalleAsync(int idFactura, string nombreProducto, decimal precioUnitario, int cantidad, decimal iva, object userState) {
            if ((this.InsertaFacturaDetalleOperationCompleted == null)) {
                this.InsertaFacturaDetalleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertaFacturaDetalleOperationCompleted);
            }
            this.InvokeAsync("InsertaFacturaDetalle", new object[] {
                        idFactura,
                        nombreProducto,
                        precioUnitario,
                        cantidad,
                        iva}, this.InsertaFacturaDetalleOperationCompleted, userState);
        }
        
        private void OnInsertaFacturaDetalleOperationCompleted(object arg) {
            if ((this.InsertaFacturaDetalleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertaFacturaDetalleCompleted(this, new InsertaFacturaDetalleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ConsultaFactura", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ResponseFacturaConsulta ConsultaFactura(string nombreCliente, System.DateTime fechaFactura) {
            object[] results = this.Invoke("ConsultaFactura", new object[] {
                        nombreCliente,
                        fechaFactura});
            return ((ResponseFacturaConsulta)(results[0]));
        }
        
        /// <remarks/>
        public void ConsultaFacturaAsync(string nombreCliente, System.DateTime fechaFactura) {
            this.ConsultaFacturaAsync(nombreCliente, fechaFactura, null);
        }
        
        /// <remarks/>
        public void ConsultaFacturaAsync(string nombreCliente, System.DateTime fechaFactura, object userState) {
            if ((this.ConsultaFacturaOperationCompleted == null)) {
                this.ConsultaFacturaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConsultaFacturaOperationCompleted);
            }
            this.InvokeAsync("ConsultaFactura", new object[] {
                        nombreCliente,
                        fechaFactura}, this.ConsultaFacturaOperationCompleted, userState);
        }
        
        private void OnConsultaFacturaOperationCompleted(object arg) {
            if ((this.ConsultaFacturaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConsultaFacturaCompleted(this, new ConsultaFacturaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ResponseFacturaInserta : BaseRespuesta {
        
        private int codigoFacturaField;
        
        /// <comentarios/>
        public int CodigoFactura {
            get {
                return this.codigoFacturaField;
            }
            set {
                this.codigoFacturaField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResponseFacturaConsulta))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResponseFacturaInserta))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class BaseRespuesta {
        
        private string codigoSalidaField;
        
        private string mensajeSalidaField;
        
        /// <comentarios/>
        public string codigoSalida {
            get {
                return this.codigoSalidaField;
            }
            set {
                this.codigoSalidaField = value;
            }
        }
        
        /// <comentarios/>
        public string mensajeSalida {
            get {
                return this.mensajeSalidaField;
            }
            set {
                this.mensajeSalidaField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ResponseFacturaConsulta : BaseRespuesta {
        
        private System.Data.DataSet consultaDsField;
        
        /// <comentarios/>
        public System.Data.DataSet ConsultaDs {
            get {
                return this.consultaDsField;
            }
            set {
                this.consultaDsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void InsertaFacturaCbeceraCompletedEventHandler(object sender, InsertaFacturaCbeceraCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertaFacturaCbeceraCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertaFacturaCbeceraCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ResponseFacturaInserta Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ResponseFacturaInserta)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void InsertaFacturaDetalleCompletedEventHandler(object sender, InsertaFacturaDetalleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertaFacturaDetalleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertaFacturaDetalleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void ConsultaFacturaCompletedEventHandler(object sender, ConsultaFacturaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConsultaFacturaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConsultaFacturaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ResponseFacturaConsulta Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ResponseFacturaConsulta)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591