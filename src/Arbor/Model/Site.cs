using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Site : ModelBase
    {
        protected new string resourceType = ResourceType.SITE;
        public const string SITE_NAME = "siteName";
        public const string SHORT_NAME = "shortName";
        public const string SITE_DISPLAY_ORDER = "siteDisplayOrder";

        public Site ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Site (string resourceType = "Site", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Site> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Site");
        	RestGateway gateway = (RestGateway) Site.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Site> siteCollection = new ModelCollection<Site> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    siteCollection.add((Site) model);
        	}
        
        	return siteCollection;
        }

        public static Site retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Site.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Site) gateway.retrieve(ResourceType.SITE, id);
        }

        public string getSiteName ()
        {
            return this.getProperty("siteName").ToString();
        }

        public void setSiteName (string siteName)
        {
            this.setProperty("siteName", siteName);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public int getSiteDisplayOrder ()
        {
            return Convert.ToInt32(this.getProperty("siteDisplayOrder"));
        }

        public void setSiteDisplayOrder (int siteDisplayOrder)
        {
            this.setProperty("siteDisplayOrder", siteDisplayOrder);
        }


    }
}

