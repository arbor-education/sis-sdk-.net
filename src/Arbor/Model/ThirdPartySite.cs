using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ThirdPartySite : ModelBase
    {
        protected string resourceType = ResourceType.THIRD_PARTY_SITE;
        public const string CODE = "code";
        public const string NAME = "name";

        public ThirdPartySite()
        {
            base.resourceType = this.resourceType;
        }

        public ThirdPartySite(string resourceType = "ThirdPartySite", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ThirdPartySite> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ThirdPartySite");
            RestGateway gateway = (RestGateway)ThirdPartySite.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ThirdPartySite> thirdpartysiteCollection = new ModelCollection<ThirdPartySite>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                thirdpartysiteCollection.add((ThirdPartySite)model);
            }

            return thirdpartysiteCollection;
        }

        public static ThirdPartySite retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ThirdPartySite.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ThirdPartySite)gateway.retrieve(ResourceType.THIRD_PARTY_SITE, id);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }


    }
}

