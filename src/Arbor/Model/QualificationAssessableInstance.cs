using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationAssessableInstance : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_ASSESSABLE_INSTANCE;
        public const string ASSESSABLE_INSTANCE_IDENTIFIER = "assessableInstanceIdentifier";
        public const string QUALIFICATION_ASSESSABLE = "qualificationAssessable";
        public const string START_DATE_RANGE_FROM = "startDateRangeFrom";
        public const string START_DATE_RANGE_UNTIL = "startDateRangeUntil";
        public const string QUALIFICATION_TIMETABLE_SESSION_TYPE = "qualificationTimetableSessionType";
        public const string DURATION = "duration";
        public const string IS_PROVISIONAL = "isProvisional";

        public QualificationAssessableInstance ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationAssessableInstance (string resourceType = "QualificationAssessableInstance", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationAssessableInstance> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationAssessableInstance");
        	RestGateway gateway = (RestGateway) QualificationAssessableInstance.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationAssessableInstance> qualificationassessableinstanceCollection = new ModelCollection<QualificationAssessableInstance> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationassessableinstanceCollection.add((QualificationAssessableInstance) model);
        	}
        
        	return qualificationassessableinstanceCollection;
        }

        public static QualificationAssessableInstance retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationAssessableInstance.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationAssessableInstance) gateway.retrieve(ResourceType.QUALIFICATION_ASSESSABLE_INSTANCE, id);
        }

        public string getAssessableInstanceIdentifier ()
        {
            return this.getProperty("assessableInstanceIdentifier").ToString();
        }

        public void setAssessableInstanceIdentifier (string assessableInstanceIdentifier)
        {
            this.setProperty("assessableInstanceIdentifier", assessableInstanceIdentifier);
        }

        public QualificationAssessable getQualificationAssessable ()
        {
            return (QualificationAssessable) this.getProperty("qualificationAssessable");
        }

        public void setQualificationAssessable (QualificationAssessable qualificationAssessable)
        {
            this.setProperty("qualificationAssessable", qualificationAssessable);
        }

        public DateTime getStartDateRangeFrom ()
        {
            return (DateTime) this.getProperty("startDateRangeFrom");
        }

        public void setStartDateRangeFrom (DateTime startDateRangeFrom)
        {
            this.setProperty("startDateRangeFrom", startDateRangeFrom);
        }

        public DateTime getStartDateRangeUntil ()
        {
            return (DateTime) this.getProperty("startDateRangeUntil");
        }

        public void setStartDateRangeUntil (DateTime startDateRangeUntil)
        {
            this.setProperty("startDateRangeUntil", startDateRangeUntil);
        }

        public ModelBase getQualificationTimetableSessionType ()
        {
            return (ModelBase) this.getProperty("qualificationTimetableSessionType");
        }

        public void setQualificationTimetableSessionType (ModelBase qualificationTimetableSessionType)
        {
            this.setProperty("qualificationTimetableSessionType", qualificationTimetableSessionType);
        }

        public string getDuration ()
        {
            return this.getProperty("duration").ToString();
        }

        public void setDuration (string duration)
        {
            this.setProperty("duration", duration);
        }

        public bool getIsProvisional ()
        {
            return (bool) this.getProperty("isProvisional");
        }

        public void setIsProvisional (bool isProvisional)
        {
            this.setProperty("isProvisional", isProvisional);
        }


    }
}

