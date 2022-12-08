using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ObservationStrand : ModelBase
    {
        protected string resourceType = ResourceType.OBSERVATION_STRAND;
        public const string OBSERVATION_THEME = "observationTheme";
        public const string OBSERVATION_GRADE_SET = "observationGradeSet";
        public const string NAME = "name";
        public const string USE_COMMENT = "useComment";

        public ObservationStrand()
        {
            base.resourceType = this.resourceType;
        }

        public ObservationStrand(string resourceType = "ObservationStrand", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ObservationStrand> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ObservationStrand");
            RestGateway gateway = (RestGateway)ObservationStrand.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ObservationStrand> observationstrandCollection = new ModelCollection<ObservationStrand>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                observationstrandCollection.add((ObservationStrand)model);
            }

            return observationstrandCollection;
        }

        public static ObservationStrand retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ObservationStrand.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ObservationStrand)gateway.retrieve(ResourceType.OBSERVATION_STRAND, id);
        }

        public ObservationTheme getObservationTheme()
        {
            return (ObservationTheme)this.getProperty("observationTheme");
        }

        public void setObservationTheme(ObservationTheme observationTheme)
        {
            this.setProperty("observationTheme", observationTheme);
        }

        public ObservationGradeSet getObservationGradeSet()
        {
            return (ObservationGradeSet)this.getProperty("observationGradeSet");
        }

        public void setObservationGradeSet(ObservationGradeSet observationGradeSet)
        {
            this.setProperty("observationGradeSet", observationGradeSet);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public bool getUseComment()
        {
            return Convert.ToBoolean(this.getProperty("useComment"));
        }

        public void setUseComment(bool useComment)
        {
            this.setProperty("useComment", useComment);
        }


    }
}

