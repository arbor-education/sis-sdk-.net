using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class UserDefinedFieldPermission : ModelBase
    {
        protected new string resourceType = ResourceType.USER_DEFINED_FIELD_PERMISSION;
        public const string USER_DEFINED_FIELD = "userDefinedField";
        public const string IDENTIFIER = "identifier";
        public const string CODE = "code";
        public const string ACTIVE = "active";

        public UserDefinedFieldPermission()
        {
            base.resourceType = this.resourceType;
        }

        public UserDefinedFieldPermission(string resourceType = "UserDefinedFieldPermission", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<UserDefinedFieldPermission> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UserDefinedFieldPermission");
            RestGateway gateway = (RestGateway)UserDefinedFieldPermission.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<UserDefinedFieldPermission> userdefinedfieldpermissionCollection = new ModelCollection<UserDefinedFieldPermission>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                userdefinedfieldpermissionCollection.add((UserDefinedFieldPermission)model);
            }

            return userdefinedfieldpermissionCollection;
        }

        public static UserDefinedFieldPermission retrieve(string id)
        {
            RestGateway gateway = (RestGateway)UserDefinedFieldPermission.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (UserDefinedFieldPermission)gateway.retrieve(ResourceType.USER_DEFINED_FIELD_PERMISSION, id);
        }

        public UserDefinedField getUserDefinedField()
        {
            return (UserDefinedField)this.getProperty("userDefinedField");
        }

        public void setUserDefinedField(UserDefinedField userDefinedField)
        {
            this.setProperty("userDefinedField", userDefinedField);
        }

        public string getIdentifier()
        {
            return this.getProperty("identifier").ToString();
        }

        public void setIdentifier(string identifier)
        {
            this.setProperty("identifier", identifier);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive(bool active)
        {
            this.setProperty("active", active);
        }


    }
}

