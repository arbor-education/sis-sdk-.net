using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CommunicationTemplate : ModelBase
    {
        protected new string resourceType = ResourceType.COMMUNICATION_TEMPLATE;
        public const string NAME = "name";
        public const string IDENTIFIER = "identifier";
        public const string EMAIL_SUBJECT = "emailSubject";
        public const string EMAIL_BODY = "emailBody";
        public const string SMS_BODY = "smsBody";
        public const string LETTER_BODY = "letterBody";
        public const string IN_APP_MESSAGE_BODY = "inAppMessageBody";
        public const string COMMUNICATION_TEMPLATE_DEFINITION_CLASS = "communicationTemplateDefinitionClass";
        public const string CUSTOM_REPORT = "customReport";

        public CommunicationTemplate()
        {
            base.resourceType = this.resourceType;
        }

        public CommunicationTemplate(string resourceType = "CommunicationTemplate", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CommunicationTemplate> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CommunicationTemplate");
            RestGateway gateway = (RestGateway)CommunicationTemplate.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CommunicationTemplate> communicationtemplateCollection = new ModelCollection<CommunicationTemplate>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                communicationtemplateCollection.add((CommunicationTemplate)model);
            }

            return communicationtemplateCollection;
        }

        public static CommunicationTemplate retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CommunicationTemplate.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CommunicationTemplate)gateway.retrieve(ResourceType.COMMUNICATION_TEMPLATE, id);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public string getIdentifier()
        {
            return this.getProperty("identifier").ToString();
        }

        public void setIdentifier(string identifier)
        {
            this.setProperty("identifier", identifier);
        }

        public string getEmailSubject()
        {
            return this.getProperty("emailSubject").ToString();
        }

        public void setEmailSubject(string emailSubject)
        {
            this.setProperty("emailSubject", emailSubject);
        }

        public string getEmailBody()
        {
            return this.getProperty("emailBody").ToString();
        }

        public void setEmailBody(string emailBody)
        {
            this.setProperty("emailBody", emailBody);
        }

        public string getSmsBody()
        {
            return this.getProperty("smsBody").ToString();
        }

        public void setSmsBody(string smsBody)
        {
            this.setProperty("smsBody", smsBody);
        }

        public string getLetterBody()
        {
            return this.getProperty("letterBody").ToString();
        }

        public void setLetterBody(string letterBody)
        {
            this.setProperty("letterBody", letterBody);
        }

        public string getInAppMessageBody()
        {
            return this.getProperty("inAppMessageBody").ToString();
        }

        public void setInAppMessageBody(string inAppMessageBody)
        {
            this.setProperty("inAppMessageBody", inAppMessageBody);
        }

        public string getCommunicationTemplateDefinitionClass()
        {
            return this.getProperty("communicationTemplateDefinitionClass").ToString();
        }

        public void setCommunicationTemplateDefinitionClass(string communicationTemplateDefinitionClass)
        {
            this.setProperty("communicationTemplateDefinitionClass", communicationTemplateDefinitionClass);
        }

        public CustomReport getCustomReport()
        {
            return (CustomReport)this.getProperty("customReport");
        }

        public void setCustomReport(CustomReport customReport)
        {
            this.setProperty("customReport", customReport);
        }


    }
}

