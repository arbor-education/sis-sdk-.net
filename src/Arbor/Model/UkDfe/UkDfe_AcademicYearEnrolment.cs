using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_AcademicYearEnrolment : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_ACADEMIC_YEAR_ENROLMENT;
        public const string PLANNED_LEARNING_HOURS = "plannedLearningHours";
        public const string PLANNED_EEP_HOURS = "plannedEepHours";

        public UkDfe_AcademicYearEnrolment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_AcademicYearEnrolment (string resourceType = "UkDfe_AcademicYearEnrolment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_AcademicYearEnrolment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_AcademicYearEnrolment");
        	RestGateway gateway = (RestGateway) UkDfe_AcademicYearEnrolment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_AcademicYearEnrolment> ukdfe_academicyearenrolmentCollection = new ModelCollection<UkDfe_AcademicYearEnrolment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_academicyearenrolmentCollection.add((UkDfe_AcademicYearEnrolment) model);
        	}
        
        	return ukdfe_academicyearenrolmentCollection;
        }

        public static UkDfe_AcademicYearEnrolment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_AcademicYearEnrolment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_AcademicYearEnrolment) gateway.retrieve(ResourceType.UK_DFE_ACADEMIC_YEAR_ENROLMENT, id);
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

