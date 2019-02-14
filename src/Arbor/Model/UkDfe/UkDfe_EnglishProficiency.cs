using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_EnglishProficiency : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_ENGLISH_PROFICIENCY;
        public const string STUDENT = "student";
        public const string PROFICIENCY = "proficiency";
        public const string PROFICIENCY_DATE = "proficiencyDate";

        public UkDfe_EnglishProficiency ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_EnglishProficiency (string resourceType = "UkDfe_EnglishProficiency", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_EnglishProficiency> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_EnglishProficiency");
        	RestGateway gateway = (RestGateway) UkDfe_EnglishProficiency.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_EnglishProficiency> ukdfe_englishproficiencyCollection = new ModelCollection<UkDfe_EnglishProficiency> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_englishproficiencyCollection.add((UkDfe_EnglishProficiency) model);
        	}
        
        	return ukdfe_englishproficiencyCollection;
        }

        public static UkDfe_EnglishProficiency retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_EnglishProficiency.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_EnglishProficiency) gateway.retrieve(ResourceType.UK_DFE_ENGLISH_PROFICIENCY, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public string getProficiency ()
        {
            return this.getProperty("proficiency").ToString();
        }

        public void setProficiency (string proficiency)
        {
            this.setProperty("proficiency", proficiency);
        }

        public DateTime getProficiencyDate ()
        {
            return Convert.ToDateTime(this.getProperty("proficiencyDate"))
        }

        public void setProficiencyDate (DateTime proficiencyDate)
        {
            this.setProperty("proficiencyDate", proficiencyDate);
        }


    }
}

