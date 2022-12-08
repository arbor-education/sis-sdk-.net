using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ChildProtectionNote : ModelBase
    {
        protected string resourceType = ResourceType.CHILD_PROTECTION_NOTE;
        public const string STUDENT = "student";
        public const string SUMMARY = "summary";
        public const string CONTENT = "content";
        public const string NOTE_DATE = "noteDate";

        public ChildProtectionNote()
        {
            base.resourceType = this.resourceType;
        }

        public ChildProtectionNote(string resourceType = "ChildProtectionNote", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ChildProtectionNote> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ChildProtectionNote");
            RestGateway gateway = (RestGateway)ChildProtectionNote.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ChildProtectionNote> childprotectionnoteCollection = new ModelCollection<ChildProtectionNote>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                childprotectionnoteCollection.add((ChildProtectionNote)model);
            }

            return childprotectionnoteCollection;
        }

        public static ChildProtectionNote retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ChildProtectionNote.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ChildProtectionNote)gateway.retrieve(ResourceType.CHILD_PROTECTION_NOTE, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public string getSummary()
        {
            return this.getProperty("summary").ToString();
        }

        public void setSummary(string summary)
        {
            this.setProperty("summary", summary);
        }

        public string getContent()
        {
            return this.getProperty("content").ToString();
        }

        public void setContent(string content)
        {
            this.setProperty("content", content);
        }

        public DateTime getNoteDate()
        {
            return Convert.ToDateTime(this.getProperty("noteDate"));
        }

        public void setNoteDate(DateTime noteDate)
        {
            this.setProperty("noteDate", noteDate);
        }


    }
}

