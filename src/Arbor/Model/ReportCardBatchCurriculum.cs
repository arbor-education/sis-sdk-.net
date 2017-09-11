using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ReportCardBatchCurriculum : ModelBase
    {
        protected string resourceType = ResourceType.REPORT_CARD_BATCH_CURRICULUM;
        public const string REPORT_CARD_BATCH = "reportCardBatch";
        public const string ORDER = "order";
        public const string CURRICULUM = "curriculum";
        public const string INCLUDE_STATEMENTS = "includeStatements";
        public const string LOWER_ACHIEVEMENT_LEVEL = "lowerAchievementLevel";
        public const string LOWER_ACHIEVEMENT_VALUE = "lowerAchievementValue";
        public const string UPPER_ACHIEVEMENT_LEVEL = "upperAchievementLevel";
        public const string UPPER_ACHIEVEMENT_VALUE = "upperAchievementValue";
        public const string REPORTING_MODE = "reportingMode";
        public const string INCLUDE_SUMMATIVE_GRADE = "includeSummativeGrade";
        public const string SUMMATIVE_GRADE_TYPE = "summativeGradeType";
        public const string SUMMATIVE_GRADE_ACHIEVEMENT_LEVEL_SET = "summativeGradeAchievementLevelSet";

        public ReportCardBatchCurriculum ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ReportCardBatchCurriculum (string resourceType = "ReportCardBatchCurriculum", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ReportCardBatchCurriculum> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ReportCardBatchCurriculum");
        	RestGateway gateway = (RestGateway) ReportCardBatchCurriculum.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ReportCardBatchCurriculum> reportcardbatchcurriculumCollection = new ModelCollection<ReportCardBatchCurriculum> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    reportcardbatchcurriculumCollection.add((ReportCardBatchCurriculum) model);
        	}
        
        	return reportcardbatchcurriculumCollection;
        }

        public static ReportCardBatchCurriculum retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ReportCardBatchCurriculum.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ReportCardBatchCurriculum) gateway.retrieve(ResourceType.REPORT_CARD_BATCH_CURRICULUM, id);
        }

        public NewReportCardBatch getReportCardBatch ()
        {
            return (NewReportCardBatch) this.getProperty("reportCardBatch");
        }

        public void setReportCardBatch (NewReportCardBatch reportCardBatch)
        {
            this.setProperty("reportCardBatch", reportCardBatch);
        }

        public int getOrder ()
        {
            return Convert.ToInt32(this.getProperty("order"));
        }

        public void setOrder (int order)
        {
            this.setProperty("order", order);
        }

        public Curriculum getCurriculum ()
        {
            return (Curriculum) this.getProperty("curriculum");
        }

        public void setCurriculum (Curriculum curriculum)
        {
            this.setProperty("curriculum", curriculum);
        }

        public bool getIncludeStatements ()
        {
            return (bool) this.getProperty("includeStatements");
        }

        public void setIncludeStatements (bool includeStatements)
        {
            this.setProperty("includeStatements", includeStatements);
        }

        public AchievementLevel getLowerAchievementLevel ()
        {
            return (AchievementLevel) this.getProperty("lowerAchievementLevel");
        }

        public void setLowerAchievementLevel (AchievementLevel lowerAchievementLevel)
        {
            this.setProperty("lowerAchievementLevel", lowerAchievementLevel);
        }

        public float getLowerAchievementValue ()
        {
            return (float) this.getProperty("lowerAchievementValue");
        }

        public void setLowerAchievementValue (float lowerAchievementValue)
        {
            this.setProperty("lowerAchievementValue", lowerAchievementValue);
        }

        public AchievementLevel getUpperAchievementLevel ()
        {
            return (AchievementLevel) this.getProperty("upperAchievementLevel");
        }

        public void setUpperAchievementLevel (AchievementLevel upperAchievementLevel)
        {
            this.setProperty("upperAchievementLevel", upperAchievementLevel);
        }

        public float getUpperAchievementValue ()
        {
            return (float) this.getProperty("upperAchievementValue");
        }

        public void setUpperAchievementValue (float upperAchievementValue)
        {
            this.setProperty("upperAchievementValue", upperAchievementValue);
        }

        public string getReportingMode ()
        {
            return this.getProperty("reportingMode").ToString();
        }

        public void setReportingMode (string reportingMode)
        {
            this.setProperty("reportingMode", reportingMode);
        }

        public bool getIncludeSummativeGrade ()
        {
            return (bool) this.getProperty("includeSummativeGrade");
        }

        public void setIncludeSummativeGrade (bool includeSummativeGrade)
        {
            this.setProperty("includeSummativeGrade", includeSummativeGrade);
        }

        public string getSummativeGradeType ()
        {
            return this.getProperty("summativeGradeType").ToString();
        }

        public void setSummativeGradeType (string summativeGradeType)
        {
            this.setProperty("summativeGradeType", summativeGradeType);
        }

        public AchievementLevelSet getSummativeGradeAchievementLevelSet ()
        {
            return (AchievementLevelSet) this.getProperty("summativeGradeAchievementLevelSet");
        }

        public void setSummativeGradeAchievementLevelSet (AchievementLevelSet summativeGradeAchievementLevelSet)
        {
            this.setProperty("summativeGradeAchievementLevelSet", summativeGradeAchievementLevelSet);
        }


    }
}

