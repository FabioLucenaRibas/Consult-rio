﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Consultorio.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Consultar", ReplyAction="http://tempuri.org/IService1/ConsultarResponse")]
        Biblioteca.ClassesBasicas.Consulta[] Consultar(Biblioteca.ClassesBasicas.ConsultaFiltro pFiltro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Consultar", ReplyAction="http://tempuri.org/IService1/ConsultarResponse")]
        System.Threading.Tasks.Task<Biblioteca.ClassesBasicas.Consulta[]> ConsultarAsync(Biblioteca.ClassesBasicas.ConsultaFiltro pFiltro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConsultarPaciente", ReplyAction="http://tempuri.org/IService1/ConsultarPacienteResponse")]
        Biblioteca.ClassesBasicas.Paciente[] ConsultarPaciente(Biblioteca.ClassesBasicas.Paciente pFiltro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConsultarPaciente", ReplyAction="http://tempuri.org/IService1/ConsultarPacienteResponse")]
        System.Threading.Tasks.Task<Biblioteca.ClassesBasicas.Paciente[]> ConsultarPacienteAsync(Biblioteca.ClassesBasicas.Paciente pFiltro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConsultarCEP", ReplyAction="http://tempuri.org/IService1/ConsultarCEPResponse")]
        Biblioteca.ClassesBasicas.CEP ConsultarCEP(string CEP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConsultarCEP", ReplyAction="http://tempuri.org/IService1/ConsultarCEPResponse")]
        System.Threading.Tasks.Task<Biblioteca.ClassesBasicas.CEP> ConsultarCEPAsync(string CEP);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Consultorio.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Consultorio.ServiceReference1.IService1>, Consultorio.ServiceReference1.IService1 {
        
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
        
        public Biblioteca.ClassesBasicas.Consulta[] Consultar(Biblioteca.ClassesBasicas.ConsultaFiltro pFiltro) {
            return base.Channel.Consultar(pFiltro);
        }
        
        public System.Threading.Tasks.Task<Biblioteca.ClassesBasicas.Consulta[]> ConsultarAsync(Biblioteca.ClassesBasicas.ConsultaFiltro pFiltro) {
            return base.Channel.ConsultarAsync(pFiltro);
        }
        
        public Biblioteca.ClassesBasicas.Paciente[] ConsultarPaciente(Biblioteca.ClassesBasicas.Paciente pFiltro) {
            return base.Channel.ConsultarPaciente(pFiltro);
        }
        
        public System.Threading.Tasks.Task<Biblioteca.ClassesBasicas.Paciente[]> ConsultarPacienteAsync(Biblioteca.ClassesBasicas.Paciente pFiltro) {
            return base.Channel.ConsultarPacienteAsync(pFiltro);
        }
        
        public Biblioteca.ClassesBasicas.CEP ConsultarCEP(string CEP) {
            return base.Channel.ConsultarCEP(CEP);
        }
        
        public System.Threading.Tasks.Task<Biblioteca.ClassesBasicas.CEP> ConsultarCEPAsync(string CEP) {
            return base.Channel.ConsultarCEPAsync(CEP);
        }
    }
}
