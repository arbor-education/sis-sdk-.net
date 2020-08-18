using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_InCareStatusAssignment : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_IN_CARE_STATUS_ASSIGNMENT;
        public const string RESPONSIBLE_LOCAL_AUTHORITY = "responsibleLocalAuthority";

        public UkDfe_InCareStatusAssignment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_InCareStatusAssignment (string resourceType = "UkDfe_InCareStatusAssignment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_InCareStatusAssignment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_InCareStatusAssignment");
        	RestGateway gateway = (RestGateway) UkDfe_InCareStatusAssignment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_InCareStatusAssignment> ukdfe_incarestatusassignmentCollection = new ModelCollection<UkDfe_InCareStatusAssignment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_incarestatusassignmentCollection.add((UkDfe_InCareStatusAssignment) model);
        	}
        
        	return ukdfe_incarestatusassignmentCollection;
        }

        public static UkDfe_InCareStatusAssignment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_InCareStatusAssignment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_InCareStatusAssignment) gateway.retrieve(ResourceType.UK_DFE_IN_CARE_STATUS_ASSIGNMENT, id);
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

