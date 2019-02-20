using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DataExport : ModelBase
    {
        protected string resourceType = ResourceType.DATA_EXPORT;
        public const string USER = "user";
        public const string MODULE = "module";
        public const string CONTROLLER = "controller";
        public const string ACTION = "action";
        public const string PARAMS = "params";
        public const string HASH = "hash";
        public const string LAST_EXPORT_DATETIME = "lastExportDatetime";
        public const string LAST_EXPORT_TITLE = "lastExportTitle";

        public DataExport ()
        {
            base.resourceType = this.resourceType;
        }
        
        public DataExport (string resourceType = "DataExport", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<DataExport> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("DataExport");
        	RestGateway gateway = (RestGateway) DataExport.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<DataExport> dataexportCollection = new ModelCollection<DataExport> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    dataexportCollection.add((DataExport) model);
        	}
        
        	return dataexportCollection;
        }

        public static DataExport retrieve (string id)
        {
            RestGateway gateway = (RestGateway) DataExport.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (DataExport) gateway.retrieve(ResourceType.DATA_EXPORT, id);
        }

        public User getUser ()
        {
            return (User) this.getProperty("user");
        }

        public void setUser (User user)
        {
            this.setProperty("user", user);
        }

        public string getModule ()
        {
            return this.getProperty("module").ToString();
        }

        public void setModule (string module)
        {
            this.setProperty("module", module);
        }

        public string getController ()
        {
            return this.getProperty("controller").ToString();
        }

        public void setController (string controller)
        {
            this.setProperty("controller", controller);
        }

        public string getAction ()
        {
            return this.getProperty("action").ToString();
        }

        public void setAction (string action)
        {
            this.setProperty("action", action);
        }

        public string getParams ()
        {
            return this.getProperty("params").ToString();
        }

        public void setParams (string parameters)
        {
            this.setProperty("params", parameters);
        }

        public string getHash ()
        {
            return this.getProperty("hash").ToString();
        }

        public void setHash (string hash)
        {
            this.setProperty("hash", hash);
        }

        public DateTime getLastExportDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("lastExportDatetime"));
        }

        public void setLastExportDatetime (DateTime lastExportDatetime)
        {
            this.setProperty("lastExportDatetime", lastExportDatetime);
        }

        public string getLastExportTitle ()
        {
            return this.getProperty("lastExportTitle").ToString();
        }

        public void setLastExportTitle (string lastExportTitle)
        {
            this.setProperty("lastExportTitle", lastExportTitle);
        }


    }
}

