using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class SchoolEnrolment : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SCHOOL_ENROLMENT;
        public const string PLANNED_LEARNING_HOURS = "plannedLearningHours";
        public const string PLANNED_EEP_HOURS = "plannedEepHours";

        public SchoolEnrolment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SchoolEnrolment (string resourceType = "SchoolEnrolment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SchoolEnrolment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_SchoolEnrolment");
        	RestGateway gateway = (RestGateway) SchoolEnrolment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SchoolEnrolment> schoolenrolmentCollection = new ModelCollection<SchoolEnrolment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schoolenrolmentCollection.add((SchoolEnrolment) model);
        	}
        
        	return schoolenrolmentCollection;
        }

        public static SchoolEnrolment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SchoolEnrolment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SchoolEnrolment) gateway.retrieve(ResourceType.UK_DFE_SCHOOL_ENROLMENT, id);
        }

        public int getPlannedLearningHours ()
        {
            return Convert.ToInt32(this.getProperty("plannedLearningHours"));
        }

        public void setPlannedLearningHours (int plannedLearningHours)
        {
            this.setProperty("plannedLearningHours", plannedLearningHours);
        }

        public int getPlannedEepHours ()
        {
            return Convert.ToInt32(this.getProperty("plannedEepHours"));
        }

        public void setPlannedEepHours (int plannedEepHours)
        {
            this.setProperty("plannedEepHours", plannedEepHours);
        }


    }
}

