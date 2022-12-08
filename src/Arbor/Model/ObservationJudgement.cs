using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ObservationJudgement : ModelBase
    {
        protected string resourceType = ResourceType.OBSERVATION_JUDGEMENT;
        public const string OBSERVATION = "observation";
        public const string OBSERVATION_STRAND = "observationStrand";
        public const string OBSERVATION_GRADE = "observationGrade";
        public const string COMMENT = "comment";

        public ObservationJudgement()
        {
            base.resourceType = this.resourceType;
        }

        public ObservationJudgement(string resourceType = "ObservationJudgement", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ObservationJudgement> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ObservationJudgement");
            RestGateway gateway = (RestGateway)ObservationJudgement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ObservationJudgement> observationjudgementCollection = new ModelCollection<ObservationJudgement>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                observationjudgementCollection.add((ObservationJudgement)model);
            }

            return observationjudgementCollection;
        }

        public static ObservationJudgement retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ObservationJudgement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ObservationJudgement)gateway.retrieve(ResourceType.OBSERVATION_JUDGEMENT, id);
        }

        public Observation getObservation()
        {
            return (Observation)this.getProperty("observation");
        }

        public void setObservation(Observation observation)
        {
            this.setProperty("observation", observation);
        }

        public ObservationStrand getObservationStrand()
        {
            return (ObservationStrand)this.getProperty("observationStrand");
        }

        public void setObservationStrand(ObservationStrand observationStrand)
        {
            this.setProperty("observationStrand", observationStrand);
        }

        public ObservationGrade getObservationGrade()
        {
            return (ObservationGrade)this.getProperty("observationGrade");
        }

        public void setObservationGrade(ObservationGrade observationGrade)
        {
            this.setProperty("observationGrade", observationGrade);
        }

        public string getComment()
        {
            return this.getProperty("comment").ToString();
        }

        public void setComment(string comment)
        {
            this.setProperty("comment", comment);
        }


    }
}

