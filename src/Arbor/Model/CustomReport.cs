using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomReport : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOM_REPORT;
        public const string TITLE = "title";
        public const string REPORT_CLASS = "reportClass";
        public const string LAST_ACCESS_DATETIME = "lastAccessDatetime";
        public const string LAST_DB_QUERIES = "lastDbQueries";
        public const string LAST_DB_TIME = "lastDbTime";
        public const string LAST_TOTAL_TIME = "lastTotalTime";
        public const string SETUP_COMPLETED_DATETIME = "setupCompletedDatetime";
        public const string TRANSIENT = "transient";

        public CustomReport()
        {
            base.resourceType = this.resourceType;
        }

        public CustomReport(string resourceType = "CustomReport", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CustomReport> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CustomReport");
            RestGateway gateway = (RestGateway)CustomReport.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CustomReport> customreportCollection = new ModelCollection<CustomReport>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                customreportCollection.add((CustomReport)model);
            }

            return customreportCollection;
        }

        public static CustomReport retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CustomReport.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CustomReport)gateway.retrieve(ResourceType.CUSTOM_REPORT, id);
        }

        public string getTitle()
        {
            return this.getProperty("title").ToString();
        }

        public void setTitle(string title)
        {
            this.setProperty("title", title);
        }

        public string getReportClass()
        {
            return this.getProperty("reportClass").ToString();
        }

        public void setReportClass(string reportClass)
        {
            this.setProperty("reportClass", reportClass);
        }

        public DateTime getLastAccessDatetime()
        {
            return Convert.ToDateTime(this.getProperty("lastAccessDatetime"));
        }

        public void setLastAccessDatetime(DateTime lastAccessDatetime)
        {
            this.setProperty("lastAccessDatetime", lastAccessDatetime);
        }

        public int getLastDbQueries()
        {
            return Convert.ToInt32(this.getProperty("lastDbQueries"));
        }

        public void setLastDbQueries(int lastDbQueries)
        {
            this.setProperty("lastDbQueries", lastDbQueries);
        }

        public float getLastDbTime()
        {
            return (float)this.getProperty("lastDbTime");
        }

        public void setLastDbTime(float lastDbTime)
        {
            this.setProperty("lastDbTime", lastDbTime);
        }

        public float getLastTotalTime()
        {
            return (float)this.getProperty("lastTotalTime");
        }

        public void setLastTotalTime(float lastTotalTime)
        {
            this.setProperty("lastTotalTime", lastTotalTime);
        }

        public DateTime getSetupCompletedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("setupCompletedDatetime"));
        }

        public void setSetupCompletedDatetime(DateTime setupCompletedDatetime)
        {
            this.setProperty("setupCompletedDatetime", setupCompletedDatetime);
        }

        public bool getTransient()
        {
            return Convert.ToBoolean(this.getProperty("transient"));
        }

        public void setTransient(bool transient)
        {
            this.setProperty("transient", transient);
        }


    }
}

