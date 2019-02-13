using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProgrammeLead : ModelBase
    {
        protected string resourceType = ResourceType.PROGRAMME_LEAD;
        public const string PROGRAMME = "programme";
        public const string STAFF = "staff";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public ProgrammeLead ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ProgrammeLead (string resourceType = "ProgrammeLead", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ProgrammeLead> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ProgrammeLead");
        	RestGateway gateway = (RestGateway) ProgrammeLead.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ProgrammeLead> programmeleadCollection = new ModelCollection<ProgrammeLead> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    programmeleadCollection.add((ProgrammeLead) model);
        	}
        
        	return programmeleadCollection;
        }

        public static ProgrammeLead retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ProgrammeLead.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ProgrammeLead) gateway.retrieve(ResourceType.PROGRAMME_LEAD, id);
        }

        public Programme getProgramme ()
        {
            return (Programme) this.getProperty("programme");
        }

        public void setProgramme (Programme programme)
        {
            this.setProperty("programme", programme);
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
            return Convert.ToDateTime(this.getProperty("startDate"))
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

