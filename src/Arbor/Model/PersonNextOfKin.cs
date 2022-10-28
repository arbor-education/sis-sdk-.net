using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PersonNextOfKin : ModelBase
    {
        protected new string resourceType = ResourceType.PERSON_NEXT_OF_KIN;
        public const string PERSON = "person";
        public const string RELATED_PERSON = "relatedPerson";
        public const string RELATIONSHIP = "relationship";

        public PersonNextOfKin ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PersonNextOfKin (string resourceType = "PersonNextOfKin", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PersonNextOfKin> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("PersonNextOfKin");
        	RestGateway gateway = (RestGateway) PersonNextOfKin.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PersonNextOfKin> personnextofkinCollection = new ModelCollection<PersonNextOfKin> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    personnextofkinCollection.add((PersonNextOfKin) model);
        	}
        
        	return personnextofkinCollection;
        }

        public static PersonNextOfKin retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PersonNextOfKin.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PersonNextOfKin) gateway.retrieve(ResourceType.PERSON_NEXT_OF_KIN, id);
        }

        public Person getPerson ()
        {
            return (Person) this.getProperty("person");
        }

        public void setPerson (Person person)
        {
            this.setProperty("person", person);
        }

        public ModelBase getRelatedPerson ()
        {
            return (ModelBase) this.getProperty("relatedPerson");
        }

        public void setRelatedPerson (ModelBase relatedPerson)
        {
            this.setProperty("relatedPerson", relatedPerson);
        }

        public NextOfKinRelationship getRelationship ()
        {
            return (NextOfKinRelationship) this.getProperty("relationship");
        }

        public void setRelationship (NextOfKinRelationship relationship)
        {
            this.setProperty("relationship", relationship);
        }


    }
}

