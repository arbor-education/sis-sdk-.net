using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CourtOrderParty : ModelBase
    {
        protected new string resourceType = ResourceType.COURT_ORDER_PARTY;
        public const string COURT_ORDER = "courtOrder";
        public const string PARTY = "party";

        public CourtOrderParty ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CourtOrderParty (string resourceType = "CourtOrderParty", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CourtOrderParty> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CourtOrderParty");
        	RestGateway gateway = (RestGateway) CourtOrderParty.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CourtOrderParty> courtorderpartyCollection = new ModelCollection<CourtOrderParty> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    courtorderpartyCollection.add((CourtOrderParty) model);
        	}
        
        	return courtorderpartyCollection;
        }

        public static CourtOrderParty retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CourtOrderParty.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CourtOrderParty) gateway.retrieve(ResourceType.COURT_ORDER_PARTY, id);
        }

        public CourtOrder getCourtOrder ()
        {
            return (CourtOrder) this.getProperty("courtOrder");
        }

        public void setCourtOrder (CourtOrder courtOrder)
        {
            this.setProperty("courtOrder", courtOrder);
        }

        public ModelBase getParty ()
        {
            return (ModelBase) this.getProperty("party");
        }

        public void setParty (ModelBase party)
        {
            this.setProperty("party", party);
        }


    }
}

