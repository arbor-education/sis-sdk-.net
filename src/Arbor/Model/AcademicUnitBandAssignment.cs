using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicUnitBandAssignment : ModelBase
    {
        protected new string resourceType = ResourceType.ACADEMIC_UNIT_BAND_ASSIGNMENT;
        public const string ACADEMIC_UNIT = "academicUnit";
        public const string BAND_NAME = "bandName";

        public AcademicUnitBandAssignment()
        {
            base.resourceType = this.resourceType;
        }

        public AcademicUnitBandAssignment(string resourceType = "AcademicUnitBandAssignment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AcademicUnitBandAssignment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AcademicUnitBandAssignment");
            RestGateway gateway = (RestGateway)AcademicUnitBandAssignment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AcademicUnitBandAssignment> academicunitbandassignmentCollection = new ModelCollection<AcademicUnitBandAssignment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                academicunitbandassignmentCollection.add((AcademicUnitBandAssignment)model);
            }

            return academicunitbandassignmentCollection;
        }

        public static AcademicUnitBandAssignment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AcademicUnitBandAssignment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AcademicUnitBandAssignment)gateway.retrieve(ResourceType.ACADEMIC_UNIT_BAND_ASSIGNMENT, id);
        }

        public AcademicUnit getAcademicUnit()
        {
            return (AcademicUnit)this.getProperty("academicUnit");
        }

        public void setAcademicUnit(AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }

        public string getBandName()
        {
            return this.getProperty("bandName").ToString();
        }

        public void setBandName(string bandName)
        {
            this.setProperty("bandName", bandName);
        }


    }
}

