using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_SenStatusAssignment : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SEN_STATUS_ASSIGNMENT;
        public const string IS_MEMBER_OF_SEN_UNIT = "isMemberOfSenUnit";
        public const string HAS_RESOURCED_PROVISION = "hasResourcedProvision";

        public UkDfe_SenStatusAssignment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_SenStatusAssignment (string resourceType = "UkDfe_SenStatusAssignment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_SenStatusAssignment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_SenStatusAssignment");
        	RestGateway gateway = (RestGateway) UkDfe_SenStatusAssignment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_SenStatusAssignment> ukdfe_senstatusassignmentCollection = new ModelCollection<UkDfe_SenStatusAssignment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_senstatusassignmentCollection.add((UkDfe_SenStatusAssignment) model);
        	}
        
        	return ukdfe_senstatusassignmentCollection;
        }

        public static UkDfe_SenStatusAssignment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_SenStatusAssignment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_SenStatusAssignment) gateway.retrieve(ResourceType.UK_DFE_SEN_STATUS_ASSIGNMENT, id);
        }

        public bool getIsMemberOfSenUnit ()
        {
            return Convert.ToBoolean(this.getProperty("isMemberOfSenUnit"))
        }

        public void setIsMemberOfSenUnit (bool isMemberOfSenUnit)
        {
            this.setProperty("isMemberOfSenUnit", isMemberOfSenUnit);
        }

        public bool getHasResourcedProvision ()
        {
            return Convert.ToBoolean(this.getProperty("hasResourcedProvision"))
        }

        public void setHasResourcedProvision (bool hasResourcedProvision)
        {
            this.setProperty("hasResourcedProvision", hasResourcedProvision);
        }


    }
}

