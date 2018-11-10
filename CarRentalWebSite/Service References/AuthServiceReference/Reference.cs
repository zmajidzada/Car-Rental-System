﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalWebSite.AuthServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuthServiceReference.IAuthService")]
    public interface IAuthService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/RegisterCustomerDetails", ReplyAction="http://tempuri.org/IAuthService/RegisterCustomerDetailsResponse")]
        bool RegisterCustomerDetails(CarRentalServices.CustomerModel customerModel, CarRentalServices.AddressModel customerAddressModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/RegisterCustomerDetails", ReplyAction="http://tempuri.org/IAuthService/RegisterCustomerDetailsResponse")]
        System.Threading.Tasks.Task<bool> RegisterCustomerDetailsAsync(CarRentalServices.CustomerModel customerModel, CarRentalServices.AddressModel customerAddressModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/AuthenticateCustomer", ReplyAction="http://tempuri.org/IAuthService/AuthenticateCustomerResponse")]
        bool AuthenticateCustomer(CarRentalServices.CustomerModel customerLogin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/AuthenticateCustomer", ReplyAction="http://tempuri.org/IAuthService/AuthenticateCustomerResponse")]
        System.Threading.Tasks.Task<bool> AuthenticateCustomerAsync(CarRentalServices.CustomerModel customerLogin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/RegisterAdmin", ReplyAction="http://tempuri.org/IAuthService/RegisterAdminResponse")]
        bool RegisterAdmin(CarRentalServices.AdminModel adminModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/RegisterAdmin", ReplyAction="http://tempuri.org/IAuthService/RegisterAdminResponse")]
        System.Threading.Tasks.Task<bool> RegisterAdminAsync(CarRentalServices.AdminModel adminModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/AuthenticateAdmin", ReplyAction="http://tempuri.org/IAuthService/AuthenticateAdminResponse")]
        bool AuthenticateAdmin(CarRentalServices.AdminModel adminModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/AuthenticateAdmin", ReplyAction="http://tempuri.org/IAuthService/AuthenticateAdminResponse")]
        System.Threading.Tasks.Task<bool> AuthenticateAdminAsync(CarRentalServices.AdminModel adminModel);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthServiceChannel : CarRentalWebSite.AuthServiceReference.IAuthService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthServiceClient : System.ServiceModel.ClientBase<CarRentalWebSite.AuthServiceReference.IAuthService>, CarRentalWebSite.AuthServiceReference.IAuthService {
        
        public AuthServiceClient() {
        }
        
        public AuthServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool RegisterCustomerDetails(CarRentalServices.CustomerModel customerModel, CarRentalServices.AddressModel customerAddressModel) {
            return base.Channel.RegisterCustomerDetails(customerModel, customerAddressModel);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterCustomerDetailsAsync(CarRentalServices.CustomerModel customerModel, CarRentalServices.AddressModel customerAddressModel) {
            return base.Channel.RegisterCustomerDetailsAsync(customerModel, customerAddressModel);
        }
        
        public bool AuthenticateCustomer(CarRentalServices.CustomerModel customerLogin) {
            return base.Channel.AuthenticateCustomer(customerLogin);
        }
        
        public System.Threading.Tasks.Task<bool> AuthenticateCustomerAsync(CarRentalServices.CustomerModel customerLogin) {
            return base.Channel.AuthenticateCustomerAsync(customerLogin);
        }
        
        public bool RegisterAdmin(CarRentalServices.AdminModel adminModel) {
            return base.Channel.RegisterAdmin(adminModel);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAdminAsync(CarRentalServices.AdminModel adminModel) {
            return base.Channel.RegisterAdminAsync(adminModel);
        }
        
        public bool AuthenticateAdmin(CarRentalServices.AdminModel adminModel) {
            return base.Channel.AuthenticateAdmin(adminModel);
        }
        
        public System.Threading.Tasks.Task<bool> AuthenticateAdminAsync(CarRentalServices.AdminModel adminModel) {
            return base.Channel.AuthenticateAdminAsync(adminModel);
        }
    }
}
