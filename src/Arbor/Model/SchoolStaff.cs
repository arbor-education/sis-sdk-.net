using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SchoolStaff : ModelBase
    {
        protected string resourceType = ResourceType.SCHOOL_STAFF;
        public const string SCHOOL = "school";
        public const string PERSON = "person";
        public const string POSITION = "position";

        public SchoolStaff ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SchoolStaff (string resourceType = "SchoolStaff", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SchoolStaff> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SchoolStaff");
        	RestGateway gateway = (RestGateway) SchoolStaff.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SchoolStaff> schoolstaffCollection = new ModelCollection<SchoolStaff> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schoolstaffCollection.add((SchoolStaff) model);
        	}
        
        	return schoolstaffCollection;
        }

        public static SchoolStaff retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SchoolStaff.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SchoolStaff) gateway.retrieve(ResourceType.SCHOOL_STAFF, id);
        }

        public School getSchool ()
        {
            return (School) this.getProperty("school");
        }

        public void setSchool (School school)
        {
            this.setProperty("school", school);
        }

        public Person getPerson ()
        {
            return (Person) this.getProperty("person");
        }

        public void setPerson (Person person)
        {
            this.setProperty("person", person);
        }

        public string getPosition ()
        {
            return this.getProperty("position").ToString();
        }

        public void setPosition (string position)
        {
            this.setProperty("position", position);
        }


    }
}

