using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Detention : ModelBase
    {
        protected string resourceType = ResourceType.DETENTION;
        public const string STUDENT = "student";
        public const string ISSUED_BY_STAFF = "issuedByStaff";
        public const string DETENTION_SESSION = "detentionSession";
        public const string DETENTION_TYPE = "detentionType";
        public const string DECISION_DATETIME = "decisionDatetime";
        public const string NOTIFIED_STUDENT_DATETIME = "notifiedStudentDatetime";
        public const string NOTIFIED_GUARDIANS_DATETIME = "notifiedGuardiansDatetime";
        public const string NOTIFIED_TUTORS_DATETIME = "notifiedTutorsDatetime";
        public const string DETENTION_DURATION = "detentionDuration";
        public const string ATTENDANCE_MARK = "attendanceMark";
        public const string NOTES = "notes";
        public const string REASON_FOR_DETENTION = "reasonForDetention";
        public const string ABSENTEES_DETENTION_ACTION = "absenteesDetentionAction";
        public const string EVENT = "event";

        public Detention ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Detention (string resourceType = "Detention", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Detention> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Detention");
        	RestGateway gateway = (RestGateway) Detention.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Detention> detentionCollection = new ModelCollection<Detention> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    detentionCollection.add((Detention) model);
        	}
        
        	return detentionCollection;
        }

        public static Detention retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Detention.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Detention) gateway.retrieve(ResourceType.DETENTION, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public Staff getIssuedByStaff ()
        {
            return (Staff) this.getProperty("issuedByStaff");
        }

        public void setIssuedByStaff (Staff issuedByStaff)
        {
            this.setProperty("issuedByStaff", issuedByStaff);
        }

        public DetentionSession getDetentionSession ()
        {
            return (DetentionSession) this.getProperty("detentionSession");
        }

        public void setDetentionSession (DetentionSession detentionSession)
        {
            this.setProperty("detentionSession", detentionSession);
        }

        public DetentionType getDetentionType ()
        {
            return (DetentionType) this.getProperty("detentionType");
        }

        public void setDetentionType (DetentionType detentionType)
        {
            this.setProperty("detentionType", detentionType);
        }

        public DateTime getDecisionDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("decisionDatetime"));
        }

        public void setDecisionDatetime (DateTime decisionDatetime)
        {
            this.setProperty("decisionDatetime", decisionDatetime);
        }

        public DateTime getNotifiedStudentDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("notifiedStudentDatetime"));
        }

        public void setNotifiedStudentDatetime (DateTime notifiedStudentDatetime)
        {
            this.setProperty("notifiedStudentDatetime", notifiedStudentDatetime);
        }

        public DateTime getNotifiedGuardiansDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("notifiedGuardiansDatetime"));
        }

        public void setNotifiedGuardiansDatetime (DateTime notifiedGuardiansDatetime)
        {
            this.setProperty("notifiedGuardiansDatetime", notifiedGuardiansDatetime);
        }

        public DateTime getNotifiedTutorsDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("notifiedTutorsDatetime"));
        }

        public void setNotifiedTutorsDatetime (DateTime notifiedTutorsDatetime)
        {
            this.setProperty("notifiedTutorsDatetime", notifiedTutorsDatetime);
        }

        public string getDetentionDuration ()
        {
            return this.getProperty("detentionDuration").ToString();
        }

        public void setDetentionDuration (string detentionDuration)
        {
            this.setProperty("detentionDuration", detentionDuration);
        }

        public string getAttendanceMark ()
        {
            return this.getProperty("attendanceMark").ToString();
        }

        public void setAttendanceMark (string attendanceMark)
        {
            this.setProperty("attendanceMark", attendanceMark);
        }

        public string getNotes ()
        {
            return this.getProperty("notes").ToString();
        }

        public void setNotes (string notes)
        {
            this.setProperty("notes", notes);
        }

        public Behaviour getReasonForDetention ()
        {
            return (Behaviour) this.getProperty("reasonForDetention");
        }

        public void setReasonForDetention (Behaviour reasonForDetention)
        {
            this.setProperty("reasonForDetention", reasonForDetention);
        }

        public ModelBase getAbsenteesDetentionAction ()
        {
            return (ModelBase) this.getProperty("absenteesDetentionAction");
        }

        public void setAbsenteesDetentionAction (ModelBase absenteesDetentionAction)
        {
            this.setProperty("absenteesDetentionAction", absenteesDetentionAction);
        }

        public ModelBase getEvent ()
        {
            return (ModelBase) this.getProperty("event");
        }

        public void setEvent (ModelBase _event)
        {
            this.setProperty("event", _event);
        }


    }
}

