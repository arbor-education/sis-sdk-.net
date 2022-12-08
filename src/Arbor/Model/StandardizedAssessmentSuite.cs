using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StandardizedAssessmentSuite : ModelBase
    {
        protected string resourceType = ResourceType.STANDARDIZED_ASSESSMENT_SUITE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string ASSESSMENT_PROVIDER = "assessmentProvider";
        public const string SUBJECT = "subject";
        public const string NAME = "name";
        public const string SHORT_NAME = "shortName";

        public StandardizedAssessmentSuite()
        {
            base.resourceType = this.resourceType;
        }

        public StandardizedAssessmentSuite(string resourceType = "StandardizedAssessmentSuite", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StandardizedAssessmentSuite> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StandardizedAssessmentSuite");
            RestGateway gateway = (RestGateway)StandardizedAssessmentSuite.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StandardizedAssessmentSuite> standardizedassessmentsuiteCollection = new ModelCollection<StandardizedAssessmentSuite>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                standardizedassessmentsuiteCollection.add((StandardizedAssessmentSuite)model);
            }

            return standardizedassessmentsuiteCollection;
        }

        public static StandardizedAssessmentSuite retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StandardizedAssessmentSuite.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StandardizedAssessmentSuite)gateway.retrieve(ResourceType.STANDARDIZED_ASSESSMENT_SUITE, id);
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

        public AssessmentProvider getAssessmentProvider()
        {
            return (AssessmentProvider)this.getProperty("assessmentProvider");
        }

        public void setAssessmentProvider(AssessmentProvider assessmentProvider)
        {
            this.setProperty("assessmentProvider", assessmentProvider);
        }

        public Subject getSubject()
        {
            return (Subject)this.getProperty("subject");
        }

        public void setSubject(Subject subject)
        {
            this.setProperty("subject", subject);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public string getShortName()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName(string shortName)
        {
            this.setProperty("shortName", shortName);
        }


    }
}

