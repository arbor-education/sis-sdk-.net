using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentReportCardSection : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_REPORT_CARD_SECTION;
        public const string STUDENT_REPORT_CARD = "studentReportCard";
        public const string PARENT_STUDENT_REPORT_CARD_SECTION = "parentStudentReportCardSection";
        public const string REPORT_CARD_TEMPLATE_SECTION = "reportCardTemplateSection";
        public const string ACADEMIC_UNIT = "academicUnit";
        public const string SUBJECT = "subject";
        public const string SESSION_STREAM = "sessionStream";
        public const string COMPLETED_DATETIME = "completedDatetime";
        public const string APPROVED_DATETIME = "approvedDatetime";

        public StudentReportCardSection ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentReportCardSection (string resourceType = "StudentReportCardSection", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentReportCardSection> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentReportCardSection");
        	RestGateway gateway = (RestGateway) StudentReportCardSection.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentReportCardSection> studentreportcardsectionCollection = new ModelCollection<StudentReportCardSection> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentreportcardsectionCollection.add((StudentReportCardSection) model);
        	}
        
        	return studentreportcardsectionCollection;
        }

        public static StudentReportCardSection retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentReportCardSection.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentReportCardSection) gateway.retrieve(ResourceType.STUDENT_REPORT_CARD_SECTION, id);
        }

        public StudentReportCard getStudentReportCard ()
        {
            return (StudentReportCard) this.getProperty("studentReportCard");
        }

        public void setStudentReportCard (StudentReportCard studentReportCard)
        {
            this.setProperty("studentReportCard", studentReportCard);
        }

        public StudentReportCardSection getParentStudentReportCardSection ()
        {
            return (StudentReportCardSection) this.getProperty("parentStudentReportCardSection");
        }

        public void setParentStudentReportCardSection (StudentReportCardSection parentStudentReportCardSection)
        {
            this.setProperty("parentStudentReportCardSection", parentStudentReportCardSection);
        }

        public ReportCardTemplateSection getReportCardTemplateSection ()
        {
            return (ReportCardTemplateSection) this.getProperty("reportCardTemplateSection");
        }

        public void setReportCardTemplateSection (ReportCardTemplateSection reportCardTemplateSection)
        {
            this.setProperty("reportCardTemplateSection", reportCardTemplateSection);
        }

        public AcademicUnit getAcademicUnit ()
        {
            return (AcademicUnit) this.getProperty("academicUnit");
        }

        public void setAcademicUnit (AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }

        public Subject getSubject ()
        {
            return (Subject) this.getProperty("subject");
        }

        public void setSubject (Subject subject)
        {
            this.setProperty("subject", subject);
        }

        public SessionStream getSessionStream ()
        {
            return (SessionStream) this.getProperty("sessionStream");
        }

        public void setSessionStream (SessionStream sessionStream)
        {
            this.setProperty("sessionStream", sessionStream);
        }

        public DateTime getCompletedDatetime ()
        {
            return (DateTime) this.getProperty("completedDatetime");
        }

        public void setCompletedDatetime (DateTime completedDatetime)
        {
            this.setProperty("completedDatetime", completedDatetime);
        }

        public DateTime getApprovedDatetime ()
        {
            return (DateTime) this.getProperty("approvedDatetime");
        }

        public void setApprovedDatetime (DateTime approvedDatetime)
        {
            this.setProperty("approvedDatetime", approvedDatetime);
        }


    }
}

