﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFClientApplication.WCFTestApplication {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFTestApplication.IWCFTestApplication")]
    public interface IWCFTestApplication {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFTestApplication/GetData", ReplyAction="http://tempuri.org/IWCFTestApplication/GetDataResponse")]
        string GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFTestApplication/GetData", ReplyAction="http://tempuri.org/IWCFTestApplication/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWCFTestApplicationChannel : WCFClientApplication.WCFTestApplication.IWCFTestApplication, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFTestApplicationClient : System.ServiceModel.ClientBase<WCFClientApplication.WCFTestApplication.IWCFTestApplication>, WCFClientApplication.WCFTestApplication.IWCFTestApplication {
        
        public WCFTestApplicationClient() {
        }
        
        public WCFTestApplicationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFTestApplicationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFTestApplicationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFTestApplicationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData() {
            return base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
    }
}
