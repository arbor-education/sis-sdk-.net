using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SessionStream : ModelBase
    {
        protected string resourceType = ResourceType.SESSION_STREAM;
        public const string ACADEMIC_UNIT = "academicUnit";
        public const string CODE = "code";
        public const string SESSION_STREAM_NAME = "sessionStreamName";
        public const string DEFAULT_ROOM = "defaultRoom";

        public SessionStream ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SessionStream (string resourceType = "SessionStream", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SessionStream> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SessionStream");
        	RestGateway gateway = (RestGateway) SessionStream.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SessionStream> sessionstreamCollection = new ModelCollection<SessionStream> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    sessionstreamCollection.add((SessionStream) model);
        	}
        
        	return sessionstreamCollection;
        }

        public static SessionStream retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SessionStream.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SessionStream) gateway.retrieve(ResourceType.SESSION_STREAM, id);
        }

        public AcademicUnit getAcademicUnit ()
        {
            return (AcademicUnit) this.getProperty("academicUnit");
        }

        public void setAcademicUnit (AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public string getSessionStreamName ()
        {
            return this.getProperty("sessionStreamName").ToString();
        }

        public void setSessionStreamName (string sessionStreamName)
        {
            this.setProperty("sessionStreamName", sessionStreamName);
        }

        public Room getDefaultRoom ()
        {
            return (Room) this.getProperty("defaultRoom");
        }

        public void setDefaultRoom (Room defaultRoom)
        {
            this.setProperty("defaultRoom", defaultRoom);
        }


    }
}

