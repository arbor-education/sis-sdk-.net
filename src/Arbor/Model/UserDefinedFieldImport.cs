using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class UserDefinedFieldImport : ModelBase
    {
        protected string resourceType = ResourceType.USER_DEFINED_FIELD_IMPORT;
        public const string ENTITY = "entity";
        public const string VALUE = "value";
        public const string ROW_INDEX = "rowIndex";
        public const string ERRORS = "errors";
        public const string REQUIRED_ERRORS = "requiredErrors";

        public UserDefinedFieldImport()
        {
            base.resourceType = this.resourceType;
        }

        public UserDefinedFieldImport(string resourceType = "UserDefinedFieldImport", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<UserDefinedFieldImport> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UserDefinedFieldImport");
            RestGateway gateway = (RestGateway)UserDefinedFieldImport.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<UserDefinedFieldImport> userdefinedfieldimportCollection = new ModelCollection<UserDefinedFieldImport>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                userdefinedfieldimportCollection.add((UserDefinedFieldImport)model);
            }

            return userdefinedfieldimportCollection;
        }

        public static UserDefinedFieldImport retrieve(string id)
        {
            RestGateway gateway = (RestGateway)UserDefinedFieldImport.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (UserDefinedFieldImport)gateway.retrieve(ResourceType.USER_DEFINED_FIELD_IMPORT, id);
        }

        public ModelBase getEntity()
        {
            return (ModelBase)this.getProperty("entity");
        }

        public void setEntity(ModelBase entity)
        {
            this.setProperty("entity", entity);
        }

        public string getValue()
        {
            return this.getProperty("value").ToString();
        }

        public void setValue(string value)
        {
            this.setProperty("value", value);
        }

        public int getRowIndex()
        {
            return Convert.ToInt32(this.getProperty("rowIndex"));
        }

        public void setRowIndex(int rowIndex)
        {
            this.setProperty("rowIndex", rowIndex);
        }

        public string getErrors()
        {
            return this.getProperty("errors").ToString();
        }

        public void setErrors(string errors)
        {
            this.setProperty("errors", errors);
        }

        public string getRequiredErrors()
        {
            return this.getProperty("requiredErrors").ToString();
        }

        public void setRequiredErrors(string requiredErrors)
        {
            this.setProperty("requiredErrors", requiredErrors);
        }


    }
}

