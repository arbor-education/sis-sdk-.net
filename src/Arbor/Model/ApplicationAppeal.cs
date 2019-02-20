using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ApplicationAppeal : ModelBase
    {
        protected string resourceType = ResourceType.APPLICATION_APPEAL;
        public const string APPLICATION = "application";
        public const string NARRATIVE = "narrative";
        public const string LODGED_DATE = "lodgedDate";
        public const string WITHDRAWN_DATE = "withdrawnDate";
        public const string HEARING_DATE = "hearingDate";
        public const string DECISION_DATETIME = "decisionDatetime";
        public const string DECISION = "decision";

        public ApplicationAppeal ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ApplicationAppeal (string resourceType = "ApplicationAppeal", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ApplicationAppeal> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ApplicationAppeal");
        	RestGateway gateway = (RestGateway) ApplicationAppeal.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ApplicationAppeal> applicationappealCollection = new ModelCollection<ApplicationAppeal> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    applicationappealCollection.add((ApplicationAppeal) model);
        	}
        
        	return applicationappealCollection;
        }

        public static ApplicationAppeal retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ApplicationAppeal.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ApplicationAppeal) gateway.retrieve(ResourceType.APPLICATION_APPEAL, id);
        }

        public Application getApplication ()
        {
            return (Application) this.getProperty("application");
        }

        public void setApplication (Application application)
        {
            this.setProperty("application", application);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public DateTime getLodgedDate ()
        {
            return Convert.ToDateTime(this.getProperty("lodgedDate"));
        }

        public void setLodgedDate (DateTime lodgedDate)
        {
            this.setProperty("lodgedDate", lodgedDate);
        }

        public DateTime getWithdrawnDate ()
        {
            return Convert.ToDateTime(this.getProperty("withdrawnDate"));
        }

        public void setWithdrawnDate (DateTime withdrawnDate)
        {
            this.setProperty("withdrawnDate", withdrawnDate);
        }

        public DateTime getHearingDate ()
        {
            return Convert.ToDateTime(this.getProperty("hearingDate"));
        }

        public void setHearingDate (DateTime hearingDate)
        {
            this.setProperty("hearingDate", hearingDate);
        }

        public DateTime getDecisionDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("decisionDatetime"));
        }

        public void setDecisionDatetime (DateTime decisionDatetime)
        {
            this.setProperty("decisionDatetime", decisionDatetime);
        }

        public string getDecision ()
        {
            return this.getProperty("decision").ToString();
        }

        public void setDecision (string decision)
        {
            this.setProperty("decision", decision);
        }


    }
}

