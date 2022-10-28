using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class OutgoingEntityTransfer : ModelBase
    {
        protected new string resourceType = ResourceType.OUTGOING_ENTITY_TRANSFER;
        public const string SOURCE_ENTITY = "sourceEntity";
        public const string TRANSFER_CLASS_NAME = "transferClassName";
        public const string DESTINATION_APPLICATION_ID = "destinationApplicationId";
        public const string SYNC_EFFECTIVE_DATE = "syncEffectiveDate";
        public const string SYNC_END_DATE = "syncEndDate";
        public const string SYNC_DISABLED = "syncDisabled";
        public const string LAST_SYNC_DATETIME = "lastSyncDatetime";

        public OutgoingEntityTransfer()
        {
            base.resourceType = this.resourceType;
        }

        public OutgoingEntityTransfer(string resourceType = "OutgoingEntityTransfer", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<OutgoingEntityTransfer> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("OutgoingEntityTransfer");
            RestGateway gateway = (RestGateway)OutgoingEntityTransfer.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<OutgoingEntityTransfer> outgoingentitytransferCollection = new ModelCollection<OutgoingEntityTransfer>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                outgoingentitytransferCollection.add((OutgoingEntityTransfer)model);
            }

            return outgoingentitytransferCollection;
        }

        public static OutgoingEntityTransfer retrieve(string id)
        {
            RestGateway gateway = (RestGateway)OutgoingEntityTransfer.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (OutgoingEntityTransfer)gateway.retrieve(ResourceType.OUTGOING_ENTITY_TRANSFER, id);
        }

        public ModelBase getSourceEntity()
        {
            return (ModelBase)this.getProperty("sourceEntity");
        }

        public void setSourceEntity(ModelBase sourceEntity)
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

        public string getDestinationApplicationId()
        {
            return this.getProperty("destinationApplicationId").ToString();
        }

        public void setDestinationApplicationId(string destinationApplicationId)
        {
            this.setProperty("destinationApplicationId", destinationApplicationId);
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

