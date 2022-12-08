using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Candidate : ModelBase
    {
        protected string resourceType = ResourceType.CANDIDATE;
        public const string STUDENT = "student";
        public const string CANDIDATE_NUMBER = "candidateNumber";

        public Candidate()
        {
            base.resourceType = this.resourceType;
        }

        public Candidate(string resourceType = "Candidate", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Candidate> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Candidate");
            RestGateway gateway = (RestGateway)Candidate.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Candidate> candidateCollection = new ModelCollection<Candidate>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                candidateCollection.add((Candidate)model);
            }

            return candidateCollection;
        }

        public static Candidate retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Candidate.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Candidate)gateway.retrieve(ResourceType.CANDIDATE, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public int getCandidateNumber()
        {
            return Convert.ToInt32(this.getProperty("candidateNumber"));
        }

        public void setCandidateNumber(int candidateNumber)
        {
            this.setProperty("candidateNumber", candidateNumber);
        }


    }
}

