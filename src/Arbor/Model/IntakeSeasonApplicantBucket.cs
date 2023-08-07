using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IntakeSeasonApplicantBucket : ModelBase
    {
        protected new string resourceType = ResourceType.INTAKE_SEASON_APPLICANT_BUCKET;
        public const string APPLICANT_BUCKET_NAME = "applicantBucketName";
        public const string INTAKE_SEASON = "intakeSeason";

        public IntakeSeasonApplicantBucket()
        {
            base.resourceType = this.resourceType;
        }

        public IntakeSeasonApplicantBucket(string resourceType = "IntakeSeasonApplicantBucket", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<IntakeSeasonApplicantBucket> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("IntakeSeasonApplicantBucket");
            RestGateway gateway = (RestGateway)IntakeSeasonApplicantBucket.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<IntakeSeasonApplicantBucket> intakeseasonapplicantbucketCollection = new ModelCollection<IntakeSeasonApplicantBucket>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                intakeseasonapplicantbucketCollection.add((IntakeSeasonApplicantBucket)model);
            }

            return intakeseasonapplicantbucketCollection;
        }

        public static IntakeSeasonApplicantBucket retrieve(string id)
        {
            RestGateway gateway = (RestGateway)IntakeSeasonApplicantBucket.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (IntakeSeasonApplicantBucket)gateway.retrieve(ResourceType.INTAKE_SEASON_APPLICANT_BUCKET, id);
        }

        public string getApplicantBucketName()
        {
            return this.getProperty("applicantBucketName").ToString();
        }

        public void setApplicantBucketName(string applicantBucketName)
        {
            this.setProperty("applicantBucketName", applicantBucketName);
        }

        public IntakeSeason getIntakeSeason()
        {
            return (IntakeSeason)this.getProperty("intakeSeason");
        }

        public void setIntakeSeason(IntakeSeason intakeSeason)
        {
            this.setProperty("intakeSeason", intakeSeason);
        }


    }
}

