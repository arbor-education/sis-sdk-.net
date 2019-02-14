using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Note : ModelBase
    {
        protected string resourceType = ResourceType.NOTE;
        public const string NOTE = "note";
        public const string REFERENCE_OBJECT = "referenceObject";
        public const string IS_SHARED_WITH_GUARDIANS = "isSharedWithGuardians";

        public Note ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Note (string resourceType = "Note", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Note> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Note");
        	RestGateway gateway = (RestGateway) Note.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Note> noteCollection = new ModelCollection<Note> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    noteCollection.add((Note) model);
        	}
        
        	return noteCollection;
        }

        public static Note retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Note.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Note) gateway.retrieve(ResourceType.NOTE, id);
        }

        public string getNote ()
        {
            return this.getProperty("note").ToString();
        }

        public void setNote (string note)
        {
            this.setProperty("note", note);
        }

        public ModelBase getReferenceObject ()
        {
            return (ModelBase) this.getProperty("referenceObject");
        }

        public void setReferenceObject (ModelBase referenceObject)
        {
            this.setProperty("referenceObject", referenceObject);
        }

        public bool getIsSharedWithGuardians ()
        {
            return Convert.ToBoolean(this.getProperty("isSharedWithGuardians"))
        }

        public void setIsSharedWithGuardians (bool isSharedWithGuardians)
        {
            this.setProperty("isSharedWithGuardians", isSharedWithGuardians);
        }


    }
}

