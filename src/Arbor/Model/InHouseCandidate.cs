using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InHouseCandidate : ModelBase
    {
        protected new string resourceType = ResourceType.IN_HOUSE_CANDIDATE;
        public const string STUDENT = "student";
        public const string CANDIDATE_NUMBER = "candidateNumber";

        public InHouseCandidate ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InHouseCandidate (string resourceType = "InHouseCandidate", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InHouseCandidate> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InHouseCandidate");
        	RestGateway gateway = (RestGateway) InHouseCandidate.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InHouseCandidate> inhousecandidateCollection = new ModelCollection<InHouseCandidate> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    inhousecandidateCollection.add((InHouseCandidate) model);
        	}
        
        	return inhousecandidateCollection;
        }

        public static InHouseCandidate retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InHouseCandidate.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InHouseCandidate) gateway.retrieve(ResourceType.IN_HOUSE_CANDIDATE, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public int getCandidateNumber ()
        {
            return Convert.ToInt32(this.getProperty("candidateNumber"));
        }

        public void setCandidateNumber (int candidateNumber)
        {
            this.setProperty("candidateNumber", candidateNumber);
        }


    }
}

