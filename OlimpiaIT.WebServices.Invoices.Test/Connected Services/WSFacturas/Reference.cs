﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OlimpiaIT.WebServices.Invoices.Test.WSFacturas {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InvoiceData", Namespace="http://schemas.datacontract.org/2004/07/OlimpiaIT.WebServices.Invoices.Contracts")]
    [System.SerializableAttribute()]
    public partial class InvoiceData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NITField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ProcentajeIVAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ValorTotalField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NIT {
            get {
                return this.NITField;
            }
            set {
                if ((object.ReferenceEquals(this.NITField, value) != true)) {
                    this.NITField = value;
                    this.RaisePropertyChanged("NIT");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ProcentajeIVA {
            get {
                return this.ProcentajeIVAField;
            }
            set {
                if ((this.ProcentajeIVAField.Equals(value) != true)) {
                    this.ProcentajeIVAField = value;
                    this.RaisePropertyChanged("ProcentajeIVA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ValorTotal {
            get {
                return this.ValorTotalField;
            }
            set {
                if ((this.ValorTotalField.Equals(value) != true)) {
                    this.ValorTotalField = value;
                    this.RaisePropertyChanged("ValorTotal");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultadoValidacionFactura", Namespace="http://schemas.datacontract.org/2004/07/OlimpiaIT.WebServices.Invoices.Contracts")]
    [System.SerializableAttribute()]
    public partial class ResultadoValidacionFactura : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool FacturasValidasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private OlimpiaIT.WebServices.Invoices.Test.WSFacturas.ResultData[] MensajesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TotalFacturasField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool FacturasValidas {
            get {
                return this.FacturasValidasField;
            }
            set {
                if ((this.FacturasValidasField.Equals(value) != true)) {
                    this.FacturasValidasField = value;
                    this.RaisePropertyChanged("FacturasValidas");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public OlimpiaIT.WebServices.Invoices.Test.WSFacturas.ResultData[] Mensajes {
            get {
                return this.MensajesField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajesField, value) != true)) {
                    this.MensajesField = value;
                    this.RaisePropertyChanged("Mensajes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double TotalFacturas {
            get {
                return this.TotalFacturasField;
            }
            set {
                if ((this.TotalFacturasField.Equals(value) != true)) {
                    this.TotalFacturasField = value;
                    this.RaisePropertyChanged("TotalFacturas");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultData", Namespace="http://schemas.datacontract.org/2004/07/OlimpiaIT.WebServices.Invoices.Manager")]
    [System.SerializableAttribute()]
    public partial class ResultData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdFacturaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsValidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] MensajesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdFactura {
            get {
                return this.IdFacturaField;
            }
            set {
                if ((this.IdFacturaField.Equals(value) != true)) {
                    this.IdFacturaField = value;
                    this.RaisePropertyChanged("IdFactura");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsValid {
            get {
                return this.IsValidField;
            }
            set {
                if ((this.IsValidField.Equals(value) != true)) {
                    this.IsValidField = value;
                    this.RaisePropertyChanged("IsValid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Mensajes {
            get {
                return this.MensajesField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajesField, value) != true)) {
                    this.MensajesField = value;
                    this.RaisePropertyChanged("Mensajes");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSFacturas.IFactura")]
    public interface IFactura {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFactura/CalcularTotalFacturas", ReplyAction="http://tempuri.org/IFactura/CalcularTotalFacturasResponse")]
        OlimpiaIT.WebServices.Invoices.Test.WSFacturas.ResultadoValidacionFactura CalcularTotalFacturas(OlimpiaIT.WebServices.Invoices.Test.WSFacturas.InvoiceData[] facturas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFactura/CalcularTotalFacturas", ReplyAction="http://tempuri.org/IFactura/CalcularTotalFacturasResponse")]
        System.Threading.Tasks.Task<OlimpiaIT.WebServices.Invoices.Test.WSFacturas.ResultadoValidacionFactura> CalcularTotalFacturasAsync(OlimpiaIT.WebServices.Invoices.Test.WSFacturas.InvoiceData[] facturas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFactura/ValidarFactura", ReplyAction="http://tempuri.org/IFactura/ValidarFacturaResponse")]
        OlimpiaIT.WebServices.Invoices.Test.WSFacturas.ResultData ValidarFactura(OlimpiaIT.WebServices.Invoices.Test.WSFacturas.InvoiceData factura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFactura/ValidarFactura", ReplyAction="http://tempuri.org/IFactura/ValidarFacturaResponse")]
        System.Threading.Tasks.Task<OlimpiaIT.WebServices.Invoices.Test.WSFacturas.ResultData> ValidarFacturaAsync(OlimpiaIT.WebServices.Invoices.Test.WSFacturas.InvoiceData factura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFactura/CalcularValorIVA", ReplyAction="http://tempuri.org/IFactura/CalcularValorIVAResponse")]
        double CalcularValorIVA(OlimpiaIT.WebServices.Invoices.Test.WSFacturas.InvoiceData factura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFactura/CalcularValorIVA", ReplyAction="http://tempuri.org/IFactura/CalcularValorIVAResponse")]
        System.Threading.Tasks.Task<double> CalcularValorIVAAsync(OlimpiaIT.WebServices.Invoices.Test.WSFacturas.InvoiceData factura);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFacturaChannel : OlimpiaIT.WebServices.Invoices.Test.WSFacturas.IFactura, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FacturaClient : System.ServiceModel.ClientBase<OlimpiaIT.WebServices.Invoices.Test.WSFacturas.IFactura>, OlimpiaIT.WebServices.Invoices.Test.WSFacturas.IFactura {
        
        public FacturaClient() {
        }
        
        public FacturaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FacturaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FacturaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FacturaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public OlimpiaIT.WebServices.Invoices.Test.WSFacturas.ResultadoValidacionFactura CalcularTotalFacturas(OlimpiaIT.WebServices.Invoices.Test.WSFacturas.InvoiceData[] facturas) {
            return base.Channel.CalcularTotalFacturas(facturas);
        }
        
        public System.Threading.Tasks.Task<OlimpiaIT.WebServices.Invoices.Test.WSFacturas.ResultadoValidacionFactura> CalcularTotalFacturasAsync(OlimpiaIT.WebServices.Invoices.Test.WSFacturas.InvoiceData[] facturas) {
            return base.Channel.CalcularTotalFacturasAsync(facturas);
        }
        
        public OlimpiaIT.WebServices.Invoices.Test.WSFacturas.ResultData ValidarFactura(OlimpiaIT.WebServices.Invoices.Test.WSFacturas.InvoiceData factura) {
            return base.Channel.ValidarFactura(factura);
        }
        
        public System.Threading.Tasks.Task<OlimpiaIT.WebServices.Invoices.Test.WSFacturas.ResultData> ValidarFacturaAsync(OlimpiaIT.WebServices.Invoices.Test.WSFacturas.InvoiceData factura) {
            return base.Channel.ValidarFacturaAsync(factura);
        }
        
        public double CalcularValorIVA(OlimpiaIT.WebServices.Invoices.Test.WSFacturas.InvoiceData factura) {
            return base.Channel.CalcularValorIVA(factura);
        }
        
        public System.Threading.Tasks.Task<double> CalcularValorIVAAsync(OlimpiaIT.WebServices.Invoices.Test.WSFacturas.InvoiceData factura) {
            return base.Channel.CalcularValorIVAAsync(factura);
        }
    }
}