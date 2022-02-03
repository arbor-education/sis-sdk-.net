using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CompanyStaff : ModelBase
    {
        protected string resourceType = ResourceType.COMPANY_STAFF;
        public const string COMPANY = "company";
        public const string PERSON = "person";
        public const string POSITION = "position";

        public CompanyStaff ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CompanyStaff (string resourceType = "CompanyStaff", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CompanyStaff> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CompanyStaff");
        	RestGateway gateway = (RestGateway) CompanyStaff.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CompanyStaff> companystaffCollection = new ModelCollection<CompanyStaff> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    companystaffCollection.add((CompanyStaff) model);
        	}
        
        	return companystaffCollection;
        }

        public static CompanyStaff retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CompanyStaff.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CompanyStaff) gateway.retrieve(ResourceType.COMPANY_STAFF, id);
        }

        public Company getCompany ()
        {
            return (Company) this.getProperty("company");
        }

        public void setCompany (Company company)
        {
            this.setProperty("company", company);
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

