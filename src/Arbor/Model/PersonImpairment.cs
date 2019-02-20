using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PersonImpairment : ModelBase
    {
        protected string resourceType = ResourceType.PERSON_IMPAIRMENT;
        public const string PERSON = "person";
        public const string PERSON_IMPAIRMENT_NAME = "personImpairmentName";
        public const string IMPAIRMENT_CATEGORY = "impairmentCategory";
        public const string DATE_ADVISED = "dateAdvised";
        public const string AFFECTS_WORKING_ABILITY = "affectsWorkingAbility";

        public PersonImpairment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PersonImpairment (string resourceType = "PersonImpairment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PersonImpairment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("PersonImpairment");
        	RestGateway gateway = (RestGateway) PersonImpairment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PersonImpairment> personimpairmentCollection = new ModelCollection<PersonImpairment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    personimpairmentCollection.add((PersonImpairment) model);
        	}
        
        	return personimpairmentCollection;
        }

        public static PersonImpairment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PersonImpairment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PersonImpairment) gateway.retrieve(ResourceType.PERSON_IMPAIRMENT, id);
        }

        public ModelBase getPerson ()
        {
            return (ModelBase) this.getProperty("person");
        }

        public void setPerson (ModelBase person)
        {
            this.setProperty("person", person);
        }

        public string getPersonImpairmentName ()
        {
            return this.getProperty("personImpairmentName").ToString();
        }

        public void setPersonImpairmentName (string personImpairmentName)
        {
            this.setProperty("personImpairmentName", personImpairmentName);
        }

        public ImpairmentCategory getImpairmentCategory ()
        {
            return (ImpairmentCategory) this.getProperty("impairmentCategory");
        }

        public void setImpairmentCategory (ImpairmentCategory impairmentCategory)
        {
            this.setProperty("impairmentCategory", impairmentCategory);
        }

        public DateTime getDateAdvised ()
        {
            return Convert.ToDateTime(this.getProperty("dateAdvised"));
        }

        public void setDateAdvised (DateTime dateAdvised)
        {
            this.setProperty("dateAdvised", dateAdvised);
        }

        public bool getAffectsWorkingAbility ()
        {
            return Convert.ToBoolean(this.getProperty("affectsWorkingAbility"));
        }

        public void setAffectsWorkingAbility (bool affectsWorkingAbility)
        {
            this.setProperty("affectsWorkingAbility", affectsWorkingAbility);
        }


    }
}

