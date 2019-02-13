using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentEmploymentRecord : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_EMPLOYMENT_RECORD;
        public const string STUDENT = "student";
        public const string EMPLOYER = "employer";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string MIN_HOURS_PER_WEEK = "minHoursPerWeek";
        public const string MAX_HOURS_PER_WEEK = "maxHoursPerWeek";
        public const string INFORMATION_COLLECTED_DATE = "informationCollectedDate";
        public const string EMPLOYMENT_RECORD_TYPE = "employmentRecordType";

        public StudentEmploymentRecord ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentEmploymentRecord (string resourceType = "StudentEmploymentRecord", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentEmploymentRecord> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentEmploymentRecord");
        	RestGateway gateway = (RestGateway) StudentEmploymentRecord.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentEmploymentRecord> studentemploymentrecordCollection = new ModelCollection<StudentEmploymentRecord> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentemploymentrecordCollection.add((StudentEmploymentRecord) model);
        	}
        
        	return studentemploymentrecordCollection;
        }

        public static StudentEmploymentRecord retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentEmploymentRecord.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentEmploymentRecord) gateway.retrieve(ResourceType.STUDENT_EMPLOYMENT_RECORD, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public Employer getEmployer ()
        {
            return (Employer) this.getProperty("employer");
        }

        public void setEmployer (Employer employer)
        {
            this.setProperty("employer", employer);
        }

        public DateTime getStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("startDate"))
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getMinHoursPerWeek ()
        {
            return this.getProperty("minHoursPerWeek").ToString();
        }

        public void setMinHoursPerWeek (string minHoursPerWeek)
        {
            this.setProperty("minHoursPerWeek", minHoursPerWeek);
        }

        public string getMaxHoursPerWeek ()
        {
            return this.getProperty("maxHoursPerWeek").ToString();
        }

        public void setMaxHoursPerWeek (string maxHoursPerWeek)
        {
            this.setProperty("maxHoursPerWeek", maxHoursPerWeek);
        }

        public DateTime getInformationCollectedDate ()
        {
            return Convert.ToDateTime(this.getProperty("informationCollectedDate"))
        }

        public void setInformationCollectedDate (DateTime informationCollectedDate)
        {
            this.setProperty("informationCollectedDate", informationCollectedDate);
        }

        public EmploymentRecordType getEmploymentRecordType ()
        {
            return (EmploymentRecordType) this.getProperty("employmentRecordType");
        }

        public void setEmploymentRecordType (EmploymentRecordType employmentRecordType)
        {
            this.setProperty("employmentRecordType", employmentRecordType);
        }


    }
}

