using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentReportCardMark : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_REPORT_CARD_MARK;
        public const string STUDENT = "student";
        public const string STUDENT_REPORT_CARD_SECTION = "studentReportCardSection";
        public const string ASPECT = "aspect";
        public const string MARK_INTEGER = "markInteger";
        public const string MARK_DECIMAL = "markDecimal";
        public const string MARK_COMMENT = "markComment";
        public const string MARK_GRADE = "markGrade";

        public StudentReportCardMark ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentReportCardMark (string resourceType = "StudentReportCardMark", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentReportCardMark> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentReportCardMark");
        	RestGateway gateway = (RestGateway) StudentReportCardMark.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentReportCardMark> studentreportcardmarkCollection = new ModelCollection<StudentReportCardMark> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentreportcardmarkCollection.add((StudentReportCardMark) model);
        	}
        
        	return studentreportcardmarkCollection;
        }

        public static StudentReportCardMark retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentReportCardMark.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentReportCardMark) gateway.retrieve(ResourceType.STUDENT_REPORT_CARD_MARK, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public StudentReportCardSection getStudentReportCardSection ()
        {
            return (StudentReportCardSection) this.getProperty("studentReportCardSection");
        }

        public void setStudentReportCardSection (StudentReportCardSection studentReportCardSection)
        {
            this.setProperty("studentReportCardSection", studentReportCardSection);
        }

        public Aspect getAspect ()
        {
            return (Aspect) this.getProperty("aspect");
        }

        public void setAspect (Aspect aspect)
        {
            this.setProperty("aspect", aspect);
        }

        public int getMarkInteger ()
        {
            return Convert.ToInt32(this.getProperty("markInteger"));
        }

        public void setMarkInteger (int markInteger)
        {
            this.setProperty("markInteger", markInteger);
        }

        public float getMarkDecimal ()
        {
            return (float) this.getProperty("markDecimal");
        }

        public void setMarkDecimal (float markDecimal)
        {
            this.setProperty("markDecimal", markDecimal);
        }

        public string getMarkComment ()
        {
            return this.getProperty("markComment").ToString();
        }

        public void setMarkComment (string markComment)
        {
            this.setProperty("markComment", markComment);
        }

        public Grade getMarkGrade ()
        {
            return (Grade) this.getProperty("markGrade");
        }

        public void setMarkGrade (Grade markGrade)
        {
            this.setProperty("markGrade", markGrade);
        }


    }
}

