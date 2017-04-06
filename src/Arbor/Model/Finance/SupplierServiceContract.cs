using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class SupplierServiceContract : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SUPPLIER_SERVICE_CONTRACT;
        public const string SUPPLIER_SERVICE = "supplierService";
        public const string SERVICE_CONTRACT_NUMBER = "serviceContractNumber";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public SupplierServiceContract ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SupplierServiceContract (string resourceType = "SupplierServiceContract", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SupplierServiceContract> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_SupplierServiceContract");
        	RestGateway gateway = (RestGateway) SupplierServiceContract.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SupplierServiceContract> supplierservicecontractCollection = new ModelCollection<SupplierServiceContract> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    supplierservicecontractCollection.add((SupplierServiceContract) model);
        	}
        
        	return supplierservicecontractCollection;
        }

        public static SupplierServiceContract retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SupplierServiceContract.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SupplierServiceContract) gateway.retrieve(ResourceType.FINANCE_SUPPLIER_SERVICE_CONTRACT, id);
        }

        public ModelBase getSupplierService ()
        {
            return (ModelBase) this.getProperty("supplierService");
        }

        public void setSupplierService (ModelBase supplierService)
        {
            this.setProperty("supplierService", supplierService);
        }

        public string getServiceContractNumber ()
        {
            return this.getProperty("serviceContractNumber").ToString();
        }

        public void setServiceContractNumber (string serviceContractNumber)
        {
            this.setProperty("serviceContractNumber", serviceContractNumber);
        }

        public DateTime getStartDate ()
        {
            return (DateTime) this.getProperty("startDate");
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
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

