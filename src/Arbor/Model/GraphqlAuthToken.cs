using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class GraphqlAuthToken : ModelBase
    {
        protected string resourceType = ResourceType.GRAPHQL_AUTH_TOKEN;
        public const string USER = "user";
        public const string GRAPHQL_QUERY = "graphqlQuery";
        public const string AUTH_TOKEN = "authToken";

        public GraphqlAuthToken ()
        {
            base.resourceType = this.resourceType;
        }
        
        public GraphqlAuthToken (string resourceType = "GraphqlAuthToken", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<GraphqlAuthToken> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("GraphqlAuthToken");
        	RestGateway gateway = (RestGateway) GraphqlAuthToken.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<GraphqlAuthToken> graphqlauthtokenCollection = new ModelCollection<GraphqlAuthToken> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    graphqlauthtokenCollection.add((GraphqlAuthToken) model);
        	}
        
        	return graphqlauthtokenCollection;
        }

        public static GraphqlAuthToken retrieve (string id)
        {
            RestGateway gateway = (RestGateway) GraphqlAuthToken.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (GraphqlAuthToken) gateway.retrieve(ResourceType.GRAPHQL_AUTH_TOKEN, id);
        }

        public User getUser ()
        {
            return (User) this.getProperty("user");
        }

        public void setUser (User user)
        {
            this.setProperty("user", user);
        }

        public GraphqlQuery getGraphqlQuery ()
        {
            return (GraphqlQuery) this.getProperty("graphqlQuery");
        }

        public void setGraphqlQuery (GraphqlQuery graphqlQuery)
        {
            this.setProperty("graphqlQuery", graphqlQuery);
        }

        public string getAuthToken ()
        {
            return this.getProperty("authToken").ToString();
        }

        public void setAuthToken (string authToken)
        {
            this.setProperty("authToken", authToken);
        }


    }
}

