using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentCurriculumEvidence : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_CURRICULUM_EVIDENCE;
        public const string STUDENT = "student";
        public const string CURRICULUM_STATEMENT = "curriculumStatement";
        public const string STUDENT_CURRICULUM_ACHIEVEMENT = "studentCurriculumAchievement";
        public const string SUMMARY = "summary";
        public const string DETAILS = "details";
        public const string OBSERVATION_DATE = "observationDate";
        public const string OBSERVATION_STAFF = "observationStaff";
        public const string EVIDENCE = "evidence";

        public StudentCurriculumEvidence ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentCurriculumEvidence (string resourceType = "StudentCurriculumEvidence", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentCurriculumEvidence> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentCurriculumEvidence");
        	RestGateway gateway = (RestGateway) StudentCurriculumEvidence.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentCurriculumEvidence> studentcurriculumevidenceCollection = new ModelCollection<StudentCurriculumEvidence> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentcurriculumevidenceCollection.add((StudentCurriculumEvidence) model);
        	}
        
        	return studentcurriculumevidenceCollection;
        }

        public static StudentCurriculumEvidence retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentCurriculumEvidence.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentCurriculumEvidence) gateway.retrieve(ResourceType.STUDENT_CURRICULUM_EVIDENCE, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public CurriculumStatement getCurriculumStatement ()
        {
            return (CurriculumStatement) this.getProperty("curriculumStatement");
        }

        public void setCurriculumStatement (CurriculumStatement curriculumStatement)
        {
            this.setProperty("curriculumStatement", curriculumStatement);
        }

        public StudentCurriculumAchievement getStudentCurriculumAchievement ()
        {
            return (StudentCurriculumAchievement) this.getProperty("studentCurriculumAchievement");
        }

        public void setStudentCurriculumAchievement (StudentCurriculumAchievement studentCurriculumAchievement)
        {
            this.setProperty("studentCurriculumAchievement", studentCurriculumAchievement);
        }

        public string getSummary ()
        {
            return this.getProperty("summary").ToString();
        }

        public void setSummary (string summary)
        {
            this.setProperty("summary", summary);
        }

        public string getDetails ()
        {
            return this.getProperty("details").ToString();
        }

        public void setDetails (string details)
        {
            this.setProperty("details", details);
        }

        public DateTime getObservationDate (){
            return Convert.ToDateTime(this.getProperty("observationDate"));
        }

        public void setObservationDate (DateTime observationDate)
        {
            this.setProperty("observationDate", observationDate);
        }

        public Staff getObservationStaff ()
        {
            return (Staff) this.getProperty("observationStaff");
        }

        public void setObservationStaff (Staff observationStaff)
        {
            this.setProperty("observationStaff", observationStaff);
        }

        public ModelBase getEvidence ()
        {
            return (ModelBase) this.getProperty("evidence");
        }

        public void setEvidence (ModelBase evidence)
        {
            this.setProperty("evidence", evidence);
        }


    }
}

