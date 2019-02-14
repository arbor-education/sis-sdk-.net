using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CandidateEntryAudit : ModelBase
    {
        protected string resourceType = ResourceType.CANDIDATE_ENTRY_AUDIT;
        public const string CANDIDATE_ENTRY = "candidateEntry";
        public const string TYPE = "type";
        public const string ACTION_DATETIME = "actionDatetime";

        public CandidateEntryAudit ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CandidateEntryAudit (string resourceType = "CandidateEntryAudit", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CandidateEntryAudit> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CandidateEntryAudit");
        	RestGateway gateway = (RestGateway) CandidateEntryAudit.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CandidateEntryAudit> candidateentryauditCollection = new ModelCollection<CandidateEntryAudit> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    candidateentryauditCollection.add((CandidateEntryAudit) model);
        	}
        
        	return candidateentryauditCollection;
        }

        public static CandidateEntryAudit retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CandidateEntryAudit.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CandidateEntryAudit) gateway.retrieve(ResourceType.CANDIDATE_ENTRY_AUDIT, id);
        }

        public CandidateEntry getCandidateEntry ()
        {
            return (CandidateEntry) this.getProperty("candidateEntry");
        }

        public void setCandidateEntry (CandidateEntry candidateEntry)
        {
            this.setProperty("candidateEntry", candidateEntry);
        }

        public string getType ()
        {
            return this.getProperty("type").ToString();
        }

        public void setType (string type)
        {
            this.setProperty("type", type);
        }

        public DateTime getActionDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("actionDatetime"))
        }

        public void setActionDatetime (DateTime actionDatetime)
        {
            this.setProperty("actionDatetime", actionDatetime);
        }


    }
}

