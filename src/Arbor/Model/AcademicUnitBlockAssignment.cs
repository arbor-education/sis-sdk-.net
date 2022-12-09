using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicUnitBlockAssignment : ModelBase
    {
        protected new string resourceType = ResourceType.ACADEMIC_UNIT_BLOCK_ASSIGNMENT;
        public const string ACADEMIC_UNIT = "academicUnit";
        public const string BLOCK_NAME = "blockName";

        public AcademicUnitBlockAssignment()
        {
            base.resourceType = this.resourceType;
        }

        public AcademicUnitBlockAssignment(string resourceType = "AcademicUnitBlockAssignment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AcademicUnitBlockAssignment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AcademicUnitBlockAssignment");
            RestGateway gateway = (RestGateway)AcademicUnitBlockAssignment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AcademicUnitBlockAssignment> academicunitblockassignmentCollection = new ModelCollection<AcademicUnitBlockAssignment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                academicunitblockassignmentCollection.add((AcademicUnitBlockAssignment)model);
            }

            return academicunitblockassignmentCollection;
        }

        public static AcademicUnitBlockAssignment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AcademicUnitBlockAssignment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AcademicUnitBlockAssignment)gateway.retrieve(ResourceType.ACADEMIC_UNIT_BLOCK_ASSIGNMENT, id);
        }

        public AcademicUnit getAcademicUnit()
        {
            return (AcademicUnit)this.getProperty("academicUnit");
        }

        public void setAcademicUnit(AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }

        public string getBlockName()
        {
            return this.getProperty("blockName").ToString();
        }

        public void setBlockName(string blockName)
        {
            this.setProperty("blockName", blockName);
        }


    }
}

