using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class IssuedCheque : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_ISSUED_CHEQUE;
        public const string CHEQUE_BOOK = "chequeBook";
        public const string PAYMENT_BATCH = "paymentBatch";
        public const string PAYEE_NAME = "payeeName";
        public const string CHEQUE_AMOUNT = "chequeAmount";
        public const string CHEQUE_AMOUNT_CURRENCY = "chequeAmountCurrency";
        public const string CHEQUE_DATE = "chequeDate";
        public const string CANCELLED_DATETIME = "cancelledDatetime";
        public const string PRINTED_DATETIME = "printedDatetime";

        public IssuedCheque ()
        {
            base.resourceType = this.resourceType;
        }
        
        public IssuedCheque (string resourceType = "IssuedCheque", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<IssuedCheque> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_IssuedCheque");
        	RestGateway gateway = (RestGateway) IssuedCheque.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<IssuedCheque> issuedchequeCollection = new ModelCollection<IssuedCheque> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    issuedchequeCollection.add((IssuedCheque) model);
        	}
        
        	return issuedchequeCollection;
        }

        public static IssuedCheque retrieve (string id)
        {
            RestGateway gateway = (RestGateway) IssuedCheque.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (IssuedCheque) gateway.retrieve(ResourceType.FINANCE_ISSUED_CHEQUE, id);
        }

        public ModelBase getChequeBook ()
        {
            return (ModelBase) this.getProperty("chequeBook");
        }

        public void setChequeBook (ModelBase chequeBook)
        {
            this.setProperty("chequeBook", chequeBook);
        }

        public ModelBase getPaymentBatch ()
        {
            return (ModelBase) this.getProperty("paymentBatch");
        }

        public void setPaymentBatch (ModelBase paymentBatch)
        {
            this.setProperty("paymentBatch", paymentBatch);
        }

        public string getPayeeName ()
        {
            return this.getProperty("payeeName").ToString();
        }

        public void setPayeeName (string payeeName)
        {
            this.setProperty("payeeName", payeeName);
        }

        public string getChequeAmount ()
        {
            return this.getProperty("chequeAmount").ToString();
        }

        public void setChequeAmount (string chequeAmount)
        {
            this.setProperty("chequeAmount", chequeAmount);
        }

        public string getChequeAmountCurrency ()
        {
            return this.getProperty("chequeAmountCurrency").ToString();
        }

        public void setChequeAmountCurrency (string chequeAmountCurrency)
        {
            this.setProperty("chequeAmountCurrency", chequeAmountCurrency);
        }

        public DateTime getChequeDate ()
        {
            return (DateTime) this.getProperty("chequeDate");
        }

        public void setChequeDate (DateTime chequeDate)
        {
            this.setProperty("chequeDate", chequeDate);
        }

        public DateTime getCancelledDatetime ()
        {
            return (DateTime) this.getProperty("cancelledDatetime");
        }

        public void setCancelledDatetime (DateTime cancelledDatetime)
        {
            this.setProperty("cancelledDatetime", cancelledDatetime);
        }

        public DateTime getPrintedDatetime ()
        {
            return (DateTime) this.getProperty("printedDatetime");
        }

        public void setPrintedDatetime (DateTime printedDatetime)
        {
            this.setProperty("printedDatetime", printedDatetime);
        }


    }
}

