using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationForecastResult : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_FORECAST_RESULT;
        public const string QUALIFICATION_ASPECT = "qualificationAspect";
        public const string QUALIFICATION_GRADE = "qualificationGrade";
        public const string NUMERIC_VALUE = "numericValue";
        public const string STUDENT = "student";
        public const string CANDIDATE_ENTRY = "candidateEntry";
        public const string CANDIDATE_REGISTRATION = "candidateRegistration";
        public const string INPUT_DATETIME = "inputDatetime";

        public QualificationForecastResult ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationForecastResult (string resourceType = "QualificationForecastResult", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationForecastResult> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationForecastResult");
        	RestGateway gateway = (RestGateway) QualificationForecastResult.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationForecastResult> qualificationforecastresultCollection = new ModelCollection<QualificationForecastResult> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationforecastresultCollection.add((QualificationForecastResult) model);
        	}
        
        	return qualificationforecastresultCollection;
        }

        public static QualificationForecastResult retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationForecastResult.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationForecastResult) gateway.retrieve(ResourceType.QUALIFICATION_FORECAST_RESULT, id);
        }

        public QualificationAspect getQualificationAspect ()
        {
            return (QualificationAspect) this.getProperty("qualificationAspect");
        }

        public void setQualificationAspect (QualificationAspect qualificationAspect)
        {
            this.setProperty("qualificationAspect", qualificationAspect);
        }

        public QualificationGrade getQualificationGrade ()
        {
            return (QualificationGrade) this.getProperty("qualificationGrade");
        }

        public void setQualificationGrade (QualificationGrade qualificationGrade)
        {
            this.setProperty("qualificationGrade", qualificationGrade);
        }

        public float getNumericValue ()
        {
            return (float) this.getProperty("numericValue");
        }

        public void setNumericValue (float numericValue)
        {
            this.setProperty("numericValue", numericValue);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public CandidateEntry getCandidateEntry ()
        {
            return (CandidateEntry) this.getProperty("candidateEntry");
        }

        public void setCandidateEntry (CandidateEntry candidateEntry)
        {
            this.setProperty("candidateEntry", candidateEntry);
        }

        public CandidateRegistration getCandidateRegistration ()
        {
            return (CandidateRegistration) this.getProperty("candidateRegistration");
        }

        public void setCandidateRegistration (CandidateRegistration candidateRegistration)
        {
            this.setProperty("candidateRegistration", candidateRegistration);
        }

        public DateTime getInputDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("inputDatetime"));
        }

        public void setInputDatetime (DateTime inputDatetime)
        {
            this.setProperty("inputDatetime", inputDatetime);
        }


    }
}

