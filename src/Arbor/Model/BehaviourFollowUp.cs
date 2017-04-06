using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BehaviourFollowUp : ModelBase
    {
        protected string resourceType = ResourceType.BEHAVIOUR_FOLLOW_UP;
        public const string STUDENT = "student";
        public const string STAFF = "staff";
        public const string FOLLOW_UP_DATETIME = "followUpDatetime";
        public const string SUMMARY = "summary";

        public BehaviourFollowUp ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BehaviourFollowUp (string resourceType = "BehaviourFollowUp", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BehaviourFollowUp> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BehaviourFollowUp");
        	RestGateway gateway = (RestGateway) BehaviourFollowUp.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BehaviourFollowUp> behaviourfollowupCollection = new ModelCollection<BehaviourFollowUp> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    behaviourfollowupCollection.add((BehaviourFollowUp) model);
        	}
        
        	return behaviourfollowupCollection;
        }

        public static BehaviourFollowUp retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BehaviourFollowUp.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BehaviourFollowUp) gateway.retrieve(ResourceType.BEHAVIOUR_FOLLOW_UP, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public DateTime getFollowUpDatetime ()
        {
            return (DateTime) this.getProperty("followUpDatetime");
        }

        public void setFollowUpDatetime (DateTime followUpDatetime)
        {
            this.setProperty("followUpDatetime", followUpDatetime);
        }

        public string getSummary ()
        {
            return this.getProperty("summary").ToString();
        }

        public void setSummary (string summary)
        {
            this.setProperty("summary", summary);
        }


    }
}

