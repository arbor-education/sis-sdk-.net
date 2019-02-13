using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SuspectedDuplicate : ModelBase
    {
        protected string resourceType = ResourceType.SUSPECTED_DUPLICATE;
        public const string SUSPECT_ONE = "suspectOne";
        public const string SUSPECT_TWO = "suspectTwo";
        public const string UNIQUE_KEY = "uniqueKey";
        public const string TOTAL_DUPLICATE_SCORE = "totalDuplicateScore";
        public const string DUPLICATE_SCORES = "duplicateScores";
        public const string RESOLVED_DATETIME = "resolvedDatetime";
        public const string RESOLVED_BY_STAFF = "resolvedByStaff";
        public const string RESOLUTION = "resolution";

        public SuspectedDuplicate ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SuspectedDuplicate (string resourceType = "SuspectedDuplicate", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SuspectedDuplicate> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SuspectedDuplicate");
        	RestGateway gateway = (RestGateway) SuspectedDuplicate.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SuspectedDuplicate> suspectedduplicateCollection = new ModelCollection<SuspectedDuplicate> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    suspectedduplicateCollection.add((SuspectedDuplicate) model);
        	}
        
        	return suspectedduplicateCollection;
        }

        public static SuspectedDuplicate retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SuspectedDuplicate.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SuspectedDuplicate) gateway.retrieve(ResourceType.SUSPECTED_DUPLICATE, id);
        }

        public ModelBase getSuspectOne ()
        {
            return (ModelBase) this.getProperty("suspectOne");
        }

        public void setSuspectOne (ModelBase suspectOne)
        {
            this.setProperty("suspectOne", suspectOne);
        }

        public ModelBase getSuspectTwo ()
        {
            return (ModelBase) this.getProperty("suspectTwo");
        }

        public void setSuspectTwo (ModelBase suspectTwo)
        {
            this.setProperty("suspectTwo", suspectTwo);
        }

        public string getUniqueKey ()
        {
            return this.getProperty("uniqueKey").ToString();
        }

        public void setUniqueKey (string uniqueKey)
        {
            this.setProperty("uniqueKey", uniqueKey);
        }

        public int getTotalDuplicateScore ()
        {
            return Convert.ToInt32(this.getProperty("totalDuplicateScore"));
        }

        public void setTotalDuplicateScore (int totalDuplicateScore)
        {
            this.setProperty("totalDuplicateScore", totalDuplicateScore);
        }

        public string getDuplicateScores ()
        {
            return this.getProperty("duplicateScores").ToString();
        }

        public void setDuplicateScores (string duplicateScores)
        {
            this.setProperty("duplicateScores", duplicateScores);
        }

        public DateTime getResolvedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("resolvedDatetime"))
        }

        public void setResolvedDatetime (DateTime resolvedDatetime)
        {
            this.setProperty("resolvedDatetime", resolvedDatetime);
        }

        public Staff getResolvedByStaff ()
        {
            return (Staff) this.getProperty("resolvedByStaff");
        }

        public void setResolvedByStaff (Staff resolvedByStaff)
        {
            this.setProperty("resolvedByStaff", resolvedByStaff);
        }

        public string getResolution ()
        {
            return this.getProperty("resolution").ToString();
        }

        public void setResolution (string resolution)
        {
            this.setProperty("resolution", resolution);
        }


    }
}

