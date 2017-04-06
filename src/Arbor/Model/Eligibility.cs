using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Eligibility : ModelBase
    {
        protected string resourceType = ResourceType.ELIGIBILITY;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string ELIGIBILITY_NAME = "eligibilityName";

        public Eligibility ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Eligibility (string resourceType = "Eligibility", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Eligibility> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Eligibility");
        	RestGateway gateway = (RestGateway) Eligibility.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Eligibility> eligibilityCollection = new ModelCollection<Eligibility> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    eligibilityCollection.add((Eligibility) model);
        	}
        
        	return eligibilityCollection;
        }

        public static Eligibility retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Eligibility.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Eligibility) gateway.retrieve(ResourceType.ELIGIBILITY, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return (bool) this.getProperty("active");
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getEligibilityName ()
        {
            return this.getProperty("eligibilityName").ToString();
        }

        public void setEligibilityName (string eligibilityName)
        {
            this.setProperty("eligibilityName", eligibilityName);
        }


    }
}

