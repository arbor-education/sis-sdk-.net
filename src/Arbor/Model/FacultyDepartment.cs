using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class FacultyDepartment : ModelBase
    {
        protected string resourceType = ResourceType.FACULTY_DEPARTMENT;
        public const string DEPARTMENT = "department";
        public const string FACULTY = "faculty";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public FacultyDepartment()
        {
            base.resourceType = this.resourceType;
        }

        public FacultyDepartment(string resourceType = "FacultyDepartment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<FacultyDepartment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("FacultyDepartment");
            RestGateway gateway = (RestGateway)FacultyDepartment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<FacultyDepartment> facultydepartmentCollection = new ModelCollection<FacultyDepartment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                facultydepartmentCollection.add((FacultyDepartment)model);
            }

            return facultydepartmentCollection;
        }

        public static FacultyDepartment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)FacultyDepartment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (FacultyDepartment)gateway.retrieve(ResourceType.FACULTY_DEPARTMENT, id);
        }

        public Department getDepartment()
        {
            return (Department)this.getProperty("department");
        }

        public void setDepartment(Department department)
        {
            this.setProperty("department", department);
        }

        public Faculty getFaculty()
        {
            return (Faculty)this.getProperty("faculty");
        }

        public void setFaculty(Faculty faculty)
        {
            this.setProperty("faculty", faculty);
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

