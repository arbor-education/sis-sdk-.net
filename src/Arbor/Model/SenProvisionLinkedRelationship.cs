using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SenProvisionLinkedRelationship : ModelBase
    {
        protected string resourceType = ResourceType.SEN_PROVISION_LINKED_RELATIONSHIP;
        public const string SEN_PROVISION = "senProvision";
        public const string LINKED_PARTY = "linkedParty";
        public const string SEN_PROVISION_LINKED_RELATIONSHIP_TYPE = "senProvisionLinkedRelationshipType";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public SenProvisionLinkedRelationship ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SenProvisionLinkedRelationship (string resourceType = "SenProvisionLinkedRelationship", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SenProvisionLinkedRelationship> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SenProvisionLinkedRelationship");
        	RestGateway gateway = (RestGateway) SenProvisionLinkedRelationship.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SenProvisionLinkedRelationship> senprovisionlinkedrelationshipCollection = new ModelCollection<SenProvisionLinkedRelationship> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    senprovisionlinkedrelationshipCollection.add((SenProvisionLinkedRelationship) model);
        	}
        
        	return senprovisionlinkedrelationshipCollection;
        }

        public static SenProvisionLinkedRelationship retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SenProvisionLinkedRelationship.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SenProvisionLinkedRelationship) gateway.retrieve(ResourceType.SEN_PROVISION_LINKED_RELATIONSHIP, id);
        }

        public SenProvision getSenProvision ()
        {
            return (SenProvision) this.getProperty("senProvision");
        }

        public void setSenProvision (SenProvision senProvision)
        {
            this.setProperty("senProvision", senProvision);
        }

        public ModelBase getLinkedParty ()
        {
            return (ModelBase) this.getProperty("linkedParty");
        }

        public void setLinkedParty (ModelBase linkedParty)
        {
            this.setProperty("linkedParty", linkedParty);
        }

        public string getSenProvisionLinkedRelationshipType ()
        {
            return this.getProperty("senProvisionLinkedRelationshipType").ToString();
        }

        public void setSenProvisionLinkedRelationshipType (string senProvisionLinkedRelationshipType)
        {
            this.setProperty("senProvisionLinkedRelationshipType", senProvisionLinkedRelationshipType);
        }

        public DateTime getEffectiveDate ()
        {
            return (DateTime) this.getProperty("effectiveDate");
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return (DateTime) this.getProperty("endDate");
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

