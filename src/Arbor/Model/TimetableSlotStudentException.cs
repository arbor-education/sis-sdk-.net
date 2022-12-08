using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TimetableSlotStudentException : ModelBase
    {
        protected string resourceType = ResourceType.TIMETABLE_SLOT_STUDENT_EXCEPTION;
        public const string TIMETABLE_SLOT = "timetableSlot";
        public const string STUDENT = "student";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public TimetableSlotStudentException()
        {
            base.resourceType = this.resourceType;
        }

        public TimetableSlotStudentException(string resourceType = "TimetableSlotStudentException", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<TimetableSlotStudentException> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("TimetableSlotStudentException");
            RestGateway gateway = (RestGateway)TimetableSlotStudentException.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<TimetableSlotStudentException> timetableslotstudentexceptionCollection = new ModelCollection<TimetableSlotStudentException>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                timetableslotstudentexceptionCollection.add((TimetableSlotStudentException)model);
            }

            return timetableslotstudentexceptionCollection;
        }

        public static TimetableSlotStudentException retrieve(string id)
        {
            RestGateway gateway = (RestGateway)TimetableSlotStudentException.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (TimetableSlotStudentException)gateway.retrieve(ResourceType.TIMETABLE_SLOT_STUDENT_EXCEPTION, id);
        }

        public TimetableSlot getTimetableSlot()
        {
            return (TimetableSlot)this.getProperty("timetableSlot");
        }

        public void setTimetableSlot(TimetableSlot timetableSlot)
        {
            this.setProperty("timetableSlot", timetableSlot);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
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


    }
}

