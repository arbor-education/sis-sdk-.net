using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InterventionGroup : ModelBase
    {
        protected string resourceType = ResourceType.INTERVENTION_GROUP;
        public const string NAME = "name";
        public const string INTERVENTION = "intervention";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string AIMS = "aims";
        public const string SUCCESS_CRITERIA = "successCriteria";
        public const string STAFF = "staff";
        public const string IS_ATTENDANCE_REGISTERED = "isAttendanceRegistered";

        public InterventionGroup ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InterventionGroup (string resourceType = "InterventionGroup", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InterventionGroup> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InterventionGroup");
        	RestGateway gateway = (RestGateway) InterventionGroup.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InterventionGroup> interventiongroupCollection = new ModelCollection<InterventionGroup> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    interventiongroupCollection.add((InterventionGroup) model);
        	}
        
        	return interventiongroupCollection;
        }

        public static InterventionGroup retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InterventionGroup.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InterventionGroup) gateway.retrieve(ResourceType.INTERVENTION_GROUP, id);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public Intervention getIntervention ()
        {
            return (Intervention) this.getProperty("intervention");
        }

        public void setIntervention (Intervention intervention)
        {
            this.setProperty("intervention", intervention);
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

        public string getAims ()
        {
            return this.getProperty("aims").ToString();
        }

        public void setAims (string aims)
        {
            this.setProperty("aims", aims);
        }

        public string getSuccessCriteria ()
        {
            return this.getProperty("successCriteria").ToString();
        }

        public void setSuccessCriteria (string successCriteria)
        {
            this.setProperty("successCriteria", successCriteria);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public bool getIsAttendanceRegistered ()
        {
            return Convert.ToBoolean(this.getProperty("isAttendanceRegistered"));
        }

        public void setIsAttendanceRegistered (bool isAttendanceRegistered)
        {
            this.setProperty("isAttendanceRegistered", isAttendanceRegistered);
        }


    }
}

