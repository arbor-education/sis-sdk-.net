using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentGradeSet : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_GRADE_SET;
        public const string ASSESSMENT = "assessment";
        public const string GRADE_SET = "gradeSet";
        public const string IS_DEFAULT = "isDefault";
        public const string IS_ORIGINAL = "isOriginal";

        public AssessmentGradeSet()
        {
            base.resourceType = this.resourceType;
        }

        public AssessmentGradeSet(string resourceType = "AssessmentGradeSet", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AssessmentGradeSet> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AssessmentGradeSet");
            RestGateway gateway = (RestGateway)AssessmentGradeSet.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AssessmentGradeSet> assessmentgradesetCollection = new ModelCollection<AssessmentGradeSet>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                assessmentgradesetCollection.add((AssessmentGradeSet)model);
            }

            return assessmentgradesetCollection;
        }

        public static AssessmentGradeSet retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AssessmentGradeSet.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AssessmentGradeSet)gateway.retrieve(ResourceType.ASSESSMENT_GRADE_SET, id);
        }

        public Assessment getAssessment()
        {
            return (Assessment)this.getProperty("assessment");
        }

        public void setAssessment(Assessment assessment)
        {
            this.setProperty("assessment", assessment);
        }

        public GradeSet getGradeSet()
        {
            return (GradeSet)this.getProperty("gradeSet");
        }

        public void setGradeSet(GradeSet gradeSet)
        {
            this.setProperty("gradeSet", gradeSet);
        }

        public bool getIsDefault()
        {
            return Convert.ToBoolean(this.getProperty("isDefault"));
        }

        public void setIsDefault(bool isDefault)
        {
            this.setProperty("isDefault", isDefault);
        }

        public bool getIsOriginal()
        {
            return Convert.ToBoolean(this.getProperty("isOriginal"));
        }

        public void setIsOriginal(bool isOriginal)
        {
            this.setProperty("isOriginal", isOriginal);
        }


    }
}

