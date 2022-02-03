using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;
using System.Collections;

namespace Arbor.Model
{
    public class RegistrationForm : ModelBase
    {
        protected string resourceType = ResourceType.REGISTRATION_FORM;
        public const string CODE = "code";
        public const string REGISTRATION_FORM_NAME = "registrationFormName";
        public const string SHORT_NAME = "shortName";
        public const string ROOM = "room";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string PROMOTED_TO_REGISTRATION_FORM = "promotedToRegistrationForm";
        public const string PROMOTED_DATETIME = "promotedDatetime";
        public const string COPIED_TO_REGISTRATION_FORM = "copiedToRegistrationForm";
        public const string DISPLAY_ORDER = "displayOrder";
        public const string TARGET_ENROLMENT = "targetEnrolment";

        public RegistrationForm ()
        {
            base.resourceType = this.resourceType;
        }
        
        public RegistrationForm (string resourceType = "RegistrationForm", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<RegistrationForm> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("RegistrationForm");
        	RestGateway gateway = (RestGateway) RegistrationForm.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<RegistrationForm> registrationformCollection = new ModelCollection<RegistrationForm> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    registrationformCollection.add((RegistrationForm) model);
        	}
        
        	return registrationformCollection;
        }

        public static RegistrationForm retrieve (string id)
        {
            RestGateway gateway = (RestGateway) RegistrationForm.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (RegistrationForm) gateway.retrieve(ResourceType.REGISTRATION_FORM, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public string getRegistrationFormName ()
        {
            return this.getProperty("registrationFormName").ToString();
        }

        public void setRegistrationFormName (string registrationFormName)
        {
            this.setProperty("registrationFormName", registrationFormName);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public Room getRoom ()
        {
            return (Room) this.getProperty("room");
        }

        public void setRoom (Room room)
        {
            this.setProperty("room", room);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public RegistrationForm getPromotedToRegistrationForm ()
        {
            return (RegistrationForm) this.getProperty("promotedToRegistrationForm");
        }

        public void setPromotedToRegistrationForm (RegistrationForm promotedToRegistrationForm)
        {
            this.setProperty("promotedToRegistrationForm", promotedToRegistrationForm);
        }

        public DateTime getPromotedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("promotedDatetime"));
        }

        public void setPromotedDatetime (DateTime promotedDatetime)
        {
            this.setProperty("promotedDatetime", promotedDatetime);
        }

        public RegistrationForm getCopiedToRegistrationForm ()
        {
            return (RegistrationForm) this.getProperty("copiedToRegistrationForm");
        }

        public void setCopiedToRegistrationForm (RegistrationForm copiedToRegistrationForm)
        {
            this.setProperty("copiedToRegistrationForm", copiedToRegistrationForm);
        }

        public int getDisplayOrder ()
        {
            return Convert.ToInt32(this.getProperty("displayOrder"));
        }

        public void setDisplayOrder (int displayOrder)
        {
            this.setProperty("displayOrder", displayOrder);
        }

        public int getTargetEnrolment ()
        {
            return Convert.ToInt32(this.getProperty("targetEnrolment"));
        }

        public void setTargetEnrolment (int targetEnrolment)
        {
            this.setProperty("targetEnrolment", targetEnrolment);
        }

        public ModelCollection<RegistrationFormTutor> getTutors ()
        {
            ModelCollection<ModelBase> collection = (ModelCollection<ModelBase>) this.getCollectionProperty("tutors");
        	return (ModelCollection<RegistrationFormTutor>) this.getApiGateway().castCollection<RegistrationFormTutor>(collection);
        }

        public ModelCollection<RegistrationFormMembership> getStudentMemberships ()
        {
            ModelCollection<ModelBase> collection = (ModelCollection<ModelBase>) this.getCollectionProperty("studentMemberships");
        	return (ModelCollection<RegistrationFormMembership>) this.getApiGateway().castCollection<RegistrationFormMembership>(collection);
        }


    }
}

