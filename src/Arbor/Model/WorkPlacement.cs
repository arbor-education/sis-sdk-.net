using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class WorkPlacement : ModelBase
    {
        protected string resourceType = ResourceType.WORK_PLACEMENT;
        public const string STUDENT = "student";
        public const string EMPLOYER = "employer";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string WORK_PLACEMENT_MODE = "workPlacementMode";
        public const string PLANNED_HOURS = "plannedHours";
        public const string PROGRAMME_ENROLMENT = "programmeEnrolment";

        public WorkPlacement ()
        {
            base.resourceType = this.resourceType;
        }
        
        public WorkPlacement (string resourceType = "WorkPlacement", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<WorkPlacement> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("WorkPlacement");
        	RestGateway gateway = (RestGateway) WorkPlacement.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<WorkPlacement> workplacementCollection = new ModelCollection<WorkPlacement> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    workplacementCollection.add((WorkPlacement) model);
        	}
        
        	return workplacementCollection;
        }

        public static WorkPlacement retrieve (string id)
        {
            RestGateway gateway = (RestGateway) WorkPlacement.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (WorkPlacement) gateway.retrieve(ResourceType.WORK_PLACEMENT, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public Employer getEmployer ()
        {
            return (Employer) this.getProperty("employer");
        }

        public void setEmployer (Employer employer)
        {
            this.setProperty("employer", employer);
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

        public string getWorkPlacementMode ()
        {
            return this.getProperty("workPlacementMode").ToString();
        }

        public void setWorkPlacementMode (string workPlacementMode)
        {
            this.setProperty("workPlacementMode", workPlacementMode);
        }

        public string getPlannedHours ()
        {
            return this.getProperty("plannedHours").ToString();
        }

        public void setPlannedHours (string plannedHours)
        {
            this.setProperty("plannedHours", plannedHours);
        }

        public ProgrammeEnrolment getProgrammeEnrolment ()
        {
            return (ProgrammeEnrolment) this.getProperty("programmeEnrolment");
        }

        public void setProgrammeEnrolment (ProgrammeEnrolment programmeEnrolment)
        {
            this.setProperty("programmeEnrolment", programmeEnrolment);
        }


    }
}

