using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EligibilityRecord : ModelBase
    {
        protected string resourceType = ResourceType.ELIGIBILITY_RECORD;
        public const string ELIGIBILITY = "eligibility";
        public const string PERSON = "person";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string LAST_VERIFIED_DATE = "lastVerifiedDate";
        public const string NEXT_CHECK_DATE = "nextCheckDate";

        public EligibilityRecord ()
        {
            base.resourceType = this.resourceType;
        }
        
        public EligibilityRecord (string resourceType = "EligibilityRecord", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<EligibilityRecord> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("EligibilityRecord");
        	RestGateway gateway = (RestGateway) EligibilityRecord.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<EligibilityRecord> eligibilityrecordCollection = new ModelCollection<EligibilityRecord> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    eligibilityrecordCollection.add((EligibilityRecord) model);
        	}
        
        	return eligibilityrecordCollection;
        }

        public static EligibilityRecord retrieve (string id)
        {
            RestGateway gateway = (RestGateway) EligibilityRecord.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (EligibilityRecord) gateway.retrieve(ResourceType.ELIGIBILITY_RECORD, id);
        }

        public Eligibility getEligibility ()
        {
            return (Eligibility) this.getProperty("eligibility");
        }

        public void setEligibility (Eligibility eligibility)
        {
            this.setProperty("eligibility", eligibility);
        }

        public ModelBase getPerson ()
        {
            return (ModelBase) this.getProperty("person");
        }

        public void setPerson (ModelBase person)
        {
            this.setProperty("person", person);
        }

        public DateTime getStartDate (){
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate (){
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public DateTime getLastVerifiedDate (){
            return Convert.ToDateTime(this.getProperty("lastVerifiedDate"));
        }

        public void setLastVerifiedDate (DateTime lastVerifiedDate)
        {
            this.setProperty("lastVerifiedDate", lastVerifiedDate);
        }

        public DateTime getNextCheckDate (){
            return Convert.ToDateTime(this.getProperty("nextCheckDate"));
        }

        public void setNextCheckDate (DateTime nextCheckDate)
        {
            this.setProperty("nextCheckDate", nextCheckDate);
        }


    }
}

