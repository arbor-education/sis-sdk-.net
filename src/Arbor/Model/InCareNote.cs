using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InCareNote : ModelBase
    {
        protected string resourceType = ResourceType.IN_CARE_NOTE;
        public const string STUDENT = "student";
        public const string SUMMARY = "summary";
        public const string CONTENT = "content";
        public const string NOTE_DATE = "noteDate";

        public InCareNote ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InCareNote (string resourceType = "InCareNote", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InCareNote> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InCareNote");
        	RestGateway gateway = (RestGateway) InCareNote.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InCareNote> incarenoteCollection = new ModelCollection<InCareNote> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    incarenoteCollection.add((InCareNote) model);
        	}
        
        	return incarenoteCollection;
        }

        public static InCareNote retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InCareNote.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InCareNote) gateway.retrieve(ResourceType.IN_CARE_NOTE, id);
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
            return (DateTime) this.getProperty("noteDate");
        }

        public void setNoteDate (DateTime noteDate)
        {
            this.setProperty("noteDate", noteDate);
        }


    }
}

