using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class SchoolLedTutoringHour : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SCHOOL_LED_TUTORING_HOUR;
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string HOURS = "hours";

        public SchoolLedTutoringHour ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SchoolLedTutoringHour (string resourceType = "SchoolLedTutoringHour", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SchoolLedTutoringHour> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_SchoolLedTutoringHour");
        	RestGateway gateway = (RestGateway) SchoolLedTutoringHour.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SchoolLedTutoringHour> schoolledtutoringhourCollection = new ModelCollection<SchoolLedTutoringHour> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schoolledtutoringhourCollection.add((SchoolLedTutoringHour) model);
        	}
        
        	return schoolledtutoringhourCollection;
        }

        public static SchoolLedTutoringHour retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SchoolLedTutoringHour.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SchoolLedTutoringHour) gateway.retrieve(ResourceType.UK_DFE_SCHOOL_LED_TUTORING_HOUR, id);
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

        public float getHours ()
        {
            return (float) this.getProperty("hours");
        }

        public void setHours (float hours)
        {
            this.setProperty("hours", hours);
        }


    }
}

