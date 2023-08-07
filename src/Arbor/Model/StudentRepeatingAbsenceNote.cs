using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentRepeatingAbsenceNote : ModelBase
    {
        protected new string resourceType = ResourceType.STUDENT_REPEATING_ABSENCE_NOTE;
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string START_TIME = "startTime";
        public const string END_TIME = "endTime";
        public const string REPEATING_TYPE = "repeatingType";
        public const string MAX_OCCURRENCE = "maxOccurrence";

        public StudentRepeatingAbsenceNote ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentRepeatingAbsenceNote (string resourceType = "StudentRepeatingAbsenceNote", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentRepeatingAbsenceNote> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentRepeatingAbsenceNote");
        	RestGateway gateway = (RestGateway) StudentRepeatingAbsenceNote.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentRepeatingAbsenceNote> studentrepeatingabsencenoteCollection = new ModelCollection<StudentRepeatingAbsenceNote> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentrepeatingabsencenoteCollection.add((StudentRepeatingAbsenceNote) model);
        	}
        
        	return studentrepeatingabsencenoteCollection;
        }

        public static StudentRepeatingAbsenceNote retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentRepeatingAbsenceNote.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentRepeatingAbsenceNote) gateway.retrieve(ResourceType.STUDENT_REPEATING_ABSENCE_NOTE, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getStartTime ()
        {
            return this.getProperty("startTime").ToString();
        }

        public void setStartTime (string startTime)
        {
            this.setProperty("startTime", startTime);
        }

        public string getEndTime ()
        {
            return this.getProperty("endTime").ToString();
        }

        public void setEndTime (string endTime)
        {
            this.setProperty("endTime", endTime);
        }

        public string getRepeatingType ()
        {
            return this.getProperty("repeatingType").ToString();
        }

        public void setRepeatingType (string repeatingType)
        {
            this.setProperty("repeatingType", repeatingType);
        }

        public int getMaxOccurrence ()
        {
            return Convert.ToInt32(this.getProperty("maxOccurrence"));
        }

        public void setMaxOccurrence (int maxOccurrence)
        {
            this.setProperty("maxOccurrence", maxOccurrence);
        }


    }
}

