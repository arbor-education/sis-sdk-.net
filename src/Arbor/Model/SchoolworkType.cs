using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SchoolworkType : ModelBase
    {
        protected string resourceType = ResourceType.SCHOOLWORK_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string SCHOOLWORK_TYPE_NAME = "schoolworkTypeName";

        public SchoolworkType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SchoolworkType (string resourceType = "SchoolworkType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SchoolworkType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SchoolworkType");
        	RestGateway gateway = (RestGateway) SchoolworkType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SchoolworkType> schoolworktypeCollection = new ModelCollection<SchoolworkType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schoolworktypeCollection.add((SchoolworkType) model);
        	}
        
        	return schoolworktypeCollection;
        }

        public static SchoolworkType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SchoolworkType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SchoolworkType) gateway.retrieve(ResourceType.SCHOOLWORK_TYPE, id);
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

        public string getSchoolworkTypeName ()
        {
            return this.getProperty("schoolworkTypeName").ToString();
        }

        public void setSchoolworkTypeName (string schoolworkTypeName)
        {
            this.setProperty("schoolworkTypeName", schoolworkTypeName);
        }


    }
}

