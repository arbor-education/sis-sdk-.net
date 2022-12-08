using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TrainingCourse : ModelBase
    {
        protected string resourceType = ResourceType.TRAINING_COURSE;
        public const string TRAINING_COURSE_TITLE = "trainingCourseTitle";
        public const string TRAINING_COURSE_DESCRIPTION = "trainingCourseDescription";
        public const string ORGANIZER = "organizer";
        public const string COURSE_FEES = "courseFees";
        public const string OTHER_COSTS = "otherCosts";

        public TrainingCourse()
        {
            base.resourceType = this.resourceType;
        }

        public TrainingCourse(string resourceType = "TrainingCourse", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<TrainingCourse> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("TrainingCourse");
            RestGateway gateway = (RestGateway)TrainingCourse.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<TrainingCourse> trainingcourseCollection = new ModelCollection<TrainingCourse>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                trainingcourseCollection.add((TrainingCourse)model);
            }

            return trainingcourseCollection;
        }

        public static TrainingCourse retrieve(string id)
        {
            RestGateway gateway = (RestGateway)TrainingCourse.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (TrainingCourse)gateway.retrieve(ResourceType.TRAINING_COURSE, id);
        }

        public string getTrainingCourseTitle()
        {
            return this.getProperty("trainingCourseTitle").ToString();
        }

        public void setTrainingCourseTitle(string trainingCourseTitle)
        {
            this.setProperty("trainingCourseTitle", trainingCourseTitle);
        }

        public string getTrainingCourseDescription()
        {
            return this.getProperty("trainingCourseDescription").ToString();
        }

        public void setTrainingCourseDescription(string trainingCourseDescription)
        {
            this.setProperty("trainingCourseDescription", trainingCourseDescription);
        }

        public ModelBase getOrganizer()
        {
            return (ModelBase)this.getProperty("organizer");
        }

        public void setOrganizer(ModelBase organizer)
        {
            this.setProperty("organizer", organizer);
        }

        public float getCourseFees()
        {
            return (float)this.getProperty("courseFees");
        }

        public void setCourseFees(float courseFees)
        {
            this.setProperty("courseFees", courseFees);
        }

        public float getOtherCosts()
        {
            return (float)this.getProperty("otherCosts");
        }

        public void setOtherCosts(float otherCosts)
        {
            this.setProperty("otherCosts", otherCosts);
        }


    }
}

