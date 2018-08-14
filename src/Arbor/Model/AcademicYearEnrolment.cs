using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicYearEnrolment : ModelBase
    {
        protected string resourceType = ResourceType.ACADEMIC_YEAR_ENROLMENT;
        public const string ACADEMIC_YEAR = "academicYear";
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string UNENROLMENT_REASON = "unenrolmentReason";
        public const string ENROLMENT_NOTES = "enrolmentNotes";

        public AcademicYearEnrolment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicYearEnrolment (string resourceType = "AcademicYearEnrolment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicYearEnrolment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicYearEnrolment");
        	RestGateway gateway = (RestGateway) AcademicYearEnrolment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicYearEnrolment> academicyearenrolmentCollection = new ModelCollection<AcademicYearEnrolment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academicyearenrolmentCollection.add((AcademicYearEnrolment) model);
        	}
        
        	return academicyearenrolmentCollection;
        }

        public static AcademicYearEnrolment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicYearEnrolment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicYearEnrolment) gateway.retrieve(ResourceType.ACADEMIC_YEAR_ENROLMENT, id);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getStartDate (){
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate (){
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public UnenrolmentReason getUnenrolmentReason ()
        {
            return (UnenrolmentReason) this.getProperty("unenrolmentReason");
        }

        public void setUnenrolmentReason (UnenrolmentReason unenrolmentReason)
        {
            this.setProperty("unenrolmentReason", unenrolmentReason);
        }

        public string getEnrolmentNotes ()
        {
            return this.getProperty("enrolmentNotes").ToString();
        }

        public void setEnrolmentNotes (string enrolmentNotes)
        {
            this.setProperty("enrolmentNotes", enrolmentNotes);
        }


    }
}

