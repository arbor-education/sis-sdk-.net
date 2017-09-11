using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Staff : ModelBase
    {
        protected string resourceType = ResourceType.STAFF;
        public const string ELIGIBLE_FOR_SCHOOL_WORKFORCE_RETURN = "eligibleForSchoolWorkforceReturn";
        public const string QUALIFIED_TEACHER_STATUS = "qualifiedTeacherStatus";
        public const string QUALIFIED_TEACHER_ROUTE = "qualifiedTeacherRoute";
        public const string HLTA_STATUS = "hltaStatus";
        public const string PERSON = "person";
        public const string ETHNICITY = "ethnicity";
        public const string RELIGION = "religion";
        public const string BLOOD_GROUP = "bloodGroup";
        public const string STAFF_NUMBER = "staffNumber";
        public const string ZENDESK_USER = "zendeskUser";
        public const string TIMETABLE_ABBREVIATION = "timetableAbbreviation";
        public const string LEGACY_SYSTEM_ID = "legacySystemId";

        public Staff ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Staff (string resourceType = "Staff", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Staff> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Staff");
        	RestGateway gateway = (RestGateway) Staff.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Staff> staffCollection = new ModelCollection<Staff> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    staffCollection.add((Staff) model);
        	}
        
        	return staffCollection;
        }

        public static Staff retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Staff.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Staff) gateway.retrieve(ResourceType.STAFF, id);
        }

        public bool getEligibleForSchoolWorkforceReturn ()
        {
            return (bool) this.getProperty("eligibleForSchoolWorkforceReturn");
        }

        public void setEligibleForSchoolWorkforceReturn (bool eligibleForSchoolWorkforceReturn)
        {
            this.setProperty("eligibleForSchoolWorkforceReturn", eligibleForSchoolWorkforceReturn);
        }

        public bool getQualifiedTeacherStatus ()
        {
            return (bool) this.getProperty("qualifiedTeacherStatus");
        }

        public void setQualifiedTeacherStatus (bool qualifiedTeacherStatus)
        {
            this.setProperty("qualifiedTeacherStatus", qualifiedTeacherStatus);
        }

        public QualifiedTeacherRoute getQualifiedTeacherRoute ()
        {
            return (QualifiedTeacherRoute) this.getProperty("qualifiedTeacherRoute");
        }

        public void setQualifiedTeacherRoute (QualifiedTeacherRoute qualifiedTeacherRoute)
        {
            this.setProperty("qualifiedTeacherRoute", qualifiedTeacherRoute);
        }

        public bool getHltaStatus ()
        {
            return (bool) this.getProperty("hltaStatus");
        }

        public void setHltaStatus (bool hltaStatus)
        {
            this.setProperty("hltaStatus", hltaStatus);
        }

        public Person getPerson ()
        {
            return (Person) this.getProperty("person");
        }

        public void setPerson (Person person)
        {
            this.setProperty("person", person);
        }

        public Ethnicity getEthnicity ()
        {
            return (Ethnicity) this.getProperty("ethnicity");
        }

        public void setEthnicity (Ethnicity ethnicity)
        {
            this.setProperty("ethnicity", ethnicity);
        }

        public Religion getReligion ()
        {
            return (Religion) this.getProperty("religion");
        }

        public void setReligion (Religion religion)
        {
            this.setProperty("religion", religion);
        }

        public string getBloodGroup ()
        {
            return this.getProperty("bloodGroup").ToString();
        }

        public void setBloodGroup (string bloodGroup)
        {
            this.setProperty("bloodGroup", bloodGroup);
        }

        public string getStaffNumber ()
        {
            return this.getProperty("staffNumber").ToString();
        }

        public void setStaffNumber (string staffNumber)
        {
            this.setProperty("staffNumber", staffNumber);
        }

        public string getZendeskUser ()
        {
            return this.getProperty("zendeskUser").ToString();
        }

        public void setZendeskUser (string zendeskUser)
        {
            this.setProperty("zendeskUser", zendeskUser);
        }

        public string getTimetableAbbreviation ()
        {
            return this.getProperty("timetableAbbreviation").ToString();
        }

        public void setTimetableAbbreviation (string timetableAbbreviation)
        {
            this.setProperty("timetableAbbreviation", timetableAbbreviation);
        }

        public string getLegacySystemId ()
        {
            return this.getProperty("legacySystemId").ToString();
        }

        public void setLegacySystemId (string legacySystemId)
        {
            this.setProperty("legacySystemId", legacySystemId);
        }


    }
}

