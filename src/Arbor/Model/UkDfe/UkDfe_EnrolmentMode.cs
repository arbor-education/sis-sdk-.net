using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_EnrolmentMode : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_ENROLMENT_MODE;
        public const string D00018 = "d00018";

        public UkDfe_EnrolmentMode ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_EnrolmentMode (string resourceType = "UkDfe_EnrolmentMode", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_EnrolmentMode> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_EnrolmentMode");
        	RestGateway gateway = (RestGateway) UkDfe_EnrolmentMode.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_EnrolmentMode> ukdfe_enrolmentmodeCollection = new ModelCollection<UkDfe_EnrolmentMode> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_enrolmentmodeCollection.add((UkDfe_EnrolmentMode) model);
        	}
        
        	return ukdfe_enrolmentmodeCollection;
        }

        public static UkDfe_EnrolmentMode retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_EnrolmentMode.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_EnrolmentMode) gateway.retrieve(ResourceType.UK_DFE_ENROLMENT_MODE, id);
        }

        public string getD00018 ()
        {
            return this.getProperty("d00018").ToString();
        }

        public void setD00018 (string d00018)
        {
            this.setProperty("d00018", d00018);
        }


    }
}

