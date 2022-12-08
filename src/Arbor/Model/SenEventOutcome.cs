using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SenEventOutcome : ModelBase
    {
        protected string resourceType = ResourceType.SEN_EVENT_OUTCOME;
        public const string SEN_EVENT = "senEvent";
        public const string SEN_EVENT_OUTCOME_TYPE = "senEventOutcomeType";
        public const string COMMENTS = "comments";

        public SenEventOutcome()
        {
            base.resourceType = this.resourceType;
        }

        public SenEventOutcome(string resourceType = "SenEventOutcome", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SenEventOutcome> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("SenEventOutcome");
            RestGateway gateway = (RestGateway)SenEventOutcome.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SenEventOutcome> seneventoutcomeCollection = new ModelCollection<SenEventOutcome>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                seneventoutcomeCollection.add((SenEventOutcome)model);
            }

            return seneventoutcomeCollection;
        }

        public static SenEventOutcome retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SenEventOutcome.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SenEventOutcome)gateway.retrieve(ResourceType.SEN_EVENT_OUTCOME, id);
        }

        public SenEvent getSenEvent()
        {
            return (SenEvent)this.getProperty("senEvent");
        }

        public void setSenEvent(SenEvent senEvent)
        {
            this.setProperty("senEvent", senEvent);
        }

        public SenEventOutcomeType getSenEventOutcomeType()
        {
            return (SenEventOutcomeType)this.getProperty("senEventOutcomeType");
        }

        public void setSenEventOutcomeType(SenEventOutcomeType senEventOutcomeType)
        {
            this.setProperty("senEventOutcomeType", senEventOutcomeType);
        }

        public string getComments()
        {
            return this.getProperty("comments").ToString();
        }

        public void setComments(string comments)
        {
            this.setProperty("comments", comments);
        }


    }
}

