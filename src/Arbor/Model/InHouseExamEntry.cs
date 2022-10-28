using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InHouseExamEntry : ModelBase
    {
        protected new string resourceType = ResourceType.IN_HOUSE_EXAM_ENTRY;
        public const string IN_HOUSE_EXAM = "inHouseExam";
        public const string IN_HOUSE_EXAM_INSTANCE = "inHouseExamInstance";
        public const string IN_HOUSE_CANDIDATE = "inHouseCandidate";
        public const string INVIGILATION_SESSION = "invigilationSession";
        public const string SEAT = "seat";
        public const string START_DATETIME = "startDatetime";
        public const string EXTRA_TIME_PERCENTAGE = "extraTimePercentage";
        public const string ATTENDANCE_MARK = "attendanceMark";
        public const string MINUTES_LATE = "minutesLate";

        public InHouseExamEntry()
        {
            base.resourceType = this.resourceType;
        }

        public InHouseExamEntry(string resourceType = "InHouseExamEntry", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<InHouseExamEntry> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("InHouseExamEntry");
            RestGateway gateway = (RestGateway)InHouseExamEntry.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<InHouseExamEntry> inhouseexamentryCollection = new ModelCollection<InHouseExamEntry>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                inhouseexamentryCollection.add((InHouseExamEntry)model);
            }

            return inhouseexamentryCollection;
        }

        public static InHouseExamEntry retrieve(string id)
        {
            RestGateway gateway = (RestGateway)InHouseExamEntry.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (InHouseExamEntry)gateway.retrieve(ResourceType.IN_HOUSE_EXAM_ENTRY, id);
        }

        public InHouseExam getInHouseExam()
        {
            return (InHouseExam)this.getProperty("inHouseExam");
        }

        public void setInHouseExam(InHouseExam inHouseExam)
        {
            this.setProperty("inHouseExam", inHouseExam);
        }

        public InHouseExamInstance getInHouseExamInstance()
        {
            return (InHouseExamInstance)this.getProperty("inHouseExamInstance");
        }

        public void setInHouseExamInstance(InHouseExamInstance inHouseExamInstance)
        {
            this.setProperty("inHouseExamInstance", inHouseExamInstance);
        }

        public InHouseCandidate getInHouseCandidate()
        {
            return (InHouseCandidate)this.getProperty("inHouseCandidate");
        }

        public void setInHouseCandidate(InHouseCandidate inHouseCandidate)
        {
            this.setProperty("inHouseCandidate", inHouseCandidate);
        }

        public InvigilationSession getInvigilationSession()
        {
            return (InvigilationSession)this.getProperty("invigilationSession");
        }

        public void setInvigilationSession(InvigilationSession invigilationSession)
        {
            this.setProperty("invigilationSession", invigilationSession);
        }

        public RoomLayoutSeat getSeat()
        {
            return (RoomLayoutSeat)this.getProperty("seat");
        }

        public void setSeat(RoomLayoutSeat seat)
        {
            this.setProperty("seat", seat);
        }

        public DateTime getStartDatetime()
        {
            return Convert.ToDateTime(this.getProperty("startDatetime"));
        }

        public void setStartDatetime(DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public float getExtraTimePercentage()
        {
            return (float)this.getProperty("extraTimePercentage");
        }

        public void setExtraTimePercentage(float extraTimePercentage)
        {
            this.setProperty("extraTimePercentage", extraTimePercentage);
        }

        public string getAttendanceMark()
        {
            return this.getProperty("attendanceMark").ToString();
        }

        public void setAttendanceMark(string attendanceMark)
        {
            this.setProperty("attendanceMark", attendanceMark);
        }

        public int getMinutesLate()
        {
            return Convert.ToInt32(this.getProperty("minutesLate"));
        }

        public void setMinutesLate(int minutesLate)
        {
            this.setProperty("minutesLate", minutesLate);
        }


    }
}

