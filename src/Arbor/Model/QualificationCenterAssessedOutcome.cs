using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationCenterAssessedOutcome : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_CENTER_ASSESSED_OUTCOME;
        public const string QUALIFICATION_ASPECT = "qualificationAspect";
        public const string QUALIFICATION_GRADE = "qualificationGrade";
        public const string NUMERIC_VALUE = "numericValue";
        public const string STUDENT = "student";
        public const string CANDIDATE_ENTRY = "candidateEntry";
        public const string ASSESSMENT_DATE = "assessmentDate";
        public const string NARRATIVE = "narrative";

        public QualificationCenterAssessedOutcome()
        {
            base.resourceType = this.resourceType;
        }

        public QualificationCenterAssessedOutcome(string resourceType = "QualificationCenterAssessedOutcome", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<QualificationCenterAssessedOutcome> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("QualificationCenterAssessedOutcome");
            RestGateway gateway = (RestGateway)QualificationCenterAssessedOutcome.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<QualificationCenterAssessedOutcome> qualificationcenterassessedoutcomeCollection = new ModelCollection<QualificationCenterAssessedOutcome>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                qualificationcenterassessedoutcomeCollection.add((QualificationCenterAssessedOutcome)model);
            }

            return qualificationcenterassessedoutcomeCollection;
        }

        public static QualificationCenterAssessedOutcome retrieve(string id)
        {
            RestGateway gateway = (RestGateway)QualificationCenterAssessedOutcome.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (QualificationCenterAssessedOutcome)gateway.retrieve(ResourceType.QUALIFICATION_CENTER_ASSESSED_OUTCOME, id);
        }

        public QualificationAspect getQualificationAspect()
        {
            return (QualificationAspect)this.getProperty("qualificationAspect");
        }

        public void setQualificationAspect(QualificationAspect qualificationAspect)
        {
            this.setProperty("qualificationAspect", qualificationAspect);
        }

        public QualificationGrade getQualificationGrade()
        {
            return (QualificationGrade)this.getProperty("qualificationGrade");
        }

        public void setQualificationGrade(QualificationGrade qualificationGrade)
        {
            this.setProperty("qualificationGrade", qualificationGrade);
        }

        public float getNumericValue()
        {
            return (float)this.getProperty("numericValue");
        }

        public void setNumericValue(float numericValue)
        {
            this.setProperty("numericValue", numericValue);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public CandidateEntry getCandidateEntry()
        {
            return (CandidateEntry)this.getProperty("candidateEntry");
        }

        public void setCandidateEntry(CandidateEntry candidateEntry)
        {
            this.setProperty("candidateEntry", candidateEntry);
        }

        public DateTime getAssessmentDate()
        {
            return Convert.ToDateTime(this.getProperty("assessmentDate"));
        }

        public void setAssessmentDate(DateTime assessmentDate)
        {
            this.setProperty("assessmentDate", assessmentDate);
        }

        public string getNarrative()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative(string narrative)
        {
            this.setProperty("narrative", narrative);
        }


    }
}

