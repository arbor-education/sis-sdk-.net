using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class UserDefinedRecord : ModelBase
    {
        protected string resourceType = ResourceType.USER_DEFINED_RECORD;
        public const string ENTITY = "entity";
        public const string USER_DEFINED_FIELD = "userDefinedField";
        public const string VALUE = "value";

        public UserDefinedRecord()
        {
            base.resourceType = this.resourceType;
        }

        public UserDefinedRecord(string resourceType = "UserDefinedRecord", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<UserDefinedRecord> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UserDefinedRecord");
            RestGateway gateway = (RestGateway)UserDefinedRecord.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<UserDefinedRecord> userdefinedrecordCollection = new ModelCollection<UserDefinedRecord>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                userdefinedrecordCollection.add((UserDefinedRecord)model);
            }

            return userdefinedrecordCollection;
        }

        public static UserDefinedRecord retrieve(string id)
        {
            RestGateway gateway = (RestGateway)UserDefinedRecord.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (UserDefinedRecord)gateway.retrieve(ResourceType.USER_DEFINED_RECORD, id);
        }

        public ModelBase getEntity()
        {
            return (ModelBase)this.getProperty("entity");
        }

        public void setEntity(ModelBase entity)
        {
            this.setProperty("entity", entity);
        }

        public UserDefinedField getUserDefinedField()
        {
            return (UserDefinedField)this.getProperty("userDefinedField");
        }

        public void setUserDefinedField(UserDefinedField userDefinedField)
        {
            this.setProperty("userDefinedField", userDefinedField);
        }

        public string getValue()
        {
            return this.getProperty("value").ToString();
        }

        public void setValue(string value)
        {
            this.setProperty("value", value);
        }


    }
}

