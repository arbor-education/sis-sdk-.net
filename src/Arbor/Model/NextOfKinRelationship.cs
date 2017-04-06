using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class NextOfKinRelationship : ModelBase
    {
        protected string resourceType = ResourceType.NEXT_OF_KIN_RELATIONSHIP;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string RELATIONSHIP_NAME = "relationshipName";

        public NextOfKinRelationship ()
        {
            base.resourceType = this.resourceType;
        }
        
        public NextOfKinRelationship (string resourceType = "NextOfKinRelationship", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<NextOfKinRelationship> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("NextOfKinRelationship");
        	RestGateway gateway = (RestGateway) NextOfKinRelationship.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<NextOfKinRelationship> nextofkinrelationshipCollection = new ModelCollection<NextOfKinRelationship> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    nextofkinrelationshipCollection.add((NextOfKinRelationship) model);
        	}
        
        	return nextofkinrelationshipCollection;
        }

        public static NextOfKinRelationship retrieve (string id)
        {
            RestGateway gateway = (RestGateway) NextOfKinRelationship.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (NextOfKinRelationship) gateway.retrieve(ResourceType.NEXT_OF_KIN_RELATIONSHIP, id);
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
            return (bool) this.getProperty("active");
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

        public string getRelationshipName ()
        {
            return this.getProperty("relationshipName").ToString();
        }

        public void setRelationshipName (string relationshipName)
        {
            this.setProperty("relationshipName", relationshipName);
        }


    }
}

