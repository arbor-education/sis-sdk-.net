using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ReportCardBatchTarget : ModelBase
    {
        protected string resourceType = ResourceType.REPORT_CARD_BATCH_TARGET;
        public const string REPORT_CARD_BATCH = "reportCardBatch";
        public const string TARGET = "target";

        public ReportCardBatchTarget ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ReportCardBatchTarget (string resourceType = "ReportCardBatchTarget", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ReportCardBatchTarget> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ReportCardBatchTarget");
        	RestGateway gateway = (RestGateway) ReportCardBatchTarget.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ReportCardBatchTarget> reportcardbatchtargetCollection = new ModelCollection<ReportCardBatchTarget> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    reportcardbatchtargetCollection.add((ReportCardBatchTarget) model);
        	}
        
        	return reportcardbatchtargetCollection;
        }

        public static ReportCardBatchTarget retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ReportCardBatchTarget.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ReportCardBatchTarget) gateway.retrieve(ResourceType.REPORT_CARD_BATCH_TARGET, id);
        }

        public ReportCardBatch getReportCardBatch ()
        {
            return (ReportCardBatch) this.getProperty("reportCardBatch");
        }

        public void setReportCardBatch (ReportCardBatch reportCardBatch)
        {
            this.setProperty("reportCardBatch", reportCardBatch);
        }

        public ModelBase getTarget ()
        {
            return (ModelBase) this.getProperty("target");
        }

        public void setTarget (ModelBase target)
        {
            this.setProperty("target", target);
        }


    }
}

