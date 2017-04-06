using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentReportCard : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_REPORT_CARD;
        public const string STUDENT = "student";
        public const string REPORT_CARD_TEMPLATE = "reportCardTemplate";
        public const string REPORT_CARD_BATCH = "reportCardBatch";
        public const string REPORT_CARD_BATCH_TARGET = "reportCardBatchTarget";
        public const string REPORTING_PERIOD_START_DATE = "reportingPeriodStartDate";
        public const string REPORTING_PERIOD_END_DATE = "reportingPeriodEndDate";
        public const string DUE_DATE = "dueDate";
        public const string COMPLETED_DATETIME = "completedDatetime";
        public const string APPROVED_DATETIME = "approvedDatetime";

        public StudentReportCard ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentReportCard (string resourceType = "StudentReportCard", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentReportCard> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentReportCard");
        	RestGateway gateway = (RestGateway) StudentReportCard.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentReportCard> studentreportcardCollection = new ModelCollection<StudentReportCard> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentreportcardCollection.add((StudentReportCard) model);
        	}
        
        	return studentreportcardCollection;
        }

        public static StudentReportCard retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentReportCard.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentReportCard) gateway.retrieve(ResourceType.STUDENT_REPORT_CARD, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public ReportCardTemplate getReportCardTemplate ()
        {
            return (ReportCardTemplate) this.getProperty("reportCardTemplate");
        }

        public void setReportCardTemplate (ReportCardTemplate reportCardTemplate)
        {
            this.setProperty("reportCardTemplate", reportCardTemplate);
        }

        public ReportCardBatch getReportCardBatch ()
        {
            return (ReportCardBatch) this.getProperty("reportCardBatch");
        }

        public void setReportCardBatch (ReportCardBatch reportCardBatch)
        {
            this.setProperty("reportCardBatch", reportCardBatch);
        }

        public ReportCardBatchTarget getReportCardBatchTarget ()
        {
            return (ReportCardBatchTarget) this.getProperty("reportCardBatchTarget");
        }

        public void setReportCardBatchTarget (ReportCardBatchTarget reportCardBatchTarget)
        {
            this.setProperty("reportCardBatchTarget", reportCardBatchTarget);
        }

        public DateTime getReportingPeriodStartDate ()
        {
            return (DateTime) this.getProperty("reportingPeriodStartDate");
        }

        public void setReportingPeriodStartDate (DateTime reportingPeriodStartDate)
        {
            this.setProperty("reportingPeriodStartDate", reportingPeriodStartDate);
        }

        public DateTime getReportingPeriodEndDate ()
        {
            return (DateTime) this.getProperty("reportingPeriodEndDate");
        }

        public void setReportingPeriodEndDate (DateTime reportingPeriodEndDate)
        {
            this.setProperty("reportingPeriodEndDate", reportingPeriodEndDate);
        }

        public DateTime getDueDate ()
        {
            return (DateTime) this.getProperty("dueDate");
        }

        public void setDueDate (DateTime dueDate)
        {
            this.setProperty("dueDate", dueDate);
        }

        public DateTime getCompletedDatetime ()
        {
            return (DateTime) this.getProperty("completedDatetime");
        }

        public void setCompletedDatetime (DateTime completedDatetime)
        {
            this.setProperty("completedDatetime", completedDatetime);
        }

        public DateTime getApprovedDatetime ()
        {
            return (DateTime) this.getProperty("approvedDatetime");
        }

        public void setApprovedDatetime (DateTime approvedDatetime)
        {
            this.setProperty("approvedDatetime", approvedDatetime);
        }


    }
}

