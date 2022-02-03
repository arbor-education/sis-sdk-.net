using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ExternallyGeneratedReportCard : ModelBase
    {
        protected string resourceType = ResourceType.EXTERNALLY_GENERATED_REPORT_CARD;
        public const string CONTENT = "content";
        public const string REPORT_CARD_BATCH = "reportCardBatch";
        public const string STUDENT = "student";

        public ExternallyGeneratedReportCard ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ExternallyGeneratedReportCard (string resourceType = "ExternallyGeneratedReportCard", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ExternallyGeneratedReportCard> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ExternallyGeneratedReportCard");
        	RestGateway gateway = (RestGateway) ExternallyGeneratedReportCard.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ExternallyGeneratedReportCard> externallygeneratedreportcardCollection = new ModelCollection<ExternallyGeneratedReportCard> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    externallygeneratedreportcardCollection.add((ExternallyGeneratedReportCard) model);
        	}
        
        	return externallygeneratedreportcardCollection;
        }

        public static ExternallyGeneratedReportCard retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ExternallyGeneratedReportCard.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ExternallyGeneratedReportCard) gateway.retrieve(ResourceType.EXTERNALLY_GENERATED_REPORT_CARD, id);
        }

        public Content getContent ()
        {
            return (Content) this.getProperty("content");
        }

        public void setContent (Content content)
        {
            this.setProperty("content", content);
        }

        public NewReportCardBatch getReportCardBatch ()
        {
            return (NewReportCardBatch) this.getProperty("reportCardBatch");
        }

        public void setReportCardBatch (NewReportCardBatch reportCardBatch)
        {
            this.setProperty("reportCardBatch", reportCardBatch);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }


    }
}

