using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DataSource : ModelBase
    {
        protected new string resourceType = ResourceType.DATA_SOURCE;
        public const string DOMAIN = "domain";
        public const string PROVIDER = "provider";

        public DataSource ()
        {
            base.resourceType = this.resourceType;
        }
        
        public DataSource (string resourceType = "DataSource", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<DataSource> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("DataSource");
        	RestGateway gateway = (RestGateway) DataSource.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<DataSource> datasourceCollection = new ModelCollection<DataSource> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    datasourceCollection.add((DataSource) model);
        	}
        
        	return datasourceCollection;
        }

        public static DataSource retrieve (string id)
        {
            RestGateway gateway = (RestGateway) DataSource.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (DataSource) gateway.retrieve(ResourceType.DATA_SOURCE, id);
        }

        public string getDomain ()
        {
            return this.getProperty("domain").ToString();
        }

        public void setDomain (string domain)
        {
            this.setProperty("domain", domain);
        }

        public string getProvider ()
        {
            return this.getProperty("provider").ToString();
        }

        public void setProvider (string provider)
        {
            this.setProperty("provider", provider);
        }


    }
}

