﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GatewayTest.CreditNoteServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CreditNoteServiceReference.ICreditNoteService")]
    public interface ICreditNoteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreditNoteService/GetCreditNote", ReplyAction="http://tempuri.org/ICreditNoteService/GetCreditNoteResponse")]
        int GetCreditNote(long tcNo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICreditNoteServiceChannel : GatewayTest.CreditNoteServiceReference.ICreditNoteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CreditNoteServiceClient : System.ServiceModel.ClientBase<GatewayTest.CreditNoteServiceReference.ICreditNoteService>, GatewayTest.CreditNoteServiceReference.ICreditNoteService {
        
        public CreditNoteServiceClient() {
        }
        
        public CreditNoteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CreditNoteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreditNoteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreditNoteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetCreditNote(long tcNo) {
            return base.Channel.GetCreditNote(tcNo);
        }
    }
}
