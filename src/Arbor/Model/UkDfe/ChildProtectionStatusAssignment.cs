using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class ChildProtectionStatusAssignment : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_CHILD_PROTECTION_STATUS_ASSIGNMENT;
        public const string RESPONSIBLE_LOCAL_AUTHORITY = "responsibleLocalAuthority";

        public ChildProtectionStatusAssignment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ChildProtectionStatusAssignment (string resourceType = "ChildProtectionStatusAssignment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ChildProtectionStatusAssignment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_ChildProtectionStatusAssignment");
        	RestGateway gateway = (RestGateway) ChildProtectionStatusAssignment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ChildProtectionStatusAssignment> childprotectionstatusassignmentCollection = new ModelCollection<ChildProtectionStatusAssignment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    childprotectionstatusassignmentCollection.add((ChildProtectionStatusAssignment) model);
        	}
        
        	return childprotectionstatusassignmentCollection;
        }

        public static ChildProtectionStatusAssignment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ChildProtectionStatusAssignment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ChildProtectionStatusAssignment) gateway.retrieve(ResourceType.UK_DFE_CHILD_PROTECTION_STATUS_ASSIGNMENT, id);
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

