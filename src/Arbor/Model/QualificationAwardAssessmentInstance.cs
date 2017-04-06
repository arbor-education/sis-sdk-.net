using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationAwardAssessmentInstance : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_AWARD_ASSESSMENT_INSTANCE;
        public const string QUALIFICATION_AWARD_ASSESSMENT = "qualificationAwardAssessment";
        public const string TEACHER_GRADE_DUE_DATE = "teacherGradeDueDate";
        public const string ASSESSMENT_TIMETABLE_DATETIME = "assessmentTimetableDatetime";

        public QualificationAwardAssessmentInstance ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationAwardAssessmentInstance (string resourceType = "QualificationAwardAssessmentInstance", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationAwardAssessmentInstance> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationAwardAssessmentInstance");
        	RestGateway gateway = (RestGateway) QualificationAwardAssessmentInstance.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationAwardAssessmentInstance> qualificationawardassessmentinstanceCollection = new ModelCollection<QualificationAwardAssessmentInstance> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationawardassessmentinstanceCollection.add((QualificationAwardAssessmentInstance) model);
        	}
        
        	return qualificationawardassessmentinstanceCollection;
        }

        public static QualificationAwardAssessmentInstance retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationAwardAssessmentInstance.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationAwardAssessmentInstance) gateway.retrieve(ResourceType.QUALIFICATION_AWARD_ASSESSMENT_INSTANCE, id);
        }

        public QualificationAwardAssessment getQualificationAwardAssessment ()
        {
            return (QualificationAwardAssessment) this.getProperty("qualificationAwardAssessment");
        }

        public void setQualificationAwardAssessment (QualificationAwardAssessment qualificationAwardAssessment)
        {
            this.setProperty("qualificationAwardAssessment", qualificationAwardAssessment);
        }

        public DateTime getTeacherGradeDueDate ()
        {
            return (DateTime) this.getProperty("teacherGradeDueDate");
        }

        public void setTeacherGradeDueDate (DateTime teacherGradeDueDate)
        {
            this.setProperty("teacherGradeDueDate", teacherGradeDueDate);
        }

        public DateTime getAssessmentTimetableDatetime ()
        {
            return (DateTime) this.getProperty("assessmentTimetableDatetime");
        }

        public void setAssessmentTimetableDatetime (DateTime assessmentTimetableDatetime)
        {
            this.setProperty("assessmentTimetableDatetime", assessmentTimetableDatetime);
        }


    }
}

