using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AdHocAssessment : ModelBase
    {
        protected new string resourceType = ResourceType.AD_HOC_ASSESSMENT;
        public const string AD_HOC_ASSESSMENT_CATEGORY = "adHocAssessmentCategory";
        public const string ASSESSMENT_NAME = "assessmentName";
        public const string ASSESSMENT_CODE = "assessmentCode";
        public const string MARK_DATA_TYPE = "markDataType";
        public const string GRADE_SET = "gradeSet";
        public const string NUMBER_FORMAT = "numberFormat";
        public const string NUMBER_UNIT = "numberUnit";
        public const string CURRICULUM_TIER = "curriculumTier";
        public const string CURRICULUM_GRADE = "curriculumGrade";
        public const string SUBJECT = "subject";
        public const string ASSESSMENT_STRATEGY = "assessmentStrategy";

        public AdHocAssessment()
        {
            base.resourceType = this.resourceType;
        }

        public AdHocAssessment(string resourceType = "AdHocAssessment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AdHocAssessment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AdHocAssessment");
            RestGateway gateway = (RestGateway)AdHocAssessment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AdHocAssessment> adhocassessmentCollection = new ModelCollection<AdHocAssessment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                adhocassessmentCollection.add((AdHocAssessment)model);
            }

            return adhocassessmentCollection;
        }

        public static AdHocAssessment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AdHocAssessment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AdHocAssessment)gateway.retrieve(ResourceType.AD_HOC_ASSESSMENT, id);
        }

        public AdHocAssessmentCategory getAdHocAssessmentCategory()
        {
            return (AdHocAssessmentCategory)this.getProperty("adHocAssessmentCategory");
        }

        public void setAdHocAssessmentCategory(AdHocAssessmentCategory adHocAssessmentCategory)
        {
            this.setProperty("adHocAssessmentCategory", adHocAssessmentCategory);
        }

        public string getAssessmentName()
        {
            return this.getProperty("assessmentName").ToString();
        }

        public void setAssessmentName(string assessmentName)
        {
            this.setProperty("assessmentName", assessmentName);
        }

        public string getAssessmentCode()
        {
            return this.getProperty("assessmentCode").ToString();
        }

        public void setAssessmentCode(string assessmentCode)
        {
            this.setProperty("assessmentCode", assessmentCode);
        }

        public string getMarkDataType()
        {
            return this.getProperty("markDataType").ToString();
        }

        public void setMarkDataType(string markDataType)
        {
            this.setProperty("markDataType", markDataType);
        }

        public GradeSet getGradeSet()
        {
            return (GradeSet)this.getProperty("gradeSet");
        }

        public void setGradeSet(GradeSet gradeSet)
        {
            this.setProperty("gradeSet", gradeSet);
        }

        public string getNumberFormat()
        {
            return this.getProperty("numberFormat").ToString();
        }

        public void setNumberFormat(string numberFormat)
        {
            this.setProperty("numberFormat", numberFormat);
        }

        public string getNumberUnit()
        {
            return this.getProperty("numberUnit").ToString();
        }

        public void setNumberUnit(string numberUnit)
        {
            this.setProperty("numberUnit", numberUnit);
        }

        public CurriculumTier getCurriculumTier()
        {
            return (CurriculumTier)this.getProperty("curriculumTier");
        }

        public void setCurriculumTier(CurriculumTier curriculumTier)
        {
            this.setProperty("curriculumTier", curriculumTier);
        }

        public CurriculumGrade getCurriculumGrade()
        {
            return (CurriculumGrade)this.getProperty("curriculumGrade");
        }

        public void setCurriculumGrade(CurriculumGrade curriculumGrade)
        {
            this.setProperty("curriculumGrade", curriculumGrade);
        }

        public Subject getSubject()
        {
            return (Subject)this.getProperty("subject");
        }

        public void setSubject(Subject subject)
        {
            this.setProperty("subject", subject);
        }

        public string getAssessmentStrategy()
        {
            return this.getProperty("assessmentStrategy").ToString();
        }

        public void setAssessmentStrategy(string assessmentStrategy)
        {
            this.setProperty("assessmentStrategy", assessmentStrategy);
        }


    }
}

