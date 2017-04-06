using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class Supplier : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SUPPLIER;
        public const string LEGAL_ENTITY = "legalEntity";

        public Supplier ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Supplier (string resourceType = "Supplier", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Supplier> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_Supplier");
        	RestGateway gateway = (RestGateway) Supplier.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Supplier> supplierCollection = new ModelCollection<Supplier> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    supplierCollection.add((Supplier) model);
        	}
        
        	return supplierCollection;
        }

        public static Supplier retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Supplier.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Supplier) gateway.retrieve(ResourceType.FINANCE_SUPPLIER, id);
        }

        public ModelBase getLegalEntity ()
        {
            return (ModelBase) this.getProperty("legalEntity");
        }

        public void setLegalEntity (ModelBase legalEntity)
        {
            this.setProperty("legalEntity", legalEntity);
        }


    }
}

