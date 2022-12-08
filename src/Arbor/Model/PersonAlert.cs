using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PersonAlert : ModelBase
    {
        protected string resourceType = ResourceType.PERSON_ALERT;
        public const string PERSON = "person";
        public const string CONTEXT_PERSON = "contextPerson";
        public const string CONTEXT_OBJECT = "contextObject";
        public const string TYPE = "type";
        public const string ALERT_DATETIME = "alertDatetime";

        public PersonAlert()
        {
            base.resourceType = this.resourceType;
        }

        public PersonAlert(string resourceType = "PersonAlert", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PersonAlert> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PersonAlert");
            RestGateway gateway = (RestGateway)PersonAlert.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PersonAlert> personalertCollection = new ModelCollection<PersonAlert>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                personalertCollection.add((PersonAlert)model);
            }

            return personalertCollection;
        }

        public static PersonAlert retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PersonAlert.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PersonAlert)gateway.retrieve(ResourceType.PERSON_ALERT, id);
        }

        public ModelBase getPerson()
        {
            return (ModelBase)this.getProperty("person");
        }

        public void setPerson(ModelBase person)
        {
            this.setProperty("person", person);
        }

        public ModelBase getContextPerson()
        {
            return (ModelBase)this.getProperty("contextPerson");
        }

        public void setContextPerson(ModelBase contextPerson)
        {
            this.setProperty("contextPerson", contextPerson);
        }

        public ModelBase getContextObject()
        {
            return (ModelBase)this.getProperty("contextObject");
        }

        public void setContextObject(ModelBase contextObject)
        {
            this.setProperty("contextObject", contextObject);
        }

        public string getType()
        {
            return this.getProperty("type").ToString();
        }

        public void setType(string type)
        {
            this.setProperty("type", type);
        }

        public DateTime getAlertDatetime()
        {
            return Convert.ToDateTime(this.getProperty("alertDatetime"));
        }

        public void setAlertDatetime(DateTime alertDatetime)
        {
            this.setProperty("alertDatetime", alertDatetime);
        }


    }
}

