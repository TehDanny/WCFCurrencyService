﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CurrencyClient.CurrencyService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CurrencyDTO", Namespace="http://schemas.datacontract.org/2004/07/CurrencyService")]
    [System.SerializableAttribute()]
    public partial class CurrencyDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ExchangeRateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ISOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public decimal ExchangeRate {
            get {
                return this.ExchangeRateField;
            }
            set {
                if ((this.ExchangeRateField.Equals(value) != true)) {
                    this.ExchangeRateField = value;
                    this.RaisePropertyChanged("ExchangeRate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ISO {
            get {
                return this.ISOField;
            }
            set {
                if ((object.ReferenceEquals(this.ISOField, value) != true)) {
                    this.ISOField = value;
                    this.RaisePropertyChanged("ISO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CurrencyService.ICurrencyService")]
    public interface ICurrencyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyService/DanishKronerToEuro", ReplyAction="http://tempuri.org/ICurrencyService/DanishKronerToEuroResponse")]
        decimal DanishKronerToEuro(decimal danishKroner);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyService/DanishKronerToEuro", ReplyAction="http://tempuri.org/ICurrencyService/DanishKronerToEuroResponse")]
        System.Threading.Tasks.Task<decimal> DanishKronerToEuroAsync(decimal danishKroner);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyService/GetExchangeRate", ReplyAction="http://tempuri.org/ICurrencyService/GetExchangeRateResponse")]
        decimal GetExchangeRate(string iso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyService/GetExchangeRate", ReplyAction="http://tempuri.org/ICurrencyService/GetExchangeRateResponse")]
        System.Threading.Tasks.Task<decimal> GetExchangeRateAsync(string iso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyService/GetCurrencies", ReplyAction="http://tempuri.org/ICurrencyService/GetCurrenciesResponse")]
        CurrencyClient.CurrencyService.CurrencyDTO[] GetCurrencies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyService/GetCurrencies", ReplyAction="http://tempuri.org/ICurrencyService/GetCurrenciesResponse")]
        System.Threading.Tasks.Task<CurrencyClient.CurrencyService.CurrencyDTO[]> GetCurrenciesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICurrencyServiceChannel : CurrencyClient.CurrencyService.ICurrencyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CurrencyServiceClient : System.ServiceModel.ClientBase<CurrencyClient.CurrencyService.ICurrencyService>, CurrencyClient.CurrencyService.ICurrencyService {
        
        public CurrencyServiceClient() {
        }
        
        public CurrencyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CurrencyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CurrencyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CurrencyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal DanishKronerToEuro(decimal danishKroner) {
            return base.Channel.DanishKronerToEuro(danishKroner);
        }
        
        public System.Threading.Tasks.Task<decimal> DanishKronerToEuroAsync(decimal danishKroner) {
            return base.Channel.DanishKronerToEuroAsync(danishKroner);
        }
        
        public decimal GetExchangeRate(string iso) {
            return base.Channel.GetExchangeRate(iso);
        }
        
        public System.Threading.Tasks.Task<decimal> GetExchangeRateAsync(string iso) {
            return base.Channel.GetExchangeRateAsync(iso);
        }
        
        public CurrencyClient.CurrencyService.CurrencyDTO[] GetCurrencies() {
            return base.Channel.GetCurrencies();
        }
        
        public System.Threading.Tasks.Task<CurrencyClient.CurrencyService.CurrencyDTO[]> GetCurrenciesAsync() {
            return base.Channel.GetCurrenciesAsync();
        }
    }
}
