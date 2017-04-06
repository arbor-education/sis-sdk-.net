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
        public const string QUALIFICATION_LEARNING_UNIT = "qualificationLearningUnit";
        public const string CODE = "code";
        public const string ASSESSABLE_IDENTIFIER = "assessableIdentifier";
        public const string AWARDING_ORGANIZATION = "awardingOrganization";
        public const string FULL_TITLE = "fullTitle";
        public const string SHORT_TITLE = "shortTitle";
        public const string DESCRIPTION = "description";
        public const string ASSESSMENT_METHOD_TYPE = "assessmentMethodType";
        public const string ASSESSOR = "assessor";
        public const string IS_CENTER_ASSESSED = "isCenterAssessed";
        public const string CENTER_ASSESSMENT_DUE_DATE = "centerAssessmentDueDate";
        public const string TIME_ALLOWED = "timeAllowed";
        public const string MAX_EXTRA_TIME = "maxExtraTime";
        public const string CREDIT_VALUE = "creditValue";
        public const string MAX_RESITS_ALLOWED = "maxResitsAllowed";
        public const string TIMETABLE_SLOT_DECIDER = "timetableSlotDecider";

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

        public QualificationLearningUnit getQualificationLearningUnit ()
        {
            return (QualificationLearningUnit) this.getProperty("qualificationLearningUnit");
        }

        public void setQualificationLearningUnit (QualificationLearningUnit qualificationLearningUnit)
        {
            this.setProperty("qualificationLearningUnit", qualificationLearningUnit);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
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

        public string getFullTitle ()
        {
            return this.getProperty("fullTitle").ToString();
        }

        public void setFullTitle (string fullTitle)
        {
            this.setProperty("fullTitle", fullTitle);
        }

        public string getShortTitle ()
        {
            return this.getProperty("shortTitle").ToString();
        }

        public void setShortTitle (string shortTitle)
        {
            this.setProperty("shortTitle", shortTitle);
        }

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }

        public string getAssessmentMethodType ()
        {
            return this.getProperty("assessmentMethodType").ToString();
        }

        public void setAssessmentMethodType (string assessmentMethodType)
        {
            this.setProperty("assessmentMethodType", assessmentMethodType);
        }

        public string getAssessor ()
        {
            return this.getProperty("assessor").ToString();
        }

        public void setAssessor (string assessor)
        {
            this.setProperty("assessor", assessor);
        }

        public bool getIsCenterAssessed ()
        {
            return (bool) this.getProperty("isCenterAssessed");
        }

        public void setIsCenterAssessed (bool isCenterAssessed)
        {
            this.setProperty("isCenterAssessed", isCenterAssessed);
        }

        public DateTime getCenterAssessmentDueDate ()
        {
            return (DateTime) this.getProperty("centerAssessmentDueDate");
        }

        public void setCenterAssessmentDueDate (DateTime centerAssessmentDueDate)
        {
            this.setProperty("centerAssessmentDueDate", centerAssessmentDueDate);
        }

        public string getTimeAllowed ()
        {
            return this.getProperty("timeAllowed").ToString();
        }

        public void setTimeAllowed (string timeAllowed)
        {
            this.setProperty("timeAllowed", timeAllowed);
        }

        public string getMaxExtraTime ()
        {
            return this.getProperty("maxExtraTime").ToString();
        }

        public void setMaxExtraTime (string maxExtraTime)
        {
            this.setProperty("maxExtraTime", maxExtraTime);
        }

        public float getCreditValue ()
        {
            return (float) this.getProperty("creditValue");
        }

        public void setCreditValue (float creditValue)
        {
            this.setProperty("creditValue", creditValue);
        }

        public int getMaxResitsAllowed ()
        {
            return Convert.ToInt32(this.getProperty("maxResitsAllowed"));
        }

        public void setMaxResitsAllowed (int maxResitsAllowed)
        {
            this.setProperty("maxResitsAllowed", maxResitsAllowed);
        }

        public string getTimetableSlotDecider ()
        {
            return this.getProperty("timetableSlotDecider").ToString();
        }

        public void setTimetableSlotDecider (string timetableSlotDecider)
        {
            this.setProperty("timetableSlotDecider", timetableSlotDecider);
        }


    }
}

