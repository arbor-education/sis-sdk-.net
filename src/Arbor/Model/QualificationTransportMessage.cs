using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationTransportMessage : ModelBase
    {
        protected new string resourceType = ResourceType.QUALIFICATION_TRANSPORT_MESSAGE;
        public const string QUALIFICATION_TRANSPORT_CERTIFICATE = "qualificationTransportCertificate";
        public const string CONTENT = "content";
        public const string TYPE = "type";
        public const string MESSAGE_ID = "messageId";
        public const string DIRECTION = "direction";
        public const string REF_TO_MESSAGE_ID = "refToMessageId";
        public const string DATETIME = "datetime";
        public const string RAW_CONTENT = "rawContent";

        public QualificationTransportMessage()
        {
            base.resourceType = this.resourceType;
        }

        public QualificationTransportMessage(string resourceType = "QualificationTransportMessage", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<QualificationTransportMessage> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("QualificationTransportMessage");
            RestGateway gateway = (RestGateway)QualificationTransportMessage.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<QualificationTransportMessage> qualificationtransportmessageCollection = new ModelCollection<QualificationTransportMessage>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                qualificationtransportmessageCollection.add((QualificationTransportMessage)model);
            }

            return qualificationtransportmessageCollection;
        }

        public static QualificationTransportMessage retrieve(string id)
        {
            RestGateway gateway = (RestGateway)QualificationTransportMessage.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (QualificationTransportMessage)gateway.retrieve(ResourceType.QUALIFICATION_TRANSPORT_MESSAGE, id);
        }

        public QualificationTransportCertificate getQualificationTransportCertificate()
        {
            return (QualificationTransportCertificate)this.getProperty("qualificationTransportCertificate");
        }

        public void setQualificationTransportCertificate(QualificationTransportCertificate qualificationTransportCertificate)
        {
            this.setProperty("qualificationTransportCertificate", qualificationTransportCertificate);
        }

        public Content getContent()
        {
            return (Content)this.getProperty("content");
        }

        public void setContent(Content content)
        {
            this.setProperty("content", content);
        }

        public string getType()
        {
            return this.getProperty("type").ToString();
        }

        public void setType(string type)
        {
            this.setProperty("type", type);
        }

        public string getMessageId()
        {
            return this.getProperty("messageId").ToString();
        }

        public void setMessageId(string messageId)
        {
            this.setProperty("messageId", messageId);
        }

        public string getDirection()
        {
            return this.getProperty("direction").ToString();
        }

        public void setDirection(string direction)
        {
            this.setProperty("direction", direction);
        }

        public string getRefToMessageId()
        {
            return this.getProperty("refToMessageId").ToString();
        }

        public void setRefToMessageId(string refToMessageId)
        {
            this.setProperty("refToMessageId", refToMessageId);
        }

        public DateTime getDatetime()
        {
            return Convert.ToDateTime(this.getProperty("datetime"));
        }

        public void setDatetime(DateTime datetime)
        {
            this.setProperty("datetime", datetime);
        }

        public string getRawContent()
        {
            return this.getProperty("rawContent").ToString();
        }

        public void setRawContent(string rawContent)
        {
            this.setProperty("rawContent", rawContent);
        }


    }
}

