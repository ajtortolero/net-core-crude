//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace ECollectWebServices.PSE
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.avisortech.com/eCollectWebservices", ConfigurationName = "ECollectWebServices.PSE.eCollectWebservicesv3Soap")]
    public interface eCollectWebservicesv3Soap
    {
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.avisortech.com/eCollectWebservices/getTransactionInformation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<ECollectWebServices.PSE.getTransactionInformationResponse> getTransactionInformationAsync(ECollectWebServices.PSE.getTransactionInformationRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.avisortech.com/eCollectWebservices/getBankList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<ECollectWebServices.PSE.getBankListResponse> getBankListAsync(ECollectWebServices.PSE.getBankListRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.avisortech.com/eCollectWebservices/createTransactionPayment", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<ECollectWebServices.PSE.createTransactionPaymentResponse> createTransactionPaymentAsync(ECollectWebServices.PSE.createTransactionPaymentRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.avisortech.com/eCollectWebservices/processTransactionPayment", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<ECollectWebServices.PSE.processTransactionPaymentResponse> processTransactionPaymentAsync(ECollectWebServices.PSE.processTransactionPaymentRequest request);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.avisortech.com/eCollectWebservices")]
    public partial class getTransactionInformationType
    {
        private string entityCodeField;

        private string ticketIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string EntityCode
        {
            get
            {
                return this.entityCodeField;
            }
            set
            {
                this.entityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string TicketId
        {
            get
            {
                return this.ticketIdField;
            }
            set
            {
                this.ticketIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.avisortech.com/eCollectWebservices")]
    public partial class createTransactionResponseType
    {
        private string returnCodeField;

        private string ticketIdField;

        private string eCollectUrlField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ReturnCode
        {
            get
            {
                return this.returnCodeField;
            }
            set
            {
                this.returnCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string TicketId
        {
            get
            {
                return this.ticketIdField;
            }
            set
            {
                this.ticketIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string eCollectUrl
        {
            get
            {
                return this.eCollectUrlField;
            }
            set
            {
                this.eCollectUrlField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.avisortech.com/eCollectWebservices")]
    public partial class createTransactionType
    {
        private string entityCodeField;

        private string srvCodeField;

        private decimal transValueField;

        private decimal transVatValueField;

        private string srvCurrencyField;

        private string uRLResponseField;

        private string uRLRedirectField;

        private string signField;

        private string signFieldsField;

        private string[] referenceArrayField;

        private string paymentSystemField;

        private string fICodeField;

        private string[] authReferenceArrayField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string EntityCode
        {
            get
            {
                return this.entityCodeField;
            }
            set
            {
                this.entityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string SrvCode
        {
            get
            {
                return this.srvCodeField;
            }
            set
            {
                this.srvCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public decimal TransValue
        {
            get
            {
                return this.transValueField;
            }
            set
            {
                this.transValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public decimal TransVatValue
        {
            get
            {
                return this.transVatValueField;
            }
            set
            {
                this.transVatValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string SrvCurrency
        {
            get
            {
                return this.srvCurrencyField;
            }
            set
            {
                this.srvCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string URLResponse
        {
            get
            {
                return this.uRLResponseField;
            }
            set
            {
                this.uRLResponseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string URLRedirect
        {
            get
            {
                return this.uRLRedirectField;
            }
            set
            {
                this.uRLRedirectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string Sign
        {
            get
            {
                return this.signField;
            }
            set
            {
                this.signField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string SignFields
        {
            get
            {
                return this.signFieldsField;
            }
            set
            {
                this.signFieldsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReferenceArray", Order = 9)]
        public string[] ReferenceArray
        {
            get
            {
                return this.referenceArrayField;
            }
            set
            {
                this.referenceArrayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string PaymentSystem
        {
            get
            {
                return this.paymentSystemField;
            }
            set
            {
                this.paymentSystemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string FICode
        {
            get
            {
                return this.fICodeField;
            }
            set
            {
                this.fICodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 12)]
        public string[] AuthReferenceArray
        {
            get
            {
                return this.authReferenceArrayField;
            }
            set
            {
                this.authReferenceArrayField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.avisortech.com/eCollectWebservices")]
    public partial class getBankListResponseType
    {
        private string paymentSystemField;

        private string financialInstitutionCodeField;

        private string financialInstitutionNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger", Order = 0)]
        public string paymentSystem
        {
            get
            {
                return this.paymentSystemField;
            }
            set
            {
                this.paymentSystemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger", Order = 1)]
        public string financialInstitutionCode
        {
            get
            {
                return this.financialInstitutionCodeField;
            }
            set
            {
                this.financialInstitutionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string financialInstitutionName
        {
            get
            {
                return this.financialInstitutionNameField;
            }
            set
            {
                this.financialInstitutionNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.avisortech.com/eCollectWebservices")]
    public partial class getBankListType
    {
        private string entityCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string EntityCode
        {
            get
            {
                return this.entityCodeField;
            }
            set
            {
                this.entityCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.avisortech.com/eCollectWebservices")]
    public partial class retriesTicketIdType
    {
        private string ticketIdField;

        private string tranStateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string TicketId
        {
            get
            {
                return this.ticketIdField;
            }
            set
            {
                this.ticketIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string TranState
        {
            get
            {
                return this.tranStateField;
            }
            set
            {
                this.tranStateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.avisortech.com/eCollectWebservices")]
    public partial class getTransactionInformationResponseType
    {
        private string entityCodeField;

        private string ticketIdField;

        private string trazabilityCodeField;

        private string tranStateField;

        private string returnCodeField;

        private decimal transValueField;

        private decimal transVatValueField;

        private string payCurrencyField;

        private decimal currencyRateField;

        private System.DateTime bankProcessDateField;

        private string bankNameField;

        private string paymentSystemField;

        private string[] referenceArrayField;

        private string[] authReferenceArrayField;

        private retriesTicketIdType[] retriesTicketIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string EntityCode
        {
            get
            {
                return this.entityCodeField;
            }
            set
            {
                this.entityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string TicketId
        {
            get
            {
                return this.ticketIdField;
            }
            set
            {
                this.ticketIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string TrazabilityCode
        {
            get
            {
                return this.trazabilityCodeField;
            }
            set
            {
                this.trazabilityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string TranState
        {
            get
            {
                return this.tranStateField;
            }
            set
            {
                this.tranStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string ReturnCode
        {
            get
            {
                return this.returnCodeField;
            }
            set
            {
                this.returnCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public decimal TransValue
        {
            get
            {
                return this.transValueField;
            }
            set
            {
                this.transValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public decimal TransVatValue
        {
            get
            {
                return this.transVatValueField;
            }
            set
            {
                this.transVatValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string PayCurrency
        {
            get
            {
                return this.payCurrencyField;
            }
            set
            {
                this.payCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public decimal CurrencyRate
        {
            get
            {
                return this.currencyRateField;
            }
            set
            {
                this.currencyRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 9)]
        public System.DateTime BankProcessDate
        {
            get
            {
                return this.bankProcessDateField;
            }
            set
            {
                this.bankProcessDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string BankName
        {
            get
            {
                return this.bankNameField;
            }
            set
            {
                this.bankNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string PaymentSystem
        {
            get
            {
                return this.paymentSystemField;
            }
            set
            {
                this.paymentSystemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReferenceArray", Order = 12)]
        public string[] ReferenceArray
        {
            get
            {
                return this.referenceArrayField;
            }
            set
            {
                this.referenceArrayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 13)]
        public string[] AuthReferenceArray
        {
            get
            {
                return this.authReferenceArrayField;
            }
            set
            {
                this.authReferenceArrayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RetriesTicketId", Order = 14)]
        public retriesTicketIdType[] RetriesTicketId
        {
            get
            {
                return this.retriesTicketIdField;
            }
            set
            {
                this.retriesTicketIdField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getTransactionInformation", WrapperNamespace = "http://www.avisortech.com/eCollectWebservices", IsWrapped = true)]
    public partial class getTransactionInformationRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.avisortech.com/eCollectWebservices", Order = 0)]
        public ECollectWebServices.PSE.getTransactionInformationType request;

        public getTransactionInformationRequest()
        {
        }

        public getTransactionInformationRequest(ECollectWebServices.PSE.getTransactionInformationType request)
        {
            this.request = request;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getTransactionInformationResponse", WrapperNamespace = "http://www.avisortech.com/eCollectWebservices", IsWrapped = true)]
    public partial class getTransactionInformationResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.avisortech.com/eCollectWebservices", Order = 0)]
        public ECollectWebServices.PSE.getTransactionInformationResponseType getTransactionInformationResult;

        public getTransactionInformationResponse()
        {
        }

        public getTransactionInformationResponse(ECollectWebServices.PSE.getTransactionInformationResponseType getTransactionInformationResult)
        {
            this.getTransactionInformationResult = getTransactionInformationResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getBankList", WrapperNamespace = "http://www.avisortech.com/eCollectWebservices", IsWrapped = true)]
    public partial class getBankListRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.avisortech.com/eCollectWebservices", Order = 0)]
        public ECollectWebServices.PSE.getBankListType request;

        public getBankListRequest()
        {
        }

        public getBankListRequest(ECollectWebServices.PSE.getBankListType request)
        {
            this.request = request;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "getBankListResponse", WrapperNamespace = "http://www.avisortech.com/eCollectWebservices", IsWrapped = true)]
    public partial class getBankListResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.avisortech.com/eCollectWebservices", Order = 0)]
        public ECollectWebServices.PSE.getBankListResponseType[] getBankListResult;

        public getBankListResponse()
        {
        }

        public getBankListResponse(ECollectWebServices.PSE.getBankListResponseType[] getBankListResult)
        {
            this.getBankListResult = getBankListResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "createTransactionPayment", WrapperNamespace = "http://www.avisortech.com/eCollectWebservices", IsWrapped = true)]
    public partial class createTransactionPaymentRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.avisortech.com/eCollectWebservices", Order = 0)]
        public ECollectWebServices.PSE.createTransactionType request;

        public createTransactionPaymentRequest()
        {
        }

        public createTransactionPaymentRequest(ECollectWebServices.PSE.createTransactionType request)
        {
            this.request = request;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "createTransactionPaymentResponse", WrapperNamespace = "http://www.avisortech.com/eCollectWebservices", IsWrapped = true)]
    public partial class createTransactionPaymentResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.avisortech.com/eCollectWebservices", Order = 0)]
        public ECollectWebServices.PSE.createTransactionResponseType createTransactionPaymentResult;

        public createTransactionPaymentResponse()
        {
        }

        public createTransactionPaymentResponse(ECollectWebServices.PSE.createTransactionResponseType createTransactionPaymentResult)
        {
            this.createTransactionPaymentResult = createTransactionPaymentResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "processTransactionPayment", WrapperNamespace = "http://www.avisortech.com/eCollectWebservices", IsWrapped = true)]
    public partial class processTransactionPaymentRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.avisortech.com/eCollectWebservices", Order = 0)]
        public ECollectWebServices.PSE.createTransactionType request;

        public processTransactionPaymentRequest()
        {
        }

        public processTransactionPaymentRequest(ECollectWebServices.PSE.createTransactionType request)
        {
            this.request = request;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "processTransactionPaymentResponse", WrapperNamespace = "http://www.avisortech.com/eCollectWebservices", IsWrapped = true)]
    public partial class processTransactionPaymentResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.avisortech.com/eCollectWebservices", Order = 0)]
        public ECollectWebServices.PSE.getTransactionInformationResponseType processTransactionPaymentResult;

        public processTransactionPaymentResponse()
        {
        }

        public processTransactionPaymentResponse(ECollectWebServices.PSE.getTransactionInformationResponseType processTransactionPaymentResult)
        {
            this.processTransactionPaymentResult = processTransactionPaymentResult;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface eCollectWebservicesv3SoapChannel : ECollectWebServices.PSE.eCollectWebservicesv3Soap, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class eCollectWebservicesv3SoapClient : System.ServiceModel.ClientBase<ECollectWebServices.PSE.eCollectWebservicesv3Soap>, ECollectWebServices.PSE.eCollectWebservicesv3Soap
    {
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);

        public eCollectWebservicesv3SoapClient(EndpointConfiguration endpointConfiguration) :
                base(eCollectWebservicesv3SoapClient.GetBindingForEndpoint(endpointConfiguration), eCollectWebservicesv3SoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public eCollectWebservicesv3SoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) :
                base(eCollectWebservicesv3SoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public eCollectWebservicesv3SoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) :
                base(eCollectWebservicesv3SoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public eCollectWebservicesv3SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public System.Threading.Tasks.Task<ECollectWebServices.PSE.getTransactionInformationResponse> getTransactionInformationAsync(ECollectWebServices.PSE.getTransactionInformationRequest request)
        {
            return base.Channel.getTransactionInformationAsync(request);
        }

        public System.Threading.Tasks.Task<ECollectWebServices.PSE.getBankListResponse> getBankListAsync(ECollectWebServices.PSE.getBankListRequest request)
        {
            return base.Channel.getBankListAsync(request);
        }

        public System.Threading.Tasks.Task<ECollectWebServices.PSE.createTransactionPaymentResponse> createTransactionPaymentAsync(ECollectWebServices.PSE.createTransactionPaymentRequest request)
        {
            return base.Channel.createTransactionPaymentAsync(request);
        }

        public System.Threading.Tasks.Task<ECollectWebServices.PSE.processTransactionPaymentResponse> processTransactionPaymentAsync(ECollectWebServices.PSE.processTransactionPaymentRequest request)
        {
            return base.Channel.processTransactionPaymentAsync(request);
        }

        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }

        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }

        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.eCollectWebservicesv3Soap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.eCollectWebservicesv3Soap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }

        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            //if ((endpointConfiguration == EndpointConfiguration.eCollectWebservicesv3Soap))
            //{
            //    return new System.ServiceModel.EndpointAddress("https://test1.e-collect.com/d_Express/webservice/eCollectWebservicesv3.asmx");
            //}
            //if ((endpointConfiguration == EndpointConfiguration.eCollectWebservicesv3Soap12))
            //{
            //    return new System.ServiceModel.EndpointAddress("https://test1.e-collect.com/d_Express/webservice/eCollectWebservicesv3.asmx");
            //}
            if ((endpointConfiguration == EndpointConfiguration.eCollectWebservicesv3Soap))
            {
                return new System.ServiceModel.EndpointAddress("https://www.e-collect.com/p_express/webservice/eCollectWebservicesv3.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.eCollectWebservicesv3Soap12))
            {
                return new System.ServiceModel.EndpointAddress("https://www.e-collect.com/p_express/webservice/eCollectWebservicesv3.asmx");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }

        public enum EndpointConfiguration
        {
            eCollectWebservicesv3Soap,
            eCollectWebservicesv3Soap12,
        }
    }
}