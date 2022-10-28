using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class InCareStatusAssignment : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_IN_CARE_STATUS_ASSIGNMENT;
        public const string RESPONSIBLE_LOCAL_AUTHORITY = "responsibleLocalAuthority";

        public InCareStatusAssignment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InCareStatusAssignment (string resourceType = "InCareStatusAssignment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InCareStatusAssignment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_InCareStatusAssignment");
        	RestGateway gateway = (RestGateway) InCareStatusAssignment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InCareStatusAssignment> incarestatusassignmentCollection = new ModelCollection<InCareStatusAssignment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    incarestatusassignmentCollection.add((InCareStatusAssignment) model);
        	}
        
        	return incarestatusassignmentCollection;
        }

        public static InCareStatusAssignment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InCareStatusAssignment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InCareStatusAssignment) gateway.retrieve(ResourceType.UK_DFE_IN_CARE_STATUS_ASSIGNMENT, id);
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

