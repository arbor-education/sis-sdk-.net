using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BusinessRoleDefaultUserRole : ModelBase
    {
        protected new string resourceType = ResourceType.BUSINESS_ROLE_DEFAULT_USER_ROLE;
        public const string BUSINESS_ROLE = "businessRole";
        public const string USER_ROLE = "userRole";

        public BusinessRoleDefaultUserRole()
        {
            base.resourceType = this.resourceType;
        }

        public BusinessRoleDefaultUserRole(string resourceType = "BusinessRoleDefaultUserRole", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<BusinessRoleDefaultUserRole> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("BusinessRoleDefaultUserRole");
            RestGateway gateway = (RestGateway)BusinessRoleDefaultUserRole.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<BusinessRoleDefaultUserRole> businessroledefaultuserroleCollection = new ModelCollection<BusinessRoleDefaultUserRole>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                businessroledefaultuserroleCollection.add((BusinessRoleDefaultUserRole)model);
            }

            return businessroledefaultuserroleCollection;
        }

        public static BusinessRoleDefaultUserRole retrieve(string id)
        {
            RestGateway gateway = (RestGateway)BusinessRoleDefaultUserRole.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (BusinessRoleDefaultUserRole)gateway.retrieve(ResourceType.BUSINESS_ROLE_DEFAULT_USER_ROLE, id);
        }

        public BusinessRole getBusinessRole()
        {
            return (BusinessRole)this.getProperty("businessRole");
        }

        public void setBusinessRole(BusinessRole businessRole)
        {
            this.setProperty("businessRole", businessRole);
        }

        public UserRole getUserRole()
        {
            return (UserRole)this.getProperty("userRole");
        }

        public void setUserRole(UserRole userRole)
        {
            this.setProperty("userRole", userRole);
        }


    }
}

