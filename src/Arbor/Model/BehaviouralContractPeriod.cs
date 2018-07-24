using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BehaviouralContractPeriod : ModelBase
    {
        protected string resourceType = ResourceType.BEHAVIOURAL_CONTRACT_PERIOD;
        public const string BEHAVIOURAL_CONTRACT = "behaviouralContract";
        public const string BEHAVIOURAL_CONTRACT_GOAL = "behaviouralContractGoal";
        public const string SESSION = "session";
        public const string GOAL_ACHIEVED = "goalAchieved";
        public const string COMMENT = "comment";
        public const string PERIOD_START_DATETIME = "periodStartDatetime";
        public const string PERIOD_END_DATETIME = "periodEndDatetime";
        public const string SIGNED_DATETIME = "signedDatetime";
        public const string SIGNED_PERSON = "signedPerson";

        public BehaviouralContractPeriod ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BehaviouralContractPeriod (string resourceType = "BehaviouralContractPeriod", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BehaviouralContractPeriod> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BehaviouralContractPeriod");
        	RestGateway gateway = (RestGateway) BehaviouralContractPeriod.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BehaviouralContractPeriod> behaviouralcontractperiodCollection = new ModelCollection<BehaviouralContractPeriod> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    behaviouralcontractperiodCollection.add((BehaviouralContractPeriod) model);
        	}
        
        	return behaviouralcontractperiodCollection;
        }

        public static BehaviouralContractPeriod retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BehaviouralContractPeriod.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BehaviouralContractPeriod) gateway.retrieve(ResourceType.BEHAVIOURAL_CONTRACT_PERIOD, id);
        }

        public BehaviouralContract getBehaviouralContract ()
        {
            return (BehaviouralContract) this.getProperty("behaviouralContract");
        }

        public void setBehaviouralContract (BehaviouralContract behaviouralContract)
        {
            this.setProperty("behaviouralContract", behaviouralContract);
        }

        public BehaviouralContractGoal getBehaviouralContractGoal ()
        {
            return (BehaviouralContractGoal) this.getProperty("behaviouralContractGoal");
        }

        public void setBehaviouralContractGoal (BehaviouralContractGoal behaviouralContractGoal)
        {
            this.setProperty("behaviouralContractGoal", behaviouralContractGoal);
        }

        public Session getSession ()
        {
            return (Session) this.getProperty("session");
        }

        public void setSession (Session session)
        {
            this.setProperty("session", session);
        }

        public bool getGoalAchieved ()
        {
            return (bool) this.getProperty("goalAchieved");
        }

        public void setGoalAchieved (bool goalAchieved)
        {
            this.setProperty("goalAchieved", goalAchieved);
        }

        public string getComment ()
        {
            return this.getProperty("comment").ToString();
        }

        public void setComment (string comment)
        {
            this.setProperty("comment", comment);
        }

        public DateTime getPeriodStartDatetime (){
            return Convert.ToDateTime(this.getProperty("periodStartDatetime"));
        }

        public void setPeriodStartDatetime (DateTime periodStartDatetime)
        {
            this.setProperty("periodStartDatetime", periodStartDatetime);
        }

        public DateTime getPeriodEndDatetime (){
            return Convert.ToDateTime(this.getProperty("periodEndDatetime"));
        }

        public void setPeriodEndDatetime (DateTime periodEndDatetime)
        {
            this.setProperty("periodEndDatetime", periodEndDatetime);
        }

        public DateTime getSignedDatetime (){
            return Convert.ToDateTime(this.getProperty("signedDatetime"));
        }

        public void setSignedDatetime (DateTime signedDatetime)
        {
            this.setProperty("signedDatetime", signedDatetime);
        }

        public ModelBase getSignedPerson ()
        {
            return (ModelBase) this.getProperty("signedPerson");
        }

        public void setSignedPerson (ModelBase signedPerson)
        {
            this.setProperty("signedPerson", signedPerson);
        }


    }
}

