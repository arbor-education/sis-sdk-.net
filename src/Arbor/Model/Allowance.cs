using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Allowance : ModelBase
    {
        protected new string resourceType = ResourceType.ALLOWANCE;
        public const string ALLOWANCE_NAME = "allowanceName";
        public const string ALLOWANCE_CODE = "allowanceCode";

        public Allowance ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Allowance (string resourceType = "Allowance", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Allowance> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Allowance");
        	RestGateway gateway = (RestGateway) Allowance.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Allowance> allowanceCollection = new ModelCollection<Allowance> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    allowanceCollection.add((Allowance) model);
        	}
        
        	return allowanceCollection;
        }

        public static Allowance retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Allowance.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Allowance) gateway.retrieve(ResourceType.ALLOWANCE, id);
        }

        public string getAllowanceName ()
        {
            return this.getProperty("allowanceName").ToString();
        }

        public void setAllowanceName (string allowanceName)
        {
            this.setProperty("allowanceName", allowanceName);
        }

        public string getAllowanceCode ()
        {
            return this.getProperty("allowanceCode").ToString();
        }

        public void setAllowanceCode (string allowanceCode)
        {
            this.setProperty("allowanceCode", allowanceCode);
        }


    }
}

