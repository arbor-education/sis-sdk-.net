using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicCalendarDate : ModelBase
    {
        protected string resourceType = ResourceType.ACADEMIC_CALENDAR_DATE;
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string CALENDAR_YEAR = "calendarYear";
        public const string CALENDAR_MONTH = "calendarMonth";
        public const string CALENDAR_WEEK = "calendarWeek";
        public const string CALENDAR_DAY = "calendarDay";
        public const string CALENDAR_DAY_OF_WEEK = "calendarDayOfWeek";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string TERM = "term";
        public const string ACADEMIC_YEAR_CYCLE_NUMBER = "academicYearCycleNumber";
        public const string TERM_CYCLE_NUMBER = "termCycleNumber";
        public const string DAY_OF_CYCLE = "dayOfCycle";
        public const string DAY_OF_TERM = "dayOfTerm";
        public const string DAY_OF_ACADEMIC_YEAR = "dayOfAcademicYear";
        public const string ACADEMIC_HOLIDAY = "academicHoliday";
        public const string IS_GOOD_SCHOOL_DAY = "isGoodSchoolDay";

        public AcademicCalendarDate ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicCalendarDate (string resourceType = "AcademicCalendarDate", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicCalendarDate> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicCalendarDate");
        	RestGateway gateway = (RestGateway) AcademicCalendarDate.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicCalendarDate> academiccalendardateCollection = new ModelCollection<AcademicCalendarDate> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academiccalendardateCollection.add((AcademicCalendarDate) model);
        	}
        
        	return academiccalendardateCollection;
        }

        public static AcademicCalendarDate retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicCalendarDate.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicCalendarDate) gateway.retrieve(ResourceType.ACADEMIC_CALENDAR_DATE, id);
        }

        public DateTime getStartDate ()
        {
            return (DateTime) this.getProperty("startDate");
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return (DateTime) this.getProperty("endDate");
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public int getCalendarYear ()
        {
            return Convert.ToInt32(this.getProperty("calendarYear"));
        }

        public void setCalendarYear (int calendarYear)
        {
            this.setProperty("calendarYear", calendarYear);
        }

        public int getCalendarMonth ()
        {
            return Convert.ToInt32(this.getProperty("calendarMonth"));
        }

        public void setCalendarMonth (int calendarMonth)
        {
            this.setProperty("calendarMonth", calendarMonth);
        }

        public int getCalendarWeek ()
        {
            return Convert.ToInt32(this.getProperty("calendarWeek"));
        }

        public void setCalendarWeek (int calendarWeek)
        {
            this.setProperty("calendarWeek", calendarWeek);
        }

        public int getCalendarDay ()
        {
            return Convert.ToInt32(this.getProperty("calendarDay"));
        }

        public void setCalendarDay (int calendarDay)
        {
            this.setProperty("calendarDay", calendarDay);
        }

        public int getCalendarDayOfWeek ()
        {
            return Convert.ToInt32(this.getProperty("calendarDayOfWeek"));
        }

        public void setCalendarDayOfWeek (int calendarDayOfWeek)
        {
            this.setProperty("calendarDayOfWeek", calendarDayOfWeek);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public Term getTerm ()
        {
            return (Term) this.getProperty("term");
        }

        public void setTerm (Term term)
        {
            this.setProperty("term", term);
        }

        public int getAcademicYearCycleNumber ()
        {
            return Convert.ToInt32(this.getProperty("academicYearCycleNumber"));
        }

        public void setAcademicYearCycleNumber (int academicYearCycleNumber)
        {
            this.setProperty("academicYearCycleNumber", academicYearCycleNumber);
        }

        public int getTermCycleNumber ()
        {
            return Convert.ToInt32(this.getProperty("termCycleNumber"));
        }

        public void setTermCycleNumber (int termCycleNumber)
        {
            this.setProperty("termCycleNumber", termCycleNumber);
        }

        public int getDayOfCycle ()
        {
            return Convert.ToInt32(this.getProperty("dayOfCycle"));
        }

        public void setDayOfCycle (int dayOfCycle)
        {
            this.setProperty("dayOfCycle", dayOfCycle);
        }

        public int getDayOfTerm ()
        {
            return Convert.ToInt32(this.getProperty("dayOfTerm"));
        }

        public void setDayOfTerm (int dayOfTerm)
        {
            this.setProperty("dayOfTerm", dayOfTerm);
        }

        public int getDayOfAcademicYear ()
        {
            return Convert.ToInt32(this.getProperty("dayOfAcademicYear"));
        }

        public void setDayOfAcademicYear (int dayOfAcademicYear)
        {
            this.setProperty("dayOfAcademicYear", dayOfAcademicYear);
        }

        public AcademicHoliday getAcademicHoliday ()
        {
            return (AcademicHoliday) this.getProperty("academicHoliday");
        }

        public void setAcademicHoliday (AcademicHoliday academicHoliday)
        {
            this.setProperty("academicHoliday", academicHoliday);
        }

        public bool getIsGoodSchoolDay ()
        {
            return (bool) this.getProperty("isGoodSchoolDay");
        }

        public void setIsGoodSchoolDay (bool isGoodSchoolDay)
        {
            this.setProperty("isGoodSchoolDay", isGoodSchoolDay);
        }


    }
}

