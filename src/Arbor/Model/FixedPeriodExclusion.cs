using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class FixedPeriodExclusion : ModelBase
    {
        protected new string resourceType = ResourceType.FIXED_PERIOD_EXCLUSION;
        public const string STUDENT = "student";
        public const string EXCLUSION_REASON = "exclusionReason";
        public const string FROM_DATETIME = "fromDatetime";
        public const string UNTIL_DATETIME = "untilDatetime";
        public const string DAILY_START_TIME = "dailyStartTime";
        public const string DAILY_END_TIME = "dailyEndTime";
        public const string DECISION_DATETIME = "decisionDatetime";
        public const string NOTIFIED_STUDENT_DATETIME = "notifiedStudentDatetime";
        public const string NOTIFIED_GUARDIANS_DATETIME = "notifiedGuardiansDatetime";
        public const string STATISTICAL_DAYS_EXCLUDED = "statisticalDaysExcluded";
        public const string NARRATIVE = "narrative";

        public FixedPeriodExclusion()
        {
            base.resourceType = this.resourceType;
        }

        public FixedPeriodExclusion(string resourceType = "FixedPeriodExclusion", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<FixedPeriodExclusion> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("FixedPeriodExclusion");
            RestGateway gateway = (RestGateway)FixedPeriodExclusion.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<FixedPeriodExclusion> fixedperiodexclusionCollection = new ModelCollection<FixedPeriodExclusion>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                fixedperiodexclusionCollection.add((FixedPeriodExclusion)model);
            }

            return fixedperiodexclusionCollection;
        }

        public static FixedPeriodExclusion retrieve(string id)
        {
            RestGateway gateway = (RestGateway)FixedPeriodExclusion.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (FixedPeriodExclusion)gateway.retrieve(ResourceType.FIXED_PERIOD_EXCLUSION, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public ExclusionReason getExclusionReason()
        {
            return (ExclusionReason)this.getProperty("exclusionReason");
        }

        public void setExclusionReason(ExclusionReason exclusionReason)
        {
            this.setProperty("exclusionReason", exclusionReason);
        }

        public DateTime getFromDatetime()
        {
            return Convert.ToDateTime(this.getProperty("fromDatetime"));
        }

        public void setFromDatetime(DateTime fromDatetime)
        {
            this.setProperty("fromDatetime", fromDatetime);
        }

        public DateTime getUntilDatetime()
        {
            return Convert.ToDateTime(this.getProperty("untilDatetime"));
        }

        public void setUntilDatetime(DateTime untilDatetime)
        {
            this.setProperty("untilDatetime", untilDatetime);
        }

        public string getDailyStartTime()
        {
            return this.getProperty("dailyStartTime").ToString();
        }

        public void setDailyStartTime(string dailyStartTime)
        {
            this.setProperty("dailyStartTime", dailyStartTime);
        }

        public string getDailyEndTime()
        {
            return this.getProperty("dailyEndTime").ToString();
        }

        public void setDailyEndTime(string dailyEndTime)
        {
            this.setProperty("dailyEndTime", dailyEndTime);
        }

        public DateTime getDecisionDatetime()
        {
            return Convert.ToDateTime(this.getProperty("decisionDatetime"));
        }

        public void setDecisionDatetime(DateTime decisionDatetime)
        {
            this.setProperty("decisionDatetime", decisionDatetime);
        }

        public DateTime getNotifiedStudentDatetime()
        {
            return Convert.ToDateTime(this.getProperty("notifiedStudentDatetime"));
        }

        public void setNotifiedStudentDatetime(DateTime notifiedStudentDatetime)
        {
            this.setProperty("notifiedStudentDatetime", notifiedStudentDatetime);
        }

        public DateTime getNotifiedGuardiansDatetime()
        {
            return Convert.ToDateTime(this.getProperty("notifiedGuardiansDatetime"));
        }

        public void setNotifiedGuardiansDatetime(DateTime notifiedGuardiansDatetime)
        {
            this.setProperty("notifiedGuardiansDatetime", notifiedGuardiansDatetime);
        }

        public float getStatisticalDaysExcluded()
        {
            return (float)this.getProperty("statisticalDaysExcluded");
        }

        public void setStatisticalDaysExcluded(float statisticalDaysExcluded)
        {
            this.setProperty("statisticalDaysExcluded", statisticalDaysExcluded);
        }

        public string getNarrative()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative(string narrative)
        {
            this.setProperty("narrative", narrative);
        }


    }
}

