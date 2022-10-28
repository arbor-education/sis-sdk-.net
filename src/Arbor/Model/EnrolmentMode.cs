using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EnrolmentMode : ModelBase
    {
        protected new string resourceType = ResourceType.ENROLMENT_MODE;
        public const string D00018 = "d00018";
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string DESCRIPTION = "description";

        public EnrolmentMode ()
        {
            base.resourceType = this.resourceType;
        }
        
        public EnrolmentMode (string resourceType = "EnrolmentMode", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<EnrolmentMode> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("EnrolmentMode");
        	RestGateway gateway = (RestGateway) EnrolmentMode.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<EnrolmentMode> enrolmentmodeCollection = new ModelCollection<EnrolmentMode> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    enrolmentmodeCollection.add((EnrolmentMode) model);
        	}
        
        	return enrolmentmodeCollection;
        }

        public static EnrolmentMode retrieve (string id)
        {
            RestGateway gateway = (RestGateway) EnrolmentMode.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (EnrolmentMode) gateway.retrieve(ResourceType.ENROLMENT_MODE, id);
        }

        public string getD00018 ()
        {
            return this.getProperty("d00018").ToString();
        }

        public void setD00018 (string d00018)
        {
            this.setProperty("d00018", d00018);
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

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }


    }
}

