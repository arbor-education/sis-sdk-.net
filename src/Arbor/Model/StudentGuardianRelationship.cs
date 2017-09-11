using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentGuardianRelationship : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_GUARDIAN_RELATIONSHIP;
        public const string STUDENT = "student";
        public const string GUARDIAN = "guardian";
        public const string GUARDIAN_RELATIONSHIP_TYPE = "guardianRelationshipType";
        public const string IS_LEGAL_GUARDIAN = "isLegalGuardian";
        public const string IS_PRIMARY_GUARDIAN = "isPrimaryGuardian";
        public const string IS_AUTHORIZED_TO_COLLECT = "isAuthorizedToCollect";
        public const string EMERGENCY_CONTACT_PRIORITY = "emergencyContactPriority";
        public const string UNSUBSCRIBED_FROM_COMMS = "unsubscribedFromComms";
        public const string GUARDIAN_USER_AUTHORIZED = "guardianUserAuthorized";
        public const string ACCESS_NOTES = "accessNotes";

        public StudentGuardianRelationship ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentGuardianRelationship (string resourceType = "StudentGuardianRelationship", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentGuardianRelationship> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentGuardianRelationship");
        	RestGateway gateway = (RestGateway) StudentGuardianRelationship.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentGuardianRelationship> studentguardianrelationshipCollection = new ModelCollection<StudentGuardianRelationship> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentguardianrelationshipCollection.add((StudentGuardianRelationship) model);
        	}
        
        	return studentguardianrelationshipCollection;
        }

        public static StudentGuardianRelationship retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentGuardianRelationship.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentGuardianRelationship) gateway.retrieve(ResourceType.STUDENT_GUARDIAN_RELATIONSHIP, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public Guardian getGuardian ()
        {
            return (Guardian) this.getProperty("guardian");
        }

        public void setGuardian (Guardian guardian)
        {
            this.setProperty("guardian", guardian);
        }

        public GuardianRelationshipType getGuardianRelationshipType ()
        {
            return (GuardianRelationshipType) this.getProperty("guardianRelationshipType");
        }

        public void setGuardianRelationshipType (GuardianRelationshipType guardianRelationshipType)
        {
            this.setProperty("guardianRelationshipType", guardianRelationshipType);
        }

        public bool getIsLegalGuardian ()
        {
            return (bool) this.getProperty("isLegalGuardian");
        }

        public void setIsLegalGuardian (bool isLegalGuardian)
        {
            this.setProperty("isLegalGuardian", isLegalGuardian);
        }

        public bool getIsPrimaryGuardian ()
        {
            return (bool) this.getProperty("isPrimaryGuardian");
        }

        public void setIsPrimaryGuardian (bool isPrimaryGuardian)
        {
            this.setProperty("isPrimaryGuardian", isPrimaryGuardian);
        }

        public bool getIsAuthorizedToCollect ()
        {
            return (bool) this.getProperty("isAuthorizedToCollect");
        }

        public void setIsAuthorizedToCollect (bool isAuthorizedToCollect)
        {
            this.setProperty("isAuthorizedToCollect", isAuthorizedToCollect);
        }

        public string getEmergencyContactPriority ()
        {
            return this.getProperty("emergencyContactPriority").ToString();
        }

        public void setEmergencyContactPriority (string emergencyContactPriority)
        {
            this.setProperty("emergencyContactPriority", emergencyContactPriority);
        }

        public bool getUnsubscribedFromComms ()
        {
            return (bool) this.getProperty("unsubscribedFromComms");
        }

        public void setUnsubscribedFromComms (bool unsubscribedFromComms)
        {
            this.setProperty("unsubscribedFromComms", unsubscribedFromComms);
        }

        public bool getGuardianUserAuthorized ()
        {
            return (bool) this.getProperty("guardianUserAuthorized");
        }

        public void setGuardianUserAuthorized (bool guardianUserAuthorized)
        {
            this.setProperty("guardianUserAuthorized", guardianUserAuthorized);
        }

        public string getAccessNotes ()
        {
            return this.getProperty("accessNotes").ToString();
        }

        public void setAccessNotes (string accessNotes)
        {
            this.setProperty("accessNotes", accessNotes);
        }


    }
}

