using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CandidateSpecialArrangement : ModelBase
    {
        protected string resourceType = ResourceType.CANDIDATE_SPECIAL_ARRANGEMENT;
        public const string CANDIDATE_ENTRY = "candidateEntry";
        public const string SPECIAL_ARRANGEMENT_TYPE = "specialArrangementType";
        public const string NOTES = "notes";
        public const string REQUESTED_DATETIME = "requestedDatetime";
        public const string CONFIRMED_DATETIME = "confirmedDatetime";

        public CandidateSpecialArrangement ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CandidateSpecialArrangement (string resourceType = "CandidateSpecialArrangement", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CandidateSpecialArrangement> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CandidateSpecialArrangement");
        	RestGateway gateway = (RestGateway) CandidateSpecialArrangement.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CandidateSpecialArrangement> candidatespecialarrangementCollection = new ModelCollection<CandidateSpecialArrangement> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    candidatespecialarrangementCollection.add((CandidateSpecialArrangement) model);
        	}
        
        	return candidatespecialarrangementCollection;
        }

        public static CandidateSpecialArrangement retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CandidateSpecialArrangement.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CandidateSpecialArrangement) gateway.retrieve(ResourceType.CANDIDATE_SPECIAL_ARRANGEMENT, id);
        }

        public CandidateEntry getCandidateEntry ()
        {
            return (CandidateEntry) this.getProperty("candidateEntry");
        }

        public void setCandidateEntry (CandidateEntry candidateEntry)
        {
            this.setProperty("candidateEntry", candidateEntry);
        }

        public string getSpecialArrangementType ()
        {
            return this.getProperty("specialArrangementType").ToString();
        }

        public void setSpecialArrangementType (string specialArrangementType)
        {
            this.setProperty("specialArrangementType", specialArrangementType);
        }

        public string getNotes ()
        {
            return this.getProperty("notes").ToString();
        }

        public void setNotes (string notes)
        {
            this.setProperty("notes", notes);
        }

        public DateTime getRequestedDatetime ()
        {
            return (DateTime) this.getProperty("requestedDatetime");
        }

        public void setRequestedDatetime (DateTime requestedDatetime)
        {
            this.setProperty("requestedDatetime", requestedDatetime);
        }

        public DateTime getConfirmedDatetime ()
        {
            return (DateTime) this.getProperty("confirmedDatetime");
        }

        public void setConfirmedDatetime (DateTime confirmedDatetime)
        {
            this.setProperty("confirmedDatetime", confirmedDatetime);
        }


    }
}

