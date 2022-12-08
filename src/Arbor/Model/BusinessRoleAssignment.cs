using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BusinessRoleAssignment : ModelBase
    {
        protected string resourceType = ResourceType.BUSINESS_ROLE_ASSIGNMENT;
        public const string BUSINESS_ROLE = "businessRole";
        public const string STAFF_CONTRACT_POST = "staffContractPost";
        public const string PERSON = "person";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public BusinessRoleAssignment()
        {
            base.resourceType = this.resourceType;
        }

        public BusinessRoleAssignment(string resourceType = "BusinessRoleAssignment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<BusinessRoleAssignment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("BusinessRoleAssignment");
            RestGateway gateway = (RestGateway)BusinessRoleAssignment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<BusinessRoleAssignment> businessroleassignmentCollection = new ModelCollection<BusinessRoleAssignment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                businessroleassignmentCollection.add((BusinessRoleAssignment)model);
            }

            return businessroleassignmentCollection;
        }

        public static BusinessRoleAssignment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)BusinessRoleAssignment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (BusinessRoleAssignment)gateway.retrieve(ResourceType.BUSINESS_ROLE_ASSIGNMENT, id);
        }

        public BusinessRole getBusinessRole()
        {
            return (BusinessRole)this.getProperty("businessRole");
        }

        public void setBusinessRole(BusinessRole businessRole)
        {
            this.setProperty("businessRole", businessRole);
        }

        public StaffContractPost getStaffContractPost()
        {
            return (StaffContractPost)this.getProperty("staffContractPost");
        }

        public void setStaffContractPost(StaffContractPost staffContractPost)
        {
            this.setProperty("staffContractPost", staffContractPost);
        }

        public ModelBase getPerson()
        {
            return (ModelBase)this.getProperty("person");
        }

        public void setPerson(ModelBase person)
        {
            this.setProperty("person", person);
        }

        public DateTime getStartDate()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate(DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate(DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

