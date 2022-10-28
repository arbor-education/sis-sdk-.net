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
        protected new string resourceType = ResourceType.QUALIFICATION_RESULT;
        public const string QUALIFICATION_ASPECT = "qualificationAspect";
        public const string QUALIFICATION_GRADE = "qualificationGrade";
        public const string NUMERIC_VALUE = "numericValue";
        public const string STUDENT = "student";
        public const string CANDIDATE_REGISTRATION = "candidateRegistration";
        public const string CANDIDATE_ENTRY = "candidateEntry";
        public const string CANDIDATE_ASSESSABLE_ENTRY = "candidateAssessableEntry";
        public const string RESULT_DATETIME = "resultDatetime";
        public const string EMBARGO_DATETIME = "embargoDatetime";
        public const string MISSING_RESULT_REASON = "missingResultReason";
        public const string PARTIAL_ABSENCE = "partialAbsence";
        public const string ENDORSEMENT_GRADE = "endorsementGrade";

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

        public CandidateRegistration getCandidateRegistration ()
        {
            return (CandidateRegistration) this.getProperty("candidateRegistration");
        }

        public void setCandidateRegistration (CandidateRegistration candidateRegistration)
        {
            this.setProperty("candidateRegistration", candidateRegistration);
        }

        public CandidateEntry getCandidateEntry ()
        {
            return (CandidateEntry) this.getProperty("candidateEntry");
        }

        public void setCandidateEntry (CandidateEntry candidateEntry)
        {
            this.setProperty("candidateEntry", candidateEntry);
        }

        public CandidateAssessableEntry getCandidateAssessableEntry ()
        {
            return (CandidateAssessableEntry) this.getProperty("candidateAssessableEntry");
        }

        public void setCandidateAssessableEntry (CandidateAssessableEntry candidateAssessableEntry)
        {
            this.setProperty("candidateAssessableEntry", candidateAssessableEntry);
        }

        public DateTime getResultDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("resultDatetime"));
        }

        public void setResultDatetime (DateTime resultDatetime)
        {
            this.setProperty("resultDatetime", resultDatetime);
        }

        public DateTime getEmbargoDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("embargoDatetime"));
        }

        public void setEmbargoDatetime (DateTime embargoDatetime)
        {
            this.setProperty("embargoDatetime", embargoDatetime);
        }

        public string getMissingResultReason ()
        {
            return this.getProperty("missingResultReason").ToString();
        }

        public void setMissingResultReason (string missingResultReason)
        {
            this.setProperty("missingResultReason", missingResultReason);
        }

        public int getPartialAbsence ()
        {
            return Convert.ToInt32(this.getProperty("partialAbsence"));
        }

        public void setPartialAbsence (int partialAbsence)
        {
            this.setProperty("partialAbsence", partialAbsence);
        }

        public QualificationGrade getEndorsementGrade ()
        {
            return (QualificationGrade) this.getProperty("endorsementGrade");
        }

        public void setEndorsementGrade (QualificationGrade endorsementGrade)
        {
            this.setProperty("endorsementGrade", endorsementGrade);
        }


    }
}

