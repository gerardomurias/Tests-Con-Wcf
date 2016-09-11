﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFTestSolution.WPFClient.ZzaServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ZzaServices.IZzaService")]
    public interface IZzaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZzaService/GetProducts", ReplyAction="http://tempuri.org/IZzaService/GetProductsResponse")]
        System.Collections.ObjectModel.ObservableCollection<WCFTestSolution.Entities.Product> GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZzaService/GetProducts", ReplyAction="http://tempuri.org/IZzaService/GetProductsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<WCFTestSolution.Entities.Product>> GetProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZzaService/GetCustomers", ReplyAction="http://tempuri.org/IZzaService/GetCustomersResponse")]
        System.Collections.ObjectModel.ObservableCollection<WCFTestSolution.Entities.Customer> GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZzaService/GetCustomers", ReplyAction="http://tempuri.org/IZzaService/GetCustomersResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<WCFTestSolution.Entities.Customer>> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZzaService/SubmitOrder", ReplyAction="http://tempuri.org/IZzaService/SubmitOrderResponse")]
        void SubmitOrder(WCFTestSolution.Entities.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZzaService/SubmitOrder", ReplyAction="http://tempuri.org/IZzaService/SubmitOrderResponse")]
        System.Threading.Tasks.Task SubmitOrderAsync(WCFTestSolution.Entities.Order order);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IZzaServiceChannel : WCFTestSolution.WPFClient.ZzaServices.IZzaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ZzaServiceClient : System.ServiceModel.ClientBase<WCFTestSolution.WPFClient.ZzaServices.IZzaService>, WCFTestSolution.WPFClient.ZzaServices.IZzaService {
        
        public ZzaServiceClient() {
        }
        
        public ZzaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ZzaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ZzaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ZzaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.ObjectModel.ObservableCollection<WCFTestSolution.Entities.Product> GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<WCFTestSolution.Entities.Product>> GetProductsAsync() {
            return base.Channel.GetProductsAsync();
        }
        
        public System.Collections.ObjectModel.ObservableCollection<WCFTestSolution.Entities.Customer> GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<WCFTestSolution.Entities.Customer>> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public void SubmitOrder(WCFTestSolution.Entities.Order order) {
            base.Channel.SubmitOrder(order);
        }
        
        public System.Threading.Tasks.Task SubmitOrderAsync(WCFTestSolution.Entities.Order order) {
            return base.Channel.SubmitOrderAsync(order);
        }
    }
}
