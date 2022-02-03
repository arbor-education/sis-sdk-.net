using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class AcademicUnitEnrolment : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_ACADEMIC_UNIT_ENROLMENT;
        public const string PLANNED_EEP_HOURS = "plannedEepHours";

        public AcademicUnitEnrolment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicUnitEnrolment (string resourceType = "AcademicUnitEnrolment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicUnitEnrolment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_AcademicUnitEnrolment");
        	RestGateway gateway = (RestGateway) AcademicUnitEnrolment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicUnitEnrolment> academicunitenrolmentCollection = new ModelCollection<AcademicUnitEnrolment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academicunitenrolmentCollection.add((AcademicUnitEnrolment) model);
        	}
        
        	return academicunitenrolmentCollection;
        }

        public static AcademicUnitEnrolment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicUnitEnrolment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicUnitEnrolment) gateway.retrieve(ResourceType.UK_DFE_ACADEMIC_UNIT_ENROLMENT, id);
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

