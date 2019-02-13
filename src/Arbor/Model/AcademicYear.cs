using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicYear : ModelBase
    {
        protected string resourceType = ResourceType.ACADEMIC_YEAR;
        public const string ACADEMIC_YEAR_NAME = "academicYearName";
        public const string CODE = "code";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string TIMETABLE_CYCLE_LENGTH = "timetableCycleLength";

        public AcademicYear ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicYear (string resourceType = "AcademicYear", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicYear> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicYear");
        	RestGateway gateway = (RestGateway) AcademicYear.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicYear> academicyearCollection = new ModelCollection<AcademicYear> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academicyearCollection.add((AcademicYear) model);
        	}
        
        	return academicyearCollection;
        }

        public static AcademicYear retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicYear.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicYear) gateway.retrieve(ResourceType.ACADEMIC_YEAR, id);
        }

        public string getAcademicYearName ()
        {
            return this.getProperty("academicYearName").ToString();
        }

        public void setAcademicYearName (string academicYearName)
        {
            this.setProperty("academicYearName", academicYearName);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
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

        public int getTimetableCycleLength ()
        {
            return Convert.ToInt32(this.getProperty("timetableCycleLength"));
        }

        public void setTimetableCycleLength (int timetableCycleLength)
        {
            this.setProperty("timetableCycleLength", timetableCycleLength);
        }


    }
}

