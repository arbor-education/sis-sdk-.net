using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CheckClearanceLevel : ModelBase
    {
        protected string resourceType = ResourceType.CHECK_CLEARANCE_LEVEL;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string LABEL = "label";
        public const string CHECK_TYPE = "checkType";

        public CheckClearanceLevel ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CheckClearanceLevel (string resourceType = "CheckClearanceLevel", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CheckClearanceLevel> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CheckClearanceLevel");
        	RestGateway gateway = (RestGateway) CheckClearanceLevel.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CheckClearanceLevel> checkclearancelevelCollection = new ModelCollection<CheckClearanceLevel> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    checkclearancelevelCollection.add((CheckClearanceLevel) model);
        	}
        
        	return checkclearancelevelCollection;
        }

        public static CheckClearanceLevel retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CheckClearanceLevel.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CheckClearanceLevel) gateway.retrieve(ResourceType.CHECK_CLEARANCE_LEVEL, id);
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
            return Convert.ToBoolean(this.getProperty("active"))
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

        public CheckType getCheckType ()
        {
            return (CheckType) this.getProperty("checkType");
        }

        public void setCheckType (CheckType checkType)
        {
            this.setProperty("checkType", checkType);
        }


    }
}

