﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Interface.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Connect", ReplyAction="http://tempuri.org/IService1/ConnectResponse")]
        void Connect();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Connect", ReplyAction="http://tempuri.org/IService1/ConnectResponse")]
        System.Threading.Tasks.Task ConnectAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Diconnect", ReplyAction="http://tempuri.org/IService1/DiconnectResponse")]
        void Diconnect();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Diconnect", ReplyAction="http://tempuri.org/IService1/DiconnectResponse")]
        System.Threading.Tasks.Task DiconnectAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchFile", ReplyAction="http://tempuri.org/IService1/SearchFileResponse")]
        string[] SearchFile();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchFile", ReplyAction="http://tempuri.org/IService1/SearchFileResponse")]
        System.Threading.Tasks.Task<string[]> SearchFileAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchFolder", ReplyAction="http://tempuri.org/IService1/SearchFolderResponse")]
        string SearchFolder();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchFolder", ReplyAction="http://tempuri.org/IService1/SearchFolderResponse")]
        System.Threading.Tasks.Task<string> SearchFolderAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Insert", ReplyAction="http://tempuri.org/IService1/InsertResponse")]
        void Insert(string[] dbInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Insert", ReplyAction="http://tempuri.org/IService1/InsertResponse")]
        System.Threading.Tasks.Task InsertAsync(string[] dbInfo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Interface.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Interface.ServiceReference1.IService1>, Interface.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Connect() {
            base.Channel.Connect();
        }
        
        public System.Threading.Tasks.Task ConnectAsync() {
            return base.Channel.ConnectAsync();
        }
        
        public void Diconnect() {
            base.Channel.Diconnect();
        }
        
        public System.Threading.Tasks.Task DiconnectAsync() {
            return base.Channel.DiconnectAsync();
        }
        
        public string[] SearchFile() {
            return base.Channel.SearchFile();
        }
        
        public System.Threading.Tasks.Task<string[]> SearchFileAsync() {
            return base.Channel.SearchFileAsync();
        }
        
        public string SearchFolder() {
            return base.Channel.SearchFolder();
        }
        
        public System.Threading.Tasks.Task<string> SearchFolderAsync() {
            return base.Channel.SearchFolderAsync();
        }
        
        public void Insert(string[] dbInfo) {
            base.Channel.Insert(dbInfo);
        }
        
        public System.Threading.Tasks.Task InsertAsync(string[] dbInfo) {
            return base.Channel.InsertAsync(dbInfo);
        }
    }
}
