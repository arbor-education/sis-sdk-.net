using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EducationRecordType : ModelBase
    {
        protected string resourceType = ResourceType.EDUCATION_RECORD_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";

        public EducationRecordType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public EducationRecordType (string resourceType = "EducationRecordType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<EducationRecordType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("EducationRecordType");
        	RestGateway gateway = (RestGateway) EducationRecordType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<EducationRecordType> educationrecordtypeCollection = new ModelCollection<EducationRecordType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    educationrecordtypeCollection.add((EducationRecordType) model);
        	}
        
        	return educationrecordtypeCollection;
        }

        public static EducationRecordType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) EducationRecordType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (EducationRecordType) gateway.retrieve(ResourceType.EDUCATION_RECORD_TYPE, id);
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

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }


    }
}

