using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class Programme : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_PROGRAMME;
        public const string IS_TRAINEESHIP = "isTraineeship";

        public Programme()
        {
            base.resourceType = this.resourceType;
        }

        public Programme(string resourceType = "Programme", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Programme> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_Programme");
            RestGateway gateway = (RestGateway)Programme.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Programme> programmeCollection = new ModelCollection<Programme>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                programmeCollection.add((Programme)model);
            }

            return programmeCollection;
        }

        public static Programme retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Programme.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Programme)gateway.retrieve(ResourceType.UK_DFE_PROGRAMME, id);
        }

        public bool getIsTraineeship()
        {
            return Convert.ToBoolean(this.getProperty("isTraineeship"));
        }

        public void setIsTraineeship(bool isTraineeship)
        {
            this.setProperty("isTraineeship", isTraineeship);
        }


    }
}

