using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DataItemSubscription : ModelBase
    {
        protected string resourceType = ResourceType.DATA_ITEM_SUBSCRIPTION;
        public const string ENTITY_TYPE = "entityType";
        public const string URL = "url";
        public const string LAST_UPDATED_DATETIME = "lastUpdatedDatetime";
        public const string DATA_SET_SUBSCRIPTION = "dataSetSubscription";
        public const string DO_NOT_UPDATE = "doNotUpdate";

        public DataItemSubscription ()
        {
            base.resourceType = this.resourceType;
        }
        
        public DataItemSubscription (string resourceType = "DataItemSubscription", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<DataItemSubscription> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("DataItemSubscription");
        	RestGateway gateway = (RestGateway) DataItemSubscription.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<DataItemSubscription> dataitemsubscriptionCollection = new ModelCollection<DataItemSubscription> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    dataitemsubscriptionCollection.add((DataItemSubscription) model);
        	}
        
        	return dataitemsubscriptionCollection;
        }

        public static DataItemSubscription retrieve (string id)
        {
            RestGateway gateway = (RestGateway) DataItemSubscription.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (DataItemSubscription) gateway.retrieve(ResourceType.DATA_ITEM_SUBSCRIPTION, id);
        }

        public int getEntityType ()
        {
            return Convert.ToInt32(this.getProperty("entityType"));
        }

        public void setEntityType (int entityType)
        {
            this.setProperty("entityType", entityType);
        }

        public string getUrl ()
        {
            return this.getProperty("url").ToString();
        }

        public void setUrl (string url)
        {
            this.setProperty("url", url);
        }

        public DateTime getLastUpdatedDatetime ()
        {
            return (DateTime) this.getProperty("lastUpdatedDatetime");
        }

        public void setLastUpdatedDatetime (DateTime lastUpdatedDatetime)
        {
            this.setProperty("lastUpdatedDatetime", lastUpdatedDatetime);
        }

        public DataSetSubscription getDataSetSubscription ()
        {
            return (DataSetSubscription) this.getProperty("dataSetSubscription");
        }

        public void setDataSetSubscription (DataSetSubscription dataSetSubscription)
        {
            this.setProperty("dataSetSubscription", dataSetSubscription);
        }

        public bool getDoNotUpdate ()
        {
            return (bool) this.getProperty("doNotUpdate");
        }

        public void setDoNotUpdate (bool doNotUpdate)
        {
            this.setProperty("doNotUpdate", doNotUpdate);
        }


    }
}

