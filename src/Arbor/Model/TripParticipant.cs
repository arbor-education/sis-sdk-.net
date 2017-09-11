using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TripParticipant : ModelBase
    {
        protected string resourceType = ResourceType.TRIP_PARTICIPANT;
        public const string TRIP = "trip";
        public const string STUDENT = "student";
        public const string CUSTOMER_INVOICE = "customerInvoice";
        public const string CONSENT_RECEIVED = "consentReceived";

        public TripParticipant ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TripParticipant (string resourceType = "TripParticipant", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TripParticipant> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("TripParticipant");
        	RestGateway gateway = (RestGateway) TripParticipant.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TripParticipant> tripparticipantCollection = new ModelCollection<TripParticipant> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    tripparticipantCollection.add((TripParticipant) model);
        	}
        
        	return tripparticipantCollection;
        }

        public static TripParticipant retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TripParticipant.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TripParticipant) gateway.retrieve(ResourceType.TRIP_PARTICIPANT, id);
        }

        public Trip getTrip ()
        {
            return (Trip) this.getProperty("trip");
        }

        public void setTrip (Trip trip)
        {
            this.setProperty("trip", trip);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public CustomerInvoice getCustomerInvoice ()
        {
            return (CustomerInvoice) this.getProperty("customerInvoice");
        }

        public void setCustomerInvoice (CustomerInvoice customerInvoice)
        {
            this.setProperty("customerInvoice", customerInvoice);
        }

        public bool getConsentReceived ()
        {
            return (bool) this.getProperty("consentReceived");
        }

        public void setConsentReceived (bool consentReceived)
        {
            this.setProperty("consentReceived", consentReceived);
        }


    }
}

