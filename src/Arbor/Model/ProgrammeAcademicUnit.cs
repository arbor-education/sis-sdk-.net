using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProgrammeAcademicUnit : ModelBase
    {
        protected string resourceType = ResourceType.PROGRAMME_ACADEMIC_UNIT;
        public const string PROGRAMME_INSTANCE = "programmeInstance";
        public const string ACADEMIC_UNIT = "academicUnit";

        public ProgrammeAcademicUnit()
        {
            base.resourceType = this.resourceType;
        }

        public ProgrammeAcademicUnit(string resourceType = "ProgrammeAcademicUnit", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ProgrammeAcademicUnit> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ProgrammeAcademicUnit");
            RestGateway gateway = (RestGateway)ProgrammeAcademicUnit.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ProgrammeAcademicUnit> programmeacademicunitCollection = new ModelCollection<ProgrammeAcademicUnit>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                programmeacademicunitCollection.add((ProgrammeAcademicUnit)model);
            }

            return programmeacademicunitCollection;
        }

        public static ProgrammeAcademicUnit retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ProgrammeAcademicUnit.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ProgrammeAcademicUnit)gateway.retrieve(ResourceType.PROGRAMME_ACADEMIC_UNIT, id);
        }

        public ProgrammeInstance getProgrammeInstance()
        {
            return (ProgrammeInstance)this.getProperty("programmeInstance");
        }

        public void setProgrammeInstance(ProgrammeInstance programmeInstance)
        {
            this.setProperty("programmeInstance", programmeInstance);
        }

        public AcademicUnit getAcademicUnit()
        {
            return (AcademicUnit)this.getProperty("academicUnit");
        }

        public void setAcademicUnit(AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }


    }
}

