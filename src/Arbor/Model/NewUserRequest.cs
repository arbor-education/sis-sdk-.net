using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class NewUserRequest : ModelBase
    {
        protected string resourceType = ResourceType.NEW_USER_REQUEST;
        public const string BUSINESS_ROLE = "businessRole";
        public const string TITLE = "title";
        public const string FIRST_NAME = "firstName";
        public const string LAST_NAME = "lastName";
        public const string EMAIL = "email";
        public const string MOBILE_NUMBER = "mobileNumber";
        public const string APPROVED_DATETIME = "approvedDatetime";
        public const string REJECTED_DATETIME = "rejectedDatetime";
        public const string SELECTED_APPROVER_STAFF = "selectedApproverStaff";
        public const string APPROVERS_EXIST = "approversExist";

        public NewUserRequest ()
        {
            base.resourceType = this.resourceType;
        }
        
        public NewUserRequest (string resourceType = "NewUserRequest", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<NewUserRequest> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("NewUserRequest");
        	RestGateway gateway = (RestGateway) NewUserRequest.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<NewUserRequest> newuserrequestCollection = new ModelCollection<NewUserRequest> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    newuserrequestCollection.add((NewUserRequest) model);
        	}
        
        	return newuserrequestCollection;
        }

        public static NewUserRequest retrieve (string id)
        {
            RestGateway gateway = (RestGateway) NewUserRequest.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (NewUserRequest) gateway.retrieve(ResourceType.NEW_USER_REQUEST, id);
        }

        public BusinessRole getBusinessRole ()
        {
            return (BusinessRole) this.getProperty("businessRole");
        }

        public void setBusinessRole (BusinessRole businessRole)
        {
            this.setProperty("businessRole", businessRole);
        }

        public Title getTitle ()
        {
            return (Title) this.getProperty("title");
        }

        public void setTitle (Title title)
        {
            this.setProperty("title", title);
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

        public string getEmail ()
        {
            return this.getProperty("email").ToString();
        }

        public void setEmail (string email)
        {
            this.setProperty("email", email);
        }

        public string getMobileNumber ()
        {
            return this.getProperty("mobileNumber").ToString();
        }

        public void setMobileNumber (string mobileNumber)
        {
            this.setProperty("mobileNumber", mobileNumber);
        }

        public DateTime getApprovedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("approvedDatetime"))
        }

        public void setApprovedDatetime (DateTime approvedDatetime)
        {
            this.setProperty("approvedDatetime", approvedDatetime);
        }

        public DateTime getRejectedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("rejectedDatetime"))
        }

        public void setRejectedDatetime (DateTime rejectedDatetime)
        {
            this.setProperty("rejectedDatetime", rejectedDatetime);
        }

        public Staff getSelectedApproverStaff ()
        {
            return (Staff) this.getProperty("selectedApproverStaff");
        }

        public void setSelectedApproverStaff (Staff selectedApproverStaff)
        {
            this.setProperty("selectedApproverStaff", selectedApproverStaff);
        }

        public bool getApproversExist ()
        {
            return Convert.ToBoolean(this.getProperty("approversExist"))
        }

        public void setApproversExist (bool approversExist)
        {
            this.setProperty("approversExist", approversExist);
        }


    }
}

