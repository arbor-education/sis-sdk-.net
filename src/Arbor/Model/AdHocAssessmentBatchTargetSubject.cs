using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AdHocAssessmentBatchTargetSubject : ModelBase
    {
        protected string resourceType = ResourceType.AD_HOC_ASSESSMENT_BATCH_TARGET_SUBJECT;
        public const string AD_HOC_ASSESSMENT_BATCH_TARGET = "adHocAssessmentBatchTarget";
        public const string SUBJECT = "subject";

        public AdHocAssessmentBatchTargetSubject()
        {
            base.resourceType = this.resourceType;
        }

        public AdHocAssessmentBatchTargetSubject(string resourceType = "AdHocAssessmentBatchTargetSubject", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AdHocAssessmentBatchTargetSubject> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AdHocAssessmentBatchTargetSubject");
            RestGateway gateway = (RestGateway)AdHocAssessmentBatchTargetSubject.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AdHocAssessmentBatchTargetSubject> adhocassessmentbatchtargetsubjectCollection = new ModelCollection<AdHocAssessmentBatchTargetSubject>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                adhocassessmentbatchtargetsubjectCollection.add((AdHocAssessmentBatchTargetSubject)model);
            }

            return adhocassessmentbatchtargetsubjectCollection;
        }

        public static AdHocAssessmentBatchTargetSubject retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AdHocAssessmentBatchTargetSubject.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AdHocAssessmentBatchTargetSubject)gateway.retrieve(ResourceType.AD_HOC_ASSESSMENT_BATCH_TARGET_SUBJECT, id);
        }

        public AdHocAssessmentBatchTarget getAdHocAssessmentBatchTarget()
        {
            return (AdHocAssessmentBatchTarget)this.getProperty("adHocAssessmentBatchTarget");
        }

        public void setAdHocAssessmentBatchTarget(AdHocAssessmentBatchTarget adHocAssessmentBatchTarget)
        {
            this.setProperty("adHocAssessmentBatchTarget", adHocAssessmentBatchTarget);
        }

        public Subject getSubject()
        {
            return (Subject)this.getProperty("subject");
        }

        public void setSubject(Subject subject)
        {
            this.setProperty("subject", subject);
        }


    }
}

