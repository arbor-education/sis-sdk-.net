using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EmploymentRecordType : ModelBase
    {
        protected string resourceType = ResourceType.EMPLOYMENT_RECORD_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";

        public EmploymentRecordType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public EmploymentRecordType (string resourceType = "EmploymentRecordType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<EmploymentRecordType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("EmploymentRecordType");
        	RestGateway gateway = (RestGateway) EmploymentRecordType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<EmploymentRecordType> employmentrecordtypeCollection = new ModelCollection<EmploymentRecordType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    employmentrecordtypeCollection.add((EmploymentRecordType) model);
        	}
        
        	return employmentrecordtypeCollection;
        }

        public static EmploymentRecordType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) EmploymentRecordType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (EmploymentRecordType) gateway.retrieve(ResourceType.EMPLOYMENT_RECORD_TYPE, id);
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

