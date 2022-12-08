using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StandardizedAssessmentAspectCategory : ModelBase
    {
        protected string resourceType = ResourceType.STANDARDIZED_ASSESSMENT_ASPECT_CATEGORY;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string ASSESSMENT_PROVIDER = "assessmentProvider";
        public const string NAME = "name";

        public StandardizedAssessmentAspectCategory()
        {
            base.resourceType = this.resourceType;
        }

        public StandardizedAssessmentAspectCategory(string resourceType = "StandardizedAssessmentAspectCategory", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StandardizedAssessmentAspectCategory> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StandardizedAssessmentAspectCategory");
            RestGateway gateway = (RestGateway)StandardizedAssessmentAspectCategory.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StandardizedAssessmentAspectCategory> standardizedassessmentaspectcategoryCollection = new ModelCollection<StandardizedAssessmentAspectCategory>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                standardizedassessmentaspectcategoryCollection.add((StandardizedAssessmentAspectCategory)model);
            }

            return standardizedassessmentaspectcategoryCollection;
        }

        public static StandardizedAssessmentAspectCategory retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StandardizedAssessmentAspectCategory.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StandardizedAssessmentAspectCategory)gateway.retrieve(ResourceType.STANDARDIZED_ASSESSMENT_ASPECT_CATEGORY, id);
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

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }


    }
}

