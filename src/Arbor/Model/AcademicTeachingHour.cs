using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicTeachingHour : ModelBase
    {
        protected new string resourceType = ResourceType.ACADEMIC_TEACHING_HOUR;
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string START_TIME = "startTime";
        public const string END_TIME = "endTime";
        public const string DAY_OF_CYCLE = "dayOfCycle";

        public AcademicTeachingHour()
        {
            base.resourceType = this.resourceType;
        }

        public AcademicTeachingHour(string resourceType = "AcademicTeachingHour", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AcademicTeachingHour> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AcademicTeachingHour");
            RestGateway gateway = (RestGateway)AcademicTeachingHour.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AcademicTeachingHour> academicteachinghourCollection = new ModelCollection<AcademicTeachingHour>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                academicteachinghourCollection.add((AcademicTeachingHour)model);
            }

            return academicteachinghourCollection;
        }

        public static AcademicTeachingHour retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AcademicTeachingHour.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AcademicTeachingHour)gateway.retrieve(ResourceType.ACADEMIC_TEACHING_HOUR, id);
        }

        public DateTime getEffectiveDate()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate(DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate(DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getStartTime()
        {
            return this.getProperty("startTime").ToString();
        }

        public void setStartTime(string startTime)
        {
            this.setProperty("startTime", startTime);
        }

        public string getEndTime()
        {
            return this.getProperty("endTime").ToString();
        }

        public void setEndTime(string endTime)
        {
            this.setProperty("endTime", endTime);
        }

        public int getDayOfCycle()
        {
            return Convert.ToInt32(this.getProperty("dayOfCycle"));
        }

        public void setDayOfCycle(int dayOfCycle)
        {
            this.setProperty("dayOfCycle", dayOfCycle);
        }


    }
}

