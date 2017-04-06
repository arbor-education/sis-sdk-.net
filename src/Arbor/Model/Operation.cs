using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Operation : ModelBase
    {
        protected string resourceType = ResourceType.OPERATION;
        public const string USER = "user";
        public const string OCCURRED_DATETIME = "occurredDatetime";

        public Operation ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Operation (string resourceType = "Operation", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Operation> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Operation");
        	RestGateway gateway = (RestGateway) Operation.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Operation> operationCollection = new ModelCollection<Operation> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    operationCollection.add((Operation) model);
        	}
        
        	return operationCollection;
        }

        public static Operation retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Operation.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Operation) gateway.retrieve(ResourceType.OPERATION, id);
        }

        public User getUser ()
        {
            return (User) this.getProperty("user");
        }

        public void setUser (User user)
        {
            this.setProperty("user", user);
        }

        public DateTime getOccurredDatetime ()
        {
            return (DateTime) this.getProperty("occurredDatetime");
        }

        public void setOccurredDatetime (DateTime occurredDatetime)
        {
            this.setProperty("occurredDatetime", occurredDatetime);
        }


    }
}

