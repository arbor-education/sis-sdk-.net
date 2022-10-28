using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class SenStatus : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_SEN_STATUS;
        public const string D00229 = "d00229";

        public SenStatus()
        {
            base.resourceType = this.resourceType;
        }

        public SenStatus(string resourceType = "SenStatus", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SenStatus> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_SenStatus");
            RestGateway gateway = (RestGateway)SenStatus.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SenStatus> senstatusCollection = new ModelCollection<SenStatus>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                senstatusCollection.add((SenStatus)model);
            }

            return senstatusCollection;
        }

        public static SenStatus retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SenStatus.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SenStatus)gateway.retrieve(ResourceType.UK_DFE_SEN_STATUS, id);
        }

        public string getD00229()
        {
            return this.getProperty("d00229").ToString();
        }

        public void setD00229(string d00229)
        {
            this.setProperty("d00229", d00229);
        }


    }
}

