using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EnrolmentModeAssignment : ModelBase
    {
        protected string resourceType = ResourceType.ENROLMENT_MODE_ASSIGNMENT;
        public const string ACADEMIC_YEAR_ENROLMENT = "academicYearEnrolment";
        public const string ENROLMENT_MODE = "enrolmentMode";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public EnrolmentModeAssignment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public EnrolmentModeAssignment (string resourceType = "EnrolmentModeAssignment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<EnrolmentModeAssignment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("EnrolmentModeAssignment");
        	RestGateway gateway = (RestGateway) EnrolmentModeAssignment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<EnrolmentModeAssignment> enrolmentmodeassignmentCollection = new ModelCollection<EnrolmentModeAssignment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    enrolmentmodeassignmentCollection.add((EnrolmentModeAssignment) model);
        	}
        
        	return enrolmentmodeassignmentCollection;
        }

        public static EnrolmentModeAssignment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) EnrolmentModeAssignment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (EnrolmentModeAssignment) gateway.retrieve(ResourceType.ENROLMENT_MODE_ASSIGNMENT, id);
        }

        public AcademicYearEnrolment getAcademicYearEnrolment ()
        {
            return (AcademicYearEnrolment) this.getProperty("academicYearEnrolment");
        }

        public void setAcademicYearEnrolment (AcademicYearEnrolment academicYearEnrolment)
        {
            this.setProperty("academicYearEnrolment", academicYearEnrolment);
        }

        public EnrolmentMode getEnrolmentMode ()
        {
            return (EnrolmentMode) this.getProperty("enrolmentMode");
        }

        public void setEnrolmentMode (EnrolmentMode enrolmentMode)
        {
            this.setProperty("enrolmentMode", enrolmentMode);
        }

        public DateTime getStartDate ()
        {
            return (DateTime) this.getProperty("startDate");
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return (DateTime) this.getProperty("endDate");
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

