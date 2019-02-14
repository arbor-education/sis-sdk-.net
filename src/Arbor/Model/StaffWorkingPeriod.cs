using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffWorkingPeriod : ModelBase
    {
        protected string resourceType = ResourceType.STAFF_WORKING_PERIOD;
        public const string STAFF = "staff";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string APPLIES_ON_MONDAY = "appliesOnMonday";
        public const string APPLIES_ON_TUESDAY = "appliesOnTuesday";
        public const string APPLIES_ON_WEDNESDAY = "appliesOnWednesday";
        public const string APPLIES_ON_THURSDAY = "appliesOnThursday";
        public const string APPLIES_ON_FRIDAY = "appliesOnFriday";
        public const string APPLIES_ON_SATURDAY = "appliesOnSaturday";
        public const string APPLIES_ON_SUNDAY = "appliesOnSunday";
        public const string START_TIME = "startTime";
        public const string END_TIME = "endTime";

        public StaffWorkingPeriod ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StaffWorkingPeriod (string resourceType = "StaffWorkingPeriod", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StaffWorkingPeriod> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StaffWorkingPeriod");
        	RestGateway gateway = (RestGateway) StaffWorkingPeriod.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StaffWorkingPeriod> staffworkingperiodCollection = new ModelCollection<StaffWorkingPeriod> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    staffworkingperiodCollection.add((StaffWorkingPeriod) model);
        	}
        
        	return staffworkingperiodCollection;
        }

        public static StaffWorkingPeriod retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StaffWorkingPeriod.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StaffWorkingPeriod) gateway.retrieve(ResourceType.STAFF_WORKING_PERIOD, id);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"))
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public bool getAppliesOnMonday ()
        {
            return Convert.ToBoolean(this.getProperty("appliesOnMonday"))
        }

        public void setAppliesOnMonday (bool appliesOnMonday)
        {
            this.setProperty("appliesOnMonday", appliesOnMonday);
        }

        public bool getAppliesOnTuesday ()
        {
            return Convert.ToBoolean(this.getProperty("appliesOnTuesday"))
        }

        public void setAppliesOnTuesday (bool appliesOnTuesday)
        {
            this.setProperty("appliesOnTuesday", appliesOnTuesday);
        }

        public bool getAppliesOnWednesday ()
        {
            return Convert.ToBoolean(this.getProperty("appliesOnWednesday"))
        }

        public void setAppliesOnWednesday (bool appliesOnWednesday)
        {
            this.setProperty("appliesOnWednesday", appliesOnWednesday);
        }

        public bool getAppliesOnThursday ()
        {
            return Convert.ToBoolean(this.getProperty("appliesOnThursday"))
        }

        public void setAppliesOnThursday (bool appliesOnThursday)
        {
            this.setProperty("appliesOnThursday", appliesOnThursday);
        }

        public bool getAppliesOnFriday ()
        {
            return Convert.ToBoolean(this.getProperty("appliesOnFriday"))
        }

        public void setAppliesOnFriday (bool appliesOnFriday)
        {
            this.setProperty("appliesOnFriday", appliesOnFriday);
        }

        public bool getAppliesOnSaturday ()
        {
            return Convert.ToBoolean(this.getProperty("appliesOnSaturday"))
        }

        public void setAppliesOnSaturday (bool appliesOnSaturday)
        {
            this.setProperty("appliesOnSaturday", appliesOnSaturday);
        }

        public bool getAppliesOnSunday ()
        {
            return Convert.ToBoolean(this.getProperty("appliesOnSunday"))
        }

        public void setAppliesOnSunday (bool appliesOnSunday)
        {
            this.setProperty("appliesOnSunday", appliesOnSunday);
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


    }
}

