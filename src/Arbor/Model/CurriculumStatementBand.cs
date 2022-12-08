using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CurriculumStatementBand : ModelBase
    {
        protected string resourceType = ResourceType.CURRICULUM_STATEMENT_BAND;
        public const string CURRICULUM = "curriculum";
        public const string NAME = "name";
        public const string LOWER_GRADE_POINT_SCALE_VALUE = "lowerGradePointScaleValue";
        public const string UPPER_GRADE_POINT_SCALE_VALUE = "upperGradePointScaleValue";

        public CurriculumStatementBand()
        {
            base.resourceType = this.resourceType;
        }

        public CurriculumStatementBand(string resourceType = "CurriculumStatementBand", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CurriculumStatementBand> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CurriculumStatementBand");
            RestGateway gateway = (RestGateway)CurriculumStatementBand.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CurriculumStatementBand> curriculumstatementbandCollection = new ModelCollection<CurriculumStatementBand>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                curriculumstatementbandCollection.add((CurriculumStatementBand)model);
            }

            return curriculumstatementbandCollection;
        }

        public static CurriculumStatementBand retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CurriculumStatementBand.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CurriculumStatementBand)gateway.retrieve(ResourceType.CURRICULUM_STATEMENT_BAND, id);
        }

        public Curriculum getCurriculum()
        {
            return (Curriculum)this.getProperty("curriculum");
        }

        public void setCurriculum(Curriculum curriculum)
        {
            this.setProperty("curriculum", curriculum);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public float getLowerGradePointScaleValue()
        {
            return (float)this.getProperty("lowerGradePointScaleValue");
        }

        public void setLowerGradePointScaleValue(float lowerGradePointScaleValue)
        {
            this.setProperty("lowerGradePointScaleValue", lowerGradePointScaleValue);
        }

        public float getUpperGradePointScaleValue()
        {
            return (float)this.getProperty("upperGradePointScaleValue");
        }

        public void setUpperGradePointScaleValue(float upperGradePointScaleValue)
        {
            this.setProperty("upperGradePointScaleValue", upperGradePointScaleValue);
        }


    }
}

