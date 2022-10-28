using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationScheme : ModelBase
    {
        protected new string resourceType = ResourceType.QUALIFICATION_SCHEME;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string AWARDING_ORGANIZATION = "awardingOrganization";
        public const string SCHEME_IDENTIFIER = "schemeIdentifier";
        public const string TITLE = "title";

        public QualificationScheme()
        {
            base.resourceType = this.resourceType;
        }

        public QualificationScheme(string resourceType = "QualificationScheme", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<QualificationScheme> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("QualificationScheme");
            RestGateway gateway = (RestGateway)QualificationScheme.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<QualificationScheme> qualificationschemeCollection = new ModelCollection<QualificationScheme>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                qualificationschemeCollection.add((QualificationScheme)model);
            }

            return qualificationschemeCollection;
        }

        public static QualificationScheme retrieve(string id)
        {
            RestGateway gateway = (RestGateway)QualificationScheme.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (QualificationScheme)gateway.retrieve(ResourceType.QUALIFICATION_SCHEME, id);
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

        public string getSchemeIdentifier()
        {
            return this.getProperty("schemeIdentifier").ToString();
        }

        public void setSchemeIdentifier(string schemeIdentifier)
        {
            this.setProperty("schemeIdentifier", schemeIdentifier);
        }

        public string getTitle()
        {
            return this.getProperty("title").ToString();
        }

        public void setTitle(string title)
        {
            this.setProperty("title", title);
        }


    }
}

