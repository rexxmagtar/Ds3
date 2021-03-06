﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PolWebApplication.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Visit", Namespace="http://schemas.datacontract.org/2004/07/PolyclinicService")]
    [System.SerializableAttribute()]
    public partial class Visit : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DoctorFioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PatientFioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SpecialityField;

        public Visit(string doctorFio, string patientFio, DateTime date, string speciality)
        {
            DoctorFio = doctorFio;
            PatientFio = patientFio;
            Date = date;
            Speciality = speciality;
        }

        public Visit(int id, string doctorFio, string patientFio, DateTime date, string speciality)
        {
            Id = id;
            DoctorFio = doctorFio;
            PatientFio = patientFio;
            Date = date;
            Speciality = speciality;
        }

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
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DoctorFio {
            get {
                return this.DoctorFioField;
            }
            set {
                if ((object.ReferenceEquals(this.DoctorFioField, value) != true)) {
                    this.DoctorFioField = value;
                    this.RaisePropertyChanged("DoctorFio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PatientFio {
            get {
                return this.PatientFioField;
            }
            set {
                if ((object.ReferenceEquals(this.PatientFioField, value) != true)) {
                    this.PatientFioField = value;
                    this.RaisePropertyChanged("PatientFio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Speciality {
            get {
                return this.SpecialityField;
            }
            set {
                if ((object.ReferenceEquals(this.SpecialityField, value) != true)) {
                    this.SpecialityField = value;
                    this.RaisePropertyChanged("Speciality");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Token", Namespace="http://schemas.datacontract.org/2004/07/PolyclinicService")]
    [System.SerializableAttribute()]
    public partial class Token : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Day1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Day2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PolWebApplication.ServiceReference.Functions FunctionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LineField;

        public Token(int id, string data, Functions function, DateTime date1, DateTime date2)
        {
            Id = id;
            Line = data;
            Function = function;
            Day1 = date1;
            Day2 = date2;
        }

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
        public System.DateTime Day1 {
            get {
                return this.Day1Field;
            }
            set {
                if ((this.Day1Field.Equals(value) != true)) {
                    this.Day1Field = value;
                    this.RaisePropertyChanged("Day1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Day2 {
            get {
                return this.Day2Field;
            }
            set {
                if ((this.Day2Field.Equals(value) != true)) {
                    this.Day2Field = value;
                    this.RaisePropertyChanged("Day2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PolWebApplication.ServiceReference.Functions Function {
            get {
                return this.FunctionField;
            }
            set {
                if ((this.FunctionField.Equals(value) != true)) {
                    this.FunctionField = value;
                    this.RaisePropertyChanged("Function");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Line {
            get {
                return this.LineField;
            }
            set {
                if ((object.ReferenceEquals(this.LineField, value) != true)) {
                    this.LineField = value;
                    this.RaisePropertyChanged("Line");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Functions", Namespace="http://schemas.datacontract.org/2004/07/PolyclinicService")]
    public enum Functions : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Create = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Update = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Delete = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Get = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Undefined = 4,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TokenPaymentDto", Namespace="http://schemas.datacontract.org/2004/07/PolyclinicService")]
    [System.SerializableAttribute()]
    public partial class TokenPaymentDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Date1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Date2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PolWebApplication.ServiceReference.Functions dataField;

        public TokenPaymentDto(Functions data, DateTime date1, DateTime date2)
        {
            this.data = data;
            Date1 = date1;
            Date2 = date2;
        }

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
        public System.DateTime Date1 {
            get {
                return this.Date1Field;
            }
            set {
                if ((this.Date1Field.Equals(value) != true)) {
                    this.Date1Field = value;
                    this.RaisePropertyChanged("Date1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date2 {
            get {
                return this.Date2Field;
            }
            set {
                if ((this.Date2Field.Equals(value) != true)) {
                    this.Date2Field = value;
                    this.RaisePropertyChanged("Date2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PolWebApplication.ServiceReference.Functions data {
            get {
                return this.dataField;
            }
            set {
                if ((this.dataField.Equals(value) != true)) {
                    this.dataField = value;
                    this.RaisePropertyChanged("data");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IPolyclinicService")]
    public interface IPolyclinicService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolyclinicService/GetVisits", ReplyAction="http://tempuri.org/IPolyclinicService/GetVisitsResponse")]
        PolWebApplication.ServiceReference.Visit[] GetVisits();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolyclinicService/GetVisits", ReplyAction="http://tempuri.org/IPolyclinicService/GetVisitsResponse")]
        System.Threading.Tasks.Task<PolWebApplication.ServiceReference.Visit[]> GetVisitsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolyclinicService/CreateVisit", ReplyAction="http://tempuri.org/IPolyclinicService/CreateVisitResponse")]
        bool CreateVisit(PolWebApplication.ServiceReference.Visit visit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolyclinicService/CreateVisit", ReplyAction="http://tempuri.org/IPolyclinicService/CreateVisitResponse")]
        System.Threading.Tasks.Task<bool> CreateVisitAsync(PolWebApplication.ServiceReference.Visit visit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolyclinicService/UpdateVisit", ReplyAction="http://tempuri.org/IPolyclinicService/UpdateVisitResponse")]
        bool UpdateVisit(PolWebApplication.ServiceReference.Visit visit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolyclinicService/UpdateVisit", ReplyAction="http://tempuri.org/IPolyclinicService/UpdateVisitResponse")]
        System.Threading.Tasks.Task<bool> UpdateVisitAsync(PolWebApplication.ServiceReference.Visit visit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolyclinicService/DeleteVisit", ReplyAction="http://tempuri.org/IPolyclinicService/DeleteVisitResponse")]
        bool DeleteVisit(PolWebApplication.ServiceReference.Visit visit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolyclinicService/DeleteVisit", ReplyAction="http://tempuri.org/IPolyclinicService/DeleteVisitResponse")]
        System.Threading.Tasks.Task<bool> DeleteVisitAsync(PolWebApplication.ServiceReference.Visit visit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolyclinicService/getTokenPayments", ReplyAction="http://tempuri.org/IPolyclinicService/getTokenPaymentsResponse")]
        PolWebApplication.ServiceReference.Token[] getTokenPayments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolyclinicService/getTokenPayments", ReplyAction="http://tempuri.org/IPolyclinicService/getTokenPaymentsResponse")]
        System.Threading.Tasks.Task<PolWebApplication.ServiceReference.Token[]> getTokenPaymentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolyclinicService/PayToken", ReplyAction="http://tempuri.org/IPolyclinicService/PayTokenResponse")]
        void PayToken(PolWebApplication.ServiceReference.TokenPaymentDto tokenDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolyclinicService/PayToken", ReplyAction="http://tempuri.org/IPolyclinicService/PayTokenResponse")]
        System.Threading.Tasks.Task PayTokenAsync(PolWebApplication.ServiceReference.TokenPaymentDto tokenDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolyclinicService/IsTokenExists", ReplyAction="http://tempuri.org/IPolyclinicService/IsTokenExistsResponse")]
        bool IsTokenExists(PolWebApplication.ServiceReference.Functions functions);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolyclinicService/IsTokenExists", ReplyAction="http://tempuri.org/IPolyclinicService/IsTokenExistsResponse")]
        System.Threading.Tasks.Task<bool> IsTokenExistsAsync(PolWebApplication.ServiceReference.Functions functions);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPolyclinicServiceChannel : PolWebApplication.ServiceReference.IPolyclinicService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PolyclinicServiceClient : System.ServiceModel.ClientBase<PolWebApplication.ServiceReference.IPolyclinicService>, PolWebApplication.ServiceReference.IPolyclinicService {
        
        public PolyclinicServiceClient() {
        }
        
        public PolyclinicServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PolyclinicServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PolyclinicServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PolyclinicServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PolWebApplication.ServiceReference.Visit[] GetVisits() {
            return base.Channel.GetVisits();
        }
        
        public System.Threading.Tasks.Task<PolWebApplication.ServiceReference.Visit[]> GetVisitsAsync() {
            return base.Channel.GetVisitsAsync();
        }
        
        public bool CreateVisit(PolWebApplication.ServiceReference.Visit visit) {
            return base.Channel.CreateVisit(visit);
        }
        
        public System.Threading.Tasks.Task<bool> CreateVisitAsync(PolWebApplication.ServiceReference.Visit visit) {
            return base.Channel.CreateVisitAsync(visit);
        }
        
        public bool UpdateVisit(PolWebApplication.ServiceReference.Visit visit) {
            return base.Channel.UpdateVisit(visit);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateVisitAsync(PolWebApplication.ServiceReference.Visit visit) {
            return base.Channel.UpdateVisitAsync(visit);
        }
        
        public bool DeleteVisit(PolWebApplication.ServiceReference.Visit visit) {
            return base.Channel.DeleteVisit(visit);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteVisitAsync(PolWebApplication.ServiceReference.Visit visit) {
            return base.Channel.DeleteVisitAsync(visit);
        }
        
        public PolWebApplication.ServiceReference.Token[] getTokenPayments() {
            return base.Channel.getTokenPayments();
        }
        
        public System.Threading.Tasks.Task<PolWebApplication.ServiceReference.Token[]> getTokenPaymentsAsync() {
            return base.Channel.getTokenPaymentsAsync();
        }
        
        public void PayToken(PolWebApplication.ServiceReference.TokenPaymentDto tokenDto) {
            base.Channel.PayToken(tokenDto);
        }
        
        public System.Threading.Tasks.Task PayTokenAsync(PolWebApplication.ServiceReference.TokenPaymentDto tokenDto) {
            return base.Channel.PayTokenAsync(tokenDto);
        }
        
        public bool IsTokenExists(PolWebApplication.ServiceReference.Functions functions) {
            return base.Channel.IsTokenExists(functions);
        }
        
        public System.Threading.Tasks.Task<bool> IsTokenExistsAsync(PolWebApplication.ServiceReference.Functions functions) {
            return base.Channel.IsTokenExistsAsync(functions);
        }
    }
}
