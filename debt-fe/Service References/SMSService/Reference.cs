﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace debt_fe.SMSService {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SMSService.WSAgentSoap")]
    public interface WSAgentSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SendSMS(string xmlParam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMS", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SendSMSAsync(string xmlParam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMSExt", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SendSMSExt(string username, string password, string startTime_yyyyMMddHHmm, string endTime_yyyyMMddHHmm, string fromEmail, string phone, int priority, string message, string callbackEmail, string callbackUrl, int reference, string information);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMSExt", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SendSMSExtAsync(string username, string password, string startTime_yyyyMMddHHmm, string endTime_yyyyMMddHHmm, string fromEmail, string phone, int priority, string message, string callbackEmail, string callbackUrl, int reference, string information);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetJob", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetJob(int jobISN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetJob", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetJobAsync(int jobISN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetLastestJobByPhone", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetLastestJobByPhone(string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetLastestJobByPhone", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetLastestJobByPhoneAsync(string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MergeScheduleExt", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string MergeScheduleExt(string blastName, int order, int type, long start, int speed, string emailFrom, string emailTo, int emailPriority, string emailSubject, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MergeScheduleExt", ReplyAction="*")]
        System.Threading.Tasks.Task<string> MergeScheduleExtAsync(string blastName, int order, int type, long start, int speed, string emailFrom, string emailTo, int emailPriority, string emailSubject, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetScheduleExt", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SetScheduleExt(string blastName, int order, int type, long start, int speed, string smsPhone, int smsPriority, string smsMessage, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetScheduleExt", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SetScheduleExtAsync(string blastName, int order, int type, long start, int speed, string smsPhone, int smsPriority, string smsMessage, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ClearScheduleExt", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string ClearScheduleExt(string blastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ClearScheduleExt", ReplyAction="*")]
        System.Threading.Tasks.Task<string> ClearScheduleExtAsync(string blastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetIncomingMessage", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetIncomingMessage(int messageISN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetIncomingMessage", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetIncomingMessageAsync(int messageISN);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSAgentSoapChannel : debt_fe.SMSService.WSAgentSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSAgentSoapClient : System.ServiceModel.ClientBase<debt_fe.SMSService.WSAgentSoap>, debt_fe.SMSService.WSAgentSoap {
        
        public WSAgentSoapClient() {
        }
        
        public WSAgentSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSAgentSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSAgentSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSAgentSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SendSMS(string xmlParam) {
            return base.Channel.SendSMS(xmlParam);
        }
        
        public System.Threading.Tasks.Task<string> SendSMSAsync(string xmlParam) {
            return base.Channel.SendSMSAsync(xmlParam);
        }
        
        public string SendSMSExt(string username, string password, string startTime_yyyyMMddHHmm, string endTime_yyyyMMddHHmm, string fromEmail, string phone, int priority, string message, string callbackEmail, string callbackUrl, int reference, string information) {
            return base.Channel.SendSMSExt(username, password, startTime_yyyyMMddHHmm, endTime_yyyyMMddHHmm, fromEmail, phone, priority, message, callbackEmail, callbackUrl, reference, information);
        }
        
        public System.Threading.Tasks.Task<string> SendSMSExtAsync(string username, string password, string startTime_yyyyMMddHHmm, string endTime_yyyyMMddHHmm, string fromEmail, string phone, int priority, string message, string callbackEmail, string callbackUrl, int reference, string information) {
            return base.Channel.SendSMSExtAsync(username, password, startTime_yyyyMMddHHmm, endTime_yyyyMMddHHmm, fromEmail, phone, priority, message, callbackEmail, callbackUrl, reference, information);
        }
        
        public System.Data.DataSet GetJob(int jobISN) {
            return base.Channel.GetJob(jobISN);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetJobAsync(int jobISN) {
            return base.Channel.GetJobAsync(jobISN);
        }
        
        public System.Data.DataSet GetLastestJobByPhone(string phone) {
            return base.Channel.GetLastestJobByPhone(phone);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetLastestJobByPhoneAsync(string phone) {
            return base.Channel.GetLastestJobByPhoneAsync(phone);
        }
        
        public string MergeScheduleExt(string blastName, int order, int type, long start, int speed, string emailFrom, string emailTo, int emailPriority, string emailSubject, string comment) {
            return base.Channel.MergeScheduleExt(blastName, order, type, start, speed, emailFrom, emailTo, emailPriority, emailSubject, comment);
        }
        
        public System.Threading.Tasks.Task<string> MergeScheduleExtAsync(string blastName, int order, int type, long start, int speed, string emailFrom, string emailTo, int emailPriority, string emailSubject, string comment) {
            return base.Channel.MergeScheduleExtAsync(blastName, order, type, start, speed, emailFrom, emailTo, emailPriority, emailSubject, comment);
        }
        
        public string SetScheduleExt(string blastName, int order, int type, long start, int speed, string smsPhone, int smsPriority, string smsMessage, string comment) {
            return base.Channel.SetScheduleExt(blastName, order, type, start, speed, smsPhone, smsPriority, smsMessage, comment);
        }
        
        public System.Threading.Tasks.Task<string> SetScheduleExtAsync(string blastName, int order, int type, long start, int speed, string smsPhone, int smsPriority, string smsMessage, string comment) {
            return base.Channel.SetScheduleExtAsync(blastName, order, type, start, speed, smsPhone, smsPriority, smsMessage, comment);
        }
        
        public string ClearScheduleExt(string blastName) {
            return base.Channel.ClearScheduleExt(blastName);
        }
        
        public System.Threading.Tasks.Task<string> ClearScheduleExtAsync(string blastName) {
            return base.Channel.ClearScheduleExtAsync(blastName);
        }
        
        public string GetIncomingMessage(int messageISN) {
            return base.Channel.GetIncomingMessage(messageISN);
        }
        
        public System.Threading.Tasks.Task<string> GetIncomingMessageAsync(int messageISN) {
            return base.Channel.GetIncomingMessageAsync(messageISN);
        }
    }
}
