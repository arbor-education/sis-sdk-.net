using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AttendanceFollowUp : ModelBase
    {
        protected string resourceType = ResourceType.ATTENDANCE_FOLLOW_UP;
        public const string STUDENT = "student";
        public const string ATTENDANCE_DATE = "attendanceDate";
        public const string SENDING_STARTED_DATETIME = "sendingStartedDatetime";
        public const string EMAIL_SENT_DATETIME = "emailSentDatetime";
        public const string EMAIL_FAILED_DATETIME = "emailFailedDatetime";
        public const string SMS_SENT_DATETIME = "smsSentDatetime";
        public const string SMS_FAILED_DATETIME = "smsFailedDatetime";
        public const string TELEPHONE_CALL_DATETIME = "telephoneCallDatetime";

        public AttendanceFollowUp()
        {
            base.resourceType = this.resourceType;
        }

        public AttendanceFollowUp(string resourceType = "AttendanceFollowUp", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AttendanceFollowUp> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AttendanceFollowUp");
            RestGateway gateway = (RestGateway)AttendanceFollowUp.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AttendanceFollowUp> attendancefollowupCollection = new ModelCollection<AttendanceFollowUp>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                attendancefollowupCollection.add((AttendanceFollowUp)model);
            }

            return attendancefollowupCollection;
        }

        public static AttendanceFollowUp retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AttendanceFollowUp.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AttendanceFollowUp)gateway.retrieve(ResourceType.ATTENDANCE_FOLLOW_UP, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getAttendanceDate()
        {
            return Convert.ToDateTime(this.getProperty("attendanceDate"));
        }

        public void setAttendanceDate(DateTime attendanceDate)
        {
            this.setProperty("attendanceDate", attendanceDate);
        }

        public DateTime getSendingStartedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("sendingStartedDatetime"));
        }

        public void setSendingStartedDatetime(DateTime sendingStartedDatetime)
        {
            this.setProperty("sendingStartedDatetime", sendingStartedDatetime);
        }

        public DateTime getEmailSentDatetime()
        {
            return Convert.ToDateTime(this.getProperty("emailSentDatetime"));
        }

        public void setEmailSentDatetime(DateTime emailSentDatetime)
        {
            this.setProperty("emailSentDatetime", emailSentDatetime);
        }

        public DateTime getEmailFailedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("emailFailedDatetime"));
        }

        public void setEmailFailedDatetime(DateTime emailFailedDatetime)
        {
            this.setProperty("emailFailedDatetime", emailFailedDatetime);
        }

        public DateTime getSmsSentDatetime()
        {
            return Convert.ToDateTime(this.getProperty("smsSentDatetime"));
        }

        public void setSmsSentDatetime(DateTime smsSentDatetime)
        {
            this.setProperty("smsSentDatetime", smsSentDatetime);
        }

        public DateTime getSmsFailedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("smsFailedDatetime"));
        }

        public void setSmsFailedDatetime(DateTime smsFailedDatetime)
        {
            this.setProperty("smsFailedDatetime", smsFailedDatetime);
        }

        public DateTime getTelephoneCallDatetime()
        {
            return Convert.ToDateTime(this.getProperty("telephoneCallDatetime"));
        }

        public void setTelephoneCallDatetime(DateTime telephoneCallDatetime)
        {
            this.setProperty("telephoneCallDatetime", telephoneCallDatetime);
        }


    }
}

