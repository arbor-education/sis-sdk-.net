using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DataQualityCheckTag : ModelBase
    {
        protected string resourceType = ResourceType.DATA_QUALITY_CHECK_TAG;
        public const string DATA_QUALITY_CHECK_RESULT = "dataQualityCheckResult";
        public const string TAGGED = "tagged";

        public DataQualityCheckTag()
        {
            base.resourceType = this.resourceType;
        }

        public DataQualityCheckTag(string resourceType = "DataQualityCheckTag", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<DataQualityCheckTag> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("DataQualityCheckTag");
            RestGateway gateway = (RestGateway)DataQualityCheckTag.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<DataQualityCheckTag> dataqualitychecktagCollection = new ModelCollection<DataQualityCheckTag>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                dataqualitychecktagCollection.add((DataQualityCheckTag)model);
            }

            return dataqualitychecktagCollection;
        }

        public static DataQualityCheckTag retrieve(string id)
        {
            RestGateway gateway = (RestGateway)DataQualityCheckTag.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (DataQualityCheckTag)gateway.retrieve(ResourceType.DATA_QUALITY_CHECK_TAG, id);
        }

        public DataQualityCheckResult getDataQualityCheckResult()
        {
            return (DataQualityCheckResult)this.getProperty("dataQualityCheckResult");
        }

        public void setDataQualityCheckResult(DataQualityCheckResult dataQualityCheckResult)
        {
            this.setProperty("dataQualityCheckResult", dataQualityCheckResult);
        }

        public ModelBase getTagged()
        {
            return (ModelBase)this.getProperty("tagged");
        }

        public void setTagged(ModelBase tagged)
        {
            this.setProperty("tagged", tagged);
        }


    }
}

