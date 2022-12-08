using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class AcademicYearEnrolment : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_ACADEMIC_YEAR_ENROLMENT;
        public const string PLANNED_LEARNING_HOURS = "plannedLearningHours";
        public const string PLANNED_EEP_HOURS = "plannedEepHours";
        public const string T_LEVEL_PLANNED_LEARNING_HOURS = "tLevelPlannedLearningHours";

        public AcademicYearEnrolment()
        {
            base.resourceType = this.resourceType;
        }

        public AcademicYearEnrolment(string resourceType = "AcademicYearEnrolment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AcademicYearEnrolment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_AcademicYearEnrolment");
            RestGateway gateway = (RestGateway)AcademicYearEnrolment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AcademicYearEnrolment> academicyearenrolmentCollection = new ModelCollection<AcademicYearEnrolment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                academicyearenrolmentCollection.add((AcademicYearEnrolment)model);
            }

            return academicyearenrolmentCollection;
        }

        public static AcademicYearEnrolment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AcademicYearEnrolment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AcademicYearEnrolment)gateway.retrieve(ResourceType.UK_DFE_ACADEMIC_YEAR_ENROLMENT, id);
        }

        public int getPlannedLearningHours()
        {
            return Convert.ToInt32(this.getProperty("plannedLearningHours"));
        }

        public void setPlannedLearningHours(int plannedLearningHours)
        {
            this.setProperty("plannedLearningHours", plannedLearningHours);
        }

        public int getPlannedEepHours()
        {
            return Convert.ToInt32(this.getProperty("plannedEepHours"));
        }

        public void setPlannedEepHours(int plannedEepHours)
        {
            this.setProperty("plannedEepHours", plannedEepHours);
        }

        public int getTLevelPlannedLearningHours()
        {
            return Convert.ToInt32(this.getProperty("tLevelPlannedLearningHours"));
        }

        public void setTLevelPlannedLearningHours(int tLevelPlannedLearningHours)
        {
            this.setProperty("tLevelPlannedLearningHours", tLevelPlannedLearningHours);
        }


    }
}

