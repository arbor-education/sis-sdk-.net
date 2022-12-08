using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class NewReportCardBatchTarget : ModelBase
    {
        protected string resourceType = ResourceType.NEW_REPORT_CARD_BATCH_TARGET;
        public const string REPORT_CARD_BATCH = "reportCardBatch";
        public const string TARGET = "target";
        public const string REPORTS_GENERATING = "reportsGenerating";

        public NewReportCardBatchTarget()
        {
            base.resourceType = this.resourceType;
        }

        public NewReportCardBatchTarget(string resourceType = "NewReportCardBatchTarget", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<NewReportCardBatchTarget> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("NewReportCardBatchTarget");
            RestGateway gateway = (RestGateway)NewReportCardBatchTarget.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<NewReportCardBatchTarget> newreportcardbatchtargetCollection = new ModelCollection<NewReportCardBatchTarget>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                newreportcardbatchtargetCollection.add((NewReportCardBatchTarget)model);
            }

            return newreportcardbatchtargetCollection;
        }

        public static NewReportCardBatchTarget retrieve(string id)
        {
            RestGateway gateway = (RestGateway)NewReportCardBatchTarget.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (NewReportCardBatchTarget)gateway.retrieve(ResourceType.NEW_REPORT_CARD_BATCH_TARGET, id);
        }

        public NewReportCardBatch getReportCardBatch()
        {
            return (NewReportCardBatch)this.getProperty("reportCardBatch");
        }

        public void setReportCardBatch(NewReportCardBatch reportCardBatch)
        {
            this.setProperty("reportCardBatch", reportCardBatch);
        }

        public ModelBase getTarget()
        {
            return (ModelBase)this.getProperty("target");
        }

        public void setTarget(ModelBase target)
        {
            this.setProperty("target", target);
        }

        public bool getReportsGenerating()
        {
            return Convert.ToBoolean(this.getProperty("reportsGenerating"));
        }

        public void setReportsGenerating(bool reportsGenerating)
        {
            this.setProperty("reportsGenerating", reportsGenerating);
        }


    }
}

