using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Cheque : ModelBase
    {
        protected string resourceType = ResourceType.CHEQUE;
        public const string CHEQUE_BOOK = "chequeBook";
        public const string CHEQUE_NUMBER = "chequeNumber";

        public Cheque ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Cheque (string resourceType = "Cheque", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Cheque> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Cheque");
        	RestGateway gateway = (RestGateway) Cheque.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Cheque> chequeCollection = new ModelCollection<Cheque> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    chequeCollection.add((Cheque) model);
        	}
        
        	return chequeCollection;
        }

        public static Cheque retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Cheque.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Cheque) gateway.retrieve(ResourceType.CHEQUE, id);
        }

        public ChequeBook getChequeBook ()
        {
            return (ChequeBook) this.getProperty("chequeBook");
        }

        public void setChequeBook (ChequeBook chequeBook)
        {
            this.setProperty("chequeBook", chequeBook);
        }

        public string getChequeNumber ()
        {
            return this.getProperty("chequeNumber").ToString();
        }

        public void setChequeNumber (string chequeNumber)
        {
            this.setProperty("chequeNumber", chequeNumber);
        }


    }
}

