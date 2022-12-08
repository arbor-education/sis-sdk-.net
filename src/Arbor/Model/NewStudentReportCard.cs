using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class NewStudentReportCard : ModelBase
    {
        protected string resourceType = ResourceType.NEW_STUDENT_REPORT_CARD;
        public const string STUDENT = "student";
        public const string REPORT_CARD_BATCH = "reportCardBatch";
        public const string COMPLETED_DATETIME = "completedDatetime";
        public const string APPROVED_DATETIME = "approvedDatetime";

        public NewStudentReportCard()
        {
            base.resourceType = this.resourceType;
        }

        public NewStudentReportCard(string resourceType = "NewStudentReportCard", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<NewStudentReportCard> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("NewStudentReportCard");
            RestGateway gateway = (RestGateway)NewStudentReportCard.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<NewStudentReportCard> newstudentreportcardCollection = new ModelCollection<NewStudentReportCard>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                newstudentreportcardCollection.add((NewStudentReportCard)model);
            }

            return newstudentreportcardCollection;
        }

        public static NewStudentReportCard retrieve(string id)
        {
            RestGateway gateway = (RestGateway)NewStudentReportCard.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (NewStudentReportCard)gateway.retrieve(ResourceType.NEW_STUDENT_REPORT_CARD, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public NewReportCardBatch getReportCardBatch()
        {
            return (NewReportCardBatch)this.getProperty("reportCardBatch");
        }

        public void setReportCardBatch(NewReportCardBatch reportCardBatch)
        {
            this.setProperty("reportCardBatch", reportCardBatch);
        }

        public DateTime getCompletedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("completedDatetime"));
        }

        public void setCompletedDatetime(DateTime completedDatetime)
        {
            this.setProperty("completedDatetime", completedDatetime);
        }

        public DateTime getApprovedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("approvedDatetime"));
        }

        public void setApprovedDatetime(DateTime approvedDatetime)
        {
            this.setProperty("approvedDatetime", approvedDatetime);
        }


    }
}

