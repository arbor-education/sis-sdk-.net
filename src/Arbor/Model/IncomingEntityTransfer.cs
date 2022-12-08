using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IncomingEntityTransfer : ModelBase
    {
        protected string resourceType = ResourceType.INCOMING_ENTITY_TRANSFER;
        public const string SOURCE_APPLICATION_ID = "sourceApplicationId";
        public const string SOURCE_ENTITY = "sourceEntity";
        public const string TRANSFER_CLASS_NAME = "transferClassName";
        public const string IMPORTED_ENTITY = "importedEntity";
        public const string SYNC_EFFECTIVE_DATE = "syncEffectiveDate";
        public const string SYNC_END_DATE = "syncEndDate";
        public const string SYNC_DISABLED = "syncDisabled";
        public const string LAST_SYNC_DATETIME = "lastSyncDatetime";

        public IncomingEntityTransfer()
        {
            base.resourceType = this.resourceType;
        }

        public IncomingEntityTransfer(string resourceType = "IncomingEntityTransfer", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<IncomingEntityTransfer> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("IncomingEntityTransfer");
            RestGateway gateway = (RestGateway)IncomingEntityTransfer.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<IncomingEntityTransfer> incomingentitytransferCollection = new ModelCollection<IncomingEntityTransfer>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                incomingentitytransferCollection.add((IncomingEntityTransfer)model);
            }

            return incomingentitytransferCollection;
        }

        public static IncomingEntityTransfer retrieve(string id)
        {
            RestGateway gateway = (RestGateway)IncomingEntityTransfer.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (IncomingEntityTransfer)gateway.retrieve(ResourceType.INCOMING_ENTITY_TRANSFER, id);
        }

        public string getSourceApplicationId()
        {
            return this.getProperty("sourceApplicationId").ToString();
        }

        public void setSourceApplicationId(string sourceApplicationId)
        {
            this.setProperty("sourceApplicationId", sourceApplicationId);
        }

        public string getSourceEntity()
        {
            return this.getProperty("sourceEntity").ToString();
        }

        public void setSourceEntity(string sourceEntity)
        {
            this.setProperty("sourceEntity", sourceEntity);
        }

        public string getTransferClassName()
        {
            return this.getProperty("transferClassName").ToString();
        }

        public void setTransferClassName(string transferClassName)
        {
            this.setProperty("transferClassName", transferClassName);
        }

        public ModelBase getImportedEntity()
        {
            return (ModelBase)this.getProperty("importedEntity");
        }

        public void setImportedEntity(ModelBase importedEntity)
        {
            this.setProperty("importedEntity", importedEntity);
        }

        public DateTime getSyncEffectiveDate()
        {
            return Convert.ToDateTime(this.getProperty("syncEffectiveDate"));
        }

        public void setSyncEffectiveDate(DateTime syncEffectiveDate)
        {
            this.setProperty("syncEffectiveDate", syncEffectiveDate);
        }

        public DateTime getSyncEndDate()
        {
            return Convert.ToDateTime(this.getProperty("syncEndDate"));
        }

        public void setSyncEndDate(DateTime syncEndDate)
        {
            this.setProperty("syncEndDate", syncEndDate);
        }

        public bool getSyncDisabled()
        {
            return Convert.ToBoolean(this.getProperty("syncDisabled"));
        }

        public void setSyncDisabled(bool syncDisabled)
        {
            this.setProperty("syncDisabled", syncDisabled);
        }

        public DateTime getLastSyncDatetime()
        {
            return Convert.ToDateTime(this.getProperty("lastSyncDatetime"));
        }

        public void setLastSyncDatetime(DateTime lastSyncDatetime)
        {
            this.setProperty("lastSyncDatetime", lastSyncDatetime);
        }


    }
}

