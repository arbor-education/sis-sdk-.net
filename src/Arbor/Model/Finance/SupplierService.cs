using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class SupplierService : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SUPPLIER_SERVICE;
        public const string SUPPLIER = "supplier";
        public const string SUPPLIER_SERVICE_TYPE = "supplierServiceType";
        public const string SERVICE_DESCRIPTION = "serviceDescription";

        public SupplierService ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SupplierService (string resourceType = "SupplierService", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SupplierService> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_SupplierService");
        	RestGateway gateway = (RestGateway) SupplierService.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SupplierService> supplierserviceCollection = new ModelCollection<SupplierService> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    supplierserviceCollection.add((SupplierService) model);
        	}
        
        	return supplierserviceCollection;
        }

        public static SupplierService retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SupplierService.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SupplierService) gateway.retrieve(ResourceType.FINANCE_SUPPLIER_SERVICE, id);
        }

        public ModelBase getSupplier ()
        {
            return (ModelBase) this.getProperty("supplier");
        }

        public void setSupplier (ModelBase supplier)
        {
            this.setProperty("supplier", supplier);
        }

        public ModelBase getSupplierServiceType ()
        {
            return (ModelBase) this.getProperty("supplierServiceType");
        }

        public void setSupplierServiceType (ModelBase supplierServiceType)
        {
            this.setProperty("supplierServiceType", supplierServiceType);
        }

        public string getServiceDescription ()
        {
            return this.getProperty("serviceDescription").ToString();
        }

        public void setServiceDescription (string serviceDescription)
        {
            this.setProperty("serviceDescription", serviceDescription);
        }


    }
}

