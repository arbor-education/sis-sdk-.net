using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PersonCheck : ModelBase
    {
        protected string resourceType = ResourceType.PERSON_CHECK;
        public const string PERSON = "person";
        public const string CHECK_TYPE = "checkType";
        public const string CHECK_CLEARANCE_LEVEL = "checkClearanceLevel";
        public const string REQUESTED_DATE = "requestedDate";
        public const string RETURNED_DATE = "returnedDate";
        public const string EXPIRY_DATE = "expiryDate";
        public const string REFERENCE_NUMBER = "referenceNumber";
        public const string AUTHENTICATED_DATE = "authenticatedDate";
        public const string AUTHENTICATED_BY_STAFF = "authenticatedByStaff";
        public const string EVIDENCE_RECORDED_DATE = "evidenceRecordedDate";
        public const string COMMENT = "comment";

        public PersonCheck ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PersonCheck (string resourceType = "PersonCheck", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PersonCheck> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("PersonCheck");
        	RestGateway gateway = (RestGateway) PersonCheck.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PersonCheck> personcheckCollection = new ModelCollection<PersonCheck> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    personcheckCollection.add((PersonCheck) model);
        	}
        
        	return personcheckCollection;
        }

        public static PersonCheck retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PersonCheck.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PersonCheck) gateway.retrieve(ResourceType.PERSON_CHECK, id);
        }

        public ModelBase getPerson ()
        {
            return (ModelBase) this.getProperty("person");
        }

        public void setPerson (ModelBase person)
        {
            this.setProperty("person", person);
        }

        public CheckType getCheckType ()
        {
            return (CheckType) this.getProperty("checkType");
        }

        public void setCheckType (CheckType checkType)
        {
            this.setProperty("checkType", checkType);
        }

        public CheckClearanceLevel getCheckClearanceLevel ()
        {
            return (CheckClearanceLevel) this.getProperty("checkClearanceLevel");
        }

        public void setCheckClearanceLevel (CheckClearanceLevel checkClearanceLevel)
        {
            this.setProperty("checkClearanceLevel", checkClearanceLevel);
        }

        public DateTime getRequestedDate ()
        {
            return Convert.ToDateTime(this.getProperty("requestedDate"))
        }

        public void setRequestedDate (DateTime requestedDate)
        {
            this.setProperty("requestedDate", requestedDate);
        }

        public DateTime getReturnedDate ()
        {
            return Convert.ToDateTime(this.getProperty("returnedDate"))
        }

        public void setReturnedDate (DateTime returnedDate)
        {
            this.setProperty("returnedDate", returnedDate);
        }

        public DateTime getExpiryDate ()
        {
            return Convert.ToDateTime(this.getProperty("expiryDate"))
        }

        public void setExpiryDate (DateTime expiryDate)
        {
            this.setProperty("expiryDate", expiryDate);
        }

        public string getReferenceNumber ()
        {
            return this.getProperty("referenceNumber").ToString();
        }

        public void setReferenceNumber (string referenceNumber)
        {
            this.setProperty("referenceNumber", referenceNumber);
        }

        public DateTime getAuthenticatedDate ()
        {
            return Convert.ToDateTime(this.getProperty("authenticatedDate"))
        }

        public void setAuthenticatedDate (DateTime authenticatedDate)
        {
            this.setProperty("authenticatedDate", authenticatedDate);
        }

        public Staff getAuthenticatedByStaff ()
        {
            return (Staff) this.getProperty("authenticatedByStaff");
        }

        public void setAuthenticatedByStaff (Staff authenticatedByStaff)
        {
            this.setProperty("authenticatedByStaff", authenticatedByStaff);
        }

        public DateTime getEvidenceRecordedDate ()
        {
            return Convert.ToDateTime(this.getProperty("evidenceRecordedDate"))
        }

        public void setEvidenceRecordedDate (DateTime evidenceRecordedDate)
        {
            this.setProperty("evidenceRecordedDate", evidenceRecordedDate);
        }

        public string getComment ()
        {
            return this.getProperty("comment").ToString();
        }

        public void setComment (string comment)
        {
            this.setProperty("comment", comment);
        }


    }
}

