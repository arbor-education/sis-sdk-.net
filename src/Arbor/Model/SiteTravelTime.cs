using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SiteTravelTime : ModelBase
    {
        protected new string resourceType = ResourceType.SITE_TRAVEL_TIME;
        public const string SITE1 = "site1";
        public const string SITE2 = "site2";
        public const string TRAVEL_TIME = "travelTime";

        public SiteTravelTime ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SiteTravelTime (string resourceType = "SiteTravelTime", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SiteTravelTime> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SiteTravelTime");
        	RestGateway gateway = (RestGateway) SiteTravelTime.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SiteTravelTime> sitetraveltimeCollection = new ModelCollection<SiteTravelTime> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    sitetraveltimeCollection.add((SiteTravelTime) model);
        	}
        
        	return sitetraveltimeCollection;
        }

        public static SiteTravelTime retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SiteTravelTime.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SiteTravelTime) gateway.retrieve(ResourceType.SITE_TRAVEL_TIME, id);
        }

        public Site getSite1 ()
        {
            return (Site) this.getProperty("site1");
        }

        public void setSite1 (Site site1)
        {
            this.setProperty("site1", site1);
        }

        public Site getSite2 ()
        {
            return (Site) this.getProperty("site2");
        }

        public void setSite2 (Site site2)
        {
            this.setProperty("site2", site2);
        }

        public int getTravelTime ()
        {
            return Convert.ToInt32(this.getProperty("travelTime"));
        }

        public void setTravelTime (int travelTime)
        {
            this.setProperty("travelTime", travelTime);
        }


    }
}

