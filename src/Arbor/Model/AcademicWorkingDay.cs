using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicWorkingDay : ModelBase
    {
        protected new string resourceType = ResourceType.ACADEMIC_WORKING_DAY;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string DAY_OF_CALENDAR_WEEK = "dayOfCalendarWeek";

        public AcademicWorkingDay ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicWorkingDay (string resourceType = "AcademicWorkingDay", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicWorkingDay> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicWorkingDay");
        	RestGateway gateway = (RestGateway) AcademicWorkingDay.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicWorkingDay> academicworkingdayCollection = new ModelCollection<AcademicWorkingDay> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academicworkingdayCollection.add((AcademicWorkingDay) model);
        	}
        
        	return academicworkingdayCollection;
        }

        public static AcademicWorkingDay retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicWorkingDay.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicWorkingDay) gateway.retrieve(ResourceType.ACADEMIC_WORKING_DAY, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public int getDayOfCalendarWeek ()
        {
            return Convert.ToInt32(this.getProperty("dayOfCalendarWeek"));
        }

        public void setDayOfCalendarWeek (int dayOfCalendarWeek)
        {
            this.setProperty("dayOfCalendarWeek", dayOfCalendarWeek);
        }


    }
}

