using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicUnitCurriculum : ModelBase
    {
        protected string resourceType = ResourceType.ACADEMIC_UNIT_CURRICULUM;
        public const string ACADEMIC_UNIT = "academicUnit";
        public const string CURRICULUM = "curriculum";

        public AcademicUnitCurriculum()
        {
            base.resourceType = this.resourceType;
        }

        public AcademicUnitCurriculum(string resourceType = "AcademicUnitCurriculum", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AcademicUnitCurriculum> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AcademicUnitCurriculum");
            RestGateway gateway = (RestGateway)AcademicUnitCurriculum.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AcademicUnitCurriculum> academicunitcurriculumCollection = new ModelCollection<AcademicUnitCurriculum>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                academicunitcurriculumCollection.add((AcademicUnitCurriculum)model);
            }

            return academicunitcurriculumCollection;
        }

        public static AcademicUnitCurriculum retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AcademicUnitCurriculum.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AcademicUnitCurriculum)gateway.retrieve(ResourceType.ACADEMIC_UNIT_CURRICULUM, id);
        }

        public AcademicUnit getAcademicUnit()
        {
            return (AcademicUnit)this.getProperty("academicUnit");
        }

        public void setAcademicUnit(AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }

        public Curriculum getCurriculum()
        {
            return (Curriculum)this.getProperty("curriculum");
        }

        public void setCurriculum(Curriculum curriculum)
        {
            this.setProperty("curriculum", curriculum);
        }


    }
}

