using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class HouseAutomaticEnrolment : ModelBase
    {
        protected string resourceType = ResourceType.HOUSE_AUTOMATIC_ENROLMENT;
        public const string HOUSE = "house";
        public const string TRIGGER = "trigger";

        public HouseAutomaticEnrolment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public HouseAutomaticEnrolment (string resourceType = "HouseAutomaticEnrolment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<HouseAutomaticEnrolment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("HouseAutomaticEnrolment");
        	RestGateway gateway = (RestGateway) HouseAutomaticEnrolment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<HouseAutomaticEnrolment> houseautomaticenrolmentCollection = new ModelCollection<HouseAutomaticEnrolment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    houseautomaticenrolmentCollection.add((HouseAutomaticEnrolment) model);
        	}
        
        	return houseautomaticenrolmentCollection;
        }

        public static HouseAutomaticEnrolment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) HouseAutomaticEnrolment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (HouseAutomaticEnrolment) gateway.retrieve(ResourceType.HOUSE_AUTOMATIC_ENROLMENT, id);
        }

        public House getHouse ()
        {
            return (House) this.getProperty("house");
        }

        public void setHouse (House house)
        {
            this.setProperty("house", house);
        }

        public RegistrationForm getTrigger ()
        {
            return (RegistrationForm) this.getProperty("trigger");
        }

        public void setTrigger (RegistrationForm trigger)
        {
            this.setProperty("trigger", trigger);
        }


    }
}

