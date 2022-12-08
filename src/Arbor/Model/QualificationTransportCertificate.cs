using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationTransportCertificate : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_TRANSPORT_CERTIFICATE;
        public const string AWARDING_ORGANIZATION = "awardingOrganization";
        public const string EDUCATIONAL_INSTITUTION = "educationalInstitution";
        public const string PRIVATE_KEY = "privateKey";
        public const string PUBLIC_KEY = "publicKey";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string LAST_SEQUENCE_NUMBER = "lastSequenceNumber";

        public QualificationTransportCertificate()
        {
            base.resourceType = this.resourceType;
        }

        public QualificationTransportCertificate(string resourceType = "QualificationTransportCertificate", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<QualificationTransportCertificate> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("QualificationTransportCertificate");
            RestGateway gateway = (RestGateway)QualificationTransportCertificate.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<QualificationTransportCertificate> qualificationtransportcertificateCollection = new ModelCollection<QualificationTransportCertificate>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                qualificationtransportcertificateCollection.add((QualificationTransportCertificate)model);
            }

            return qualificationtransportcertificateCollection;
        }

        public static QualificationTransportCertificate retrieve(string id)
        {
            RestGateway gateway = (RestGateway)QualificationTransportCertificate.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (QualificationTransportCertificate)gateway.retrieve(ResourceType.QUALIFICATION_TRANSPORT_CERTIFICATE, id);
        }

        public AwardingOrganization getAwardingOrganization()
        {
            return (AwardingOrganization)this.getProperty("awardingOrganization");
        }

        public void setAwardingOrganization(AwardingOrganization awardingOrganization)
        {
            this.setProperty("awardingOrganization", awardingOrganization);
        }

        public EducationalInstitution getEducationalInstitution()
        {
            return (EducationalInstitution)this.getProperty("educationalInstitution");
        }

        public void setEducationalInstitution(EducationalInstitution educationalInstitution)
        {
            this.setProperty("educationalInstitution", educationalInstitution);
        }

        public string getPrivateKey()
        {
            return this.getProperty("privateKey").ToString();
        }

        public void setPrivateKey(string privateKey)
        {
            this.setProperty("privateKey", privateKey);
        }

        public string getPublicKey()
        {
            return this.getProperty("publicKey").ToString();
        }

        public void setPublicKey(string publicKey)
        {
            this.setProperty("publicKey", publicKey);
        }

        public DateTime getEffectiveDate()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate(DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate(DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public int getLastSequenceNumber()
        {
            return Convert.ToInt32(this.getProperty("lastSequenceNumber"));
        }

        public void setLastSequenceNumber(int lastSequenceNumber)
        {
            this.setProperty("lastSequenceNumber", lastSequenceNumber);
        }


    }
}

