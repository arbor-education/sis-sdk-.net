using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class Language : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_LANGUAGE;
        public const string D00011_ALPHA3 = "d00011Alpha3";
        public const string D00011_ALPHA4 = "d00011Alpha4";

        public Language()
        {
            base.resourceType = this.resourceType;
        }

        public Language(string resourceType = "Language", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Language> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_Language");
            RestGateway gateway = (RestGateway)Language.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Language> languageCollection = new ModelCollection<Language>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                languageCollection.add((Language)model);
            }

            return languageCollection;
        }

        public static Language retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Language.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Language)gateway.retrieve(ResourceType.UK_DFE_LANGUAGE, id);
        }

        public string getD00011Alpha3()
        {
            return this.getProperty("d00011Alpha3").ToString();
        }

        public void setD00011Alpha3(string d00011Alpha3)
        {
            this.setProperty("d00011Alpha3", d00011Alpha3);
        }

        public string getD00011Alpha4()
        {
            return this.getProperty("d00011Alpha4").ToString();
        }

        public void setD00011Alpha4(string d00011Alpha4)
        {
            this.setProperty("d00011Alpha4", d00011Alpha4);
        }


    }
}

