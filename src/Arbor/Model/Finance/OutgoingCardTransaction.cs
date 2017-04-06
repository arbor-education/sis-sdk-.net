using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class OutgoingCardTransaction : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_OUTGOING_CARD_TRANSACTION;
        public const string PAYMENT_CARD = "paymentCard";
        public const string TRANSACTION_AMOUNT = "transactionAmount";
        public const string TRANSACTION_CURRENCY = "transactionCurrency";
        public const string TRANSACTION_DATETIME = "transactionDatetime";
        public const string NARRATIVE = "narrative";

        public OutgoingCardTransaction ()
        {
            base.resourceType = this.resourceType;
        }
        
        public OutgoingCardTransaction (string resourceType = "OutgoingCardTransaction", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<OutgoingCardTransaction> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_OutgoingCardTransaction");
        	RestGateway gateway = (RestGateway) OutgoingCardTransaction.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<OutgoingCardTransaction> outgoingcardtransactionCollection = new ModelCollection<OutgoingCardTransaction> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    outgoingcardtransactionCollection.add((OutgoingCardTransaction) model);
        	}
        
        	return outgoingcardtransactionCollection;
        }

        public static OutgoingCardTransaction retrieve (string id)
        {
            RestGateway gateway = (RestGateway) OutgoingCardTransaction.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (OutgoingCardTransaction) gateway.retrieve(ResourceType.FINANCE_OUTGOING_CARD_TRANSACTION, id);
        }

        public ModelBase getPaymentCard ()
        {
            return (ModelBase) this.getProperty("paymentCard");
        }

        public void setPaymentCard (ModelBase paymentCard)
        {
            this.setProperty("paymentCard", paymentCard);
        }

        public float getTransactionAmount ()
        {
            return (float) this.getProperty("transactionAmount");
        }

        public void setTransactionAmount (float transactionAmount)
        {
            this.setProperty("transactionAmount", transactionAmount);
        }

        public string getTransactionCurrency ()
        {
            return this.getProperty("transactionCurrency").ToString();
        }

        public void setTransactionCurrency (string transactionCurrency)
        {
            this.setProperty("transactionCurrency", transactionCurrency);
        }

        public DateTime getTransactionDatetime ()
        {
            return (DateTime) this.getProperty("transactionDatetime");
        }

        public void setTransactionDatetime (DateTime transactionDatetime)
        {
            this.setProperty("transactionDatetime", transactionDatetime);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }


    }
}

