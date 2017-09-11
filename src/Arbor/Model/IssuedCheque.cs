using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IssuedCheque : ModelBase
    {
        protected string resourceType = ResourceType.ISSUED_CHEQUE;
        public const string CUSTOMER_ACCOUNT = "customerAccount";
        public const string ISSUED_DATETIME = "issuedDatetime";
        public const string ISSUED = "issued";
        public const string NARRATIVE = "narrative";

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
        	query.setResourceType ("IssuedCheque");
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
        	return (IssuedCheque) gateway.retrieve(ResourceType.ISSUED_CHEQUE, id);
        }

        public CustomerAccount getCustomerAccount ()
        {
            return (CustomerAccount) this.getProperty("customerAccount");
        }

        public void setCustomerAccount (CustomerAccount customerAccount)
        {
            this.setProperty("customerAccount", customerAccount);
        }

        public DateTime getIssuedDatetime ()
        {
            return (DateTime) this.getProperty("issuedDatetime");
        }

        public void setIssuedDatetime (DateTime issuedDatetime)
        {
            this.setProperty("issuedDatetime", issuedDatetime);
        }

        public string getIssued ()
        {
            return this.getProperty("issued").ToString();
        }

        public void setIssued (string issued)
        {
            this.setProperty("issued", issued);
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

