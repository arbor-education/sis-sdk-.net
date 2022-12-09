using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CurriculumStatement : ModelBase
    {
        protected new string resourceType = ResourceType.CURRICULUM_STATEMENT;
        public const string CURRICULUM_SECTION = "curriculumSection";
        public const string CURRICULUM_STATEMENT_BAND = "curriculumStatementBand";
        public const string CODE = "code";
        public const string NAME = "name";
        public const string SHORT_NAME = "shortName";
        public const string DESCRIPTION = "description";
        public const string EXAMPLES = "examples";
        public const string WEIGHTING = "weighting";
        public const string REQUIREMENT_FOR_HIGHER = "requirementForHigher";
        public const string ORDER = "order";

        public CurriculumStatement()
        {
            base.resourceType = this.resourceType;
        }

        public CurriculumStatement(string resourceType = "CurriculumStatement", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CurriculumStatement> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CurriculumStatement");
            RestGateway gateway = (RestGateway)CurriculumStatement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CurriculumStatement> curriculumstatementCollection = new ModelCollection<CurriculumStatement>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                curriculumstatementCollection.add((CurriculumStatement)model);
            }

            return curriculumstatementCollection;
        }

        public static CurriculumStatement retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CurriculumStatement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CurriculumStatement)gateway.retrieve(ResourceType.CURRICULUM_STATEMENT, id);
        }

        public CurriculumSection getCurriculumSection()
        {
            return (CurriculumSection)this.getProperty("curriculumSection");
        }

        public void setCurriculumSection(CurriculumSection curriculumSection)
        {
            this.setProperty("curriculumSection", curriculumSection);
        }

        public CurriculumStatementBand getCurriculumStatementBand()
        {
            return (CurriculumStatementBand)this.getProperty("curriculumStatementBand");
        }

        public void setCurriculumStatementBand(CurriculumStatementBand curriculumStatementBand)
        {
            this.setProperty("curriculumStatementBand", curriculumStatementBand);
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

        public string getDescription()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription(string description)
        {
            this.setProperty("description", description);
        }

        public string getExamples()
        {
            return this.getProperty("examples").ToString();
        }

        public void setExamples(string examples)
        {
            this.setProperty("examples", examples);
        }

        public float getWeighting()
        {
            return (float)this.getProperty("weighting");
        }

        public void setWeighting(float weighting)
        {
            this.setProperty("weighting", weighting);
        }

        public bool getRequirementForHigher()
        {
            return Convert.ToBoolean(this.getProperty("requirementForHigher"));
        }

        public void setRequirementForHigher(bool requirementForHigher)
        {
            this.setProperty("requirementForHigher", requirementForHigher);
        }

        public int getOrder()
        {
            return Convert.ToInt32(this.getProperty("order"));
        }

        public void setOrder(int order)
        {
            this.setProperty("order", order);
        }


    }
}

