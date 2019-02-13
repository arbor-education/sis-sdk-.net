using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicHoliday : ModelBase
    {
        protected string resourceType = ResourceType.ACADEMIC_HOLIDAY;
        public const string ACADEMIC_HOLIDAY_TYPE = "academicHolidayType";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string HOLIDAY_LABEL = "holidayLabel";

        public AcademicHoliday ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicHoliday (string resourceType = "AcademicHoliday", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicHoliday> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicHoliday");
        	RestGateway gateway = (RestGateway) AcademicHoliday.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicHoliday> academicholidayCollection = new ModelCollection<AcademicHoliday> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academicholidayCollection.add((AcademicHoliday) model);
        	}
        
        	return academicholidayCollection;
        }

        public static AcademicHoliday retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicHoliday.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicHoliday) gateway.retrieve(ResourceType.ACADEMIC_HOLIDAY, id);
        }

        public string getAcademicHolidayType ()
        {
            return this.getProperty("academicHolidayType").ToString();
        }

        public void setAcademicHolidayType (string academicHolidayType)
        {
            this.setProperty("academicHolidayType", academicHolidayType);
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

        public string getHolidayLabel ()
        {
            return this.getProperty("holidayLabel").ToString();
        }

        public void setHolidayLabel (string holidayLabel)
        {
            this.setProperty("holidayLabel", holidayLabel);
        }


    }
}

