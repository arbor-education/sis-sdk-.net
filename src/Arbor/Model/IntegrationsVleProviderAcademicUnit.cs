using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IntegrationsVleProviderAcademicUnit : ModelBase
    {
        protected string resourceType = ResourceType.INTEGRATIONS_VLE_PROVIDER_ACADEMIC_UNIT;
        public const string ACADEMIC_UNIT = "academicUnit";

        public IntegrationsVleProviderAcademicUnit ()
        {
            base.resourceType = this.resourceType;
        }
        
        public IntegrationsVleProviderAcademicUnit (string resourceType = "IntegrationsVleProviderAcademicUnit", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<IntegrationsVleProviderAcademicUnit> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("IntegrationsVleProviderAcademicUnit");
        	RestGateway gateway = (RestGateway) IntegrationsVleProviderAcademicUnit.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<IntegrationsVleProviderAcademicUnit> integrationsvleprovideracademicunitCollection = new ModelCollection<IntegrationsVleProviderAcademicUnit> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    integrationsvleprovideracademicunitCollection.add((IntegrationsVleProviderAcademicUnit) model);
        	}
        
        	return integrationsvleprovideracademicunitCollection;
        }

        public static IntegrationsVleProviderAcademicUnit retrieve (string id)
        {
            RestGateway gateway = (RestGateway) IntegrationsVleProviderAcademicUnit.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (IntegrationsVleProviderAcademicUnit) gateway.retrieve(ResourceType.INTEGRATIONS_VLE_PROVIDER_ACADEMIC_UNIT, id);
        }

        public AcademicUnit getAcademicUnit ()
        {
            return (AcademicUnit) this.getProperty("academicUnit");
        }

        public void setAcademicUnit (AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }


    }
}

