using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class OutgoingBankTransaction : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_OUTGOING_BANK_TRANSACTION;
        public const string BANK_ACCOUNT = "bankAccount";
        public const string PAYMENT_BATCH = "paymentBatch";
        public const string SUPPLIER_BANK_DETAILS = "supplierBankDetails";
        public const string PAYMENT = "payment";
        public const string PAYMENT_DATETIME = "paymentDatetime";
        public const string PAYMENT_REFERENCE = "paymentReference";
        public const string BANK_TRANSACTION_REFERENCE = "bankTransactionReference";

        public OutgoingBankTransaction ()
        {
            base.resourceType = this.resourceType;
        }
        
        public OutgoingBankTransaction (string resourceType = "OutgoingBankTransaction", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<OutgoingBankTransaction> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_OutgoingBankTransaction");
        	RestGateway gateway = (RestGateway) OutgoingBankTransaction.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<OutgoingBankTransaction> outgoingbanktransactionCollection = new ModelCollection<OutgoingBankTransaction> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    outgoingbanktransactionCollection.add((OutgoingBankTransaction) model);
        	}
        
        	return outgoingbanktransactionCollection;
        }

        public static OutgoingBankTransaction retrieve (string id)
        {
            RestGateway gateway = (RestGateway) OutgoingBankTransaction.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (OutgoingBankTransaction) gateway.retrieve(ResourceType.FINANCE_OUTGOING_BANK_TRANSACTION, id);
        }

        public ModelBase getBankAccount ()
        {
            return (ModelBase) this.getProperty("bankAccount");
        }

        public void setBankAccount (ModelBase bankAccount)
        {
            this.setProperty("bankAccount", bankAccount);
        }

        public ModelBase getPaymentBatch ()
        {
            return (ModelBase) this.getProperty("paymentBatch");
        }

        public void setPaymentBatch (ModelBase paymentBatch)
        {
            this.setProperty("paymentBatch", paymentBatch);
        }

        public ModelBase getSupplierBankDetails ()
        {
            return (ModelBase) this.getProperty("supplierBankDetails");
        }

        public void setSupplierBankDetails (ModelBase supplierBankDetails)
        {
            this.setProperty("supplierBankDetails", supplierBankDetails);
        }

        public string getPayment ()
        {
            return this.getProperty("payment").ToString();
        }

        public void setPayment (string payment)
        {
            this.setProperty("payment", payment);
        }

        public DateTime getPaymentDatetime ()
        {
            return (DateTime) this.getProperty("paymentDatetime");
        }

        public void setPaymentDatetime (DateTime paymentDatetime)
        {
            this.setProperty("paymentDatetime", paymentDatetime);
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

