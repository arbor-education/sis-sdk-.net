using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SchoolEventType : ModelBase
    {
        protected new string resourceType = ResourceType.SCHOOL_EVENT_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string SCHOOL_EVENT_TYPE_NAME = "schoolEventTypeName";

        public SchoolEventType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SchoolEventType (string resourceType = "SchoolEventType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SchoolEventType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SchoolEventType");
        	RestGateway gateway = (RestGateway) SchoolEventType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SchoolEventType> schooleventtypeCollection = new ModelCollection<SchoolEventType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schooleventtypeCollection.add((SchoolEventType) model);
        	}
        
        	return schooleventtypeCollection;
        }

        public static SchoolEventType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SchoolEventType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SchoolEventType) gateway.retrieve(ResourceType.SCHOOL_EVENT_TYPE, id);
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
            return Convert.ToBoolean(this.getProperty("active"));
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

        public string getSchoolEventTypeName ()
        {
            return this.getProperty("schoolEventTypeName").ToString();
        }

        public void setSchoolEventTypeName (string schoolEventTypeName)
        {
            this.setProperty("schoolEventTypeName", schoolEventTypeName);
        }


    }
}

