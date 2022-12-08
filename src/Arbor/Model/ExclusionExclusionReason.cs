using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ExclusionExclusionReason : ModelBase
    {
        protected string resourceType = ResourceType.EXCLUSION_EXCLUSION_REASON;
        public const string EXCLUSION = "exclusion";
        public const string EXCLUSION_REASON = "exclusionReason";

        public ExclusionExclusionReason()
        {
            base.resourceType = this.resourceType;
        }

        public ExclusionExclusionReason(string resourceType = "ExclusionExclusionReason", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ExclusionExclusionReason> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ExclusionExclusionReason");
            RestGateway gateway = (RestGateway)ExclusionExclusionReason.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ExclusionExclusionReason> exclusionexclusionreasonCollection = new ModelCollection<ExclusionExclusionReason>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                exclusionexclusionreasonCollection.add((ExclusionExclusionReason)model);
            }

            return exclusionexclusionreasonCollection;
        }

        public static ExclusionExclusionReason retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ExclusionExclusionReason.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ExclusionExclusionReason)gateway.retrieve(ResourceType.EXCLUSION_EXCLUSION_REASON, id);
        }

        public ModelBase getExclusion()
        {
            return (ModelBase)this.getProperty("exclusion");
        }

        public void setExclusion(ModelBase exclusion)
        {
            this.setProperty("exclusion", exclusion);
        }

        public ExclusionReason getExclusionReason()
        {
            return (ExclusionReason)this.getProperty("exclusionReason");
        }

        public void setExclusionReason(ExclusionReason exclusionReason)
        {
            this.setProperty("exclusionReason", exclusionReason);
        }


    }
}

