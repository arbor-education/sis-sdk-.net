using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SiteOperatingPeriod : ModelBase
    {
        protected new string resourceType = ResourceType.SITE_OPERATING_PERIOD;
        public const string SITE = "site";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string DAY_OF_CYCLE = "dayOfCycle";
        public const string START_TIME = "startTime";
        public const string END_TIME = "endTime";

        public SiteOperatingPeriod ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SiteOperatingPeriod (string resourceType = "SiteOperatingPeriod", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SiteOperatingPeriod> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SiteOperatingPeriod");
        	RestGateway gateway = (RestGateway) SiteOperatingPeriod.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SiteOperatingPeriod> siteoperatingperiodCollection = new ModelCollection<SiteOperatingPeriod> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    siteoperatingperiodCollection.add((SiteOperatingPeriod) model);
        	}
        
        	return siteoperatingperiodCollection;
        }

        public static SiteOperatingPeriod retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SiteOperatingPeriod.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SiteOperatingPeriod) gateway.retrieve(ResourceType.SITE_OPERATING_PERIOD, id);
        }

        public Site getSite ()
        {
            return (Site) this.getProperty("site");
        }

        public void setSite (Site site)
        {
            this.setProperty("site", site);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public int getDayOfCycle ()
        {
            return Convert.ToInt32(this.getProperty("dayOfCycle"));
        }

        public void setDayOfCycle (int dayOfCycle)
        {
            this.setProperty("dayOfCycle", dayOfCycle);
        }

        public string getStartTime ()
        {
            return this.getProperty("startTime").ToString();
        }

        public void setStartTime (string startTime)
        {
            this.setProperty("startTime", startTime);
        }

        public string getEndTime ()
        {
            return this.getProperty("endTime").ToString();
        }

        public void setEndTime (string endTime)
        {
            this.setProperty("endTime", endTime);
        }


    }
}

