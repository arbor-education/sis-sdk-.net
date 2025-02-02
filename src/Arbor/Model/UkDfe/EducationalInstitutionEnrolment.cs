using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class EducationalInstitutionEnrolment : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_EDUCATIONAL_INSTITUTION_ENROLMENT;
        public const string REMOVAL_GROUNDS = "removalGrounds";
        public const string ALTERNATIVE_PROVISION_REASON = "alternativeProvisionReason";

        public EducationalInstitutionEnrolment()
        {
            base.resourceType = this.resourceType;
        }

        public EducationalInstitutionEnrolment(string resourceType = "EducationalInstitutionEnrolment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EducationalInstitutionEnrolment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_EducationalInstitutionEnrolment");
            RestGateway gateway = (RestGateway)EducationalInstitutionEnrolment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EducationalInstitutionEnrolment> educationalinstitutionenrolmentCollection = new ModelCollection<EducationalInstitutionEnrolment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                educationalinstitutionenrolmentCollection.add((EducationalInstitutionEnrolment)model);
            }

            return educationalinstitutionenrolmentCollection;
        }

        public static EducationalInstitutionEnrolment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EducationalInstitutionEnrolment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EducationalInstitutionEnrolment)gateway.retrieve(ResourceType.UK_DFE_EDUCATIONAL_INSTITUTION_ENROLMENT, id);
        }

        public string getRemovalGrounds()
        {
            return this.getProperty("removalGrounds").ToString();
        }

        public void setRemovalGrounds(string removalGrounds)
        {
            this.setProperty("removalGrounds", removalGrounds);
        }

        public AlternativeProvisionReason getAlternativeProvisionReason()
        {
            return (AlternativeProvisionReason)this.getProperty("alternativeProvisionReason");
        }

        public void setAlternativeProvisionReason(AlternativeProvisionReason alternativeProvisionReason)
        {
            this.setProperty("alternativeProvisionReason", alternativeProvisionReason);
        }


    }
}

