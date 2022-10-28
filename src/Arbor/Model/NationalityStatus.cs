using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class NationalityStatus : ModelBase
    {
        protected new string resourceType = ResourceType.NATIONALITY_STATUS;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NATIONALITY_STATUS = "nationalityStatus";

        public NationalityStatus ()
        {
            base.resourceType = this.resourceType;
        }
        
        public NationalityStatus (string resourceType = "NationalityStatus", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<NationalityStatus> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("NationalityStatus");
        	RestGateway gateway = (RestGateway) NationalityStatus.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<NationalityStatus> nationalitystatusCollection = new ModelCollection<NationalityStatus> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    nationalitystatusCollection.add((NationalityStatus) model);
        	}
        
        	return nationalitystatusCollection;
        }

        public static NationalityStatus retrieve (string id)
        {
            RestGateway gateway = (RestGateway) NationalityStatus.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (NationalityStatus) gateway.retrieve(ResourceType.NATIONALITY_STATUS, id);
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

        public string getNationalityStatus ()
        {
            return this.getProperty("nationalityStatus").ToString();
        }

        public void setNationalityStatus (string nationalityStatus)
        {
            this.setProperty("nationalityStatus", nationalityStatus);
        }


    }
}

