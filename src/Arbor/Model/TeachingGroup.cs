using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TeachingGroup : ModelBase
    {
        protected string resourceType = ResourceType.TEACHING_GROUP;
        public const string TEACHING_GROUP_NAME = "teachingGroupName";
        public const string DESCRIPTION = "description";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string PROGRAMME_INSTANCE = "programmeInstance";
        public const string COPIED_TO_TEACHING_GROUP = "copiedToTeachingGroup";
        public const string PROMOTED_TO_TEACHING_GROUP = "promotedToTeachingGroup";
        public const string PROMOTED_DATETIME = "promotedDatetime";
        public const string PROMOTED_ENROLMENT_START_DATE = "promotedEnrolmentStartDate";
        public const string PROMOTED_ENROLMENT_END_DATE = "promotedEnrolmentEndDate";

        public TeachingGroup()
        {
            base.resourceType = this.resourceType;
        }

        public TeachingGroup(string resourceType = "TeachingGroup", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<TeachingGroup> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("TeachingGroup");
            RestGateway gateway = (RestGateway)TeachingGroup.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<TeachingGroup> teachinggroupCollection = new ModelCollection<TeachingGroup>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                teachinggroupCollection.add((TeachingGroup)model);
            }

            return teachinggroupCollection;
        }

        public static TeachingGroup retrieve(string id)
        {
            RestGateway gateway = (RestGateway)TeachingGroup.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (TeachingGroup)gateway.retrieve(ResourceType.TEACHING_GROUP, id);
        }

        public string getTeachingGroupName()
        {
            return this.getProperty("teachingGroupName").ToString();
        }

        public void setTeachingGroupName(string teachingGroupName)
        {
            this.setProperty("teachingGroupName", teachingGroupName);
        }

        public string getDescription()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription(string description)
        {
            this.setProperty("description", description);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public ProgrammeInstance getProgrammeInstance()
        {
            return (ProgrammeInstance)this.getProperty("programmeInstance");
        }

        public void setProgrammeInstance(ProgrammeInstance programmeInstance)
        {
            this.setProperty("programmeInstance", programmeInstance);
        }

        public TeachingGroup getCopiedToTeachingGroup()
        {
            return (TeachingGroup)this.getProperty("copiedToTeachingGroup");
        }

        public void setCopiedToTeachingGroup(TeachingGroup copiedToTeachingGroup)
        {
            this.setProperty("copiedToTeachingGroup", copiedToTeachingGroup);
        }

        public TeachingGroup getPromotedToTeachingGroup()
        {
            return (TeachingGroup)this.getProperty("promotedToTeachingGroup");
        }

        public void setPromotedToTeachingGroup(TeachingGroup promotedToTeachingGroup)
        {
            this.setProperty("promotedToTeachingGroup", promotedToTeachingGroup);
        }

        public DateTime getPromotedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("promotedDatetime"));
        }

        public void setPromotedDatetime(DateTime promotedDatetime)
        {
            this.setProperty("promotedDatetime", promotedDatetime);
        }

        public DateTime getPromotedEnrolmentStartDate()
        {
            return Convert.ToDateTime(this.getProperty("promotedEnrolmentStartDate"));
        }

        public void setPromotedEnrolmentStartDate(DateTime promotedEnrolmentStartDate)
        {
            this.setProperty("promotedEnrolmentStartDate", promotedEnrolmentStartDate);
        }

        public DateTime getPromotedEnrolmentEndDate()
        {
            return Convert.ToDateTime(this.getProperty("promotedEnrolmentEndDate"));
        }

        public void setPromotedEnrolmentEndDate(DateTime promotedEnrolmentEndDate)
        {
            this.setProperty("promotedEnrolmentEndDate", promotedEnrolmentEndDate);
        }


    }
}

