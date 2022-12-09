using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Curriculum : ModelBase
    {
        protected new string resourceType = ResourceType.CURRICULUM;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";
        public const string SHORT_NAME = "shortName";
        public const string GRADE_POINT_SCALE = "gradePointScale";
        public const string CURRICULUM_TIER = "curriculumTier";
        public const string LOWER_CURRICULUM_GRADE = "lowerCurriculumGrade";
        public const string UPPER_CURRICULUM_GRADE = "upperCurriculumGrade";
        public const string LOWER_GRADE_POINT_SCALE_VALUE = "lowerGradePointScaleValue";
        public const string LOWER_BENCHMARK_GRADE = "lowerBenchmarkGrade";
        public const string UPPER_GRADE_POINT_SCALE_VALUE = "upperGradePointScaleValue";
        public const string UPPER_BENCHMARK_GRADE = "upperBenchmarkGrade";
        public const string ACHIEVEMENT_LEVEL_SET = "achievementLevelSet";
        public const string ASSESSMENT = "assessment";
        public const string SUBJECT = "subject";
        public const string VALID_FROM_DATE = "validFromDate";
        public const string VALID_UNTIL_DATE = "validUntilDate";

        public Curriculum()
        {
            base.resourceType = this.resourceType;
        }

        public Curriculum(string resourceType = "Curriculum", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Curriculum> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Curriculum");
            RestGateway gateway = (RestGateway)Curriculum.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Curriculum> curriculumCollection = new ModelCollection<Curriculum>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                curriculumCollection.add((Curriculum)model);
            }

            return curriculumCollection;
        }

        public static Curriculum retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Curriculum.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Curriculum)gateway.retrieve(ResourceType.CURRICULUM, id);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive(bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder(int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public string getShortName()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName(string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public GradePointScale getGradePointScale()
        {
            return (GradePointScale)this.getProperty("gradePointScale");
        }

        public void setGradePointScale(GradePointScale gradePointScale)
        {
            this.setProperty("gradePointScale", gradePointScale);
        }

        public CurriculumTier getCurriculumTier()
        {
            return (CurriculumTier)this.getProperty("curriculumTier");
        }

        public void setCurriculumTier(CurriculumTier curriculumTier)
        {
            this.setProperty("curriculumTier", curriculumTier);
        }

        public CurriculumGrade getLowerCurriculumGrade()
        {
            return (CurriculumGrade)this.getProperty("lowerCurriculumGrade");
        }

        public void setLowerCurriculumGrade(CurriculumGrade lowerCurriculumGrade)
        {
            this.setProperty("lowerCurriculumGrade", lowerCurriculumGrade);
        }

        public CurriculumGrade getUpperCurriculumGrade()
        {
            return (CurriculumGrade)this.getProperty("upperCurriculumGrade");
        }

        public void setUpperCurriculumGrade(CurriculumGrade upperCurriculumGrade)
        {
            this.setProperty("upperCurriculumGrade", upperCurriculumGrade);
        }

        public float getLowerGradePointScaleValue()
        {
            return (float)this.getProperty("lowerGradePointScaleValue");
        }

        public void setLowerGradePointScaleValue(float lowerGradePointScaleValue)
        {
            this.setProperty("lowerGradePointScaleValue", lowerGradePointScaleValue);
        }

        public Grade getLowerBenchmarkGrade()
        {
            return (Grade)this.getProperty("lowerBenchmarkGrade");
        }

        public void setLowerBenchmarkGrade(Grade lowerBenchmarkGrade)
        {
            this.setProperty("lowerBenchmarkGrade", lowerBenchmarkGrade);
        }

        public float getUpperGradePointScaleValue()
        {
            return (float)this.getProperty("upperGradePointScaleValue");
        }

        public void setUpperGradePointScaleValue(float upperGradePointScaleValue)
        {
            this.setProperty("upperGradePointScaleValue", upperGradePointScaleValue);
        }

        public Grade getUpperBenchmarkGrade()
        {
            return (Grade)this.getProperty("upperBenchmarkGrade");
        }

        public void setUpperBenchmarkGrade(Grade upperBenchmarkGrade)
        {
            this.setProperty("upperBenchmarkGrade", upperBenchmarkGrade);
        }

        public AchievementLevelSet getAchievementLevelSet()
        {
            return (AchievementLevelSet)this.getProperty("achievementLevelSet");
        }

        public void setAchievementLevelSet(AchievementLevelSet achievementLevelSet)
        {
            this.setProperty("achievementLevelSet", achievementLevelSet);
        }

        public Assessment getAssessment()
        {
            return (Assessment)this.getProperty("assessment");
        }

        public void setAssessment(Assessment assessment)
        {
            this.setProperty("assessment", assessment);
        }

        public Subject getSubject()
        {
            return (Subject)this.getProperty("subject");
        }

        public void setSubject(Subject subject)
        {
            this.setProperty("subject", subject);
        }

        public DateTime getValidFromDate()
        {
            return Convert.ToDateTime(this.getProperty("validFromDate"));
        }

        public void setValidFromDate(DateTime validFromDate)
        {
            this.setProperty("validFromDate", validFromDate);
        }

        public DateTime getValidUntilDate()
        {
            return Convert.ToDateTime(this.getProperty("validUntilDate"));
        }

        public void setValidUntilDate(DateTime validUntilDate)
        {
            this.setProperty("validUntilDate", validUntilDate);
        }


    }
}

