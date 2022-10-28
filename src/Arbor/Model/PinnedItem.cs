using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PinnedItem : ModelBase
    {
        protected new string resourceType = ResourceType.PINNED_ITEM;
        public const string PINNED = "pinned";
        public const string TARGET = "target";
        public const string PINNED_UNTIL_DATETIME = "pinnedUntilDatetime";

        public PinnedItem()
        {
            base.resourceType = this.resourceType;
        }

        public PinnedItem(string resourceType = "PinnedItem", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PinnedItem> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PinnedItem");
            RestGateway gateway = (RestGateway)PinnedItem.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PinnedItem> pinneditemCollection = new ModelCollection<PinnedItem>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                pinneditemCollection.add((PinnedItem)model);
            }

            return pinneditemCollection;
        }

        public static PinnedItem retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PinnedItem.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PinnedItem)gateway.retrieve(ResourceType.PINNED_ITEM, id);
        }

        public ModelBase getPinned()
        {
            return (ModelBase)this.getProperty("pinned");
        }

        public void setPinned(ModelBase pinned)
        {
            this.setProperty("pinned", pinned);
        }

        public ModelBase getTarget()
        {
            return (ModelBase)this.getProperty("target");
        }

        public void setTarget(ModelBase target)
        {
            this.setProperty("target", target);
        }

        public DateTime getPinnedUntilDatetime()
        {
            return Convert.ToDateTime(this.getProperty("pinnedUntilDatetime"));
        }

        public void setPinnedUntilDatetime(DateTime pinnedUntilDatetime)
        {
            this.setProperty("pinnedUntilDatetime", pinnedUntilDatetime);
        }


    }
}

