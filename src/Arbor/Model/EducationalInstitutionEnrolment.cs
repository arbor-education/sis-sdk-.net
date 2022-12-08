using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EducationalInstitutionEnrolment : ModelBase
    {
        protected string resourceType = ResourceType.EDUCATIONAL_INSTITUTION_ENROLMENT;
        public const string STUDENT = "student";
        public const string ENTRY_DATE = "entryDate";
        public const string LEAVING_DATE = "leavingDate";
        public const string UNENROLMENT_REASON = "unenrolmentReason";

        public EducationalInstitutionEnrolment()
        {
            base.resourceType = this.resourceType;
        }

        public EducationalInstitutionEnrolment(string resourceType = "EducationalInstitutionEnrolment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EducationalInstitutionEnrolment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EducationalInstitutionEnrolment");
            RestGateway gateway = (RestGateway)EducationalInstitutionEnrolment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EducationalInstitutionEnrolment> educationalinstitutionenrolmentCollection = new ModelCollection<EducationalInstitutionEnrolment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                educationalinstitutionenrolmentCollection.add((EducationalInstitutionEnrolment)model);
            }

            return educationalinstitutionenrolmentCollection;
        }

        public static EducationalInstitutionEnrolment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EducationalInstitutionEnrolment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EducationalInstitutionEnrolment)gateway.retrieve(ResourceType.EDUCATIONAL_INSTITUTION_ENROLMENT, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getEntryDate()
        {
            return Convert.ToDateTime(this.getProperty("entryDate"));
        }

        public void setEntryDate(DateTime entryDate)
        {
            this.setProperty("entryDate", entryDate);
        }

        public DateTime getLeavingDate()
        {
            return Convert.ToDateTime(this.getProperty("leavingDate"));
        }

        public void setLeavingDate(DateTime leavingDate)
        {
            this.setProperty("leavingDate", leavingDate);
        }

        public UnenrolmentReason getUnenrolmentReason()
        {
            return (UnenrolmentReason)this.getProperty("unenrolmentReason");
        }

        public void setUnenrolmentReason(UnenrolmentReason unenrolmentReason)
        {
            this.setProperty("unenrolmentReason", unenrolmentReason);
        }


    }
}

