﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace ConvertApp.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Currency ConversionSoap", Namespace="https://localhost:44340")]
    public partial class CurrencyConversion : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback VND2USDOperationCompleted;
        
        private System.Threading.SendOrPostCallback VND2EUROperationCompleted;
        
        private System.Threading.SendOrPostCallback USD2VNDOperationCompleted;
        
        private System.Threading.SendOrPostCallback EUR2VNDOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CurrencyConversion() {
            this.Url = global::ConvertApp.Properties.Settings.Default.ConvertApp_localhost_Currency_x0020_Conversion;
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
        public event VND2USDCompletedEventHandler VND2USDCompleted;
        
        /// <remarks/>
        public event VND2EURCompletedEventHandler VND2EURCompleted;
        
        /// <remarks/>
        public event USD2VNDCompletedEventHandler USD2VNDCompleted;
        
        /// <remarks/>
        public event EUR2VNDCompletedEventHandler EUR2VNDCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://localhost:44340/VND2USD", RequestNamespace="https://localhost:44340", ResponseNamespace="https://localhost:44340", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double VND2USD(double VND) {
            object[] results = this.Invoke("VND2USD", new object[] {
                        VND});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void VND2USDAsync(double VND) {
            this.VND2USDAsync(VND, null);
        }
        
        /// <remarks/>
        public void VND2USDAsync(double VND, object userState) {
            if ((this.VND2USDOperationCompleted == null)) {
                this.VND2USDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVND2USDOperationCompleted);
            }
            this.InvokeAsync("VND2USD", new object[] {
                        VND}, this.VND2USDOperationCompleted, userState);
        }
        
        private void OnVND2USDOperationCompleted(object arg) {
            if ((this.VND2USDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VND2USDCompleted(this, new VND2USDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://localhost:44340/VND2EUR", RequestNamespace="https://localhost:44340", ResponseNamespace="https://localhost:44340", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double VND2EUR(double VND) {
            object[] results = this.Invoke("VND2EUR", new object[] {
                        VND});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void VND2EURAsync(double VND) {
            this.VND2EURAsync(VND, null);
        }
        
        /// <remarks/>
        public void VND2EURAsync(double VND, object userState) {
            if ((this.VND2EUROperationCompleted == null)) {
                this.VND2EUROperationCompleted = new System.Threading.SendOrPostCallback(this.OnVND2EUROperationCompleted);
            }
            this.InvokeAsync("VND2EUR", new object[] {
                        VND}, this.VND2EUROperationCompleted, userState);
        }
        
        private void OnVND2EUROperationCompleted(object arg) {
            if ((this.VND2EURCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VND2EURCompleted(this, new VND2EURCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://localhost:44340/USD2VND", RequestNamespace="https://localhost:44340", ResponseNamespace="https://localhost:44340", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double USD2VND(double USD) {
            object[] results = this.Invoke("USD2VND", new object[] {
                        USD});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void USD2VNDAsync(double USD) {
            this.USD2VNDAsync(USD, null);
        }
        
        /// <remarks/>
        public void USD2VNDAsync(double USD, object userState) {
            if ((this.USD2VNDOperationCompleted == null)) {
                this.USD2VNDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUSD2VNDOperationCompleted);
            }
            this.InvokeAsync("USD2VND", new object[] {
                        USD}, this.USD2VNDOperationCompleted, userState);
        }
        
        private void OnUSD2VNDOperationCompleted(object arg) {
            if ((this.USD2VNDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.USD2VNDCompleted(this, new USD2VNDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://localhost:44340/EUR2VND", RequestNamespace="https://localhost:44340", ResponseNamespace="https://localhost:44340", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double EUR2VND(double EUR) {
            object[] results = this.Invoke("EUR2VND", new object[] {
                        EUR});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void EUR2VNDAsync(double EUR) {
            this.EUR2VNDAsync(EUR, null);
        }
        
        /// <remarks/>
        public void EUR2VNDAsync(double EUR, object userState) {
            if ((this.EUR2VNDOperationCompleted == null)) {
                this.EUR2VNDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEUR2VNDOperationCompleted);
            }
            this.InvokeAsync("EUR2VND", new object[] {
                        EUR}, this.EUR2VNDOperationCompleted, userState);
        }
        
        private void OnEUR2VNDOperationCompleted(object arg) {
            if ((this.EUR2VNDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EUR2VNDCompleted(this, new EUR2VNDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void VND2USDCompletedEventHandler(object sender, VND2USDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VND2USDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VND2USDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void VND2EURCompletedEventHandler(object sender, VND2EURCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VND2EURCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VND2EURCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void USD2VNDCompletedEventHandler(object sender, USD2VNDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class USD2VNDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal USD2VNDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void EUR2VNDCompletedEventHandler(object sender, EUR2VNDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EUR2VNDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EUR2VNDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591