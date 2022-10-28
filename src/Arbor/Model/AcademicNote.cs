using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicNote : ModelBase
    {
        protected new string resourceType = ResourceType.ACADEMIC_NOTE;
        public const string STUDENT = "student";
        public const string ACADEMIC_UNIT = "academicUnit";
        public const string SUMMARY = "summary";
        public const string CONTENT = "content";
        public const string NOTE_CREATED_DATETIME = "noteCreatedDatetime";

        public AcademicNote()
        {
            base.resourceType = this.resourceType;
        }

        public AcademicNote(string resourceType = "AcademicNote", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AcademicNote> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AcademicNote");
            RestGateway gateway = (RestGateway)AcademicNote.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AcademicNote> academicnoteCollection = new ModelCollection<AcademicNote>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                academicnoteCollection.add((AcademicNote)model);
            }

            return academicnoteCollection;
        }

        public static AcademicNote retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AcademicNote.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AcademicNote)gateway.retrieve(ResourceType.ACADEMIC_NOTE, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public AcademicUnit getAcademicUnit()
        {
            return (AcademicUnit)this.getProperty("academicUnit");
        }

        public void setAcademicUnit(AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
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

        public DateTime getNoteCreatedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("noteCreatedDatetime"));
        }

        public void setNoteCreatedDatetime(DateTime noteCreatedDatetime)
        {
            this.setProperty("noteCreatedDatetime", noteCreatedDatetime);
        }


    }
}

