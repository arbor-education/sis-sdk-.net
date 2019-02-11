using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class AtfImportJobStudent : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_ATF_IMPORT_JOB_STUDENT;
        public const string ATF_IMPORT_JOB = "atfImportJob";
        public const string FIRST_NAME = "firstName";
        public const string LAST_NAME = "lastName";
        public const string DATE_OF_BIRTH = "dateOfBirth";
        public const string GENDER = "gender";
        public const string APPLICATION_REFERENCE = "applicationReference";
        public const string UPN = "upn";
        public const string UNIQUE_LEARNER_NUMBER = "uniqueLearnerNumber";
        public const string UNIQUE_CANDIDATE_IDENTIFIER = "uniqueCandidateIdentifier";
        public const string STUDENT = "student";
        public const string IMPORT_DATETIME = "importDatetime";
        public const string BASIC_DETAILS_PROCESSED = "basicDetailsProcessed";
        public const string FSM_HISTORY_PROCESSED = "fsmHistoryProcessed";
        public const string LOOKED_AFTER_PROCESSED = "lookedAfterProcessed";
        public const string SEN_HISTORY_PROCESSED = "senHistoryProcessed";
        public const string ADDRESS_PROCESSED = "addressProcessed";
        public const string CONTACTS_PROCESSED = "contactsProcessed";
        public const string SCHOOL_HISTORY_PROCESSED = "schoolHistoryProcessed";
        public const string IMPORT_ERRORS = "importErrors";

        public AtfImportJobStudent ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AtfImportJobStudent (string resourceType = "AtfImportJobStudent", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AtfImportJobStudent> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_AtfImportJobStudent");
        	RestGateway gateway = (RestGateway) AtfImportJobStudent.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AtfImportJobStudent> atfimportjobstudentCollection = new ModelCollection<AtfImportJobStudent> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    atfimportjobstudentCollection.add((AtfImportJobStudent) model);
        	}
        
        	return atfimportjobstudentCollection;
        }

        public static AtfImportJobStudent retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AtfImportJobStudent.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AtfImportJobStudent) gateway.retrieve(ResourceType.UK_DFE_ATF_IMPORT_JOB_STUDENT, id);
        }

        public AtfImportJob getAtfImportJob ()
        {
            return (AtfImportJob) this.getProperty("atfImportJob");
        }

        public void setAtfImportJob (AtfImportJob atfImportJob)
        {
            this.setProperty("atfImportJob", atfImportJob);
        }

        public string getFirstName ()
        {
            return this.getProperty("firstName").ToString();
        }

        public void setFirstName (string firstName)
        {
            this.setProperty("firstName", firstName);
        }

        public string getLastName ()
        {
            return this.getProperty("lastName").ToString();
        }

        public void setLastName (string lastName)
        {
            this.setProperty("lastName", lastName);
        }

        public DateTime getDateOfBirth (){
            return Convert.ToDateTime(this.getProperty("dateOfBirth"));
        }

        public void setDateOfBirth (DateTime dateOfBirth)
        {
            this.setProperty("dateOfBirth", dateOfBirth);
        }

        public Gender getGender ()
        {
            return (Gender) this.getProperty("gender");
        }

        public void setGender (Gender gender)
        {
            this.setProperty("gender", gender);
        }

        public string getApplicationReference ()
        {
            return this.getProperty("applicationReference").ToString();
        }

        public void setApplicationReference (string applicationReference)
        {
            this.setProperty("applicationReference", applicationReference);
        }

        public string getUpn ()
        {
            return this.getProperty("upn").ToString();
        }

        public void setUpn (string upn)
        {
            this.setProperty("upn", upn);
        }

        public string getUniqueLearnerNumber ()
        {
            return this.getProperty("uniqueLearnerNumber").ToString();
        }

        public void setUniqueLearnerNumber (string uniqueLearnerNumber)
        {
            this.setProperty("uniqueLearnerNumber", uniqueLearnerNumber);
        }

        public string getUniqueCandidateIdentifier ()
        {
            return this.getProperty("uniqueCandidateIdentifier").ToString();
        }

        public void setUniqueCandidateIdentifier (string uniqueCandidateIdentifier)
        {
            this.setProperty("uniqueCandidateIdentifier", uniqueCandidateIdentifier);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getImportDatetime (){
            return Convert.ToDateTime(this.getProperty("importDatetime"));
        }

        public void setImportDatetime (DateTime importDatetime)
        {
            this.setProperty("importDatetime", importDatetime);
        }

        public bool getBasicDetailsProcessed ()
        {
            return Convert.ToBoolean( this.getProperty("basicDetailsProcessed"));
        }

        public void setBasicDetailsProcessed (bool basicDetailsProcessed)
        {
            this.setProperty("basicDetailsProcessed", basicDetailsProcessed);
        }

        public bool getFsmHistoryProcessed ()
        {
            return Convert.ToBoolean( this.getProperty("fsmHistoryProcessed"));
        }

        public void setFsmHistoryProcessed (bool fsmHistoryProcessed)
        {
            this.setProperty("fsmHistoryProcessed", fsmHistoryProcessed);
        }

        public bool getLookedAfterProcessed ()
        {
            return Convert.ToBoolean( this.getProperty("lookedAfterProcessed"));
        }

        public void setLookedAfterProcessed (bool lookedAfterProcessed)
        {
            this.setProperty("lookedAfterProcessed", lookedAfterProcessed);
        }

        public bool getSenHistoryProcessed ()
        {
            return Convert.ToBoolean( this.getProperty("senHistoryProcessed"));
        }

        public void setSenHistoryProcessed (bool senHistoryProcessed)
        {
            this.setProperty("senHistoryProcessed", senHistoryProcessed);
        }

        public bool getAddressProcessed ()
        {
            return Convert.ToBoolean( this.getProperty("addressProcessed"));
        }

        public void setAddressProcessed (bool addressProcessed)
        {
            this.setProperty("addressProcessed", addressProcessed);
        }

        public bool getContactsProcessed ()
        {
            return Convert.ToBoolean( this.getProperty("contactsProcessed"));
        }

        public void setContactsProcessed (bool contactsProcessed)
        {
            this.setProperty("contactsProcessed", contactsProcessed);
        }

        public bool getSchoolHistoryProcessed ()
        {
            return Convert.ToBoolean( this.getProperty("schoolHistoryProcessed"));
        }

        public void setSchoolHistoryProcessed (bool schoolHistoryProcessed)
        {
            this.setProperty("schoolHistoryProcessed", schoolHistoryProcessed);
        }

        public string getImportErrors ()
        {
            return this.getProperty("importErrors").ToString();
        }

        public void setImportErrors (string importErrors)
        {
            this.setProperty("importErrors", importErrors);
        }


    }
}

