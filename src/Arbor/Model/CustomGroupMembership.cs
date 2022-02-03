using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomGroupMembership : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOM_GROUP_MEMBERSHIP;
        public const string CUSTOM_GROUP = "customGroup";
        public const string PERSON = "person";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public CustomGroupMembership ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomGroupMembership (string resourceType = "CustomGroupMembership", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomGroupMembership> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CustomGroupMembership");
        	RestGateway gateway = (RestGateway) CustomGroupMembership.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomGroupMembership> customgroupmembershipCollection = new ModelCollection<CustomGroupMembership> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customgroupmembershipCollection.add((CustomGroupMembership) model);
        	}
        
        	return customgroupmembershipCollection;
        }

        public static CustomGroupMembership retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomGroupMembership.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomGroupMembership) gateway.retrieve(ResourceType.CUSTOM_GROUP_MEMBERSHIP, id);
        }

        public CustomGroup getCustomGroup ()
        {
            return (CustomGroup) this.getProperty("customGroup");
        }

        public void setCustomGroup (CustomGroup customGroup)
        {
            this.setProperty("customGroup", customGroup);
        }

        public ModelBase getPerson ()
        {
            return (ModelBase) this.getProperty("person");
        }

        public void setPerson (ModelBase person)
        {
            this.setProperty("person", person);
        }

        public DateTime getStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

