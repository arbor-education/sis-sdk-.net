using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SuperannuationScheme : ModelBase
    {
        protected string resourceType = ResourceType.SUPERANNUATION_SCHEME;
        public const string SUPERANNUATION_SCHEME_NAME = "superannuationSchemeName";
        public const string CODE = "code";

        public SuperannuationScheme ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SuperannuationScheme (string resourceType = "SuperannuationScheme", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SuperannuationScheme> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SuperannuationScheme");
        	RestGateway gateway = (RestGateway) SuperannuationScheme.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SuperannuationScheme> superannuationschemeCollection = new ModelCollection<SuperannuationScheme> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    superannuationschemeCollection.add((SuperannuationScheme) model);
        	}
        
        	return superannuationschemeCollection;
        }

        public static SuperannuationScheme retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SuperannuationScheme.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SuperannuationScheme) gateway.retrieve(ResourceType.SUPERANNUATION_SCHEME, id);
        }

        public string getSuperannuationSchemeName ()
        {
            return this.getProperty("superannuationSchemeName").ToString();
        }

        public void setSuperannuationSchemeName (string superannuationSchemeName)
        {
            this.setProperty("superannuationSchemeName", superannuationSchemeName);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }


    }
}

