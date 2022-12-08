using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;
using System.Collections;

namespace Arbor.Model
{
    public class AcademicProgrammeInstance : ModelBase
    {
        protected string resourceType = ResourceType.ACADEMIC_PROGRAMME_INSTANCE;
        public const string ACADEMIC_PROGRAMME = "academicProgramme";
        public const string INSTANCE_NAME = "instanceName";
        public const string ACADEMIC_YEAR = "academicYear";

        public AcademicProgrammeInstance()
        {
            base.resourceType = this.resourceType;
        }

        public AcademicProgrammeInstance(string resourceType = "AcademicProgrammeInstance", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AcademicProgrammeInstance> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AcademicProgrammeInstance");
            RestGateway gateway = (RestGateway)AcademicProgrammeInstance.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AcademicProgrammeInstance> academicprogrammeinstanceCollection = new ModelCollection<AcademicProgrammeInstance>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                academicprogrammeinstanceCollection.add((AcademicProgrammeInstance)model);
            }

            return academicprogrammeinstanceCollection;
        }

        public static AcademicProgrammeInstance retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AcademicProgrammeInstance.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AcademicProgrammeInstance)gateway.retrieve(ResourceType.ACADEMIC_PROGRAMME_INSTANCE, id);
        }

        public AcademicProgramme getAcademicProgramme()
        {
            return (AcademicProgramme)this.getProperty("academicProgramme");
        }

        public void setAcademicProgramme(AcademicProgramme academicProgramme)
        {
            this.setProperty("academicProgramme", academicProgramme);
        }

        public string getInstanceName()
        {
            return this.getProperty("instanceName").ToString();
        }

        public void setInstanceName(string instanceName)
        {
            this.setProperty("instanceName", instanceName);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public ModelCollection<AcademicUnit> getTopLevelAcademicUnits()
        {
            ModelCollection<ModelBase> collection = (ModelCollection<ModelBase>)this.getCollectionProperty("topLevelAcademicUnits");
            return (ModelCollection<AcademicUnit>)this.getApiGateway().castCollection<AcademicUnit>(collection);
        }


    }
}

