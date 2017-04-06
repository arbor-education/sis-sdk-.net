using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Schoolwork : ModelBase
    {
        protected string resourceType = ResourceType.SCHOOLWORK;
        public const string SCHOOLWORK_DEFINITION = "schoolworkDefinition";
        public const string TITLE = "title";
        public const string STUDENT_INSTRUCTIONS = "studentInstructions";
        public const string TEACHER_NOTES = "teacherNotes";
        public const string SET_DATETIME = "setDatetime";
        public const string DUE_EVENT = "dueEvent";
        public const string DUE_DATETIME = "dueDatetime";
        public const string MARKING_STARTED_DATETIME = "markingStartedDatetime";
        public const string MARKING_COMPLETED_DATETIME = "markingCompletedDatetime";
        public const string SESSION = "session";
        public const string SESSION_STREAM = "sessionStream";
        public const string ACADEMIC_UNIT = "academicUnit";

        public Schoolwork ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Schoolwork (string resourceType = "Schoolwork", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Schoolwork> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Schoolwork");
        	RestGateway gateway = (RestGateway) Schoolwork.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Schoolwork> schoolworkCollection = new ModelCollection<Schoolwork> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schoolworkCollection.add((Schoolwork) model);
        	}
        
        	return schoolworkCollection;
        }

        public static Schoolwork retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Schoolwork.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Schoolwork) gateway.retrieve(ResourceType.SCHOOLWORK, id);
        }

        public SchoolworkDefinition getSchoolworkDefinition ()
        {
            return (SchoolworkDefinition) this.getProperty("schoolworkDefinition");
        }

        public void setSchoolworkDefinition (SchoolworkDefinition schoolworkDefinition)
        {
            this.setProperty("schoolworkDefinition", schoolworkDefinition);
        }

        public string getTitle ()
        {
            return this.getProperty("title").ToString();
        }

        public void setTitle (string title)
        {
            this.setProperty("title", title);
        }

        public string getStudentInstructions ()
        {
            return this.getProperty("studentInstructions").ToString();
        }

        public void setStudentInstructions (string studentInstructions)
        {
            this.setProperty("studentInstructions", studentInstructions);
        }

        public string getTeacherNotes ()
        {
            return this.getProperty("teacherNotes").ToString();
        }

        public void setTeacherNotes (string teacherNotes)
        {
            this.setProperty("teacherNotes", teacherNotes);
        }

        public DateTime getSetDatetime ()
        {
            return (DateTime) this.getProperty("setDatetime");
        }

        public void setSetDatetime (DateTime setDatetime)
        {
            this.setProperty("setDatetime", setDatetime);
        }

        public ModelBase getDueEvent ()
        {
            return (ModelBase) this.getProperty("dueEvent");
        }

        public void setDueEvent (ModelBase dueEvent)
        {
            this.setProperty("dueEvent", dueEvent);
        }

        public DateTime getDueDatetime ()
        {
            return (DateTime) this.getProperty("dueDatetime");
        }

        public void setDueDatetime (DateTime dueDatetime)
        {
            this.setProperty("dueDatetime", dueDatetime);
        }

        public DateTime getMarkingStartedDatetime ()
        {
            return (DateTime) this.getProperty("markingStartedDatetime");
        }

        public void setMarkingStartedDatetime (DateTime markingStartedDatetime)
        {
            this.setProperty("markingStartedDatetime", markingStartedDatetime);
        }

        public DateTime getMarkingCompletedDatetime ()
        {
            return (DateTime) this.getProperty("markingCompletedDatetime");
        }

        public void setMarkingCompletedDatetime (DateTime markingCompletedDatetime)
        {
            this.setProperty("markingCompletedDatetime", markingCompletedDatetime);
        }

        public Session getSession ()
        {
            return (Session) this.getProperty("session");
        }

        public void setSession (Session session)
        {
            this.setProperty("session", session);
        }

        public SessionStream getSessionStream ()
        {
            return (SessionStream) this.getProperty("sessionStream");
        }

        public void setSessionStream (SessionStream sessionStream)
        {
            this.setProperty("sessionStream", sessionStream);
        }

        public AcademicUnit getAcademicUnit ()
        {
            return (AcademicUnit) this.getProperty("academicUnit");
        }

        public void setAcademicUnit (AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }


    }
}

