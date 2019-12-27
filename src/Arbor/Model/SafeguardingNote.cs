using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SafeguardingNote : ModelBase
    {
        protected string resourceType = ResourceType.SAFEGUARDING_NOTE;
        public const string STUDENT = "student";
        public const string DATE_LOGGED = "dateLogged";
        public const string SUMMARY = "summary";
        public const string CONTENT = "content";

        public SafeguardingNote ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SafeguardingNote (string resourceType = "SafeguardingNote", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SafeguardingNote> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SafeguardingNote");
        	RestGateway gateway = (RestGateway) SafeguardingNote.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SafeguardingNote> safeguardingnoteCollection = new ModelCollection<SafeguardingNote> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    safeguardingnoteCollection.add((SafeguardingNote) model);
        	}
        
        	return safeguardingnoteCollection;
        }

        public static SafeguardingNote retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SafeguardingNote.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SafeguardingNote) gateway.retrieve(ResourceType.SAFEGUARDING_NOTE, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getDateLogged ()
        {
            return Convert.ToDateTime(this.getProperty("dateLogged"));
        }

        public void setDateLogged (DateTime dateLogged)
        {
            this.setProperty("dateLogged", dateLogged);
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


    }
}

