using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AdHocAssessmentCategory : ModelBase
    {
        protected new string resourceType = ResourceType.AD_HOC_ASSESSMENT_CATEGORY;
        public const string CATEGORY_NAME = "categoryName";

        public AdHocAssessmentCategory()
        {
            base.resourceType = this.resourceType;
        }

        public AdHocAssessmentCategory(string resourceType = "AdHocAssessmentCategory", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AdHocAssessmentCategory> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AdHocAssessmentCategory");
            RestGateway gateway = (RestGateway)AdHocAssessmentCategory.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AdHocAssessmentCategory> adhocassessmentcategoryCollection = new ModelCollection<AdHocAssessmentCategory>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                adhocassessmentcategoryCollection.add((AdHocAssessmentCategory)model);
            }

            return adhocassessmentcategoryCollection;
        }

        public static AdHocAssessmentCategory retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AdHocAssessmentCategory.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AdHocAssessmentCategory)gateway.retrieve(ResourceType.AD_HOC_ASSESSMENT_CATEGORY, id);
        }

        public string getCategoryName()
        {
            return this.getProperty("categoryName").ToString();
        }

        public void setCategoryName(string categoryName)
        {
            this.setProperty("categoryName", categoryName);
        }


    }
}

