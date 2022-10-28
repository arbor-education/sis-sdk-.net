using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ConsentType : ModelBase
    {
        protected new string resourceType = ResourceType.CONSENT_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string CONSENT_TYPE_NAME = "consentTypeName";
        public const string DESCRIPTION = "description";
        public const string DEFAULT_DESCRIPTION = "defaultDescription";
        public const string AUTO_REQUEST_FROM_GUARDIANS = "autoRequestFromGuardians";
        public const string CONSENTED_BY_STUDENT = "consentedByStudent";
        public const string CONSENTED_BY_GUARDIAN = "consentedByGuardian";

        public ConsentType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ConsentType (string resourceType = "ConsentType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ConsentType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ConsentType");
        	RestGateway gateway = (RestGateway) ConsentType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ConsentType> consenttypeCollection = new ModelCollection<ConsentType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    consenttypeCollection.add((ConsentType) model);
        	}
        
        	return consenttypeCollection;
        }

        public static ConsentType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ConsentType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ConsentType) gateway.retrieve(ResourceType.CONSENT_TYPE, id);
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

        public string getConsentTypeName ()
        {
            return this.getProperty("consentTypeName").ToString();
        }

        public void setConsentTypeName (string consentTypeName)
        {
            this.setProperty("consentTypeName", consentTypeName);
        }

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }

        public string getDefaultDescription ()
        {
            return this.getProperty("defaultDescription").ToString();
        }

        public void setDefaultDescription (string defaultDescription)
        {
            this.setProperty("defaultDescription", defaultDescription);
        }

        public bool getAutoRequestFromGuardians ()
        {
            return Convert.ToBoolean(this.getProperty("autoRequestFromGuardians"));
        }

        public void setAutoRequestFromGuardians (bool autoRequestFromGuardians)
        {
            this.setProperty("autoRequestFromGuardians", autoRequestFromGuardians);
        }

        public bool getConsentedByStudent ()
        {
            return Convert.ToBoolean(this.getProperty("consentedByStudent"));
        }

        public void setConsentedByStudent (bool consentedByStudent)
        {
            this.setProperty("consentedByStudent", consentedByStudent);
        }

        public bool getConsentedByGuardian ()
        {
            return Convert.ToBoolean(this.getProperty("consentedByGuardian"));
        }

        public void setConsentedByGuardian (bool consentedByGuardian)
        {
            this.setProperty("consentedByGuardian", consentedByGuardian);
        }


    }
}

