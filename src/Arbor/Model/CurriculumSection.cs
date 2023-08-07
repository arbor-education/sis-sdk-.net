using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CurriculumSection : ModelBase
    {
        protected new string resourceType = ResourceType.CURRICULUM_SECTION;
        public const string CURRICULUM = "curriculum";
        public const string CODE = "code";
        public const string NAME = "name";
        public const string SHORT_NAME = "shortName";
        public const string PARENT_CURRICULUM_SECTION = "parentCurriculumSection";
        public const string ASSESSMENT = "assessment";
        public const string WEIGHTING = "weighting";

        public CurriculumSection()
        {
            base.resourceType = this.resourceType;
        }

        public CurriculumSection(string resourceType = "CurriculumSection", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CurriculumSection> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CurriculumSection");
            RestGateway gateway = (RestGateway)CurriculumSection.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CurriculumSection> curriculumsectionCollection = new ModelCollection<CurriculumSection>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                curriculumsectionCollection.add((CurriculumSection)model);
            }

            return curriculumsectionCollection;
        }

        public static CurriculumSection retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CurriculumSection.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CurriculumSection)gateway.retrieve(ResourceType.CURRICULUM_SECTION, id);
        }

        public Curriculum getCurriculum()
        {
            return (Curriculum)this.getProperty("curriculum");
        }

        public void setCurriculum(Curriculum curriculum)
        {
            this.setProperty("curriculum", curriculum);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
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

        public CurriculumSection getParentCurriculumSection()
        {
            return (CurriculumSection)this.getProperty("parentCurriculumSection");
        }

        public void setParentCurriculumSection(CurriculumSection parentCurriculumSection)
        {
            this.setProperty("parentCurriculumSection", parentCurriculumSection);
        }

        public Assessment getAssessment()
        {
            return (Assessment)this.getProperty("assessment");
        }

        public void setAssessment(Assessment assessment)
        {
            this.setProperty("assessment", assessment);
        }

        public float getWeighting()
        {
            return (float)this.getProperty("weighting");
        }

        public void setWeighting(float weighting)
        {
            this.setProperty("weighting", weighting);
        }


    }
}

