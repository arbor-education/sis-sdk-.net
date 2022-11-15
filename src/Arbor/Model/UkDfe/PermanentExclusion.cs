using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class PermanentExclusion : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_PERMANENT_EXCLUSION;
        public const string EXCLUDE_FROM_SCHOOL_CENSUS = "excludeFromSchoolCensus";

        public PermanentExclusion()
        {
            base.resourceType = this.resourceType;
        }

        public PermanentExclusion(string resourceType = "PermanentExclusion", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PermanentExclusion> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_PermanentExclusion");
            RestGateway gateway = (RestGateway)PermanentExclusion.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PermanentExclusion> permanentexclusionCollection = new ModelCollection<PermanentExclusion>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                permanentexclusionCollection.add((PermanentExclusion)model);
            }

            return permanentexclusionCollection;
        }

        public static PermanentExclusion retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PermanentExclusion.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PermanentExclusion)gateway.retrieve(ResourceType.UK_DFE_PERMANENT_EXCLUSION, id);
        }

        public bool getExcludeFromSchoolCensus()
        {
            return Convert.ToBoolean(this.getProperty("excludeFromSchoolCensus"));
        }

        public void setExcludeFromSchoolCensus(bool excludeFromSchoolCensus)
        {
            this.setProperty("excludeFromSchoolCensus", excludeFromSchoolCensus);
        }


    }
}

