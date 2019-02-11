using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TimetableSlot : ModelBase
    {
        protected string resourceType = ResourceType.TIMETABLE_SLOT;
        public const string ACADEMIC_YEAR = "academicYear";
        public const string TIMETABLED_OBJECT = "timetabledObject";
        public const string DAY_OF_CYCLE = "dayOfCycle";
        public const string DAY_OF_WEEK = "dayOfWeek";
        public const string TERM_TIME_ONLY = "termTimeOnly";
        public const string START_TIME = "startTime";
        public const string END_TIME = "endTime";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string FREQUENCY = "frequency";
        public const string STATUS = "status";

        public TimetableSlot ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TimetableSlot (string resourceType = "TimetableSlot", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TimetableSlot> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("TimetableSlot");
        	RestGateway gateway = (RestGateway) TimetableSlot.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TimetableSlot> timetableslotCollection = new ModelCollection<TimetableSlot> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    timetableslotCollection.add((TimetableSlot) model);
        	}
        
        	return timetableslotCollection;
        }

        public static TimetableSlot retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TimetableSlot.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TimetableSlot) gateway.retrieve(ResourceType.TIMETABLE_SLOT, id);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public ModelBase getTimetabledObject ()
        {
            return (ModelBase) this.getProperty("timetabledObject");
        }

        public void setTimetabledObject (ModelBase timetabledObject)
        {
            this.setProperty("timetabledObject", timetabledObject);
        }

        public int getDayOfCycle ()
        {
            return Convert.ToInt32(this.getProperty("dayOfCycle"));
        }

        public void setDayOfCycle (int dayOfCycle)
        {
            this.setProperty("dayOfCycle", dayOfCycle);
        }

        public int getDayOfWeek ()
        {
            return Convert.ToInt32(this.getProperty("dayOfWeek"));
        }

        public void setDayOfWeek (int dayOfWeek)
        {
            this.setProperty("dayOfWeek", dayOfWeek);
        }

        public bool getTermTimeOnly ()
        {
            return Convert.ToBoolean( this.getProperty("termTimeOnly"));
        }

        public void setTermTimeOnly (bool termTimeOnly)
        {
            this.setProperty("termTimeOnly", termTimeOnly);
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

        public DateTime getEffectiveDate (){
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate (){
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getFrequency ()
        {
            return this.getProperty("frequency").ToString();
        }

        public void setFrequency (string frequency)
        {
            this.setProperty("frequency", frequency);
        }

        public string getStatus ()
        {
            return this.getProperty("status").ToString();
        }

        public void setStatus (string status)
        {
            this.setProperty("status", status);
        }


    }
}

