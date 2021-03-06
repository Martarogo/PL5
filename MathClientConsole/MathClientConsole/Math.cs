﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34209
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MathService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tuple", Namespace="http://schemas.datacontract.org/2004/07/MathService")]
    public partial class Tuple : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private double[] DataField;
        
        private string NameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double[] Data
        {
            get
            {
                return this.DataField;
            }
            set
            {
                this.DataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IMath")]
public interface IMath
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMath/Prime", ReplyAction="http://tempuri.org/IMath/PrimeResponse")]
    bool Prime(int value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMath/Prime", ReplyAction="http://tempuri.org/IMath/PrimeResponse")]
    System.Threading.Tasks.Task<bool> PrimeAsync(int value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMath/Sum", ReplyAction="http://tempuri.org/IMath/SumResponse")]
    MathService.Tuple Sum(MathService.Tuple t);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMath/Sum", ReplyAction="http://tempuri.org/IMath/SumResponse")]
    System.Threading.Tasks.Task<MathService.Tuple> SumAsync(MathService.Tuple t);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IMathChannel : IMath, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class MathClient : System.ServiceModel.ClientBase<IMath>, IMath
{
    
    public MathClient()
    {
    }
    
    public MathClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public MathClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MathClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MathClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public bool Prime(int value)
    {
        return base.Channel.Prime(value);
    }
    
    public System.Threading.Tasks.Task<bool> PrimeAsync(int value)
    {
        return base.Channel.PrimeAsync(value);
    }
    
    public MathService.Tuple Sum(MathService.Tuple t)
    {
        return base.Channel.Sum(t);
    }
    
    public System.Threading.Tasks.Task<MathService.Tuple> SumAsync(MathService.Tuple t)
    {
        return base.Channel.SumAsync(t);
    }
}
