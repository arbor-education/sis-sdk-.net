using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DietaryRequirementType : ModelBase
    {
        protected string resourceType = ResourceType.DIETARY_REQUIREMENT_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string LABEL = "label";

        public DietaryRequirementType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public DietaryRequirementType (string resourceType = "DietaryRequirementType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<DietaryRequirementType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("DietaryRequirementType");
        	RestGateway gateway = (RestGateway) DietaryRequirementType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<DietaryRequirementType> dietaryrequirementtypeCollection = new ModelCollection<DietaryRequirementType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    dietaryrequirementtypeCollection.add((DietaryRequirementType) model);
        	}
        
        	return dietaryrequirementtypeCollection;
        }

        public static DietaryRequirementType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) DietaryRequirementType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (DietaryRequirementType) gateway.retrieve(ResourceType.DIETARY_REQUIREMENT_TYPE, id);
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
            return Convert.ToBoolean( this.getProperty("active"));
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

        public string getLabel ()
        {
            return this.getProperty("label").ToString();
        }

        public void setLabel (string label)
        {
            this.setProperty("label", label);
        }


    }
}

