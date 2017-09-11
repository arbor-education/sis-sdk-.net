using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class CtfImportJobStudent : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_CTF_IMPORT_JOB_STUDENT;
        public const string CTF_IMPORT_JOB = "ctfImportJob";
        public const string FIRST_NAME = "firstName";
        public const string LAST_NAME = "lastName";
        public const string DATE_OF_BIRTH = "dateOfBirth";
        public const string GENDER = "gender";
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
        public const string ATTENDANCE_PROCESSED = "attendanceProcessed";
        public const string STAGE_ASSESSMENTS_PROCESSED = "stageAssessmentsProcessed";
        public const string SCHOOL_HISTORY_PROCESSED = "schoolHistoryProcessed";
        public const string NAW_DETAILS_PROCESSED = "nawDetailsProcessed";
        public const string IMPORT_NAME = "importName";
        public const string IMPORT_DATE_OF_BIRTH = "importDateOfBirth";
        public const string IMPORT_LANGUAGES = "importLanguages";
        public const string IMPORT_DISABILITIES = "importDisabilities";
        public const string IMPORT_ADDRESS = "importAddress";
        public const string IMPORT_GUARDIANS = "importGuardians";
        public const string IMPORT_SEN = "importSen";
        public const string IMPORT_ATTENDANCE = "importAttendance";
        public const string IMPORT_ASSESSMENTS = "importAssessments";
        public const string IMPORT_SCHOOL_HISTORY = "importSchoolHistory";
        public const string IMPORT_LOOKED_AFTER = "importLookedAfter";
        public const string IMPORT_FSM = "importFsm";
        public const string IS_CURRENTLY_BEING_PROCESSED = "isCurrentlyBeingProcessed";
        public const string IMPORT_ERRORS = "importErrors";

        public CtfImportJobStudent ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CtfImportJobStudent (string resourceType = "CtfImportJobStudent", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CtfImportJobStudent> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_CtfImportJobStudent");
        	RestGateway gateway = (RestGateway) CtfImportJobStudent.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CtfImportJobStudent> ctfimportjobstudentCollection = new ModelCollection<CtfImportJobStudent> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ctfimportjobstudentCollection.add((CtfImportJobStudent) model);
        	}
        
        	return ctfimportjobstudentCollection;
        }

        public static CtfImportJobStudent retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CtfImportJobStudent.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CtfImportJobStudent) gateway.retrieve(ResourceType.UK_DFE_CTF_IMPORT_JOB_STUDENT, id);
        }

        public CtfImportJob getCtfImportJob ()
        {
            return (CtfImportJob) this.getProperty("ctfImportJob");
        }

        public void setCtfImportJob (CtfImportJob ctfImportJob)
        {
            this.setProperty("ctfImportJob", ctfImportJob);
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

        public DateTime getDateOfBirth ()
        {
            return (DateTime) this.getProperty("dateOfBirth");
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

        public DateTime getImportDatetime ()
        {
            return (DateTime) this.getProperty("importDatetime");
        }

        public void setImportDatetime (DateTime importDatetime)
        {
            this.setProperty("importDatetime", importDatetime);
        }

        public bool getBasicDetailsProcessed ()
        {
            return (bool) this.getProperty("basicDetailsProcessed");
        }

        public void setBasicDetailsProcessed (bool basicDetailsProcessed)
        {
            this.setProperty("basicDetailsProcessed", basicDetailsProcessed);
        }

        public bool getFsmHistoryProcessed ()
        {
            return (bool) this.getProperty("fsmHistoryProcessed");
        }

        public void setFsmHistoryProcessed (bool fsmHistoryProcessed)
        {
            this.setProperty("fsmHistoryProcessed", fsmHistoryProcessed);
        }

        public bool getLookedAfterProcessed ()
        {
            return (bool) this.getProperty("lookedAfterProcessed");
        }

        public void setLookedAfterProcessed (bool lookedAfterProcessed)
        {
            this.setProperty("lookedAfterProcessed", lookedAfterProcessed);
        }

        public bool getSenHistoryProcessed ()
        {
            return (bool) this.getProperty("senHistoryProcessed");
        }

        public void setSenHistoryProcessed (bool senHistoryProcessed)
        {
            this.setProperty("senHistoryProcessed", senHistoryProcessed);
        }

        public bool getAddressProcessed ()
        {
            return (bool) this.getProperty("addressProcessed");
        }

        public void setAddressProcessed (bool addressProcessed)
        {
            this.setProperty("addressProcessed", addressProcessed);
        }

        public bool getContactsProcessed ()
        {
            return (bool) this.getProperty("contactsProcessed");
        }

        public void setContactsProcessed (bool contactsProcessed)
        {
            this.setProperty("contactsProcessed", contactsProcessed);
        }

        public bool getAttendanceProcessed ()
        {
            return (bool) this.getProperty("attendanceProcessed");
        }

        public void setAttendanceProcessed (bool attendanceProcessed)
        {
            this.setProperty("attendanceProcessed", attendanceProcessed);
        }

        public bool getStageAssessmentsProcessed ()
        {
            return (bool) this.getProperty("stageAssessmentsProcessed");
        }

        public void setStageAssessmentsProcessed (bool stageAssessmentsProcessed)
        {
            this.setProperty("stageAssessmentsProcessed", stageAssessmentsProcessed);
        }

        public bool getSchoolHistoryProcessed ()
        {
            return (bool) this.getProperty("schoolHistoryProcessed");
        }

        public void setSchoolHistoryProcessed (bool schoolHistoryProcessed)
        {
            this.setProperty("schoolHistoryProcessed", schoolHistoryProcessed);
        }

        public bool getNawDetailsProcessed ()
        {
            return (bool) this.getProperty("nawDetailsProcessed");
        }

        public void setNawDetailsProcessed (bool nawDetailsProcessed)
        {
            this.setProperty("nawDetailsProcessed", nawDetailsProcessed);
        }

        public string getImportName ()
        {
            return this.getProperty("importName").ToString();
        }

        public void setImportName (string importName)
        {
            this.setProperty("importName", importName);
        }

        public string getImportDateOfBirth ()
        {
            return this.getProperty("importDateOfBirth").ToString();
        }

        public void setImportDateOfBirth (string importDateOfBirth)
        {
            this.setProperty("importDateOfBirth", importDateOfBirth);
        }

        public string getImportLanguages ()
        {
            return this.getProperty("importLanguages").ToString();
        }

        public void setImportLanguages (string importLanguages)
        {
            this.setProperty("importLanguages", importLanguages);
        }

        public string getImportDisabilities ()
        {
            return this.getProperty("importDisabilities").ToString();
        }

        public void setImportDisabilities (string importDisabilities)
        {
            this.setProperty("importDisabilities", importDisabilities);
        }

        public string getImportAddress ()
        {
            return this.getProperty("importAddress").ToString();
        }

        public void setImportAddress (string importAddress)
        {
            this.setProperty("importAddress", importAddress);
        }

        public string getImportGuardians ()
        {
            return this.getProperty("importGuardians").ToString();
        }

        public void setImportGuardians (string importGuardians)
        {
            this.setProperty("importGuardians", importGuardians);
        }

        public string getImportSen ()
        {
            return this.getProperty("importSen").ToString();
        }

        public void setImportSen (string importSen)
        {
            this.setProperty("importSen", importSen);
        }

        public string getImportAttendance ()
        {
            return this.getProperty("importAttendance").ToString();
        }

        public void setImportAttendance (string importAttendance)
        {
            this.setProperty("importAttendance", importAttendance);
        }

        public string getImportAssessments ()
        {
            return this.getProperty("importAssessments").ToString();
        }

        public void setImportAssessments (string importAssessments)
        {
            this.setProperty("importAssessments", importAssessments);
        }

        public string getImportSchoolHistory ()
        {
            return this.getProperty("importSchoolHistory").ToString();
        }

        public void setImportSchoolHistory (string importSchoolHistory)
        {
            this.setProperty("importSchoolHistory", importSchoolHistory);
        }

        public string getImportLookedAfter ()
        {
            return this.getProperty("importLookedAfter").ToString();
        }

        public void setImportLookedAfter (string importLookedAfter)
        {
            this.setProperty("importLookedAfter", importLookedAfter);
        }

        public string getImportFsm ()
        {
            return this.getProperty("importFsm").ToString();
        }

        public void setImportFsm (string importFsm)
        {
            this.setProperty("importFsm", importFsm);
        }

        public bool getIsCurrentlyBeingProcessed ()
        {
            return (bool) this.getProperty("isCurrentlyBeingProcessed");
        }

        public void setIsCurrentlyBeingProcessed (bool isCurrentlyBeingProcessed)
        {
            this.setProperty("isCurrentlyBeingProcessed", isCurrentlyBeingProcessed);
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

