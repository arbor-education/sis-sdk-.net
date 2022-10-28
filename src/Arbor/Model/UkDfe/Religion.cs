using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class Religion : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_RELIGION;
        public const string D00009 = "d00009";
        public const string D00195 = "d00195";

        public Religion()
        {
            base.resourceType = this.resourceType;
        }

        public Religion(string resourceType = "Religion", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Religion> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_Religion");
            RestGateway gateway = (RestGateway)Religion.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Religion> religionCollection = new ModelCollection<Religion>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                religionCollection.add((Religion)model);
            }

            return religionCollection;
        }

        public static Religion retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Religion.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Religion)gateway.retrieve(ResourceType.UK_DFE_RELIGION, id);
        }

        public string getD00009()
        {
            return this.getProperty("d00009").ToString();
        }

        public void setD00009(string d00009)
        {
            this.setProperty("d00009", d00009);
        }

        public string getD00195()
        {
            return this.getProperty("d00195").ToString();
        }

        public void setD00195(string d00195)
        {
            this.setProperty("d00195", d00195);
        }


    }
}

