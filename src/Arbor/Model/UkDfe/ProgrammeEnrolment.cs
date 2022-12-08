using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class ProgrammeEnrolment : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_PROGRAMME_ENROLMENT;
        public const string PLANNED_LEARNING_HOURS = "plannedLearningHours";
        public const string PLANNED_LEARNING_HOURS_SECOND_YEAR = "plannedLearningHoursSecondYear";
        public const string PROGRAMME_AIM_TYPE = "programmeAimType";

        public ProgrammeEnrolment()
        {
            base.resourceType = this.resourceType;
        }

        public ProgrammeEnrolment(string resourceType = "ProgrammeEnrolment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ProgrammeEnrolment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_ProgrammeEnrolment");
            RestGateway gateway = (RestGateway)ProgrammeEnrolment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ProgrammeEnrolment> programmeenrolmentCollection = new ModelCollection<ProgrammeEnrolment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                programmeenrolmentCollection.add((ProgrammeEnrolment)model);
            }

            return programmeenrolmentCollection;
        }

        public static ProgrammeEnrolment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ProgrammeEnrolment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ProgrammeEnrolment)gateway.retrieve(ResourceType.UK_DFE_PROGRAMME_ENROLMENT, id);
        }

        public int getPlannedLearningHours()
        {
            return Convert.ToInt32(this.getProperty("plannedLearningHours"));
        }

        public void setPlannedLearningHours(int plannedLearningHours)
        {
            this.setProperty("plannedLearningHours", plannedLearningHours);
        }

        public int getPlannedLearningHoursSecondYear()
        {
            return Convert.ToInt32(this.getProperty("plannedLearningHoursSecondYear"));
        }

        public void setPlannedLearningHoursSecondYear(int plannedLearningHoursSecondYear)
        {
            this.setProperty("plannedLearningHoursSecondYear", plannedLearningHoursSecondYear);
        }

        public string getProgrammeAimType()
        {
            return this.getProperty("programmeAimType").ToString();
        }

        public void setProgrammeAimType(string programmeAimType)
        {
            this.setProperty("programmeAimType", programmeAimType);
        }


    }
}

