using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class OutboundLetter : ModelBase
    {
        protected string resourceType = ResourceType.OUTBOUND_LETTER;
        public const string OUTBOUND_LETTER_DRAFT = "outboundLetterDraft";
        public const string SENDER = "sender";
        public const string DOCUMENT_LAYOUT = "documentLayout";
        public const string BODY = "body";
        public const string GENERATED_DATETIME = "generatedDatetime";
        public const string ACTION_REQUIRED_DATETIME = "actionRequiredDatetime";

        public OutboundLetter ()
        {
            base.resourceType = this.resourceType;
        }
        
        public OutboundLetter (string resourceType = "OutboundLetter", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<OutboundLetter> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("OutboundLetter");
        	RestGateway gateway = (RestGateway) OutboundLetter.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<OutboundLetter> outboundletterCollection = new ModelCollection<OutboundLetter> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    outboundletterCollection.add((OutboundLetter) model);
        	}
        
        	return outboundletterCollection;
        }

        public static OutboundLetter retrieve (string id)
        {
            RestGateway gateway = (RestGateway) OutboundLetter.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (OutboundLetter) gateway.retrieve(ResourceType.OUTBOUND_LETTER, id);
        }

        public OutboundLetterDraft getOutboundLetterDraft ()
        {
            return (OutboundLetterDraft) this.getProperty("outboundLetterDraft");
        }

        public void setOutboundLetterDraft (OutboundLetterDraft outboundLetterDraft)
        {
            this.setProperty("outboundLetterDraft", outboundLetterDraft);
        }

        public ModelBase getSender ()
        {
            return (ModelBase) this.getProperty("sender");
        }

        public void setSender (ModelBase sender)
        {
            this.setProperty("sender", sender);
        }

        public DocumentLayout getDocumentLayout ()
        {
            return (DocumentLayout) this.getProperty("documentLayout");
        }

        public void setDocumentLayout (DocumentLayout documentLayout)
        {
            this.setProperty("documentLayout", documentLayout);
        }

        public string getBody ()
        {
            return this.getProperty("body").ToString();
        }

        public void setBody (string body)
        {
            this.setProperty("body", body);
        }

        public DateTime getGeneratedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("generatedDatetime"));
        }

        public void setGeneratedDatetime (DateTime generatedDatetime)
        {
            this.setProperty("generatedDatetime", generatedDatetime);
        }

        public DateTime getActionRequiredDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("actionRequiredDatetime"));
        }

        public void setActionRequiredDatetime (DateTime actionRequiredDatetime)
        {
            this.setProperty("actionRequiredDatetime", actionRequiredDatetime);
        }


    }
}

