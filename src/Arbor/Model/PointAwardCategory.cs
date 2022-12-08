using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PointAwardCategory : ModelBase
    {
        protected string resourceType = ResourceType.POINT_AWARD_CATEGORY;
        public const string DESCRIPTION = "description";
        public const string POINT_AWARD_SCALE = "pointAwardScale";
        public const string DEFAULT_POINTS = "defaultPoints";

        public PointAwardCategory()
        {
            base.resourceType = this.resourceType;
        }

        public PointAwardCategory(string resourceType = "PointAwardCategory", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PointAwardCategory> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PointAwardCategory");
            RestGateway gateway = (RestGateway)PointAwardCategory.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PointAwardCategory> pointawardcategoryCollection = new ModelCollection<PointAwardCategory>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                pointawardcategoryCollection.add((PointAwardCategory)model);
            }

            return pointawardcategoryCollection;
        }

        public static PointAwardCategory retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PointAwardCategory.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PointAwardCategory)gateway.retrieve(ResourceType.POINT_AWARD_CATEGORY, id);
        }

        public string getDescription()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription(string description)
        {
            this.setProperty("description", description);
        }

        public PointAwardScale getPointAwardScale()
        {
            return (PointAwardScale)this.getProperty("pointAwardScale");
        }

        public void setPointAwardScale(PointAwardScale pointAwardScale)
        {
            this.setProperty("pointAwardScale", pointAwardScale);
        }

        public float getDefaultPoints()
        {
            return (float)this.getProperty("defaultPoints");
        }

        public void setDefaultPoints(float defaultPoints)
        {
            this.setProperty("defaultPoints", defaultPoints);
        }


    }
}

