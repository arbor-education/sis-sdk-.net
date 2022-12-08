using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationAssessableInstance : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_ASSESSABLE_INSTANCE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string QUALIFICATION_ASSESSABLE = "qualificationAssessable";
        public const string QUALIFICATION_AVAILABILITY_INSTANCE = "qualificationAvailabilityInstance";
        public const string QUALIFICATION_TIMETABLE_SESSION_TYPE = "qualificationTimetableSessionType";
        public const string START_DATE_RANGE_FROM = "startDateRangeFrom";
        public const string START_DATE_RANGE_UNTIL = "startDateRangeUntil";
        public const string DURATION = "duration";
        public const string IS_CENTRE_SPECIFIED_TIMETABLE = "isCentreSpecifiedTimetable";
        public const string CENTRE_SPECIFIED_DATETIME = "centreSpecifiedDatetime";
        public const string CENTRE_SPECIFIED_DURATION = "centreSpecifiedDuration";
        public const string IS_PROVISIONAL = "isProvisional";

        public QualificationAssessableInstance()
        {
            base.resourceType = this.resourceType;
        }

        public QualificationAssessableInstance(string resourceType = "QualificationAssessableInstance", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<QualificationAssessableInstance> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("QualificationAssessableInstance");
            RestGateway gateway = (RestGateway)QualificationAssessableInstance.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<QualificationAssessableInstance> qualificationassessableinstanceCollection = new ModelCollection<QualificationAssessableInstance>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                qualificationassessableinstanceCollection.add((QualificationAssessableInstance)model);
            }

            return qualificationassessableinstanceCollection;
        }

        public static QualificationAssessableInstance retrieve(string id)
        {
            RestGateway gateway = (RestGateway)QualificationAssessableInstance.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (QualificationAssessableInstance)gateway.retrieve(ResourceType.QUALIFICATION_ASSESSABLE_INSTANCE, id);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive(bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder(int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public QualificationAssessable getQualificationAssessable()
        {
            return (QualificationAssessable)this.getProperty("qualificationAssessable");
        }

        public void setQualificationAssessable(QualificationAssessable qualificationAssessable)
        {
            this.setProperty("qualificationAssessable", qualificationAssessable);
        }

        public QualificationAvailabilityInstance getQualificationAvailabilityInstance()
        {
            return (QualificationAvailabilityInstance)this.getProperty("qualificationAvailabilityInstance");
        }

        public void setQualificationAvailabilityInstance(QualificationAvailabilityInstance qualificationAvailabilityInstance)
        {
            this.setProperty("qualificationAvailabilityInstance", qualificationAvailabilityInstance);
        }

        public QualificationTimetableSessionType getQualificationTimetableSessionType()
        {
            return (QualificationTimetableSessionType)this.getProperty("qualificationTimetableSessionType");
        }

        public void setQualificationTimetableSessionType(QualificationTimetableSessionType qualificationTimetableSessionType)
        {
            this.setProperty("qualificationTimetableSessionType", qualificationTimetableSessionType);
        }

        public DateTime getStartDateRangeFrom()
        {
            return Convert.ToDateTime(this.getProperty("startDateRangeFrom"));
        }

        public void setStartDateRangeFrom(DateTime startDateRangeFrom)
        {
            this.setProperty("startDateRangeFrom", startDateRangeFrom);
        }

        public DateTime getStartDateRangeUntil()
        {
            return Convert.ToDateTime(this.getProperty("startDateRangeUntil"));
        }

        public void setStartDateRangeUntil(DateTime startDateRangeUntil)
        {
            this.setProperty("startDateRangeUntil", startDateRangeUntil);
        }

        public string getDuration()
        {
            return this.getProperty("duration").ToString();
        }

        public void setDuration(string duration)
        {
            this.setProperty("duration", duration);
        }

        public bool getIsCentreSpecifiedTimetable()
        {
            return Convert.ToBoolean(this.getProperty("isCentreSpecifiedTimetable"));
        }

        public void setIsCentreSpecifiedTimetable(bool isCentreSpecifiedTimetable)
        {
            this.setProperty("isCentreSpecifiedTimetable", isCentreSpecifiedTimetable);
        }

        public DateTime getCentreSpecifiedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("centreSpecifiedDatetime"));
        }

        public void setCentreSpecifiedDatetime(DateTime centreSpecifiedDatetime)
        {
            this.setProperty("centreSpecifiedDatetime", centreSpecifiedDatetime);
        }

        public string getCentreSpecifiedDuration()
        {
            return this.getProperty("centreSpecifiedDuration").ToString();
        }

        public void setCentreSpecifiedDuration(string centreSpecifiedDuration)
        {
            this.setProperty("centreSpecifiedDuration", centreSpecifiedDuration);
        }

        public bool getIsProvisional()
        {
            return Convert.ToBoolean(this.getProperty("isProvisional"));
        }

        public void setIsProvisional(bool isProvisional)
        {
            this.setProperty("isProvisional", isProvisional);
        }


    }
}

