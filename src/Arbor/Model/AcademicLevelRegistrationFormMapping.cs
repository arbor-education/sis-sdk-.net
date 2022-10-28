using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicLevelRegistrationFormMapping : ModelBase
    {
        protected new string resourceType = ResourceType.ACADEMIC_LEVEL_REGISTRATION_FORM_MAPPING;
        public const string ACADEMIC_LEVEL = "academicLevel";
        public const string REGISTRATION_FORM = "registrationForm";

        public AcademicLevelRegistrationFormMapping ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicLevelRegistrationFormMapping (string resourceType = "AcademicLevelRegistrationFormMapping", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicLevelRegistrationFormMapping> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicLevelRegistrationFormMapping");
        	RestGateway gateway = (RestGateway) AcademicLevelRegistrationFormMapping.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicLevelRegistrationFormMapping> academiclevelregistrationformmappingCollection = new ModelCollection<AcademicLevelRegistrationFormMapping> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academiclevelregistrationformmappingCollection.add((AcademicLevelRegistrationFormMapping) model);
        	}
        
        	return academiclevelregistrationformmappingCollection;
        }

        public static AcademicLevelRegistrationFormMapping retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicLevelRegistrationFormMapping.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicLevelRegistrationFormMapping) gateway.retrieve(ResourceType.ACADEMIC_LEVEL_REGISTRATION_FORM_MAPPING, id);
        }

        public AcademicLevel getAcademicLevel ()
        {
            return (AcademicLevel) this.getProperty("academicLevel");
        }

        public void setAcademicLevel (AcademicLevel academicLevel)
        {
            this.setProperty("academicLevel", academicLevel);
        }

        public RegistrationForm getRegistrationForm ()
        {
            return (RegistrationForm) this.getProperty("registrationForm");
        }

        public void setRegistrationForm (RegistrationForm registrationForm)
        {
            this.setProperty("registrationForm", registrationForm);
        }


    }
}

