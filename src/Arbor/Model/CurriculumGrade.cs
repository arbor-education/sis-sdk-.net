using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CurriculumGrade : ModelBase
    {
        protected new string resourceType = ResourceType.CURRICULUM_GRADE;
        public const string D00020 = "d00020";
        public const string D00020_ORDER = "d00020Order";
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string CURRICULUM_GRADE_NAME = "curriculumGradeName";
        public const string CURRICULUM_TIER = "curriculumTier";
        public const string ACADEMIC_YEAR_INDEX = "academicYearIndex";
        public const string MINIMUM_AGE_AT_START = "minimumAgeAtStart";
        public const string MAXIMUM_AGE_AT_START = "maximumAgeAtStart";

        public CurriculumGrade()
        {
            base.resourceType = this.resourceType;
        }

        public CurriculumGrade(string resourceType = "CurriculumGrade", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CurriculumGrade> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CurriculumGrade");
            RestGateway gateway = (RestGateway)CurriculumGrade.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CurriculumGrade> curriculumgradeCollection = new ModelCollection<CurriculumGrade>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                curriculumgradeCollection.add((CurriculumGrade)model);
            }

            return curriculumgradeCollection;
        }

        public static CurriculumGrade retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CurriculumGrade.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CurriculumGrade)gateway.retrieve(ResourceType.CURRICULUM_GRADE, id);
        }

        public string getD00020()
        {
            return this.getProperty("d00020").ToString();
        }

        public void setD00020(string d00020)
        {
            this.setProperty("d00020", d00020);
        }

        public int getD00020Order()
        {
            return Convert.ToInt32(this.getProperty("d00020Order"));
        }

        public void setD00020Order(int d00020Order)
        {
            this.setProperty("d00020Order", d00020Order);
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

        public string getCurriculumGradeName()
        {
            return this.getProperty("curriculumGradeName").ToString();
        }

        public void setCurriculumGradeName(string curriculumGradeName)
        {
            this.setProperty("curriculumGradeName", curriculumGradeName);
        }

        public CurriculumTier getCurriculumTier()
        {
            return (CurriculumTier)this.getProperty("curriculumTier");
        }

        public void setCurriculumTier(CurriculumTier curriculumTier)
        {
            this.setProperty("curriculumTier", curriculumTier);
        }

        public int getAcademicYearIndex()
        {
            return Convert.ToInt32(this.getProperty("academicYearIndex"));
        }

        public void setAcademicYearIndex(int academicYearIndex)
        {
            this.setProperty("academicYearIndex", academicYearIndex);
        }

        public float getMinimumAgeAtStart()
        {
            return (float)this.getProperty("minimumAgeAtStart");
        }

        public void setMinimumAgeAtStart(float minimumAgeAtStart)
        {
            this.setProperty("minimumAgeAtStart", minimumAgeAtStart);
        }

        public float getMaximumAgeAtStart()
        {
            return (float)this.getProperty("maximumAgeAtStart");
        }

        public void setMaximumAgeAtStart(float maximumAgeAtStart)
        {
            this.setProperty("maximumAgeAtStart", maximumAgeAtStart);
        }


    }
}

