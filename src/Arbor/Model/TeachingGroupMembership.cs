using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TeachingGroupMembership : ModelBase
    {
        protected string resourceType = ResourceType.TEACHING_GROUP_MEMBERSHIP;
        public const string TEACHING_GROUP = "teachingGroup";
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public TeachingGroupMembership()
        {
            base.resourceType = this.resourceType;
        }

        public TeachingGroupMembership(string resourceType = "TeachingGroupMembership", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<TeachingGroupMembership> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("TeachingGroupMembership");
            RestGateway gateway = (RestGateway)TeachingGroupMembership.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<TeachingGroupMembership> teachinggroupmembershipCollection = new ModelCollection<TeachingGroupMembership>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                teachinggroupmembershipCollection.add((TeachingGroupMembership)model);
            }

            return teachinggroupmembershipCollection;
        }

        public static TeachingGroupMembership retrieve(string id)
        {
            RestGateway gateway = (RestGateway)TeachingGroupMembership.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (TeachingGroupMembership)gateway.retrieve(ResourceType.TEACHING_GROUP_MEMBERSHIP, id);
        }

        public TeachingGroup getTeachingGroup()
        {
            return (TeachingGroup)this.getProperty("teachingGroup");
        }

        public void setTeachingGroup(TeachingGroup teachingGroup)
        {
            this.setProperty("teachingGroup", teachingGroup);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getStartDate()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate(DateTime startDate)
        {
            this.setProperty("startDate", startDate);
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

