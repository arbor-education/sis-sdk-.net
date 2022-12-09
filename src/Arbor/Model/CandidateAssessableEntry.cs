using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CandidateAssessableEntry : ModelBase
    {
        protected new string resourceType = ResourceType.CANDIDATE_ASSESSABLE_ENTRY;
        public const string CANDIDATE_ENTRY = "candidateEntry";
        public const string QUALIFICATION_ASSESSABLE = "qualificationAssessable";
        public const string QUALIFICATION_ASSESSABLE_INSTANCE = "qualificationAssessableInstance";
        public const string INVIGILATION_SESSION = "invigilationSession";
        public const string SEAT = "seat";
        public const string START_DATETIME = "startDatetime";
        public const string EXTRA_TIME_PERCENTAGE = "extraTimePercentage";
        public const string ATTENDANCE_MARK = "attendanceMark";
        public const string MINUTES_LATE = "minutesLate";

        public CandidateAssessableEntry()
        {
            base.resourceType = this.resourceType;
        }

        public CandidateAssessableEntry(string resourceType = "CandidateAssessableEntry", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CandidateAssessableEntry> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CandidateAssessableEntry");
            RestGateway gateway = (RestGateway)CandidateAssessableEntry.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CandidateAssessableEntry> candidateassessableentryCollection = new ModelCollection<CandidateAssessableEntry>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                candidateassessableentryCollection.add((CandidateAssessableEntry)model);
            }

            return candidateassessableentryCollection;
        }

        public static CandidateAssessableEntry retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CandidateAssessableEntry.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CandidateAssessableEntry)gateway.retrieve(ResourceType.CANDIDATE_ASSESSABLE_ENTRY, id);
        }

        public CandidateEntry getCandidateEntry()
        {
            return (CandidateEntry)this.getProperty("candidateEntry");
        }

        public void setCandidateEntry(CandidateEntry candidateEntry)
        {
            this.setProperty("candidateEntry", candidateEntry);
        }

        public QualificationAssessable getQualificationAssessable()
        {
            return (QualificationAssessable)this.getProperty("qualificationAssessable");
        }

        public void setQualificationAssessable(QualificationAssessable qualificationAssessable)
        {
            this.setProperty("qualificationAssessable", qualificationAssessable);
        }

        public QualificationAssessableInstance getQualificationAssessableInstance()
        {
            return (QualificationAssessableInstance)this.getProperty("qualificationAssessableInstance");
        }

        public void setQualificationAssessableInstance(QualificationAssessableInstance qualificationAssessableInstance)
        {
            this.setProperty("qualificationAssessableInstance", qualificationAssessableInstance);
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

