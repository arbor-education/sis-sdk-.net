using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DataQualityCheckResult : ModelBase
    {
        protected string resourceType = ResourceType.DATA_QUALITY_CHECK_RESULT;
        public const string OBJECT = "object";
        public const string CHECK_CLASS = "checkClass";
        public const string RESULT_TYPE = "resultType";
        public const string RESULT_CODE = "resultCode";
        public const string MESSAGE = "message";
        public const string LAST_CHECKED_DATETIME = "lastCheckedDatetime";
        public const string RESOLVED_DATETIME = "resolvedDatetime";
        public const string RESOLVED_USER = "resolvedUser";
        public const string IGNORED_USER = "ignoredUser";
        public const string IGNORED_DATETIME = "ignoredDatetime";

        public DataQualityCheckResult ()
        {
            base.resourceType = this.resourceType;
        }
        
        public DataQualityCheckResult (string resourceType = "DataQualityCheckResult", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<DataQualityCheckResult> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("DataQualityCheckResult");
        	RestGateway gateway = (RestGateway) DataQualityCheckResult.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<DataQualityCheckResult> dataqualitycheckresultCollection = new ModelCollection<DataQualityCheckResult> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    dataqualitycheckresultCollection.add((DataQualityCheckResult) model);
        	}
        
        	return dataqualitycheckresultCollection;
        }

        public static DataQualityCheckResult retrieve (string id)
        {
            RestGateway gateway = (RestGateway) DataQualityCheckResult.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (DataQualityCheckResult) gateway.retrieve(ResourceType.DATA_QUALITY_CHECK_RESULT, id);
        }

        public ModelBase getObject ()
        {
            return (ModelBase) this.getProperty("object");
        }

        public void setObject (ModelBase _object)
        {
            this.setProperty("object", _object);
        }

        public string getCheckClass ()
        {
            return this.getProperty("checkClass").ToString();
        }

        public void setCheckClass (string checkClass)
        {
            this.setProperty("checkClass", checkClass);
        }

        public string getResultType ()
        {
            return this.getProperty("resultType").ToString();
        }

        public void setResultType (string resultType)
        {
            this.setProperty("resultType", resultType);
        }

        public string getResultCode ()
        {
            return this.getProperty("resultCode").ToString();
        }

        public void setResultCode (string resultCode)
        {
            this.setProperty("resultCode", resultCode);
        }

        public string getMessage ()
        {
            return this.getProperty("message").ToString();
        }

        public void setMessage (string message)
        {
            this.setProperty("message", message);
        }

        public DateTime getLastCheckedDatetime (){
            return Convert.ToDateTime(this.getProperty("lastCheckedDatetime"));
        }

        public void setLastCheckedDatetime (DateTime lastCheckedDatetime)
        {
            this.setProperty("lastCheckedDatetime", lastCheckedDatetime);
        }

        public DateTime getResolvedDatetime (){
            return Convert.ToDateTime(this.getProperty("resolvedDatetime"));
        }

        public void setResolvedDatetime (DateTime resolvedDatetime)
        {
            this.setProperty("resolvedDatetime", resolvedDatetime);
        }

        public User getResolvedUser ()
        {
            return (User) this.getProperty("resolvedUser");
        }

        public void setResolvedUser (User resolvedUser)
        {
            this.setProperty("resolvedUser", resolvedUser);
        }

        public User getIgnoredUser ()
        {
            return (User) this.getProperty("ignoredUser");
        }

        public void setIgnoredUser (User ignoredUser)
        {
            this.setProperty("ignoredUser", ignoredUser);
        }

        public DateTime getIgnoredDatetime (){
            return Convert.ToDateTime(this.getProperty("ignoredDatetime"));
        }

        public void setIgnoredDatetime (DateTime ignoredDatetime)
        {
            this.setProperty("ignoredDatetime", ignoredDatetime);
        }


    }
}

