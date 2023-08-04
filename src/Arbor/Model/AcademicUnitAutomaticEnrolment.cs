using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicUnitAutomaticEnrolment : ModelBase
    {
        protected new string resourceType = ResourceType.ACADEMIC_UNIT_AUTOMATIC_ENROLMENT;
        public const string ACADEMIC_UNIT = "academicUnit";
        public const string TRIGGER = "trigger";
        public const string ATTENDANCE_PATTERN = "attendancePattern";

        public AcademicUnitAutomaticEnrolment()
        {
            base.resourceType = this.resourceType;
        }

        public AcademicUnitAutomaticEnrolment(string resourceType = "AcademicUnitAutomaticEnrolment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AcademicUnitAutomaticEnrolment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AcademicUnitAutomaticEnrolment");
            RestGateway gateway = (RestGateway)AcademicUnitAutomaticEnrolment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AcademicUnitAutomaticEnrolment> academicunitautomaticenrolmentCollection = new ModelCollection<AcademicUnitAutomaticEnrolment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                academicunitautomaticenrolmentCollection.add((AcademicUnitAutomaticEnrolment)model);
            }

            return academicunitautomaticenrolmentCollection;
        }

        public static AcademicUnitAutomaticEnrolment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AcademicUnitAutomaticEnrolment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AcademicUnitAutomaticEnrolment)gateway.retrieve(ResourceType.ACADEMIC_UNIT_AUTOMATIC_ENROLMENT, id);
        }

        public AcademicUnit getAcademicUnit()
        {
            return (AcademicUnit)this.getProperty("academicUnit");
        }

        public void setAcademicUnit(AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }

        public ModelBase getTrigger()
        {
            return (ModelBase)this.getProperty("trigger");
        }

        public void setTrigger(ModelBase trigger)
        {
            this.setProperty("trigger", trigger);
        }

        public AttendancePattern getAttendancePattern()
        {
            return (AttendancePattern)this.getProperty("attendancePattern");
        }

        public void setAttendancePattern(AttendancePattern attendancePattern)
        {
            this.setProperty("attendancePattern", attendancePattern);
        }


    }
}

