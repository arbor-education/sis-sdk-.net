using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentDestinationType : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_DESTINATION_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string LABEL = "label";
        public const string IS_EDUCATION = "isEducation";
        public const string IS_EMPLOYMENT = "isEmployment";
        public const string LINKED_ENTITY_TYPE = "linkedEntityType";

        public StudentDestinationType()
        {
            base.resourceType = this.resourceType;
        }

        public StudentDestinationType(string resourceType = "StudentDestinationType", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StudentDestinationType> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StudentDestinationType");
            RestGateway gateway = (RestGateway)StudentDestinationType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StudentDestinationType> studentdestinationtypeCollection = new ModelCollection<StudentDestinationType>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                studentdestinationtypeCollection.add((StudentDestinationType)model);
            }

            return studentdestinationtypeCollection;
        }

        public static StudentDestinationType retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StudentDestinationType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StudentDestinationType)gateway.retrieve(ResourceType.STUDENT_DESTINATION_TYPE, id);
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

        public int getDataOrder()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder(int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getLabel()
        {
            return this.getProperty("label").ToString();
        }

        public void setLabel(string label)
        {
            this.setProperty("label", label);
        }

        public bool getIsEducation()
        {
            return Convert.ToBoolean(this.getProperty("isEducation"));
        }

        public void setIsEducation(bool isEducation)
        {
            this.setProperty("isEducation", isEducation);
        }

        public bool getIsEmployment()
        {
            return Convert.ToBoolean(this.getProperty("isEmployment"));
        }

        public void setIsEmployment(bool isEmployment)
        {
            this.setProperty("isEmployment", isEmployment);
        }

        public int getLinkedEntityType()
        {
            return Convert.ToInt32(this.getProperty("linkedEntityType"));
        }

        public void setLinkedEntityType(int linkedEntityType)
        {
            this.setProperty("linkedEntityType", linkedEntityType);
        }


    }
}

