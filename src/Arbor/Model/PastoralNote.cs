using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PastoralNote : ModelBase
    {
        protected new string resourceType = ResourceType.PASTORAL_NOTE;
        public const string STUDENT = "student";
        public const string SUMMARY = "summary";
        public const string CONTENT = "content";
        public const string NOTE_DATE = "noteDate";

        public PastoralNote()
        {
            base.resourceType = this.resourceType;
        }

        public PastoralNote(string resourceType = "PastoralNote", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PastoralNote> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PastoralNote");
            RestGateway gateway = (RestGateway)PastoralNote.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PastoralNote> pastoralnoteCollection = new ModelCollection<PastoralNote>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                pastoralnoteCollection.add((PastoralNote)model);
            }

            return pastoralnoteCollection;
        }

        public static PastoralNote retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PastoralNote.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PastoralNote)gateway.retrieve(ResourceType.PASTORAL_NOTE, id);
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

