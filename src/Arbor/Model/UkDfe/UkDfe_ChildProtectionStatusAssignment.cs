using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_ChildProtectionStatusAssignment : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_CHILD_PROTECTION_STATUS_ASSIGNMENT;
        public const string RESPONSIBLE_LOCAL_AUTHORITY = "responsibleLocalAuthority";

        public UkDfe_ChildProtectionStatusAssignment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_ChildProtectionStatusAssignment (string resourceType = "UkDfe_ChildProtectionStatusAssignment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_ChildProtectionStatusAssignment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_ChildProtectionStatusAssignment");
        	RestGateway gateway = (RestGateway) UkDfe_ChildProtectionStatusAssignment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_ChildProtectionStatusAssignment> ukdfe_childprotectionstatusassignmentCollection = new ModelCollection<UkDfe_ChildProtectionStatusAssignment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_childprotectionstatusassignmentCollection.add((UkDfe_ChildProtectionStatusAssignment) model);
        	}
        
        	return ukdfe_childprotectionstatusassignmentCollection;
        }

        public static UkDfe_ChildProtectionStatusAssignment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_ChildProtectionStatusAssignment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_ChildProtectionStatusAssignment) gateway.retrieve(ResourceType.UK_DFE_CHILD_PROTECTION_STATUS_ASSIGNMENT, id);
        }

        public LocalAuthority getResponsibleLocalAuthority ()
        {
            return (LocalAuthority) this.getProperty("responsibleLocalAuthority");
        }

        public void setResponsibleLocalAuthority (LocalAuthority responsibleLocalAuthority)
        {
            this.setProperty("responsibleLocalAuthority", responsibleLocalAuthority);
        }


    }
}

