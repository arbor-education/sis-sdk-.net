using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class RegistrationFormTutor : ModelBase
    {
        protected string resourceType = ResourceType.REGISTRATION_FORM_TUTOR;
        public const string REGISTRATION_FORM = "registrationForm";
        public const string STAFF = "staff";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public RegistrationFormTutor ()
        {
            base.resourceType = this.resourceType;
        }
        
        public RegistrationFormTutor (string resourceType = "RegistrationFormTutor", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<RegistrationFormTutor> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("RegistrationFormTutor");
        	RestGateway gateway = (RestGateway) RegistrationFormTutor.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<RegistrationFormTutor> registrationformtutorCollection = new ModelCollection<RegistrationFormTutor> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    registrationformtutorCollection.add((RegistrationFormTutor) model);
        	}
        
        	return registrationformtutorCollection;
        }

        public static RegistrationFormTutor retrieve (string id)
        {
            RestGateway gateway = (RestGateway) RegistrationFormTutor.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (RegistrationFormTutor) gateway.retrieve(ResourceType.REGISTRATION_FORM_TUTOR, id);
        }

        public RegistrationForm getRegistrationForm ()
        {
            return (RegistrationForm) this.getProperty("registrationForm");
        }

        public void setRegistrationForm (RegistrationForm registrationForm)
        {
            this.setProperty("registrationForm", registrationForm);
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

