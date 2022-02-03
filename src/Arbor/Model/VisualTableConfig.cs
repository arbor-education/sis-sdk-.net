using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class VisualTableConfig : ModelBase
    {
        protected string resourceType = ResourceType.VISUAL_TABLE_CONFIG;
        public const string PAGE_CONTEXT = "pageContext";
        public const string TABLE_URL = "tableUrl";
        public const string USER = "user";
        public const string EXTRA_CONTEXT = "extraContext";
        public const string CONFIG = "config";

        public VisualTableConfig ()
        {
            base.resourceType = this.resourceType;
        }
        
        public VisualTableConfig (string resourceType = "VisualTableConfig", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<VisualTableConfig> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("VisualTableConfig");
        	RestGateway gateway = (RestGateway) VisualTableConfig.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<VisualTableConfig> visualtableconfigCollection = new ModelCollection<VisualTableConfig> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    visualtableconfigCollection.add((VisualTableConfig) model);
        	}
        
        	return visualtableconfigCollection;
        }

        public static VisualTableConfig retrieve (string id)
        {
            RestGateway gateway = (RestGateway) VisualTableConfig.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (VisualTableConfig) gateway.retrieve(ResourceType.VISUAL_TABLE_CONFIG, id);
        }

        public string getPageContext ()
        {
            return this.getProperty("pageContext").ToString();
        }

        public void setPageContext (string pageContext)
        {
            this.setProperty("pageContext", pageContext);
        }

        public string getTableUrl ()
        {
            return this.getProperty("tableUrl").ToString();
        }

        public void setTableUrl (string tableUrl)
        {
            this.setProperty("tableUrl", tableUrl);
        }

        public User getUser ()
        {
            return (User) this.getProperty("user");
        }

        public void setUser (User user)
        {
            this.setProperty("user", user);
        }

        public string getExtraContext ()
        {
            return this.getProperty("extraContext").ToString();
        }

        public void setExtraContext (string extraContext)
        {
            this.setProperty("extraContext", extraContext);
        }

        public string getConfig ()
        {
            return this.getProperty("config").ToString();
        }

        public void setConfig (string config)
        {
            this.setProperty("config", config);
        }


    }
}

