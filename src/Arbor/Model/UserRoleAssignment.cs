using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class UserRoleAssignment : ModelBase
    {
        protected string resourceType = ResourceType.USER_ROLE_ASSIGNMENT;
        public const string USER = "user";
        public const string USER_ROLE = "userRole";
        public const string BUSINESS_ROLE_ASSIGNMENT = "businessRoleAssignment";
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";

        public UserRoleAssignment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UserRoleAssignment (string resourceType = "UserRoleAssignment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UserRoleAssignment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UserRoleAssignment");
        	RestGateway gateway = (RestGateway) UserRoleAssignment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UserRoleAssignment> userroleassignmentCollection = new ModelCollection<UserRoleAssignment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    userroleassignmentCollection.add((UserRoleAssignment) model);
        	}
        
        	return userroleassignmentCollection;
        }

        public static UserRoleAssignment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UserRoleAssignment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UserRoleAssignment) gateway.retrieve(ResourceType.USER_ROLE_ASSIGNMENT, id);
        }

        public User getUser ()
        {
            return (User) this.getProperty("user");
        }

        public void setUser (User user)
        {
            this.setProperty("user", user);
        }

        public UserRole getUserRole ()
        {
            return (UserRole) this.getProperty("userRole");
        }

        public void setUserRole (UserRole userRole)
        {
            this.setProperty("userRole", userRole);
        }

        public BusinessRoleAssignment getBusinessRoleAssignment ()
        {
            return (BusinessRoleAssignment) this.getProperty("businessRoleAssignment");
        }

        public void setBusinessRoleAssignment (BusinessRoleAssignment businessRoleAssignment)
        {
            this.setProperty("businessRoleAssignment", businessRoleAssignment);
        }

        public DateTime getStartDatetime ()
        {
            return (DateTime) this.getProperty("startDatetime");
        }

        public void setStartDatetime (DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime ()
        {
            return (DateTime) this.getProperty("endDatetime");
        }

        public void setEndDatetime (DateTime endDatetime)
        {
            this.setProperty("endDatetime", endDatetime);
        }


    }
}

