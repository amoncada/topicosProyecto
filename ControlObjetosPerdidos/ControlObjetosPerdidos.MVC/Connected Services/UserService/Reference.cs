﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlObjetos.MVC.UserService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PeticionUsuario", Namespace="http://schemas.datacontract.org/2004/07/ControlObjetosPerdidos.MensajeServicios.U" +
        "suario")]
    [System.SerializableAttribute()]
    public partial class PeticionUsuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContrasenaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdRolUsuarioField;
        
        private string IdUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apellidos {
            get {
                return this.ApellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidosField, value) != true)) {
                    this.ApellidosField = value;
                    this.RaisePropertyChanged("Apellidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contrasena {
            get {
                return this.ContrasenaField;
            }
            set {
                if ((object.ReferenceEquals(this.ContrasenaField, value) != true)) {
                    this.ContrasenaField = value;
                    this.RaisePropertyChanged("Contrasena");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdRolUsuario {
            get {
                return this.IdRolUsuarioField;
            }
            set {
                if ((this.IdRolUsuarioField.Equals(value) != true)) {
                    this.IdRolUsuarioField = value;
                    this.RaisePropertyChanged("IdRolUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string IdUsuario {
            get {
                return this.IdUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.IdUsuarioField, value) != true)) {
                    this.IdUsuarioField = value;
                    this.RaisePropertyChanged("IdUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoField, value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RespuestaServicio", Namespace="http://schemas.datacontract.org/2004/07/ControlObjetosPerdidos.MensajeServicios.T" +
        "iposComunes")]
    [System.SerializableAttribute()]
    public partial class RespuestaServicio : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ControlObjetos.MVC.UserService.RespuestaServicioEncabezado EncabezadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ControlObjetos.MVC.UserService.RespuestaServicioContenido ContenidoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ControlObjetos.MVC.UserService.RespuestaServicioEncabezado Encabezado {
            get {
                return this.EncabezadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EncabezadoField, value) != true)) {
                    this.EncabezadoField = value;
                    this.RaisePropertyChanged("Encabezado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public ControlObjetos.MVC.UserService.RespuestaServicioContenido Contenido {
            get {
                return this.ContenidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ContenidoField, value) != true)) {
                    this.ContenidoField = value;
                    this.RaisePropertyChanged("Contenido");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RespuestaServicioEncabezado", Namespace="http://schemas.datacontract.org/2004/07/ControlObjetosPerdidos.MensajeServicios.T" +
        "iposComunes")]
    [System.SerializableAttribute()]
    public partial class RespuestaServicioEncabezado : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ControlObjetos.MVC.UserService.StatusRespuesta MensajeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ControlObjetos.MVC.UserService.StatusRespuesta Mensaje {
            get {
                return this.MensajeField;
            }
            set {
                if ((this.MensajeField.Equals(value) != true)) {
                    this.MensajeField = value;
                    this.RaisePropertyChanged("Mensaje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RespuestaServicioContenido", Namespace="http://schemas.datacontract.org/2004/07/ControlObjetosPerdidos.MensajeServicios.T" +
        "iposComunes")]
    [System.SerializableAttribute()]
    public partial class RespuestaServicioContenido : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StatusRespuesta", Namespace="http://schemas.datacontract.org/2004/07/ControlObjetosPerdidos.MensajeServicios.T" +
        "iposComunes")]
    public enum StatusRespuesta : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Warning = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserService.IServicioUsuarios")]
    public interface IServicioUsuarios {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuarios/InsertarUsuario", ReplyAction="http://tempuri.org/IServicioUsuarios/InsertarUsuarioResponse")]
        ControlObjetos.MVC.UserService.RespuestaServicio InsertarUsuario(ControlObjetos.MVC.UserService.PeticionUsuario peticionUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuarios/InsertarUsuario", ReplyAction="http://tempuri.org/IServicioUsuarios/InsertarUsuarioResponse")]
        System.Threading.Tasks.Task<ControlObjetos.MVC.UserService.RespuestaServicio> InsertarUsuarioAsync(ControlObjetos.MVC.UserService.PeticionUsuario peticionUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuarios/ActualizarRol", ReplyAction="http://tempuri.org/IServicioUsuarios/ActualizarRolResponse")]
        ControlObjetos.MVC.UserService.RespuestaServicio ActualizarRol(ControlObjetos.MVC.UserService.PeticionUsuario peticionUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuarios/ActualizarRol", ReplyAction="http://tempuri.org/IServicioUsuarios/ActualizarRolResponse")]
        System.Threading.Tasks.Task<ControlObjetos.MVC.UserService.RespuestaServicio> ActualizarRolAsync(ControlObjetos.MVC.UserService.PeticionUsuario peticionUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuarios/ActualizarEstado", ReplyAction="http://tempuri.org/IServicioUsuarios/ActualizarEstadoResponse")]
        ControlObjetos.MVC.UserService.RespuestaServicio ActualizarEstado(ControlObjetos.MVC.UserService.PeticionUsuario peticionUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuarios/ActualizarEstado", ReplyAction="http://tempuri.org/IServicioUsuarios/ActualizarEstadoResponse")]
        System.Threading.Tasks.Task<ControlObjetos.MVC.UserService.RespuestaServicio> ActualizarEstadoAsync(ControlObjetos.MVC.UserService.PeticionUsuario peticionUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuarios/EchoTest", ReplyAction="http://tempuri.org/IServicioUsuarios/EchoTestResponse")]
        ControlObjetos.MVC.UserService.RespuestaServicio EchoTest(string prueba);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuarios/EchoTest", ReplyAction="http://tempuri.org/IServicioUsuarios/EchoTestResponse")]
        System.Threading.Tasks.Task<ControlObjetos.MVC.UserService.RespuestaServicio> EchoTestAsync(string prueba);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioUsuariosChannel : ControlObjetos.MVC.UserService.IServicioUsuarios, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioUsuariosClient : System.ServiceModel.ClientBase<ControlObjetos.MVC.UserService.IServicioUsuarios>, ControlObjetos.MVC.UserService.IServicioUsuarios {
        
        public ServicioUsuariosClient() {
        }
        
        public ServicioUsuariosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioUsuariosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioUsuariosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioUsuariosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ControlObjetos.MVC.UserService.RespuestaServicio InsertarUsuario(ControlObjetos.MVC.UserService.PeticionUsuario peticionUsuario) {
            return base.Channel.InsertarUsuario(peticionUsuario);
        }
        
        public System.Threading.Tasks.Task<ControlObjetos.MVC.UserService.RespuestaServicio> InsertarUsuarioAsync(ControlObjetos.MVC.UserService.PeticionUsuario peticionUsuario) {
            return base.Channel.InsertarUsuarioAsync(peticionUsuario);
        }
        
        public ControlObjetos.MVC.UserService.RespuestaServicio ActualizarRol(ControlObjetos.MVC.UserService.PeticionUsuario peticionUsuario) {
            return base.Channel.ActualizarRol(peticionUsuario);
        }
        
        public System.Threading.Tasks.Task<ControlObjetos.MVC.UserService.RespuestaServicio> ActualizarRolAsync(ControlObjetos.MVC.UserService.PeticionUsuario peticionUsuario) {
            return base.Channel.ActualizarRolAsync(peticionUsuario);
        }
        
        public ControlObjetos.MVC.UserService.RespuestaServicio ActualizarEstado(ControlObjetos.MVC.UserService.PeticionUsuario peticionUsuario) {
            return base.Channel.ActualizarEstado(peticionUsuario);
        }
        
        public System.Threading.Tasks.Task<ControlObjetos.MVC.UserService.RespuestaServicio> ActualizarEstadoAsync(ControlObjetos.MVC.UserService.PeticionUsuario peticionUsuario) {
            return base.Channel.ActualizarEstadoAsync(peticionUsuario);
        }
        
        public ControlObjetos.MVC.UserService.RespuestaServicio EchoTest(string prueba) {
            return base.Channel.EchoTest(prueba);
        }
        
        public System.Threading.Tasks.Task<ControlObjetos.MVC.UserService.RespuestaServicio> EchoTestAsync(string prueba) {
            return base.Channel.EchoTestAsync(prueba);
        }
    }
}