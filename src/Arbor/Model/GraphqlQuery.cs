using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class GraphqlQuery : ModelBase
    {
        protected string resourceType = ResourceType.GRAPHQL_QUERY;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string QUERY = "query";
        public const string VARIABLES = "variables";
        public const string IDENTIFIER = "identifier";

        public GraphqlQuery ()
        {
            base.resourceType = this.resourceType;
        }
        
        public GraphqlQuery (string resourceType = "GraphqlQuery", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<GraphqlQuery> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("GraphqlQuery");
        	RestGateway gateway = (RestGateway) GraphqlQuery.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<GraphqlQuery> graphqlqueryCollection = new ModelCollection<GraphqlQuery> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    graphqlqueryCollection.add((GraphqlQuery) model);
        	}
        
        	return graphqlqueryCollection;
        }

        public static GraphqlQuery retrieve (string id)
        {
            RestGateway gateway = (RestGateway) GraphqlQuery.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (GraphqlQuery) gateway.retrieve(ResourceType.GRAPHQL_QUERY, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return Convert.ToBoolean( this.getProperty("active"));
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getQuery ()
        {
            return this.getProperty("query").ToString();
        }

        public void setQuery (string query)
        {
            this.setProperty("query", query);
        }

        public string getVariables ()
        {
            return this.getProperty("variables").ToString();
        }

        public void setVariables (string variables)
        {
            this.setProperty("variables", variables);
        }

        public string getIdentifier ()
        {
            return this.getProperty("identifier").ToString();
        }

        public void setIdentifier (string identifier)
        {
            this.setProperty("identifier", identifier);
        }


    }
}

