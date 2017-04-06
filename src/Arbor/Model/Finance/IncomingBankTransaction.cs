using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class IncomingBankTransaction : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_INCOMING_BANK_TRANSACTION;
        public const string BANK_ACCOUNT = "bankAccount";
        public const string BILL_PAYER = "billPayer";
        public const string PAYMENT = "payment";
        public const string PAYMENT_DATE = "paymentDate";
        public const string PAYMENT_REFERENCE = "paymentReference";
        public const string BANK_TRANSACTION_REFERENCE = "bankTransactionReference";

        public IncomingBankTransaction ()
        {
            base.resourceType = this.resourceType;
        }
        
        public IncomingBankTransaction (string resourceType = "IncomingBankTransaction", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<IncomingBankTransaction> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_IncomingBankTransaction");
        	RestGateway gateway = (RestGateway) IncomingBankTransaction.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<IncomingBankTransaction> incomingbanktransactionCollection = new ModelCollection<IncomingBankTransaction> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    incomingbanktransactionCollection.add((IncomingBankTransaction) model);
        	}
        
        	return incomingbanktransactionCollection;
        }

        public static IncomingBankTransaction retrieve (string id)
        {
            RestGateway gateway = (RestGateway) IncomingBankTransaction.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (IncomingBankTransaction) gateway.retrieve(ResourceType.FINANCE_INCOMING_BANK_TRANSACTION, id);
        }

        public ModelBase getBankAccount ()
        {
            return (ModelBase) this.getProperty("bankAccount");
        }

        public void setBankAccount (ModelBase bankAccount)
        {
            this.setProperty("bankAccount", bankAccount);
        }

        public ModelBase getBillPayer ()
        {
            return (ModelBase) this.getProperty("billPayer");
        }

        public void setBillPayer (ModelBase billPayer)
        {
            this.setProperty("billPayer", billPayer);
        }

        public string getPayment ()
        {
            return this.getProperty("payment").ToString();
        }

        public void setPayment (string payment)
        {
            this.setProperty("payment", payment);
        }

        public DateTime getPaymentDate ()
        {
            return (DateTime) this.getProperty("paymentDate");
        }

        public void setPaymentDate (DateTime paymentDate)
        {
            this.setProperty("paymentDate", paymentDate);
        }

        public string getPaymentReference ()
        {
            return this.getProperty("paymentReference").ToString();
        }

        public void setPaymentReference (string paymentReference)
        {
            this.setProperty("paymentReference", paymentReference);
        }

        public string getBankTransactionReference ()
        {
            return this.getProperty("bankTransactionReference").ToString();
        }

        public void setBankTransactionReference (string bankTransactionReference)
        {
            this.setProperty("bankTransactionReference", bankTransactionReference);
        }


    }
}

