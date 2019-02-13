using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SiteOperatingPeriodException : ModelBase
    {
        protected string resourceType = ResourceType.SITE_OPERATING_PERIOD_EXCEPTION;
        public const string SITE = "site";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public SiteOperatingPeriodException ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SiteOperatingPeriodException (string resourceType = "SiteOperatingPeriodException", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SiteOperatingPeriodException> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SiteOperatingPeriodException");
        	RestGateway gateway = (RestGateway) SiteOperatingPeriodException.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SiteOperatingPeriodException> siteoperatingperiodexceptionCollection = new ModelCollection<SiteOperatingPeriodException> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    siteoperatingperiodexceptionCollection.add((SiteOperatingPeriodException) model);
        	}
        
        	return siteoperatingperiodexceptionCollection;
        }

        public static SiteOperatingPeriodException retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SiteOperatingPeriodException.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SiteOperatingPeriodException) gateway.retrieve(ResourceType.SITE_OPERATING_PERIOD_EXCEPTION, id);
        }

        public Site getSite ()
        {
            return (Site) this.getProperty("site");
        }

        public void setSite (Site site)
        {
            this.setProperty("site", site);
        }

        public DateTime getStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("startDate"))
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

