using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DataCheckError : ModelBase
    {
        protected string resourceType = ResourceType.DATA_CHECK_ERROR;
        public const string DATA_CHECKER_CLASS_NAME = "dataCheckerClassName";
        public const string ERROR_IDENTIFIER = "errorIdentifier";
        public const string CHECKED_ENTITY = "checkedEntity";
        public const string REPORTING_ENTITY = "reportingEntity";
        public const string REPORTED_DATETIME = "reportedDatetime";
        public const string PRIORITY = "priority";
        public const string ERROR_FIX_IS_MANDATORY = "errorFixIsMandatory";
        public const string IGNORED_DATETIME = "ignoredDatetime";
        public const string IGNORED_BY_USER = "ignoredByUser";
        public const string CORRECTED_DATETIME = "correctedDatetime";
        public const string CORRECTED_BY_USER = "correctedByUser";

        public DataCheckError ()
        {
            base.resourceType = this.resourceType;
        }
        
        public DataCheckError (string resourceType = "DataCheckError", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<DataCheckError> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("DataCheckError");
        	RestGateway gateway = (RestGateway) DataCheckError.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<DataCheckError> datacheckerrorCollection = new ModelCollection<DataCheckError> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    datacheckerrorCollection.add((DataCheckError) model);
        	}
        
        	return datacheckerrorCollection;
        }

        public static DataCheckError retrieve (string id)
        {
            RestGateway gateway = (RestGateway) DataCheckError.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (DataCheckError) gateway.retrieve(ResourceType.DATA_CHECK_ERROR, id);
        }

        public string getDataCheckerClassName ()
        {
            return this.getProperty("dataCheckerClassName").ToString();
        }

        public void setDataCheckerClassName (string dataCheckerClassName)
        {
            this.setProperty("dataCheckerClassName", dataCheckerClassName);
        }

        public string getErrorIdentifier ()
        {
            return this.getProperty("errorIdentifier").ToString();
        }

        public void setErrorIdentifier (string errorIdentifier)
        {
            this.setProperty("errorIdentifier", errorIdentifier);
        }

        public ModelBase getCheckedEntity ()
        {
            return (ModelBase) this.getProperty("checkedEntity");
        }

        public void setCheckedEntity (ModelBase checkedEntity)
        {
            this.setProperty("checkedEntity", checkedEntity);
        }

        public ModelBase getReportingEntity ()
        {
            return (ModelBase) this.getProperty("reportingEntity");
        }

        public void setReportingEntity (ModelBase reportingEntity)
        {
            this.setProperty("reportingEntity", reportingEntity);
        }

        public DateTime getReportedDatetime (){
            return Convert.ToDateTime(this.getProperty("reportedDatetime"));
        }

        public void setReportedDatetime (DateTime reportedDatetime)
        {
            this.setProperty("reportedDatetime", reportedDatetime);
        }

        public string getPriority ()
        {
            return this.getProperty("priority").ToString();
        }

        public void setPriority (string priority)
        {
            this.setProperty("priority", priority);
        }

        public bool getErrorFixIsMandatory ()
        {
            return Convert.ToBoolean( this.getProperty("errorFixIsMandatory"));
        }

        public void setErrorFixIsMandatory (bool errorFixIsMandatory)
        {
            this.setProperty("errorFixIsMandatory", errorFixIsMandatory);
        }

        public DateTime getIgnoredDatetime (){

            return Convert.ToDateTime(this.getProperty("ignoredDatetime"));
        }

        public void setIgnoredDatetime (DateTime ignoredDatetime)
        {
            this.setProperty("ignoredDatetime", ignoredDatetime);
        }

        public DateTime getIgnoredByUser (){
            return Convert.ToDateTime(this.getProperty("ignoredByUser"));
        }

        public void setIgnoredByUser (DateTime ignoredByUser)
        {
            this.setProperty("ignoredByUser", ignoredByUser);
        }

        public DateTime getCorrectedDatetime (){
            return Convert.ToDateTime(this.getProperty("correctedDatetime"));
        }

        public void setCorrectedDatetime (DateTime correctedDatetime)
        {
            this.setProperty("correctedDatetime", correctedDatetime);
        }

        public User getCorrectedByUser ()
        {
            return (User) this.getProperty("correctedByUser");
        }

        public void setCorrectedByUser (User correctedByUser)
        {
            this.setProperty("correctedByUser", correctedByUser);
        }


    }
}

