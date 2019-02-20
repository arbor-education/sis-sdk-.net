using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_TravellerStatus : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_TRAVELLER_STATUS;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string TRAVELLER_STATUS_NAME = "travellerStatusName";

        public UkDfe_TravellerStatus ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_TravellerStatus (string resourceType = "UkDfe_TravellerStatus", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_TravellerStatus> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_TravellerStatus");
        	RestGateway gateway = (RestGateway) UkDfe_TravellerStatus.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_TravellerStatus> ukdfe_travellerstatusCollection = new ModelCollection<UkDfe_TravellerStatus> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_travellerstatusCollection.add((UkDfe_TravellerStatus) model);
        	}
        
        	return ukdfe_travellerstatusCollection;
        }

        public static UkDfe_TravellerStatus retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_TravellerStatus.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_TravellerStatus) gateway.retrieve(ResourceType.UK_DFE_TRAVELLER_STATUS, id);
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
            return Convert.ToBoolean(this.getProperty("active"));
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

