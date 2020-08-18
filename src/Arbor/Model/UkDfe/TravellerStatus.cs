using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class TravellerStatus : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_TRAVELLER_STATUS;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string TRAVELLER_STATUS_NAME = "travellerStatusName";

        public TravellerStatus ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TravellerStatus (string resourceType = "TravellerStatus", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TravellerStatus> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_TravellerStatus");
        	RestGateway gateway = (RestGateway) TravellerStatus.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TravellerStatus> travellerstatusCollection = new ModelCollection<TravellerStatus> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    travellerstatusCollection.add((TravellerStatus) model);
        	}
        
        	return travellerstatusCollection;
        }

        public static TravellerStatus retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TravellerStatus.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TravellerStatus) gateway.retrieve(ResourceType.UK_DFE_TRAVELLER_STATUS, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return (bool) this.getProperty("active");
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getTravellerStatusName ()
        {
            return this.getProperty("travellerStatusName").ToString();
        }

        public void setTravellerStatusName (string travellerStatusName)
        {
            this.setProperty("travellerStatusName", travellerStatusName);
        }


    }
}

