using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AchievementLevel : ModelBase
    {
        protected new string resourceType = ResourceType.ACHIEVEMENT_LEVEL;
        public const string CODE = "code";
        public const string ACHIEVEMENT_LEVEL_SET = "achievementLevelSet";
        public const string NAME = "name";
        public const string SHORT_NAME = "shortName";
        public const string ACHIEVEMENT_VALUE = "achievementValue";
        public const string LOWER_ACHIEVEMENT_VALUE = "lowerAchievementValue";
        public const string UPPER_ACHIEVEMENT_VALUE = "upperAchievementValue";
        public const string LOWER_GRADE_POINT_SCALE_VALUE = "lowerGradePointScaleValue";
        public const string LOWER_BENCHMARK_GRADE = "lowerBenchmarkGrade";
        public const string UPPER_GRADE_POINT_SCALE_VALUE = "upperGradePointScaleValue";
        public const string UPPER_BENCHMARK_GRADE = "upperBenchmarkGrade";

        public AchievementLevel()
        {
            base.resourceType = this.resourceType;
        }

        public AchievementLevel(string resourceType = "AchievementLevel", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AchievementLevel> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AchievementLevel");
            RestGateway gateway = (RestGateway)AchievementLevel.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AchievementLevel> achievementlevelCollection = new ModelCollection<AchievementLevel>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                achievementlevelCollection.add((AchievementLevel)model);
            }

            return achievementlevelCollection;
        }

        public static AchievementLevel retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AchievementLevel.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AchievementLevel)gateway.retrieve(ResourceType.ACHIEVEMENT_LEVEL, id);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }

        public AchievementLevelSet getAchievementLevelSet()
        {
            return (AchievementLevelSet)this.getProperty("achievementLevelSet");
        }

        public void setAchievementLevelSet(AchievementLevelSet achievementLevelSet)
        {
            this.setProperty("achievementLevelSet", achievementLevelSet);
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

        public float getAchievementValue()
        {
            return (float)this.getProperty("achievementValue");
        }

        public void setAchievementValue(float achievementValue)
        {
            this.setProperty("achievementValue", achievementValue);
        }

        public float getLowerAchievementValue()
        {
            return (float)this.getProperty("lowerAchievementValue");
        }

        public void setLowerAchievementValue(float lowerAchievementValue)
        {
            this.setProperty("lowerAchievementValue", lowerAchievementValue);
        }

        public float getUpperAchievementValue()
        {
            return (float)this.getProperty("upperAchievementValue");
        }

        public void setUpperAchievementValue(float upperAchievementValue)
        {
            this.setProperty("upperAchievementValue", upperAchievementValue);
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


    }
}

