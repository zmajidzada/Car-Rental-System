﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalWebSite.CustomerManagementServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerManagementServiceReference.ICustomerManagementService")]
    public interface ICustomerManagementService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerManagementService/RetrieveCustomerDetails", ReplyAction="http://tempuri.org/ICustomerManagementService/RetrieveCustomerDetailsResponse")]
        CarRentalServices.Customer RetrieveCustomerDetails(int accountId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerManagementService/RetrieveCustomerDetails", ReplyAction="http://tempuri.org/ICustomerManagementService/RetrieveCustomerDetailsResponse")]
        System.Threading.Tasks.Task<CarRentalServices.Customer> RetrieveCustomerDetailsAsync(int accountId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerManagementService/UpdateCustomerDetails", ReplyAction="http://tempuri.org/ICustomerManagementService/UpdateCustomerDetailsResponse")]
        string UpdateCustomerDetails(int accountId, CarRentalServices.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerManagementService/UpdateCustomerDetails", ReplyAction="http://tempuri.org/ICustomerManagementService/UpdateCustomerDetailsResponse")]
        System.Threading.Tasks.Task<string> UpdateCustomerDetailsAsync(int accountId, CarRentalServices.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerManagementService/DeleteDetails", ReplyAction="http://tempuri.org/ICustomerManagementService/DeleteDetailsResponse")]
        string DeleteDetails(int accountId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerManagementService/DeleteDetails", ReplyAction="http://tempuri.org/ICustomerManagementService/DeleteDetailsResponse")]
        System.Threading.Tasks.Task<string> DeleteDetailsAsync(int accountId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerManagementService/ListCustomer", ReplyAction="http://tempuri.org/ICustomerManagementService/ListCustomerResponse")]
        CarRentalServices.CustomerModel[] ListCustomer();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerManagementService/ListCustomer", ReplyAction="http://tempuri.org/ICustomerManagementService/ListCustomerResponse")]
        System.Threading.Tasks.Task<CarRentalServices.CustomerModel[]> ListCustomerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerManagementService/GetCusomterInfo", ReplyAction="http://tempuri.org/ICustomerManagementService/GetCusomterInfoResponse")]
        System.Data.DataSet GetCusomterInfo(int accountId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerManagementService/GetCusomterInfo", ReplyAction="http://tempuri.org/ICustomerManagementService/GetCusomterInfoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetCusomterInfoAsync(int accountId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerManagementServiceChannel : CarRentalWebSite.CustomerManagementServiceReference.ICustomerManagementService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerManagementServiceClient : System.ServiceModel.ClientBase<CarRentalWebSite.CustomerManagementServiceReference.ICustomerManagementService>, CarRentalWebSite.CustomerManagementServiceReference.ICustomerManagementService {
        
        public CustomerManagementServiceClient() {
        }
        
        public CustomerManagementServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerManagementServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerManagementServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerManagementServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CarRentalServices.Customer RetrieveCustomerDetails(int accountId) {
            return base.Channel.RetrieveCustomerDetails(accountId);
        }
        
        public System.Threading.Tasks.Task<CarRentalServices.Customer> RetrieveCustomerDetailsAsync(int accountId) {
            return base.Channel.RetrieveCustomerDetailsAsync(accountId);
        }
        
        public string UpdateCustomerDetails(int accountId, CarRentalServices.Customer customer) {
            return base.Channel.UpdateCustomerDetails(accountId, customer);
        }
        
        public System.Threading.Tasks.Task<string> UpdateCustomerDetailsAsync(int accountId, CarRentalServices.Customer customer) {
            return base.Channel.UpdateCustomerDetailsAsync(accountId, customer);
        }
        
        public string DeleteDetails(int accountId) {
            return base.Channel.DeleteDetails(accountId);
        }
        
        public System.Threading.Tasks.Task<string> DeleteDetailsAsync(int accountId) {
            return base.Channel.DeleteDetailsAsync(accountId);
        }
        
        public CarRentalServices.CustomerModel[] ListCustomer() {
            return base.Channel.ListCustomer();
        }
        
        public System.Threading.Tasks.Task<CarRentalServices.CustomerModel[]> ListCustomerAsync() {
            return base.Channel.ListCustomerAsync();
        }
        
        public System.Data.DataSet GetCusomterInfo(int accountId) {
            return base.Channel.GetCusomterInfo(accountId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetCusomterInfoAsync(int accountId) {
            return base.Channel.GetCusomterInfoAsync(accountId);
        }
    }
}
