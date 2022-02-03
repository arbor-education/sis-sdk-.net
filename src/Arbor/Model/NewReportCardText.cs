using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class NewReportCardText : ModelBase
    {
        protected string resourceType = ResourceType.NEW_REPORT_CARD_TEXT;
        public const string NEW_REPORT_CARD_BATCH = "newReportCardBatch";
        public const string TITLE = "title";
        public const string POSITION = "position";
        public const string BODY = "body";

        public NewReportCardText ()
        {
            base.resourceType = this.resourceType;
        }
        
        public NewReportCardText (string resourceType = "NewReportCardText", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<NewReportCardText> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("NewReportCardText");
        	RestGateway gateway = (RestGateway) NewReportCardText.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<NewReportCardText> newreportcardtextCollection = new ModelCollection<NewReportCardText> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    newreportcardtextCollection.add((NewReportCardText) model);
        	}
        
        	return newreportcardtextCollection;
        }

        public static NewReportCardText retrieve (string id)
        {
            RestGateway gateway = (RestGateway) NewReportCardText.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (NewReportCardText) gateway.retrieve(ResourceType.NEW_REPORT_CARD_TEXT, id);
        }

        public NewReportCardBatch getNewReportCardBatch ()
        {
            return (NewReportCardBatch) this.getProperty("newReportCardBatch");
        }

        public void setNewReportCardBatch (NewReportCardBatch newReportCardBatch)
        {
            this.setProperty("newReportCardBatch", newReportCardBatch);
        }

        public string getTitle ()
        {
            return this.getProperty("title").ToString();
        }

        public void setTitle (string title)
        {
            this.setProperty("title", title);
        }

        public string getPosition ()
        {
            return this.getProperty("position").ToString();
        }

        public void setPosition (string position)
        {
            this.setProperty("position", position);
        }

        public string getBody ()
        {
            return this.getProperty("body").ToString();
        }

        public void setBody (string body)
        {
            this.setProperty("body", body);
        }


    }
}

