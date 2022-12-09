using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicUnitDepartment : ModelBase
    {
        protected new string resourceType = ResourceType.ACADEMIC_UNIT_DEPARTMENT;
        public const string DEPARTMENT = "department";
        public const string ACADEMIC_UNIT = "academicUnit";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public AcademicUnitDepartment()
        {
            base.resourceType = this.resourceType;
        }

        public AcademicUnitDepartment(string resourceType = "AcademicUnitDepartment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AcademicUnitDepartment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AcademicUnitDepartment");
            RestGateway gateway = (RestGateway)AcademicUnitDepartment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AcademicUnitDepartment> academicunitdepartmentCollection = new ModelCollection<AcademicUnitDepartment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                academicunitdepartmentCollection.add((AcademicUnitDepartment)model);
            }

            return academicunitdepartmentCollection;
        }

        public static AcademicUnitDepartment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AcademicUnitDepartment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AcademicUnitDepartment)gateway.retrieve(ResourceType.ACADEMIC_UNIT_DEPARTMENT, id);
        }

        public Department getDepartment()
        {
            return (Department)this.getProperty("department");
        }

        public void setDepartment(Department department)
        {
            this.setProperty("department", department);
        }

        public AcademicUnit getAcademicUnit()
        {
            return (AcademicUnit)this.getProperty("academicUnit");
        }

        public void setAcademicUnit(AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }

        public DateTime getStartDate()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate(DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate(DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

