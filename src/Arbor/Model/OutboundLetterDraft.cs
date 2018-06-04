using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class OutboundLetterDraft : ModelBase
    {
        protected string resourceType = ResourceType.OUTBOUND_LETTER_DRAFT;
        public const string DOCUMENT_LAYOUT = "documentLayout";
        public const string SENDING_PROFILE = "sendingProfile";
        public const string BODY = "body";
        public const string CUSTOM_REPORT = "customReport";
        public const string COMBINE_MESSAGES_TO_SAME_RECIPIENT = "combineMessagesToSameRecipient";
        public const string COMBINE_MESSAGES_TO_SAME_HOUSEHOLD = "combineMessagesToSameHousehold";
        public const string GENERATION_STARTED_DATETIME = "generationStartedDatetime";
        public const string GENERATION_COMPLETED_DATETIME = "generationCompletedDatetime";

        public OutboundLetterDraft ()
        {
            base.resourceType = this.resourceType;
        }
        
        public OutboundLetterDraft (string resourceType = "OutboundLetterDraft", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<OutboundLetterDraft> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("OutboundLetterDraft");
        	RestGateway gateway = (RestGateway) OutboundLetterDraft.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<OutboundLetterDraft> outboundletterdraftCollection = new ModelCollection<OutboundLetterDraft> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    outboundletterdraftCollection.add((OutboundLetterDraft) model);
        	}
        
        	return outboundletterdraftCollection;
        }

        public static OutboundLetterDraft retrieve (string id)
        {
            RestGateway gateway = (RestGateway) OutboundLetterDraft.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (OutboundLetterDraft) gateway.retrieve(ResourceType.OUTBOUND_LETTER_DRAFT, id);
        }

        public DocumentLayout getDocumentLayout ()
        {
            return (DocumentLayout) this.getProperty("documentLayout");
        }

        public void setDocumentLayout (DocumentLayout documentLayout)
        {
            this.setProperty("documentLayout", documentLayout);
        }

        public SendingProfile getSendingProfile ()
        {
            return (SendingProfile) this.getProperty("sendingProfile");
        }

        public void setSendingProfile (SendingProfile sendingProfile)
        {
            this.setProperty("sendingProfile", sendingProfile);
        }

        public string getBody ()
        {
            return this.getProperty("body").ToString();
        }

        public void setBody (string body)
        {
            this.setProperty("body", body);
        }

        public CustomReport getCustomReport ()
        {
            return (CustomReport) this.getProperty("customReport");
        }

        public void setCustomReport (CustomReport customReport)
        {
            this.setProperty("customReport", customReport);
        }

        public bool getCombineMessagesToSameRecipient ()
        {
            return (bool) this.getProperty("combineMessagesToSameRecipient");
        }

        public void setCombineMessagesToSameRecipient (bool combineMessagesToSameRecipient)
        {
            this.setProperty("combineMessagesToSameRecipient", combineMessagesToSameRecipient);
        }

        public bool getCombineMessagesToSameHousehold ()
        {
            return (bool) this.getProperty("combineMessagesToSameHousehold");
        }

        public void setCombineMessagesToSameHousehold (bool combineMessagesToSameHousehold)
        {
            this.setProperty("combineMessagesToSameHousehold", combineMessagesToSameHousehold);
        }

        public DateTime getGenerationStartedDatetime ()
        {
            return (DateTime) this.getProperty("generationStartedDatetime");
        }

        public void setGenerationStartedDatetime (DateTime generationStartedDatetime)
        {
            this.setProperty("generationStartedDatetime", generationStartedDatetime);
        }

        public DateTime getGenerationCompletedDatetime ()
        {
            return (DateTime) this.getProperty("generationCompletedDatetime");
        }

        public void setGenerationCompletedDatetime (DateTime generationCompletedDatetime)
        {
            this.setProperty("generationCompletedDatetime", generationCompletedDatetime);
        }


    }
}

