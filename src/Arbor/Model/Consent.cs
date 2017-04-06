using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Consent : ModelBase
    {
        protected string resourceType = ResourceType.CONSENT;
        public const string STUDENT = "student";
        public const string CONSENT_TYPE = "consentType";
        public const string RELATED = "related";
        public const string REQUESTOR = "requestor";
        public const string REQUESTED_DATETIME = "requestedDatetime";
        public const string REJECTED_DATETIME = "rejectedDatetime";
        public const string CONSENTED_DATETIME = "consentedDatetime";
        public const string RESPONDEE = "respondee";

        public Consent ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Consent (string resourceType = "Consent", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Consent> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Consent");
        	RestGateway gateway = (RestGateway) Consent.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Consent> consentCollection = new ModelCollection<Consent> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    consentCollection.add((Consent) model);
        	}
        
        	return consentCollection;
        }

        public static Consent retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Consent.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Consent) gateway.retrieve(ResourceType.CONSENT, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public ConsentType getConsentType ()
        {
            return (ConsentType) this.getProperty("consentType");
        }

        public void setConsentType (ConsentType consentType)
        {
            this.setProperty("consentType", consentType);
        }

        public ModelBase getRelated ()
        {
            return (ModelBase) this.getProperty("related");
        }

        public void setRelated (ModelBase related)
        {
            this.setProperty("related", related);
        }

        public ModelBase getRequestor ()
        {
            return (ModelBase) this.getProperty("requestor");
        }

        public void setRequestor (ModelBase requestor)
        {
            this.setProperty("requestor", requestor);
        }

        public DateTime getRequestedDatetime ()
        {
            return (DateTime) this.getProperty("requestedDatetime");
        }

        public void setRequestedDatetime (DateTime requestedDatetime)
        {
            this.setProperty("requestedDatetime", requestedDatetime);
        }

        public DateTime getRejectedDatetime ()
        {
            return (DateTime) this.getProperty("rejectedDatetime");
        }

        public void setRejectedDatetime (DateTime rejectedDatetime)
        {
            this.setProperty("rejectedDatetime", rejectedDatetime);
        }

        public DateTime getConsentedDatetime ()
        {
            return (DateTime) this.getProperty("consentedDatetime");
        }

        public void setConsentedDatetime (DateTime consentedDatetime)
        {
            this.setProperty("consentedDatetime", consentedDatetime);
        }

        public ModelBase getRespondee ()
        {
            return (ModelBase) this.getProperty("respondee");
        }

        public void setRespondee (ModelBase respondee)
        {
            this.setProperty("respondee", respondee);
        }


    }
}

