using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicUnitCohortMembership : ModelBase
    {
        protected string resourceType = ResourceType.ACADEMIC_UNIT_COHORT_MEMBERSHIP;
        public const string ACADEMIC_UNIT_COHORT = "academicUnitCohort";
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public AcademicUnitCohortMembership()
        {
            base.resourceType = this.resourceType;
        }

        public AcademicUnitCohortMembership(string resourceType = "AcademicUnitCohortMembership", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AcademicUnitCohortMembership> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AcademicUnitCohortMembership");
            RestGateway gateway = (RestGateway)AcademicUnitCohortMembership.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AcademicUnitCohortMembership> academicunitcohortmembershipCollection = new ModelCollection<AcademicUnitCohortMembership>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                academicunitcohortmembershipCollection.add((AcademicUnitCohortMembership)model);
            }

            return academicunitcohortmembershipCollection;
        }

        public static AcademicUnitCohortMembership retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AcademicUnitCohortMembership.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AcademicUnitCohortMembership)gateway.retrieve(ResourceType.ACADEMIC_UNIT_COHORT_MEMBERSHIP, id);
        }

        public AcademicUnitCohort getAcademicUnitCohort()
        {
            return (AcademicUnitCohort)this.getProperty("academicUnitCohort");
        }

        public void setAcademicUnitCohort(AcademicUnitCohort academicUnitCohort)
        {
            this.setProperty("academicUnitCohort", academicUnitCohort);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getStartDate()
        {
            return (DateTime)this.getProperty("startDate");
        }

        public void setStartDate(DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate()
        {
            return (DateTime)this.getProperty("endDate");
        }

        public void setEndDate(DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

