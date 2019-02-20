using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationAssessable : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_ASSESSABLE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string ASSESSABLE_IDENTIFIER = "assessableIdentifier";
        public const string AWARDING_ORGANIZATION = "awardingOrganization";
        public const string TITLE = "title";
        public const string ASSESSMENT_METHOD_TYPE = "assessmentMethodType";
        public const string CENTER_ASSESSED = "centerAssessed";

        public QualificationAssessable ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationAssessable (string resourceType = "QualificationAssessable", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationAssessable> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationAssessable");
        	RestGateway gateway = (RestGateway) QualificationAssessable.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationAssessable> qualificationassessableCollection = new ModelCollection<QualificationAssessable> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationassessableCollection.add((QualificationAssessable) model);
        	}
        
        	return qualificationassessableCollection;
        }

        public static QualificationAssessable retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationAssessable.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationAssessable) gateway.retrieve(ResourceType.QUALIFICATION_ASSESSABLE, id);
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

        public string getAssessableIdentifier ()
        {
            return this.getProperty("assessableIdentifier").ToString();
        }

        public void setAssessableIdentifier (string assessableIdentifier)
        {
            this.setProperty("assessableIdentifier", assessableIdentifier);
        }

        public AwardingOrganization getAwardingOrganization ()
        {
            return (AwardingOrganization) this.getProperty("awardingOrganization");
        }

        public void setAwardingOrganization (AwardingOrganization awardingOrganization)
        {
            this.setProperty("awardingOrganization", awardingOrganization);
        }

        public string getTitle ()
        {
            return this.getProperty("title").ToString();
        }

        public void setTitle (string title)
        {
            this.setProperty("title", title);
        }

        public string getAssessmentMethodType ()
        {
            return this.getProperty("assessmentMethodType").ToString();
        }

        public void setAssessmentMethodType (string assessmentMethodType)
        {
            this.setProperty("assessmentMethodType", assessmentMethodType);
        }

        public bool getCenterAssessed ()
        {
            return Convert.ToBoolean(this.getProperty("centerAssessed"));
        }

        public void setCenterAssessed (bool centerAssessed)
        {
            this.setProperty("centerAssessed", centerAssessed);
        }


    }
}

