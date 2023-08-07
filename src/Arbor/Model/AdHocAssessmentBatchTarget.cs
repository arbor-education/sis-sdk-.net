using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AdHocAssessmentBatchTarget : ModelBase
    {
        protected new string resourceType = ResourceType.AD_HOC_ASSESSMENT_BATCH_TARGET;
        public const string AD_HOC_ASSESSMENT_BATCH = "adHocAssessmentBatch";
        public const string TARGET = "target";
        public const string MARKING_STARTED_DATETIME = "markingStartedDatetime";
        public const string MARKING_COMPLETED_DATETIME = "markingCompletedDatetime";

        public AdHocAssessmentBatchTarget()
        {
            base.resourceType = this.resourceType;
        }

        public AdHocAssessmentBatchTarget(string resourceType = "AdHocAssessmentBatchTarget", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AdHocAssessmentBatchTarget> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AdHocAssessmentBatchTarget");
            RestGateway gateway = (RestGateway)AdHocAssessmentBatchTarget.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AdHocAssessmentBatchTarget> adhocassessmentbatchtargetCollection = new ModelCollection<AdHocAssessmentBatchTarget>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                adhocassessmentbatchtargetCollection.add((AdHocAssessmentBatchTarget)model);
            }

            return adhocassessmentbatchtargetCollection;
        }

        public static AdHocAssessmentBatchTarget retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AdHocAssessmentBatchTarget.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AdHocAssessmentBatchTarget)gateway.retrieve(ResourceType.AD_HOC_ASSESSMENT_BATCH_TARGET, id);
        }

        public AdHocAssessmentBatch getAdHocAssessmentBatch()
        {
            return (AdHocAssessmentBatch)this.getProperty("adHocAssessmentBatch");
        }

        public void setAdHocAssessmentBatch(AdHocAssessmentBatch adHocAssessmentBatch)
        {
            this.setProperty("adHocAssessmentBatch", adHocAssessmentBatch);
        }

        public ModelBase getTarget()
        {
            return (ModelBase)this.getProperty("target");
        }

        public void setTarget(ModelBase target)
        {
            this.setProperty("target", target);
        }

        public DateTime getMarkingStartedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("markingStartedDatetime"));
        }

        public void setMarkingStartedDatetime(DateTime markingStartedDatetime)
        {
            this.setProperty("markingStartedDatetime", markingStartedDatetime);
        }

        public DateTime getMarkingCompletedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("markingCompletedDatetime"));
        }

        public void setMarkingCompletedDatetime(DateTime markingCompletedDatetime)
        {
            this.setProperty("markingCompletedDatetime", markingCompletedDatetime);
        }


    }
}

