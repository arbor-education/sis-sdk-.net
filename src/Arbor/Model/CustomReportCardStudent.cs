using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomReportCardStudent : ModelBase
    {
        protected new string resourceType = ResourceType.CUSTOM_REPORT_CARD_STUDENT;
        public const string CUSTOM_REPORT_CARD = "customReportCard";
        public const string STUDENT = "student";
        public const string STATUS = "status";
        public const string GENERATED_DATETIME = "generatedDatetime";

        public CustomReportCardStudent()
        {
            base.resourceType = this.resourceType;
        }

        public CustomReportCardStudent(string resourceType = "CustomReportCardStudent", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CustomReportCardStudent> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CustomReportCardStudent");
            RestGateway gateway = (RestGateway)CustomReportCardStudent.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CustomReportCardStudent> customreportcardstudentCollection = new ModelCollection<CustomReportCardStudent>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                customreportcardstudentCollection.add((CustomReportCardStudent)model);
            }

            return customreportcardstudentCollection;
        }

        public static CustomReportCardStudent retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CustomReportCardStudent.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CustomReportCardStudent)gateway.retrieve(ResourceType.CUSTOM_REPORT_CARD_STUDENT, id);
        }

        public CustomReportCard getCustomReportCard()
        {
            return (CustomReportCard)this.getProperty("customReportCard");
        }

        public void setCustomReportCard(CustomReportCard customReportCard)
        {
            this.setProperty("customReportCard", customReportCard);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public string getStatus()
        {
            return this.getProperty("status").ToString();
        }

        public void setStatus(string status)
        {
            this.setProperty("status", status);
        }

        public DateTime getGeneratedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("generatedDatetime"));
        }

        public void setGeneratedDatetime(DateTime generatedDatetime)
        {
            this.setProperty("generatedDatetime", generatedDatetime);
        }


    }
}

