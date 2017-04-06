using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class ChequePayment : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_CHEQUE_PAYMENT;
        public const string CHEQUE_BOOK = "chequeBook";
        public const string PAYEE = "payee";
        public const string PAYMENT = "payment";
        public const string CHEQUE_DATE = "chequeDate";

        public ChequePayment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ChequePayment (string resourceType = "ChequePayment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ChequePayment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_ChequePayment");
        	RestGateway gateway = (RestGateway) ChequePayment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ChequePayment> chequepaymentCollection = new ModelCollection<ChequePayment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    chequepaymentCollection.add((ChequePayment) model);
        	}
        
        	return chequepaymentCollection;
        }

        public static ChequePayment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ChequePayment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ChequePayment) gateway.retrieve(ResourceType.FINANCE_CHEQUE_PAYMENT, id);
        }

        public ModelBase getChequeBook ()
        {
            return (ModelBase) this.getProperty("chequeBook");
        }

        public void setChequeBook (ModelBase chequeBook)
        {
            this.setProperty("chequeBook", chequeBook);
        }

        public ModelBase getPayee ()
        {
            return (ModelBase) this.getProperty("payee");
        }

        public void setPayee (ModelBase payee)
        {
            this.setProperty("payee", payee);
        }

        public string getPayment ()
        {
            return this.getProperty("payment").ToString();
        }

        public void setPayment (string payment)
        {
            this.setProperty("payment", payment);
        }

        public DateTime getChequeDate ()
        {
            return (DateTime) this.getProperty("chequeDate");
        }

        public void setChequeDate (DateTime chequeDate)
        {
            this.setProperty("chequeDate", chequeDate);
        }


    }
}

