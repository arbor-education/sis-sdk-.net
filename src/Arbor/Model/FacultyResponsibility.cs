using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class FacultyResponsibility : ModelBase
    {
        protected string resourceType = ResourceType.FACULTY_RESPONSIBILITY;
        public const string FACULTY_RESPONSIBILITY_TYPE = "facultyResponsibilityType";
        public const string FACULTY = "faculty";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public FacultyResponsibility()
        {
            base.resourceType = this.resourceType;
        }

        public FacultyResponsibility(string resourceType = "FacultyResponsibility", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<FacultyResponsibility> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("FacultyResponsibility");
            RestGateway gateway = (RestGateway)FacultyResponsibility.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<FacultyResponsibility> facultyresponsibilityCollection = new ModelCollection<FacultyResponsibility>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                facultyresponsibilityCollection.add((FacultyResponsibility)model);
            }

            return facultyresponsibilityCollection;
        }

        public static FacultyResponsibility retrieve(string id)
        {
            RestGateway gateway = (RestGateway)FacultyResponsibility.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (FacultyResponsibility)gateway.retrieve(ResourceType.FACULTY_RESPONSIBILITY, id);
        }

        public FacultyResponsibilityType getFacultyResponsibilityType()
        {
            return (FacultyResponsibilityType)this.getProperty("facultyResponsibilityType");
        }

        public void setFacultyResponsibilityType(FacultyResponsibilityType facultyResponsibilityType)
        {
            this.setProperty("facultyResponsibilityType", facultyResponsibilityType);
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

