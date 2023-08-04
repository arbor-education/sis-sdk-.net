using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DataExportErrorTag : ModelBase
    {
        protected string resourceType = ResourceType.DATA_EXPORT_ERROR_TAG;
        public const string DATA_EXPORT_ERROR = "dataExportError";
        public const string TAGGED_ENTITY = "taggedEntity";
        public const string TAG_NAME = "tagName";
        public const string TAG_VALUE = "tagValue";
        public const string TAG_URL = "tagUrl";

        public DataExportErrorTag()
        {
            base.resourceType = this.resourceType;
        }

        public DataExportErrorTag(string resourceType = "DataExportErrorTag", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<DataExportErrorTag> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("DataExportErrorTag");
            RestGateway gateway = (RestGateway)DataExportErrorTag.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<DataExportErrorTag> dataexporterrortagCollection = new ModelCollection<DataExportErrorTag>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                dataexporterrortagCollection.add((DataExportErrorTag)model);
            }

            return dataexporterrortagCollection;
        }

        public static DataExportErrorTag retrieve(string id)
        {
            RestGateway gateway = (RestGateway)DataExportErrorTag.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (DataExportErrorTag)gateway.retrieve(ResourceType.DATA_EXPORT_ERROR_TAG, id);
        }

        public DataExportError getDataExportError()
        {
            return (DataExportError)this.getProperty("dataExportError");
        }

        public void setDataExportError(DataExportError dataExportError)
        {
            this.setProperty("dataExportError", dataExportError);
        }

        public ModelBase getTaggedEntity()
        {
            return (ModelBase)this.getProperty("taggedEntity");
        }

        public void setTaggedEntity(ModelBase taggedEntity)
        {
            this.setProperty("taggedEntity", taggedEntity);
        }

        public string getTagName()
        {
            return this.getProperty("tagName").ToString();
        }

        public void setTagName(string tagName)
        {
            this.setProperty("tagName", tagName);
        }

        public string getTagValue()
        {
            return this.getProperty("tagValue").ToString();
        }

        public void setTagValue(string tagValue)
        {
            this.setProperty("tagValue", tagValue);
        }

        public string getTagUrl()
        {
            return this.getProperty("tagUrl").ToString();
        }

        public void setTagUrl(string tagUrl)
        {
            this.setProperty("tagUrl", tagUrl);
        }


    }
}

