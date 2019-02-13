using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_EducationalInstitutionEnrolment : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_EDUCATIONAL_INSTITUTION_ENROLMENT;
        public const string REMOVAL_GROUNDS = "removalGrounds";

        public UkDfe_EducationalInstitutionEnrolment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_EducationalInstitutionEnrolment (string resourceType = "UkDfe_EducationalInstitutionEnrolment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_EducationalInstitutionEnrolment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_EducationalInstitutionEnrolment");
        	RestGateway gateway = (RestGateway) UkDfe_EducationalInstitutionEnrolment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_EducationalInstitutionEnrolment> ukdfe_educationalinstitutionenrolmentCollection = new ModelCollection<UkDfe_EducationalInstitutionEnrolment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_educationalinstitutionenrolmentCollection.add((UkDfe_EducationalInstitutionEnrolment) model);
        	}
        
        	return ukdfe_educationalinstitutionenrolmentCollection;
        }

        public static UkDfe_EducationalInstitutionEnrolment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_EducationalInstitutionEnrolment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_EducationalInstitutionEnrolment) gateway.retrieve(ResourceType.UK_DFE_EDUCATIONAL_INSTITUTION_ENROLMENT, id);
        }

        public string getRemovalGrounds ()
        {
            return this.getProperty("removalGrounds").ToString();
        }

        public void setRemovalGrounds (string removalGrounds)
        {
            this.setProperty("removalGrounds", removalGrounds);
        }


    }
}

