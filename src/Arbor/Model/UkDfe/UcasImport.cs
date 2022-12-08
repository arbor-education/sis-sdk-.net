using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UcasImport : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_UCAS_IMPORT;
        public const string NAME = "name";
        public const string FILE_DATE = "fileDate";

        public UcasImport()
        {
            base.resourceType = this.resourceType;
        }

        public UcasImport(string resourceType = "UcasImport", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<UcasImport> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_UcasImport");
            RestGateway gateway = (RestGateway)UcasImport.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<UcasImport> ucasimportCollection = new ModelCollection<UcasImport>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                ucasimportCollection.add((UcasImport)model);
            }

            return ucasimportCollection;
        }

        public static UcasImport retrieve(string id)
        {
            RestGateway gateway = (RestGateway)UcasImport.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (UcasImport)gateway.retrieve(ResourceType.UK_DFE_UCAS_IMPORT, id);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public DateTime getFileDate()
        {
            return Convert.ToDateTime(this.getProperty("fileDate"));
        }

        public void setFileDate(DateTime fileDate)
        {
            this.setProperty("fileDate", fileDate);
        }


    }
}

