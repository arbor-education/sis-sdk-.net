using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class LessonPlanSection : ModelBase
    {
        protected new string resourceType = ResourceType.LESSON_PLAN_SECTION;
        public const string LESSON_PLAN = "lessonPlan";
        public const string NARRATIVE = "narrative";
        public const string TEACHER_NOTES = "teacherNotes";
        public const string SECTION_TYPE = "sectionType";
        public const string EXPECTED_DURATION = "expectedDuration";
        public const string DISPLAY_ORDER = "displayOrder";

        public LessonPlanSection()
        {
            base.resourceType = this.resourceType;
        }

        public LessonPlanSection(string resourceType = "LessonPlanSection", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<LessonPlanSection> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("LessonPlanSection");
            RestGateway gateway = (RestGateway)LessonPlanSection.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<LessonPlanSection> lessonplansectionCollection = new ModelCollection<LessonPlanSection>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                lessonplansectionCollection.add((LessonPlanSection)model);
            }

            return lessonplansectionCollection;
        }

        public static LessonPlanSection retrieve(string id)
        {
            RestGateway gateway = (RestGateway)LessonPlanSection.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (LessonPlanSection)gateway.retrieve(ResourceType.LESSON_PLAN_SECTION, id);
        }

        public LessonPlan getLessonPlan()
        {
            return (LessonPlan)this.getProperty("lessonPlan");
        }

        public void setLessonPlan(LessonPlan lessonPlan)
        {
            this.setProperty("lessonPlan", lessonPlan);
        }

        public string getNarrative()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative(string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public string getTeacherNotes()
        {
            return this.getProperty("teacherNotes").ToString();
        }

        public void setTeacherNotes(string teacherNotes)
        {
            this.setProperty("teacherNotes", teacherNotes);
        }

        public string getSectionType()
        {
            return this.getProperty("sectionType").ToString();
        }

        public void setSectionType(string sectionType)
        {
            this.setProperty("sectionType", sectionType);
        }

        public string getExpectedDuration()
        {
            return this.getProperty("expectedDuration").ToString();
        }

        public void setExpectedDuration(string expectedDuration)
        {
            this.setProperty("expectedDuration", expectedDuration);
        }

        public int getDisplayOrder()
        {
            return Convert.ToInt32(this.getProperty("displayOrder"));
        }

        public void setDisplayOrder(int displayOrder)
        {
            this.setProperty("displayOrder", displayOrder);
        }


    }
}

