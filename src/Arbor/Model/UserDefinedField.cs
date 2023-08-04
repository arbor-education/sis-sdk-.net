using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class UserDefinedField : ModelBase
    {
        protected new string resourceType = ResourceType.USER_DEFINED_FIELD;
        public const string FIELD_NAME = "fieldName";
        public const string IDENTIFIER = "identifier";
        public const string RELATED_ENTITY_TYPE = "relatedEntityType";
        public const string FIELD_TYPE = "fieldType";
        public const string SOURCE = "source";
        public const string CODE = "code";
        public const string ACTIVE = "active";

        public UserDefinedField()
        {
            base.resourceType = this.resourceType;
        }

        public UserDefinedField(string resourceType = "UserDefinedField", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<UserDefinedField> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UserDefinedField");
            RestGateway gateway = (RestGateway)UserDefinedField.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<UserDefinedField> userdefinedfieldCollection = new ModelCollection<UserDefinedField>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                userdefinedfieldCollection.add((UserDefinedField)model);
            }

            return userdefinedfieldCollection;
        }

        public static UserDefinedField retrieve(string id)
        {
            RestGateway gateway = (RestGateway)UserDefinedField.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (UserDefinedField)gateway.retrieve(ResourceType.USER_DEFINED_FIELD, id);
        }

        public string getFieldName()
        {
            return this.getProperty("fieldName").ToString();
        }

        public void setFieldName(string fieldName)
        {
            this.setProperty("fieldName", fieldName);
        }

        public string getIdentifier()
        {
            return this.getProperty("identifier").ToString();
        }

        public void setIdentifier(string identifier)
        {
            this.setProperty("identifier", identifier);
        }

        public string getRelatedEntityType()
        {
            return this.getProperty("relatedEntityType").ToString();
        }

        public void setRelatedEntityType(string relatedEntityType)
        {
            this.setProperty("relatedEntityType", relatedEntityType);
        }

        public string getFieldType()
        {
            return this.getProperty("fieldType").ToString();
        }

        public void setFieldType(string fieldType)
        {
            this.setProperty("fieldType", fieldType);
        }

        public string getSource()
        {
            return this.getProperty("source").ToString();
        }

        public void setSource(string source)
        {
            this.setProperty("source", source);
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

