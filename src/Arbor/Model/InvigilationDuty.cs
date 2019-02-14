using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InvigilationDuty : ModelBase
    {
        protected string resourceType = ResourceType.INVIGILATION_DUTY;
        public const string INVIGILATION_SESSION = "invigilationSession";
        public const string STAFF = "staff";
        public const string ADDITIONAL_ROLE = "additionalRole";
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";

        public InvigilationDuty ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InvigilationDuty (string resourceType = "InvigilationDuty", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InvigilationDuty> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InvigilationDuty");
        	RestGateway gateway = (RestGateway) InvigilationDuty.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InvigilationDuty> invigilationdutyCollection = new ModelCollection<InvigilationDuty> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    invigilationdutyCollection.add((InvigilationDuty) model);
        	}
        
        	return invigilationdutyCollection;
        }

        public static InvigilationDuty retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InvigilationDuty.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InvigilationDuty) gateway.retrieve(ResourceType.INVIGILATION_DUTY, id);
        }

        public InvigilationSession getInvigilationSession ()
        {
            return (InvigilationSession) this.getProperty("invigilationSession");
        }

        public void setInvigilationSession (InvigilationSession invigilationSession)
        {
            this.setProperty("invigilationSession", invigilationSession);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public string getAdditionalRole ()
        {
            return this.getProperty("additionalRole").ToString();
        }

        public void setAdditionalRole (string additionalRole)
        {
            this.setProperty("additionalRole", additionalRole);
        }

        public DateTime getStartDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("startDatetime"))
        }

        public void setStartDatetime (DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("endDatetime"))
        }

        public void setEndDatetime (DateTime endDatetime)
        {
            this.setProperty("endDatetime", endDatetime);
        }


    }
}

