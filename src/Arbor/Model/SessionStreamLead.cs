using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SessionStreamLead : ModelBase
    {
        protected string resourceType = ResourceType.SESSION_STREAM_LEAD;
        public const string SESSION_STREAM = "sessionStream";
        public const string STAFF = "staff";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public SessionStreamLead ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SessionStreamLead (string resourceType = "SessionStreamLead", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SessionStreamLead> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SessionStreamLead");
        	RestGateway gateway = (RestGateway) SessionStreamLead.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SessionStreamLead> sessionstreamleadCollection = new ModelCollection<SessionStreamLead> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    sessionstreamleadCollection.add((SessionStreamLead) model);
        	}
        
        	return sessionstreamleadCollection;
        }

        public static SessionStreamLead retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SessionStreamLead.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SessionStreamLead) gateway.retrieve(ResourceType.SESSION_STREAM_LEAD, id);
        }

        public SessionStream getSessionStream ()
        {
            return (SessionStream) this.getProperty("sessionStream");
        }

        public void setSessionStream (SessionStream sessionStream)
        {
            this.setProperty("sessionStream", sessionStream);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public DateTime getStartDate ()
        {
            return (DateTime) this.getProperty("startDate");
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return (DateTime) this.getProperty("endDate");
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

