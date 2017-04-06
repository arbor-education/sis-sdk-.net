using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationResult : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_RESULT;
        public const string QUALIFICATION_ASPECT = "qualificationAspect";
        public const string QUALIFICATION_GRADE = "qualificationGrade";
        public const string NUMERIC_VALUE = "numericValue";
        public const string STUDENT = "student";
        public const string CANDIDATE_ENTRY = "candidateEntry";
        public const string RESULT_DATE = "resultDate";

        public QualificationResult ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationResult (string resourceType = "QualificationResult", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationResult> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationResult");
        	RestGateway gateway = (RestGateway) QualificationResult.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationResult> qualificationresultCollection = new ModelCollection<QualificationResult> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationresultCollection.add((QualificationResult) model);
        	}
        
        	return qualificationresultCollection;
        }

        public static QualificationResult retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationResult.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationResult) gateway.retrieve(ResourceType.QUALIFICATION_RESULT, id);
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

        public DateTime getResultDate ()
        {
            return (DateTime) this.getProperty("resultDate");
        }

        public void setResultDate (DateTime resultDate)
        {
            this.setProperty("resultDate", resultDate);
        }


    }
}

