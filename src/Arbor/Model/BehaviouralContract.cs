using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BehaviouralContract : ModelBase
    {
        protected string resourceType = ResourceType.BEHAVIOURAL_CONTRACT;
        public const string BEHAVIOURAL_CONTRACT_TITLE = "behaviouralContractTitle";
        public const string STUDENT = "student";
        public const string NARRATIVE = "narrative";
        public const string CONTRACT_START_DATE = "contractStartDate";
        public const string CONTRACT_END_DATE = "contractEndDate";
        public const string CONTRACT_REVIEW_DATE = "contractReviewDate";

        public BehaviouralContract ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BehaviouralContract (string resourceType = "BehaviouralContract", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BehaviouralContract> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BehaviouralContract");
        	RestGateway gateway = (RestGateway) BehaviouralContract.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BehaviouralContract> behaviouralcontractCollection = new ModelCollection<BehaviouralContract> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    behaviouralcontractCollection.add((BehaviouralContract) model);
        	}
        
        	return behaviouralcontractCollection;
        }

        public static BehaviouralContract retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BehaviouralContract.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BehaviouralContract) gateway.retrieve(ResourceType.BEHAVIOURAL_CONTRACT, id);
        }

        public string getBehaviouralContractTitle ()
        {
            return this.getProperty("behaviouralContractTitle").ToString();
        }

        public void setBehaviouralContractTitle (string behaviouralContractTitle)
        {
            this.setProperty("behaviouralContractTitle", behaviouralContractTitle);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public DateTime getContractStartDate (){
            return Convert.ToDateTime(this.getProperty("contractStartDate"));
        }

        public void setContractStartDate (DateTime contractStartDate)
        {
            this.setProperty("contractStartDate", contractStartDate);
        }

        public DateTime getContractEndDate (){
            return Convert.ToDateTime(this.getProperty("contractEndDate"));
        }

        public void setContractEndDate (DateTime contractEndDate)
        {
            this.setProperty("contractEndDate", contractEndDate);
        }

        public DateTime getContractReviewDate (){
            return Convert.ToDateTime(this.getProperty("contractReviewDate"));
        }

        public void setContractReviewDate (DateTime contractReviewDate)
        {
            this.setProperty("contractReviewDate", contractReviewDate);
        }


    }
}

