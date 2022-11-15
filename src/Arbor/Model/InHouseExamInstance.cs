using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InHouseExamInstance : ModelBase
    {
        protected new string resourceType = ResourceType.IN_HOUSE_EXAM_INSTANCE;
        public const string IN_HOUSE_EXAM = "inHouseExam";
        public const string EXPECTED_START_DATETIME = "expectedStartDatetime";
        public const string EXPECTED_END_DATETIME = "expectedEndDatetime";

        public InHouseExamInstance()
        {
            base.resourceType = this.resourceType;
        }

        public InHouseExamInstance(string resourceType = "InHouseExamInstance", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<InHouseExamInstance> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("InHouseExamInstance");
            RestGateway gateway = (RestGateway)InHouseExamInstance.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<InHouseExamInstance> inhouseexaminstanceCollection = new ModelCollection<InHouseExamInstance>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                inhouseexaminstanceCollection.add((InHouseExamInstance)model);
            }

            return inhouseexaminstanceCollection;
        }

        public static InHouseExamInstance retrieve(string id)
        {
            RestGateway gateway = (RestGateway)InHouseExamInstance.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (InHouseExamInstance)gateway.retrieve(ResourceType.IN_HOUSE_EXAM_INSTANCE, id);
        }

        public InHouseExam getInHouseExam()
        {
            return (InHouseExam)this.getProperty("inHouseExam");
        }

        public void setInHouseExam(InHouseExam inHouseExam)
        {
            this.setProperty("inHouseExam", inHouseExam);
        }

        public DateTime getExpectedStartDatetime()
        {
            return Convert.ToDateTime(this.getProperty("expectedStartDatetime"));
        }

        public void setExpectedStartDatetime(DateTime expectedStartDatetime)
        {
            this.setProperty("expectedStartDatetime", expectedStartDatetime);
        }

        public DateTime getExpectedEndDatetime()
        {
            return Convert.ToDateTime(this.getProperty("expectedEndDatetime"));
        }

        public void setExpectedEndDatetime(DateTime expectedEndDatetime)
        {
            this.setProperty("expectedEndDatetime", expectedEndDatetime);
        }


    }
}

