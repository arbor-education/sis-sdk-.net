using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SchoolProgressTargetRule : ModelBase
    {
        protected new string resourceType = ResourceType.SCHOOL_PROGRESS_TARGET_RULE;
        public const string RULE_NAME = "ruleName";
        public const string ASSESSMENT = "assessment";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string CURRICULUM_GRADE = "curriculumGrade";
        public const string TERM_NUMBER = "termNumber";
        public const string PROGRESS_AMOUNT = "progressAmount";
        public const string PROGRESS_AMOUNT_UNIT = "progressAmountUnit";
        public const string PROGRESS_REFERENCE_MARK_TYPE = "progressReferenceMarkType";
        public const string ACADEMIC_YEARS_OFFSET = "academicYearsOffset";
        public const string HAS_SAME_ATTAINMENT_TARGET_FOR_EACH_PERIOD = "hasSameAttainmentTargetForEachPeriod";

        public SchoolProgressTargetRule()
        {
            base.resourceType = this.resourceType;
        }

        public SchoolProgressTargetRule(string resourceType = "SchoolProgressTargetRule", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SchoolProgressTargetRule> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("SchoolProgressTargetRule");
            RestGateway gateway = (RestGateway)SchoolProgressTargetRule.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SchoolProgressTargetRule> schoolprogresstargetruleCollection = new ModelCollection<SchoolProgressTargetRule>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                schoolprogresstargetruleCollection.add((SchoolProgressTargetRule)model);
            }

            return schoolprogresstargetruleCollection;
        }

        public static SchoolProgressTargetRule retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SchoolProgressTargetRule.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SchoolProgressTargetRule)gateway.retrieve(ResourceType.SCHOOL_PROGRESS_TARGET_RULE, id);
        }

        public string getRuleName()
        {
            return this.getProperty("ruleName").ToString();
        }

        public void setRuleName(string ruleName)
        {
            this.setProperty("ruleName", ruleName);
        }

        public Assessment getAssessment()
        {
            return (Assessment)this.getProperty("assessment");
        }

        public void setAssessment(Assessment assessment)
        {
            this.setProperty("assessment", assessment);
        }

        public DateTime getEffectiveDate()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate(DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate(DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public CurriculumGrade getCurriculumGrade()
        {
            return (CurriculumGrade)this.getProperty("curriculumGrade");
        }

        public void setCurriculumGrade(CurriculumGrade curriculumGrade)
        {
            this.setProperty("curriculumGrade", curriculumGrade);
        }

        public int getTermNumber()
        {
            return Convert.ToInt32(this.getProperty("termNumber"));
        }

        public void setTermNumber(int termNumber)
        {
            this.setProperty("termNumber", termNumber);
        }

        public float getProgressAmount()
        {
            return (float)this.getProperty("progressAmount");
        }

        public void setProgressAmount(float progressAmount)
        {
            this.setProperty("progressAmount", progressAmount);
        }

        public string getProgressAmountUnit()
        {
            return this.getProperty("progressAmountUnit").ToString();
        }

        public void setProgressAmountUnit(string progressAmountUnit)
        {
            this.setProperty("progressAmountUnit", progressAmountUnit);
        }

        public string getProgressReferenceMarkType()
        {
            return this.getProperty("progressReferenceMarkType").ToString();
        }

        public void setProgressReferenceMarkType(string progressReferenceMarkType)
        {
            this.setProperty("progressReferenceMarkType", progressReferenceMarkType);
        }

        public int getAcademicYearsOffset()
        {
            return Convert.ToInt32(this.getProperty("academicYearsOffset"));
        }

        public void setAcademicYearsOffset(int academicYearsOffset)
        {
            this.setProperty("academicYearsOffset", academicYearsOffset);
        }

        public bool getHasSameAttainmentTargetForEachPeriod()
        {
            return Convert.ToBoolean(this.getProperty("hasSameAttainmentTargetForEachPeriod"));
        }

        public void setHasSameAttainmentTargetForEachPeriod(bool hasSameAttainmentTargetForEachPeriod)
        {
            this.setProperty("hasSameAttainmentTargetForEachPeriod", hasSameAttainmentTargetForEachPeriod);
        }


    }
}

