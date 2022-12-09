using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EducationPlan : ModelBase
    {
        protected new string resourceType = ResourceType.EDUCATION_PLAN;
        public const string STUDENT = "student";
        public const string EDUCATION_PLAN_TYPE = "educationPlanType";
        public const string SUMMARY = "summary";
        public const string CONTENT = "content";
        public const string START_DATE = "startDate";
        public const string SCHEDULED_REVIEW_DATE = "scheduledReviewDate";
        public const string END_DATE = "endDate";

        public EducationPlan()
        {
            base.resourceType = this.resourceType;
        }

        public EducationPlan(string resourceType = "EducationPlan", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EducationPlan> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("EducationPlan");
            RestGateway gateway = (RestGateway)EducationPlan.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EducationPlan> educationplanCollection = new ModelCollection<EducationPlan>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                educationplanCollection.add((EducationPlan)model);
            }

            return educationplanCollection;
        }

        public static EducationPlan retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EducationPlan.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EducationPlan)gateway.retrieve(ResourceType.EDUCATION_PLAN, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public string getEducationPlanType()
        {
            return this.getProperty("educationPlanType").ToString();
        }

        public void setEducationPlanType(string educationPlanType)
        {
            this.setProperty("educationPlanType", educationPlanType);
        }

        public string getSummary()
        {
            return this.getProperty("summary").ToString();
        }

        public void setSummary(string summary)
        {
            this.setProperty("summary", summary);
        }

        public string getContent()
        {
            return this.getProperty("content").ToString();
        }

        public void setContent(string content)
        {
            this.setProperty("content", content);
        }

        public DateTime getStartDate()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate(DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getScheduledReviewDate()
        {
            return Convert.ToDateTime(this.getProperty("scheduledReviewDate"));
        }

        public void setScheduledReviewDate(DateTime scheduledReviewDate)
        {
            this.setProperty("scheduledReviewDate", scheduledReviewDate);
        }

        public DateTime getEndDate()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate(DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

