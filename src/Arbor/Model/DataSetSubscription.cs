using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DataSetSubscription : ModelBase
    {
        protected new string resourceType = ResourceType.DATA_SET_SUBSCRIPTION;
        public const string DATA_SET_NAME = "dataSetName";
        public const string DATA_SET_IDENTIFIER = "dataSetIdentifier";
        public const string SUPPLIER_IDENTIFIER = "supplierIdentifier";
        public const string ENTITY_TYPE = "entityType";
        public const string CURRENT_DATA_SET_VERSION = "currentDataSetVersion";
        public const string LAST_UPDATED_DATETIME = "lastUpdatedDatetime";

        public DataSetSubscription()
        {
            base.resourceType = this.resourceType;
        }

        public DataSetSubscription(string resourceType = "DataSetSubscription", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<DataSetSubscription> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("DataSetSubscription");
            RestGateway gateway = (RestGateway)DataSetSubscription.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<DataSetSubscription> datasetsubscriptionCollection = new ModelCollection<DataSetSubscription>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                datasetsubscriptionCollection.add((DataSetSubscription)model);
            }

            return datasetsubscriptionCollection;
        }

        public static DataSetSubscription retrieve(string id)
        {
            RestGateway gateway = (RestGateway)DataSetSubscription.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (DataSetSubscription)gateway.retrieve(ResourceType.DATA_SET_SUBSCRIPTION, id);
        }

        public string getDataSetName()
        {
            return this.getProperty("dataSetName").ToString();
        }

        public void setDataSetName(string dataSetName)
        {
            this.setProperty("dataSetName", dataSetName);
        }

        public string getDataSetIdentifier()
        {
            return this.getProperty("dataSetIdentifier").ToString();
        }

        public void setDataSetIdentifier(string dataSetIdentifier)
        {
            this.setProperty("dataSetIdentifier", dataSetIdentifier);
        }

        public string getSupplierIdentifier()
        {
            return this.getProperty("supplierIdentifier").ToString();
        }

        public void setSupplierIdentifier(string supplierIdentifier)
        {
            this.setProperty("supplierIdentifier", supplierIdentifier);
        }

        public int getEntityType()
        {
            return Convert.ToInt32(this.getProperty("entityType"));
        }

        public void setEntityType(int entityType)
        {
            this.setProperty("entityType", entityType);
        }

        public int getCurrentDataSetVersion()
        {
            return Convert.ToInt32(this.getProperty("currentDataSetVersion"));
        }

        public void setCurrentDataSetVersion(int currentDataSetVersion)
        {
            this.setProperty("currentDataSetVersion", currentDataSetVersion);
        }

        public DateTime getLastUpdatedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("lastUpdatedDatetime"));
        }

        public void setLastUpdatedDatetime(DateTime lastUpdatedDatetime)
        {
            this.setProperty("lastUpdatedDatetime", lastUpdatedDatetime);
        }


    }
}

