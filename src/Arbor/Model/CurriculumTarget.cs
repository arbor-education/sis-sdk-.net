using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CurriculumTarget : ModelBase
    {
        protected string resourceType = ResourceType.CURRICULUM_TARGET;
        public const string CURRICULUM_TARGET_SET = "curriculumTargetSet";
        public const string ACADEMIC_YEAR_INDEX = "academicYearIndex";
        public const string ACADEMIC_YEAR_POINT = "academicYearPoint";
        public const string TARGET = "target";

        public CurriculumTarget()
        {
            base.resourceType = this.resourceType;
        }

        public CurriculumTarget(string resourceType = "CurriculumTarget", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CurriculumTarget> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CurriculumTarget");
            RestGateway gateway = (RestGateway)CurriculumTarget.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CurriculumTarget> curriculumtargetCollection = new ModelCollection<CurriculumTarget>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                curriculumtargetCollection.add((CurriculumTarget)model);
            }

            return curriculumtargetCollection;
        }

        public static CurriculumTarget retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CurriculumTarget.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CurriculumTarget)gateway.retrieve(ResourceType.CURRICULUM_TARGET, id);
        }

        public CurriculumTargetSet getCurriculumTargetSet()
        {
            return (CurriculumTargetSet)this.getProperty("curriculumTargetSet");
        }

        public void setCurriculumTargetSet(CurriculumTargetSet curriculumTargetSet)
        {
            this.setProperty("curriculumTargetSet", curriculumTargetSet);
        }

        public int getAcademicYearIndex()
        {
            return Convert.ToInt32(this.getProperty("academicYearIndex"));
        }

        public void setAcademicYearIndex(int academicYearIndex)
        {
            this.setProperty("academicYearIndex", academicYearIndex);
        }

        public float getAcademicYearPoint()
        {
            return (float)this.getProperty("academicYearPoint");
        }

        public void setAcademicYearPoint(float academicYearPoint)
        {
            this.setProperty("academicYearPoint", academicYearPoint);
        }

        public float getTarget()
        {
            return (float)this.getProperty("target");
        }

        public void setTarget(float target)
        {
            this.setProperty("target", target);
        }


    }
}

