using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class SupplierServiceType : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SUPPLIER_SERVICE_TYPE;
        public const string SERVICE_TYPE_DESCRIPTION = "serviceTypeDescription";

        public SupplierServiceType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SupplierServiceType (string resourceType = "SupplierServiceType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SupplierServiceType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_SupplierServiceType");
        	RestGateway gateway = (RestGateway) SupplierServiceType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SupplierServiceType> supplierservicetypeCollection = new ModelCollection<SupplierServiceType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    supplierservicetypeCollection.add((SupplierServiceType) model);
        	}
        
        	return supplierservicetypeCollection;
        }

        public static SupplierServiceType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SupplierServiceType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SupplierServiceType) gateway.retrieve(ResourceType.FINANCE_SUPPLIER_SERVICE_TYPE, id);
        }

        public string getServiceTypeDescription ()
        {
            return this.getProperty("serviceTypeDescription").ToString();
        }

        public void setServiceTypeDescription (string serviceTypeDescription)
        {
            this.setProperty("serviceTypeDescription", serviceTypeDescription);
        }


    }
}

