using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Guardian : ModelBase
    {
        protected new string resourceType = ResourceType.GUARDIAN;
        public const string PERSON = "person";
        public const string EMPLOYER = "employer";
        public const string RELIGION = "religion";
        public const string ETHNICITY = "ethnicity";
        public const string JOB_POSITION = "jobPosition";
        public const string BLOOD_GROUP = "bloodGroup";
        public const string SHARE_CONTACT_DETAILS = "shareContactDetails";
        public const string PREFERRED_CONTACT_METHOD = "preferredContactMethod";
        public const string LEGACY_SYSTEM_ID = "legacySystemId";
        public const string IS_KEY_WORKER = "isKeyWorker";
        public const string IS_ACTIVE_OUTGOING_SYNC = "isActiveOutgoingSync";
        public const string IS_ACTIVE_INCOMING_SYNC = "isActiveIncomingSync";

        public Guardian ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Guardian (string resourceType = "Guardian", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Guardian> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Guardian");
        	RestGateway gateway = (RestGateway) Guardian.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Guardian> guardianCollection = new ModelCollection<Guardian> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    guardianCollection.add((Guardian) model);
        	}
        
        	return guardianCollection;
        }

        public static Guardian retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Guardian.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Guardian) gateway.retrieve(ResourceType.GUARDIAN, id);
        }

        public Person getPerson ()
        {
            return (Person) this.getProperty("person");
        }

        public void setPerson (Person person)
        {
            this.setProperty("person", person);
        }

        public string getEmployer ()
        {
            return this.getProperty("employer").ToString();
        }

        public void setEmployer (string employer)
        {
            this.setProperty("employer", employer);
        }

        public Religion getReligion ()
        {
            return (Religion) this.getProperty("religion");
        }

        public void setReligion (Religion religion)
        {
            this.setProperty("religion", religion);
        }

        public Ethnicity getEthnicity ()
        {
            return (Ethnicity) this.getProperty("ethnicity");
        }

        public void setEthnicity (Ethnicity ethnicity)
        {
            this.setProperty("ethnicity", ethnicity);
        }

        public string getJobPosition ()
        {
            return this.getProperty("jobPosition").ToString();
        }

        public void setJobPosition (string jobPosition)
        {
            this.setProperty("jobPosition", jobPosition);
        }

        public string getBloodGroup ()
        {
            return this.getProperty("bloodGroup").ToString();
        }

        public void setBloodGroup (string bloodGroup)
        {
            this.setProperty("bloodGroup", bloodGroup);
        }

        public bool getShareContactDetails ()
        {
            return Convert.ToBoolean(this.getProperty("shareContactDetails"));
        }

        public void setShareContactDetails (bool shareContactDetails)
        {
            this.setProperty("shareContactDetails", shareContactDetails);
        }

        public string getPreferredContactMethod ()
        {
            return this.getProperty("preferredContactMethod").ToString();
        }

        public void setPreferredContactMethod (string preferredContactMethod)
        {
            this.setProperty("preferredContactMethod", preferredContactMethod);
        }

        public string getLegacySystemId ()
        {
            return this.getProperty("legacySystemId").ToString();
        }

        public void setLegacySystemId (string legacySystemId)
        {
            this.setProperty("legacySystemId", legacySystemId);
        }

        public bool getIsKeyWorker ()
        {
            return Convert.ToBoolean(this.getProperty("isKeyWorker"));
        }

        public void setIsKeyWorker (bool isKeyWorker)
        {
            this.setProperty("isKeyWorker", isKeyWorker);
        }

        public bool getIsActiveOutgoingSync ()
        {
            return Convert.ToBoolean(this.getProperty("isActiveOutgoingSync"));
        }

        public void setIsActiveOutgoingSync (bool isActiveOutgoingSync)
        {
            this.setProperty("isActiveOutgoingSync", isActiveOutgoingSync);
        }

        public bool getIsActiveIncomingSync ()
        {
            return Convert.ToBoolean(this.getProperty("isActiveIncomingSync"));
        }

        public void setIsActiveIncomingSync (bool isActiveIncomingSync)
        {
            this.setProperty("isActiveIncomingSync", isActiveIncomingSync);
        }


    }
}

