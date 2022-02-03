using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IntegrationsHrFinanceMappingStatus : ModelBase
    {
        protected string resourceType = ResourceType.INTEGRATIONS_HR_FINANCE_MAPPING_STATUS;
        public const string INTEGRATIONS_HR_FINANCE_PROVIDER = "integrationsHrFinanceProvider";
        public const string ERRORS = "errors";
        public const string STATUS = "status";
        public const string MAPPING_TYPE = "mappingType";

        public IntegrationsHrFinanceMappingStatus ()
        {
            base.resourceType = this.resourceType;
        }
        
        public IntegrationsHrFinanceMappingStatus (string resourceType = "IntegrationsHrFinanceMappingStatus", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<IntegrationsHrFinanceMappingStatus> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("IntegrationsHrFinanceMappingStatus");
        	RestGateway gateway = (RestGateway) IntegrationsHrFinanceMappingStatus.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<IntegrationsHrFinanceMappingStatus> integrationshrfinancemappingstatusCollection = new ModelCollection<IntegrationsHrFinanceMappingStatus> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    integrationshrfinancemappingstatusCollection.add((IntegrationsHrFinanceMappingStatus) model);
        	}
        
        	return integrationshrfinancemappingstatusCollection;
        }

        public static IntegrationsHrFinanceMappingStatus retrieve (string id)
        {
            RestGateway gateway = (RestGateway) IntegrationsHrFinanceMappingStatus.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (IntegrationsHrFinanceMappingStatus) gateway.retrieve(ResourceType.INTEGRATIONS_HR_FINANCE_MAPPING_STATUS, id);
        }

        public IntegrationsHrFinanceProvider getIntegrationsHrFinanceProvider ()
        {
            return (IntegrationsHrFinanceProvider) this.getProperty("integrationsHrFinanceProvider");
        }

        public void setIntegrationsHrFinanceProvider (IntegrationsHrFinanceProvider integrationsHrFinanceProvider)
        {
            this.setProperty("integrationsHrFinanceProvider", integrationsHrFinanceProvider);
        }

        public string getErrors ()
        {
            return this.getProperty("errors").ToString();
        }

        public void setErrors (string errors)
        {
            this.setProperty("errors", errors);
        }

        public string getStatus ()
        {
            return this.getProperty("status").ToString();
        }

        public void setStatus (string status)
        {
            this.setProperty("status", status);
        }

        public string getMappingType ()
        {
            return this.getProperty("mappingType").ToString();
        }

        public void setMappingType (string mappingType)
        {
            this.setProperty("mappingType", mappingType);
        }


    }
}

