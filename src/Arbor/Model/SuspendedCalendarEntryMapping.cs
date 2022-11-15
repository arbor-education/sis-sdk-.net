using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SuspendedCalendarEntryMapping : ModelBase
    {
        protected new string resourceType = ResourceType.SUSPENDED_CALENDAR_ENTRY_MAPPING;
        public const string SUSPENDED_OBJECT = "suspendedObject";
        public const string SUSPENDED_EVENT = "suspendedEvent";

        public SuspendedCalendarEntryMapping()
        {
            base.resourceType = this.resourceType;
        }

        public SuspendedCalendarEntryMapping(string resourceType = "SuspendedCalendarEntryMapping", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SuspendedCalendarEntryMapping> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("SuspendedCalendarEntryMapping");
            RestGateway gateway = (RestGateway)SuspendedCalendarEntryMapping.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SuspendedCalendarEntryMapping> suspendedcalendarentrymappingCollection = new ModelCollection<SuspendedCalendarEntryMapping>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                suspendedcalendarentrymappingCollection.add((SuspendedCalendarEntryMapping)model);
            }

            return suspendedcalendarentrymappingCollection;
        }

        public static SuspendedCalendarEntryMapping retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SuspendedCalendarEntryMapping.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SuspendedCalendarEntryMapping)gateway.retrieve(ResourceType.SUSPENDED_CALENDAR_ENTRY_MAPPING, id);
        }

        public ModelBase getSuspendedObject()
        {
            return (ModelBase)this.getProperty("suspendedObject");
        }

        public void setSuspendedObject(ModelBase suspendedObject)
        {
            this.setProperty("suspendedObject", suspendedObject);
        }

        public ModelBase getSuspendedEvent()
        {
            return (ModelBase)this.getProperty("suspendedEvent");
        }

        public void setSuspendedEvent(ModelBase suspendedEvent)
        {
            this.setProperty("suspendedEvent", suspendedEvent);
        }


    }
}

