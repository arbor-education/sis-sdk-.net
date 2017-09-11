using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SearchIndexJob : ModelBase
    {
        protected string resourceType = ResourceType.SEARCH_INDEX_JOB;
        public const string OBJECT = "object";
        public const string STARTED_DATETIME = "startedDatetime";
        public const string THREAD_IDENTIFIER = "threadIdentifier";
        public const string COMPLETED_DATETIME = "completedDatetime";

        public SearchIndexJob ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SearchIndexJob (string resourceType = "SearchIndexJob", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SearchIndexJob> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SearchIndexJob");
        	RestGateway gateway = (RestGateway) SearchIndexJob.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SearchIndexJob> searchindexjobCollection = new ModelCollection<SearchIndexJob> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    searchindexjobCollection.add((SearchIndexJob) model);
        	}
        
        	return searchindexjobCollection;
        }

        public static SearchIndexJob retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SearchIndexJob.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SearchIndexJob) gateway.retrieve(ResourceType.SEARCH_INDEX_JOB, id);
        }

        public ModelBase getObject ()
        {
            return (ModelBase) this.getProperty("object");
        }

        public void setObject (ModelBase _object)
        {
            this.setProperty("object", _object);
        }

        public DateTime getStartedDatetime ()
        {
            return (DateTime) this.getProperty("startedDatetime");
        }

        public void setStartedDatetime (DateTime startedDatetime)
        {
            this.setProperty("startedDatetime", startedDatetime);
        }

        public int getThreadIdentifier ()
        {
            return Convert.ToInt32(this.getProperty("threadIdentifier"));
        }

        public void setThreadIdentifier (int threadIdentifier)
        {
            this.setProperty("threadIdentifier", threadIdentifier);
        }

        public DateTime getCompletedDatetime ()
        {
            return (DateTime) this.getProperty("completedDatetime");
        }

        public void setCompletedDatetime (DateTime completedDatetime)
        {
            this.setProperty("completedDatetime", completedDatetime);
        }


    }
}

