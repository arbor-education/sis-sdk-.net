using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class LessonPlanSectionItem : ModelBase
    {
        protected new string resourceType = ResourceType.LESSON_PLAN_SECTION_ITEM;
        public const string LESSON_PLAN_SECTION = "lessonPlanSection";
        public const string LINKED_ITEM = "linkedItem";
        public const string NARRATIVE = "narrative";
        public const string TEACHER_NOTES = "teacherNotes";
        public const string DISPLAY_ORDER = "displayOrder";

        public LessonPlanSectionItem()
        {
            base.resourceType = this.resourceType;
        }

        public LessonPlanSectionItem(string resourceType = "LessonPlanSectionItem", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<LessonPlanSectionItem> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("LessonPlanSectionItem");
            RestGateway gateway = (RestGateway)LessonPlanSectionItem.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<LessonPlanSectionItem> lessonplansectionitemCollection = new ModelCollection<LessonPlanSectionItem>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                lessonplansectionitemCollection.add((LessonPlanSectionItem)model);
            }

            return lessonplansectionitemCollection;
        }

        public static LessonPlanSectionItem retrieve(string id)
        {
            RestGateway gateway = (RestGateway)LessonPlanSectionItem.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (LessonPlanSectionItem)gateway.retrieve(ResourceType.LESSON_PLAN_SECTION_ITEM, id);
        }

        public LessonPlanSection getLessonPlanSection()
        {
            return (LessonPlanSection)this.getProperty("lessonPlanSection");
        }

        public void setLessonPlanSection(LessonPlanSection lessonPlanSection)
        {
            this.setProperty("lessonPlanSection", lessonPlanSection);
        }

        public ModelBase getLinkedItem()
        {
            return (ModelBase)this.getProperty("linkedItem");
        }

        public void setLinkedItem(ModelBase linkedItem)
        {
            this.setProperty("linkedItem", linkedItem);
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

