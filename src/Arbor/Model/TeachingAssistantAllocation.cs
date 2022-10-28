using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TeachingAssistantAllocation : ModelBase
    {
        protected new string resourceType = ResourceType.TEACHING_ASSISTANT_ALLOCATION;
        public const string STAFF = "staff";
        public const string DAY_OF_CYCLE = "dayOfCycle";
        public const string START_TIME = "startTime";
        public const string END_TIME = "endTime";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string ALLOCATED_TO = "allocatedTo";

        public TeachingAssistantAllocation ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TeachingAssistantAllocation (string resourceType = "TeachingAssistantAllocation", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TeachingAssistantAllocation> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("TeachingAssistantAllocation");
        	RestGateway gateway = (RestGateway) TeachingAssistantAllocation.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TeachingAssistantAllocation> teachingassistantallocationCollection = new ModelCollection<TeachingAssistantAllocation> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    teachingassistantallocationCollection.add((TeachingAssistantAllocation) model);
        	}
        
        	return teachingassistantallocationCollection;
        }

        public static TeachingAssistantAllocation retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TeachingAssistantAllocation.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TeachingAssistantAllocation) gateway.retrieve(ResourceType.TEACHING_ASSISTANT_ALLOCATION, id);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public int getDayOfCycle ()
        {
            return Convert.ToInt32(this.getProperty("dayOfCycle"));
        }

        public void setDayOfCycle (int dayOfCycle)
        {
            this.setProperty("dayOfCycle", dayOfCycle);
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

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public ModelBase getAllocatedTo ()
        {
            return (ModelBase) this.getProperty("allocatedTo");
        }

        public void setAllocatedTo (ModelBase allocatedTo)
        {
            this.setProperty("allocatedTo", allocatedTo);
        }


    }
}

