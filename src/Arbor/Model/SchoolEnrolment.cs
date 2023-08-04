using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SchoolEnrolment : ModelBase
    {
        protected string resourceType = ResourceType.SCHOOL_ENROLMENT;
        public const string ACADEMIC_YEAR = "academicYear";
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string ENROLMENT_MODE = "enrolmentMode";
        public const string UNENROLMENT_REASON = "unenrolmentReason";
        public const string ENROLMENT_NOTES = "enrolmentNotes";

        public SchoolEnrolment()
        {
            base.resourceType = this.resourceType;
        }

        public SchoolEnrolment(string resourceType = "SchoolEnrolment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SchoolEnrolment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("SchoolEnrolment");
            RestGateway gateway = (RestGateway)SchoolEnrolment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SchoolEnrolment> schoolenrolmentCollection = new ModelCollection<SchoolEnrolment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                schoolenrolmentCollection.add((SchoolEnrolment)model);
            }

            return schoolenrolmentCollection;
        }

        public static SchoolEnrolment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SchoolEnrolment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SchoolEnrolment)gateway.retrieve(ResourceType.SCHOOL_ENROLMENT, id);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
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

        public EnrolmentMode getEnrolmentMode()
        {
            return (EnrolmentMode)this.getProperty("enrolmentMode");
        }

        public void setEnrolmentMode(EnrolmentMode enrolmentMode)
        {
            this.setProperty("enrolmentMode", enrolmentMode);
        }

        public UnenrolmentReason getUnenrolmentReason()
        {
            return (UnenrolmentReason)this.getProperty("unenrolmentReason");
        }

        public void setUnenrolmentReason(UnenrolmentReason unenrolmentReason)
        {
            this.setProperty("unenrolmentReason", unenrolmentReason);
        }

        public string getEnrolmentNotes()
        {
            return this.getProperty("enrolmentNotes").ToString();
        }

        public void setEnrolmentNotes(string enrolmentNotes)
        {
            this.setProperty("enrolmentNotes", enrolmentNotes);
        }


    }
}

