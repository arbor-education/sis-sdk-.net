using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MedicalNote : ModelBase
    {
        protected new string resourceType = ResourceType.MEDICAL_NOTE;
        public const string STUDENT = "student";
        public const string SUMMARY = "summary";
        public const string CONTENT = "content";
        public const string NOTE_DATE = "noteDate";

        public MedicalNote ()
        {
            base.resourceType = this.resourceType;
        }
        
        public MedicalNote (string resourceType = "MedicalNote", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<MedicalNote> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("MedicalNote");
        	RestGateway gateway = (RestGateway) MedicalNote.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<MedicalNote> medicalnoteCollection = new ModelCollection<MedicalNote> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    medicalnoteCollection.add((MedicalNote) model);
        	}
        
        	return medicalnoteCollection;
        }

        public static MedicalNote retrieve (string id)
        {
            RestGateway gateway = (RestGateway) MedicalNote.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (MedicalNote) gateway.retrieve(ResourceType.MEDICAL_NOTE, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public string getSummary ()
        {
            return this.getProperty("summary").ToString();
        }

        public void setSummary (string summary)
        {
            this.setProperty("summary", summary);
        }

        public string getContent ()
        {
            return this.getProperty("content").ToString();
        }

        public void setContent (string content)
        {
            this.setProperty("content", content);
        }

        public DateTime getNoteDate ()
        {
            return Convert.ToDateTime(this.getProperty("noteDate"));
        }

        public void setNoteDate (DateTime noteDate)
        {
            this.setProperty("noteDate", noteDate);
        }


    }
}

