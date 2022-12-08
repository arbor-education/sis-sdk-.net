using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentRoomFeatureRequirement : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_ROOM_FEATURE_REQUIREMENT;
        public const string STUDENT = "student";
        public const string ROOM_FEATURE = "roomFeature";

        public StudentRoomFeatureRequirement()
        {
            base.resourceType = this.resourceType;
        }

        public StudentRoomFeatureRequirement(string resourceType = "StudentRoomFeatureRequirement", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StudentRoomFeatureRequirement> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StudentRoomFeatureRequirement");
            RestGateway gateway = (RestGateway)StudentRoomFeatureRequirement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StudentRoomFeatureRequirement> studentroomfeaturerequirementCollection = new ModelCollection<StudentRoomFeatureRequirement>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                studentroomfeaturerequirementCollection.add((StudentRoomFeatureRequirement)model);
            }

            return studentroomfeaturerequirementCollection;
        }

        public static StudentRoomFeatureRequirement retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StudentRoomFeatureRequirement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StudentRoomFeatureRequirement)gateway.retrieve(ResourceType.STUDENT_ROOM_FEATURE_REQUIREMENT, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public RoomFeature getRoomFeature()
        {
            return (RoomFeature)this.getProperty("roomFeature");
        }

        public void setRoomFeature(RoomFeature roomFeature)
        {
            this.setProperty("roomFeature", roomFeature);
        }


    }
}

