using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class HouseTutor : ModelBase
    {
        protected new string resourceType = ResourceType.HOUSE_TUTOR;
        public const string HOUSE = "house";
        public const string STAFF = "staff";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public HouseTutor ()
        {
            base.resourceType = this.resourceType;
        }
        
        public HouseTutor (string resourceType = "HouseTutor", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<HouseTutor> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("HouseTutor");
        	RestGateway gateway = (RestGateway) HouseTutor.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<HouseTutor> housetutorCollection = new ModelCollection<HouseTutor> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    housetutorCollection.add((HouseTutor) model);
        	}
        
        	return housetutorCollection;
        }

        public static HouseTutor retrieve (string id)
        {
            RestGateway gateway = (RestGateway) HouseTutor.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (HouseTutor) gateway.retrieve(ResourceType.HOUSE_TUTOR, id);
        }

        public House getHouse ()
        {
            return (House) this.getProperty("house");
        }

        public void setHouse (House house)
        {
            this.setProperty("house", house);
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
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

