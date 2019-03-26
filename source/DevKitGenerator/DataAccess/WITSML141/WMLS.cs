﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.3038.
// 
namespace Energistics.DataAccess.WITSML141.WMLS {
    using System.Xml.Serialization;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Diagnostics;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="StoreSoapBinding", Namespace="http://www.witsml.org/wsdl/120")]
    public partial class WMLS : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback WMLS_AddToStoreOperationCompleted;
        
        private System.Threading.SendOrPostCallback WMLS_DeleteFromStoreOperationCompleted;
        
        private System.Threading.SendOrPostCallback WMLS_GetBaseMsgOperationCompleted;
        
        private System.Threading.SendOrPostCallback WMLS_GetCapOperationCompleted;
        
        private System.Threading.SendOrPostCallback WMLS_GetFromStoreOperationCompleted;
        
        private System.Threading.SendOrPostCallback WMLS_GetVersionOperationCompleted;
        
        private System.Threading.SendOrPostCallback WMLS_UpdateInStoreOperationCompleted;
        
        /// <remarks/>
        public WMLS() {
            this.Url = "http://yourorg.com/yourwebservice";
        }
        
        /// <remarks/>
        public event WMLS_AddToStoreCompletedEventHandler WMLS_AddToStoreCompleted;
        
        /// <remarks/>
        public event WMLS_DeleteFromStoreCompletedEventHandler WMLS_DeleteFromStoreCompleted;
        
        /// <remarks/>
        public event WMLS_GetBaseMsgCompletedEventHandler WMLS_GetBaseMsgCompleted;
        
        /// <remarks/>
        public event WMLS_GetCapCompletedEventHandler WMLS_GetCapCompleted;
        
        /// <remarks/>
        public event WMLS_GetFromStoreCompletedEventHandler WMLS_GetFromStoreCompleted;
        
        /// <remarks/>
        public event WMLS_GetVersionCompletedEventHandler WMLS_GetVersionCompleted;
        
        /// <remarks/>
        public event WMLS_UpdateInStoreCompletedEventHandler WMLS_UpdateInStoreCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.witsml.org/action/120/Store.WMLS_AddToStore", RequestNamespace="http://www.witsml.org/message/120", ResponseNamespace="http://www.witsml.org/message/120")]
        [return: System.Xml.Serialization.SoapElementAttribute("Result")]
        public short WMLS_AddToStore(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn, out string SuppMsgOut) {
            object[] results = this.Invoke("WMLS_AddToStore", new object[] {
                        WMLtypeIn,
                        XMLin,
                        OptionsIn,
                        CapabilitiesIn});
            SuppMsgOut = ((string)(results[1]));
            return ((short)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginWMLS_AddToStore(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("WMLS_AddToStore", new object[] {
                        WMLtypeIn,
                        XMLin,
                        OptionsIn,
                        CapabilitiesIn}, callback, asyncState);
        }
        
        /// <remarks/>
        public short EndWMLS_AddToStore(System.IAsyncResult asyncResult, out string SuppMsgOut) {
            object[] results = this.EndInvoke(asyncResult);
            SuppMsgOut = ((string)(results[1]));
            return ((short)(results[0]));
        }
        
        /// <remarks/>
        public void WMLS_AddToStoreAsync(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn) {
            this.WMLS_AddToStoreAsync(WMLtypeIn, XMLin, OptionsIn, CapabilitiesIn, null);
        }
        
        /// <remarks/>
        public void WMLS_AddToStoreAsync(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn, object userState) {
            if ((this.WMLS_AddToStoreOperationCompleted == null)) {
                this.WMLS_AddToStoreOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWMLS_AddToStoreOperationCompleted);
            }
            this.InvokeAsync("WMLS_AddToStore", new object[] {
                        WMLtypeIn,
                        XMLin,
                        OptionsIn,
                        CapabilitiesIn}, this.WMLS_AddToStoreOperationCompleted, userState);
        }
        
        private void OnWMLS_AddToStoreOperationCompleted(object arg) {
            if ((this.WMLS_AddToStoreCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WMLS_AddToStoreCompleted(this, new WMLS_AddToStoreCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.witsml.org/action/120/Store.WMLS_DeleteFromStore", RequestNamespace="http://www.witsml.org/message/120", ResponseNamespace="http://www.witsml.org/message/120")]
        [return: System.Xml.Serialization.SoapElementAttribute("Result")]
        public short WMLS_DeleteFromStore(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn, out string SuppMsgOut) {
            object[] results = this.Invoke("WMLS_DeleteFromStore", new object[] {
                        WMLtypeIn,
                        QueryIn,
                        OptionsIn,
                        CapabilitiesIn});
            SuppMsgOut = ((string)(results[1]));
            return ((short)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginWMLS_DeleteFromStore(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("WMLS_DeleteFromStore", new object[] {
                        WMLtypeIn,
                        QueryIn,
                        OptionsIn,
                        CapabilitiesIn}, callback, asyncState);
        }
        
        /// <remarks/>
        public short EndWMLS_DeleteFromStore(System.IAsyncResult asyncResult, out string SuppMsgOut) {
            object[] results = this.EndInvoke(asyncResult);
            SuppMsgOut = ((string)(results[1]));
            return ((short)(results[0]));
        }
        
        /// <remarks/>
        public void WMLS_DeleteFromStoreAsync(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn) {
            this.WMLS_DeleteFromStoreAsync(WMLtypeIn, QueryIn, OptionsIn, CapabilitiesIn, null);
        }
        
        /// <remarks/>
        public void WMLS_DeleteFromStoreAsync(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn, object userState) {
            if ((this.WMLS_DeleteFromStoreOperationCompleted == null)) {
                this.WMLS_DeleteFromStoreOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWMLS_DeleteFromStoreOperationCompleted);
            }
            this.InvokeAsync("WMLS_DeleteFromStore", new object[] {
                        WMLtypeIn,
                        QueryIn,
                        OptionsIn,
                        CapabilitiesIn}, this.WMLS_DeleteFromStoreOperationCompleted, userState);
        }
        
        private void OnWMLS_DeleteFromStoreOperationCompleted(object arg) {
            if ((this.WMLS_DeleteFromStoreCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WMLS_DeleteFromStoreCompleted(this, new WMLS_DeleteFromStoreCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.witsml.org/action/120/Store.WMLS_GetBaseMsg", RequestNamespace="http://www.witsml.org/message/120", ResponseNamespace="http://www.witsml.org/message/120")]
        [return: System.Xml.Serialization.SoapElementAttribute("Result")]
        public string WMLS_GetBaseMsg(short ReturnValueIn) {
            object[] results = this.Invoke("WMLS_GetBaseMsg", new object[] {
                        ReturnValueIn});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginWMLS_GetBaseMsg(short ReturnValueIn, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("WMLS_GetBaseMsg", new object[] {
                        ReturnValueIn}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndWMLS_GetBaseMsg(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void WMLS_GetBaseMsgAsync(short ReturnValueIn) {
            this.WMLS_GetBaseMsgAsync(ReturnValueIn, null);
        }
        
        /// <remarks/>
        public void WMLS_GetBaseMsgAsync(short ReturnValueIn, object userState) {
            if ((this.WMLS_GetBaseMsgOperationCompleted == null)) {
                this.WMLS_GetBaseMsgOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWMLS_GetBaseMsgOperationCompleted);
            }
            this.InvokeAsync("WMLS_GetBaseMsg", new object[] {
                        ReturnValueIn}, this.WMLS_GetBaseMsgOperationCompleted, userState);
        }
        
        private void OnWMLS_GetBaseMsgOperationCompleted(object arg) {
            if ((this.WMLS_GetBaseMsgCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WMLS_GetBaseMsgCompleted(this, new WMLS_GetBaseMsgCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.witsml.org/action/120/Store.WMLS_GetCap", RequestNamespace="http://www.witsml.org/message/120", ResponseNamespace="http://www.witsml.org/message/120")]
        [return: System.Xml.Serialization.SoapElementAttribute("Result")]
        public short WMLS_GetCap(string OptionsIn, out string CapabilitiesOut, out string SuppMsgOut) {
            object[] results = this.Invoke("WMLS_GetCap", new object[] {
                        OptionsIn});
            CapabilitiesOut = ((string)(results[1]));
            SuppMsgOut = ((string)(results[2]));
            return ((short)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginWMLS_GetCap(string OptionsIn, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("WMLS_GetCap", new object[] {
                        OptionsIn}, callback, asyncState);
        }
        
        /// <remarks/>
        public short EndWMLS_GetCap(System.IAsyncResult asyncResult, out string CapabilitiesOut, out string SuppMsgOut) {
            object[] results = this.EndInvoke(asyncResult);
            CapabilitiesOut = ((string)(results[1]));
            SuppMsgOut = ((string)(results[2]));
            return ((short)(results[0]));
        }
        
        /// <remarks/>
        public void WMLS_GetCapAsync(string OptionsIn) {
            this.WMLS_GetCapAsync(OptionsIn, null);
        }
        
        /// <remarks/>
        public void WMLS_GetCapAsync(string OptionsIn, object userState) {
            if ((this.WMLS_GetCapOperationCompleted == null)) {
                this.WMLS_GetCapOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWMLS_GetCapOperationCompleted);
            }
            this.InvokeAsync("WMLS_GetCap", new object[] {
                        OptionsIn}, this.WMLS_GetCapOperationCompleted, userState);
        }
        
        private void OnWMLS_GetCapOperationCompleted(object arg) {
            if ((this.WMLS_GetCapCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WMLS_GetCapCompleted(this, new WMLS_GetCapCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.witsml.org/action/120/Store.WMLS_GetFromStore", RequestNamespace="http://www.witsml.org/message/120", ResponseNamespace="http://www.witsml.org/message/120")]
        [return: System.Xml.Serialization.SoapElementAttribute("Result")]
        public short WMLS_GetFromStore(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn, out string XMLout, out string SuppMsgOut) {
            object[] results = this.Invoke("WMLS_GetFromStore", new object[] {
                        WMLtypeIn,
                        QueryIn,
                        OptionsIn,
                        CapabilitiesIn});
            XMLout = ((string)(results[1]));
            SuppMsgOut = ((string)(results[2]));
            return ((short)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginWMLS_GetFromStore(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("WMLS_GetFromStore", new object[] {
                        WMLtypeIn,
                        QueryIn,
                        OptionsIn,
                        CapabilitiesIn}, callback, asyncState);
        }
        
        /// <remarks/>
        public short EndWMLS_GetFromStore(System.IAsyncResult asyncResult, out string XMLout, out string SuppMsgOut) {
            object[] results = this.EndInvoke(asyncResult);
            XMLout = ((string)(results[1]));
            SuppMsgOut = ((string)(results[2]));
            return ((short)(results[0]));
        }
        
        /// <remarks/>
        public void WMLS_GetFromStoreAsync(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn) {
            this.WMLS_GetFromStoreAsync(WMLtypeIn, QueryIn, OptionsIn, CapabilitiesIn, null);
        }
        
        /// <remarks/>
        public void WMLS_GetFromStoreAsync(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn, object userState) {
            if ((this.WMLS_GetFromStoreOperationCompleted == null)) {
                this.WMLS_GetFromStoreOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWMLS_GetFromStoreOperationCompleted);
            }
            this.InvokeAsync("WMLS_GetFromStore", new object[] {
                        WMLtypeIn,
                        QueryIn,
                        OptionsIn,
                        CapabilitiesIn}, this.WMLS_GetFromStoreOperationCompleted, userState);
        }
        
        private void OnWMLS_GetFromStoreOperationCompleted(object arg) {
            if ((this.WMLS_GetFromStoreCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WMLS_GetFromStoreCompleted(this, new WMLS_GetFromStoreCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.witsml.org/action/120/Store.WMLS_GetVersion", RequestNamespace="http://www.witsml.org/message/120", ResponseNamespace="http://www.witsml.org/message/120")]
        [return: System.Xml.Serialization.SoapElementAttribute("Result")]
        public string WMLS_GetVersion() {
            object[] results = this.Invoke("WMLS_GetVersion", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginWMLS_GetVersion(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("WMLS_GetVersion", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndWMLS_GetVersion(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void WMLS_GetVersionAsync() {
            this.WMLS_GetVersionAsync(null);
        }
        
        /// <remarks/>
        public void WMLS_GetVersionAsync(object userState) {
            if ((this.WMLS_GetVersionOperationCompleted == null)) {
                this.WMLS_GetVersionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWMLS_GetVersionOperationCompleted);
            }
            this.InvokeAsync("WMLS_GetVersion", new object[0], this.WMLS_GetVersionOperationCompleted, userState);
        }
        
        private void OnWMLS_GetVersionOperationCompleted(object arg) {
            if ((this.WMLS_GetVersionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WMLS_GetVersionCompleted(this, new WMLS_GetVersionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.witsml.org/action/120/Store.WMLS_UpdateInStore", RequestNamespace="http://www.witsml.org/message/120", ResponseNamespace="http://www.witsml.org/message/120")]
        [return: System.Xml.Serialization.SoapElementAttribute("Result")]
        public short WMLS_UpdateInStore(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn, out string SuppMsgOut) {
            object[] results = this.Invoke("WMLS_UpdateInStore", new object[] {
                        WMLtypeIn,
                        XMLin,
                        OptionsIn,
                        CapabilitiesIn});
            SuppMsgOut = ((string)(results[1]));
            return ((short)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginWMLS_UpdateInStore(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("WMLS_UpdateInStore", new object[] {
                        WMLtypeIn,
                        XMLin,
                        OptionsIn,
                        CapabilitiesIn}, callback, asyncState);
        }
        
        /// <remarks/>
        public short EndWMLS_UpdateInStore(System.IAsyncResult asyncResult, out string SuppMsgOut) {
            object[] results = this.EndInvoke(asyncResult);
            SuppMsgOut = ((string)(results[1]));
            return ((short)(results[0]));
        }
        
        /// <remarks/>
        public void WMLS_UpdateInStoreAsync(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn) {
            this.WMLS_UpdateInStoreAsync(WMLtypeIn, XMLin, OptionsIn, CapabilitiesIn, null);
        }
        
        /// <remarks/>
        public void WMLS_UpdateInStoreAsync(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn, object userState) {
            if ((this.WMLS_UpdateInStoreOperationCompleted == null)) {
                this.WMLS_UpdateInStoreOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWMLS_UpdateInStoreOperationCompleted);
            }
            this.InvokeAsync("WMLS_UpdateInStore", new object[] {
                        WMLtypeIn,
                        XMLin,
                        OptionsIn,
                        CapabilitiesIn}, this.WMLS_UpdateInStoreOperationCompleted, userState);
        }
        
        private void OnWMLS_UpdateInStoreOperationCompleted(object arg) {
            if ((this.WMLS_UpdateInStoreCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WMLS_UpdateInStoreCompleted(this, new WMLS_UpdateInStoreCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// <remarks/>
    public delegate void WMLS_AddToStoreCompletedEventHandler(object sender, WMLS_AddToStoreCompletedEventArgs e);
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WMLS_AddToStoreCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WMLS_AddToStoreCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public short Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((short)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string SuppMsgOut {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    public delegate void WMLS_DeleteFromStoreCompletedEventHandler(object sender, WMLS_DeleteFromStoreCompletedEventArgs e);
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WMLS_DeleteFromStoreCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WMLS_DeleteFromStoreCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public short Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((short)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string SuppMsgOut {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    public delegate void WMLS_GetBaseMsgCompletedEventHandler(object sender, WMLS_GetBaseMsgCompletedEventArgs e);
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WMLS_GetBaseMsgCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WMLS_GetBaseMsgCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void WMLS_GetCapCompletedEventHandler(object sender, WMLS_GetCapCompletedEventArgs e);
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WMLS_GetCapCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WMLS_GetCapCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public short Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((short)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string CapabilitiesOut {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string SuppMsgOut {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    public delegate void WMLS_GetFromStoreCompletedEventHandler(object sender, WMLS_GetFromStoreCompletedEventArgs e);
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WMLS_GetFromStoreCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WMLS_GetFromStoreCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public short Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((short)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string XMLout {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string SuppMsgOut {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    public delegate void WMLS_GetVersionCompletedEventHandler(object sender, WMLS_GetVersionCompletedEventArgs e);
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WMLS_GetVersionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WMLS_GetVersionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void WMLS_UpdateInStoreCompletedEventHandler(object sender, WMLS_UpdateInStoreCompletedEventArgs e);
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WMLS_UpdateInStoreCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WMLS_UpdateInStoreCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public short Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((short)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string SuppMsgOut {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
}
