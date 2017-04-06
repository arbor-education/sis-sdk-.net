using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BusinessRole : ModelBase
    {
        protected string resourceType = ResourceType.BUSINESS_ROLE;
        public const string SWF_CENSUS_IDENTIFIER = "swfCensusIdentifier";
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string BUSINESS_ROLE_NAME = "businessRoleName";
        public const string USER_DEFINED_NAME = "userDefinedName";
        public const string BUSINESS_ROLE_DESCRIPTION = "businessRoleDescription";
        public const string INTERNAL_STAFF = "internalStaff";
        public const string TEACHING_STAFF = "teachingStaff";
        public const string CUSTOMER_MANAGES_DEFAULT_USER_ROLES = "customerManagesDefaultUserRoles";

        public BusinessRole ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BusinessRole (string resourceType = "BusinessRole", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BusinessRole> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BusinessRole");
        	RestGateway gateway = (RestGateway) BusinessRole.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BusinessRole> businessroleCollection = new ModelCollection<BusinessRole> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    businessroleCollection.add((BusinessRole) model);
        	}
        
        	return businessroleCollection;
        }

        public static BusinessRole retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BusinessRole.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BusinessRole) gateway.retrieve(ResourceType.BUSINESS_ROLE, id);
        }

        public string getSwfCensusIdentifier ()
        {
            return this.getProperty("swfCensusIdentifier").ToString();
        }

        public void setSwfCensusIdentifier (string swfCensusIdentifier)
        {
            this.setProperty("swfCensusIdentifier", swfCensusIdentifier);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return (bool) this.getProperty("active");
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getBusinessRoleName ()
        {
            return this.getProperty("businessRoleName").ToString();
        }

        public void setBusinessRoleName (string businessRoleName)
        {
            this.setProperty("businessRoleName", businessRoleName);
        }

        public string getUserDefinedName ()
        {
            return this.getProperty("userDefinedName").ToString();
        }

        public void setUserDefinedName (string userDefinedName)
        {
            this.setProperty("userDefinedName", userDefinedName);
        }

        public string getBusinessRoleDescription ()
        {
            return this.getProperty("businessRoleDescription").ToString();
        }

        public void setBusinessRoleDescription (string businessRoleDescription)
        {
            this.setProperty("businessRoleDescription", businessRoleDescription);
        }

        public bool getInternalStaff ()
        {
            return (bool) this.getProperty("internalStaff");
        }

        public void setInternalStaff (bool internalStaff)
        {
            this.setProperty("internalStaff", internalStaff);
        }

        public bool getTeachingStaff ()
        {
            return (bool) this.getProperty("teachingStaff");
        }

        public void setTeachingStaff (bool teachingStaff)
        {
            this.setProperty("teachingStaff", teachingStaff);
        }

        public bool getCustomerManagesDefaultUserRoles ()
        {
            return (bool) this.getProperty("customerManagesDefaultUserRoles");
        }

        public void setCustomerManagesDefaultUserRoles (bool customerManagesDefaultUserRoles)
        {
            this.setProperty("customerManagesDefaultUserRoles", customerManagesDefaultUserRoles);
        }


    }
}

