using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Dashboard : ModelBase
    {
        protected string resourceType = ResourceType.DASHBOARD;
        public const string CODE = "code";
        public const string TITLE = "title";
        public const string ICON = "icon";
        public const string DISPLAY_ORDER = "displayOrder";

        public Dashboard ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Dashboard (string resourceType = "Dashboard", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Dashboard> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Dashboard");
        	RestGateway gateway = (RestGateway) Dashboard.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Dashboard> dashboardCollection = new ModelCollection<Dashboard> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    dashboardCollection.add((Dashboard) model);
        	}
        
        	return dashboardCollection;
        }

        public static Dashboard retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Dashboard.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Dashboard) gateway.retrieve(ResourceType.DASHBOARD, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public string getTitle ()
        {
            return this.getProperty("title").ToString();
        }

        public void setTitle (string title)
        {
            this.setProperty("title", title);
        }

        public string getIcon ()
        {
            return this.getProperty("icon").ToString();
        }

        public void setIcon (string icon)
        {
            this.setProperty("icon", icon);
        }

        public int getDisplayOrder ()
        {
            return Convert.ToInt32(this.getProperty("displayOrder"));
        }

        public void setDisplayOrder (int displayOrder)
        {
            this.setProperty("displayOrder", displayOrder);
        }


    }
}

