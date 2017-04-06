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
        protected string resourceType = ResourceType.CURRICULUM;
        public const string CODE = "code";
        public const string NAME = "name";
        public const string SHORT_NAME = "shortName";
        public const string GRADE_POINT_SCALE = "gradePointScale";
        public const string LOWER_GRADE_POINT_SCALE_VALUE = "lowerGradePointScaleValue";
        public const string UPPER_GRADE_POINT_SCALE_VALUE = "upperGradePointScaleValue";
        public const string ACHIEVEMENT_LEVEL_SET = "achievementLevelSet";
        public const string ASSESSMENT = "assessment";
        public const string VALID_FROM_DATE = "validFromDate";
        public const string VALID_UNTIL_DATE = "validUntilDate";

        public Curriculum ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Curriculum (string resourceType = "Curriculum", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Curriculum> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Curriculum");
        	RestGateway gateway = (RestGateway) Curriculum.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Curriculum> curriculumCollection = new ModelCollection<Curriculum> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    curriculumCollection.add((Curriculum) model);
        	}
        
        	return curriculumCollection;
        }

        public static Curriculum retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Curriculum.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Curriculum) gateway.retrieve(ResourceType.CURRICULUM, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public GradePointScale getGradePointScale ()
        {
            return (GradePointScale) this.getProperty("gradePointScale");
        }

        public void setGradePointScale (GradePointScale gradePointScale)
        {
            this.setProperty("gradePointScale", gradePointScale);
        }

        public float getLowerGradePointScaleValue ()
        {
            return (float) this.getProperty("lowerGradePointScaleValue");
        }

        public void setLowerGradePointScaleValue (float lowerGradePointScaleValue)
        {
            this.setProperty("lowerGradePointScaleValue", lowerGradePointScaleValue);
        }

        public float getUpperGradePointScaleValue ()
        {
            return (float) this.getProperty("upperGradePointScaleValue");
        }

        public void setUpperGradePointScaleValue (float upperGradePointScaleValue)
        {
            this.setProperty("upperGradePointScaleValue", upperGradePointScaleValue);
        }

        public AchievementLevelSet getAchievementLevelSet ()
        {
            return (AchievementLevelSet) this.getProperty("achievementLevelSet");
        }

        public void setAchievementLevelSet (AchievementLevelSet achievementLevelSet)
        {
            this.setProperty("achievementLevelSet", achievementLevelSet);
        }

        public Assessment getAssessment ()
        {
            return (Assessment) this.getProperty("assessment");
        }

        public void setAssessment (Assessment assessment)
        {
            this.setProperty("assessment", assessment);
        }

        public DateTime getValidFromDate ()
        {
            return (DateTime) this.getProperty("validFromDate");
        }

        public void setValidFromDate (DateTime validFromDate)
        {
            this.setProperty("validFromDate", validFromDate);
        }

        public DateTime getValidUntilDate ()
        {
            return (DateTime) this.getProperty("validUntilDate");
        }

        public void setValidUntilDate (DateTime validUntilDate)
        {
            this.setProperty("validUntilDate", validUntilDate);
        }


    }
}

