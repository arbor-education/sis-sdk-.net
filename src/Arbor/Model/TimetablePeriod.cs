using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TimetablePeriod : ModelBase
    {
        protected new string resourceType = ResourceType.TIMETABLE_PERIOD;
        public const string TIMETABLE_PERIOD_GROUPING = "timetablePeriodGrouping";
        public const string DAY_OF_CYCLE = "dayOfCycle";
        public const string DAY_OF_WEEK = "dayOfWeek";
        public const string START_TIME = "startTime";
        public const string END_TIME = "endTime";

        public TimetablePeriod()
        {
            base.resourceType = this.resourceType;
        }

        public TimetablePeriod(string resourceType = "TimetablePeriod", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<TimetablePeriod> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("TimetablePeriod");
            RestGateway gateway = (RestGateway)TimetablePeriod.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<TimetablePeriod> timetableperiodCollection = new ModelCollection<TimetablePeriod>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                timetableperiodCollection.add((TimetablePeriod)model);
            }

            return timetableperiodCollection;
        }

        public static TimetablePeriod retrieve(string id)
        {
            RestGateway gateway = (RestGateway)TimetablePeriod.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (TimetablePeriod)gateway.retrieve(ResourceType.TIMETABLE_PERIOD, id);
        }

        public TimetablePeriodGrouping getTimetablePeriodGrouping()
        {
            return (TimetablePeriodGrouping)this.getProperty("timetablePeriodGrouping");
        }

        public void setTimetablePeriodGrouping(TimetablePeriodGrouping timetablePeriodGrouping)
        {
            this.setProperty("timetablePeriodGrouping", timetablePeriodGrouping);
        }

        public int getDayOfCycle()
        {
            return Convert.ToInt32(this.getProperty("dayOfCycle"));
        }

        public void setDayOfCycle(int dayOfCycle)
        {
            this.setProperty("dayOfCycle", dayOfCycle);
        }

        public int getDayOfWeek()
        {
            return Convert.ToInt32(this.getProperty("dayOfWeek"));
        }

        public void setDayOfWeek(int dayOfWeek)
        {
            this.setProperty("dayOfWeek", dayOfWeek);
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


    }
}

