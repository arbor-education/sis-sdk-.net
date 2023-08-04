using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationAvailabilityInstance : ModelBase
    {
        protected new string resourceType = ResourceType.QUALIFICATION_AVAILABILITY_INSTANCE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string AWARDING_ORGANIZATION = "awardingOrganization";
        public const string QUALIFICATION_AVAILABILITY_IDENTIFIER = "qualificationAvailabilityIdentifier";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public QualificationAvailabilityInstance()
        {
            base.resourceType = this.resourceType;
        }

        public QualificationAvailabilityInstance(string resourceType = "QualificationAvailabilityInstance", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<QualificationAvailabilityInstance> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("QualificationAvailabilityInstance");
            RestGateway gateway = (RestGateway)QualificationAvailabilityInstance.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<QualificationAvailabilityInstance> qualificationavailabilityinstanceCollection = new ModelCollection<QualificationAvailabilityInstance>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                qualificationavailabilityinstanceCollection.add((QualificationAvailabilityInstance)model);
            }

            return qualificationavailabilityinstanceCollection;
        }

        public static QualificationAvailabilityInstance retrieve(string id)
        {
            RestGateway gateway = (RestGateway)QualificationAvailabilityInstance.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (QualificationAvailabilityInstance)gateway.retrieve(ResourceType.QUALIFICATION_AVAILABILITY_INSTANCE, id);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive(bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder(int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public AwardingOrganization getAwardingOrganization()
        {
            return (AwardingOrganization)this.getProperty("awardingOrganization");
        }

        public void setAwardingOrganization(AwardingOrganization awardingOrganization)
        {
            this.setProperty("awardingOrganization", awardingOrganization);
        }

        public string getQualificationAvailabilityIdentifier()
        {
            return this.getProperty("qualificationAvailabilityIdentifier").ToString();
        }

        public void setQualificationAvailabilityIdentifier(string qualificationAvailabilityIdentifier)
        {
            this.setProperty("qualificationAvailabilityIdentifier", qualificationAvailabilityIdentifier);
        }

        public DateTime getStartDate()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate(DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate(DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

