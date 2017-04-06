using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationAwardAssessment : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_AWARD_ASSESSMENT;
        public const string QUALIFICATION_SCHEME = "qualificationScheme";
        public const string ASSESSMENT_CODE = "assessmentCode";
        public const string FULL_TITLE = "fullTitle";
        public const string SHORT_TITLE = "shortTitle";
        public const string DESCRIPTION = "description";
        public const string ASSESSMENT_METHOD_TYPE = "assessmentMethodType";
        public const string ASSESSOR = "assessor";
        public const string TIME_ALLOWED = "timeAllowed";
        public const string MAX_EXTRA_TIME = "maxExtraTime";
        public const string CREDIT_VALUE = "creditValue";
        public const string MAX_RESITS_ALLOWED = "maxResitsAllowed";
        public const string TIMETABLE_SLOT_DECIDER = "timetableSlotDecider";

        public QualificationAwardAssessment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationAwardAssessment (string resourceType = "QualificationAwardAssessment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationAwardAssessment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationAwardAssessment");
        	RestGateway gateway = (RestGateway) QualificationAwardAssessment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationAwardAssessment> qualificationawardassessmentCollection = new ModelCollection<QualificationAwardAssessment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationawardassessmentCollection.add((QualificationAwardAssessment) model);
        	}
        
        	return qualificationawardassessmentCollection;
        }

        public static QualificationAwardAssessment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationAwardAssessment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationAwardAssessment) gateway.retrieve(ResourceType.QUALIFICATION_AWARD_ASSESSMENT, id);
        }

        public QualificationScheme getQualificationScheme ()
        {
            return (QualificationScheme) this.getProperty("qualificationScheme");
        }

        public void setQualificationScheme (QualificationScheme qualificationScheme)
        {
            this.setProperty("qualificationScheme", qualificationScheme);
        }

        public string getAssessmentCode ()
        {
            return this.getProperty("assessmentCode").ToString();
        }

        public void setAssessmentCode (string assessmentCode)
        {
            this.setProperty("assessmentCode", assessmentCode);
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

