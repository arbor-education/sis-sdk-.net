using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class YoungCarerStatusAssignment : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_YOUNG_CARER_STATUS_ASSIGNMENT;
        public const string STUDENT = "student";
        public const string IDENTIFIED_BY = "identifiedBy";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public YoungCarerStatusAssignment()
        {
            base.resourceType = this.resourceType;
        }

        public YoungCarerStatusAssignment(string resourceType = "YoungCarerStatusAssignment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<YoungCarerStatusAssignment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_YoungCarerStatusAssignment");
            RestGateway gateway = (RestGateway)YoungCarerStatusAssignment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<YoungCarerStatusAssignment> youngcarerstatusassignmentCollection = new ModelCollection<YoungCarerStatusAssignment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                youngcarerstatusassignmentCollection.add((YoungCarerStatusAssignment)model);
            }

            return youngcarerstatusassignmentCollection;
        }

        public static YoungCarerStatusAssignment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)YoungCarerStatusAssignment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (YoungCarerStatusAssignment)gateway.retrieve(ResourceType.UK_DFE_YOUNG_CARER_STATUS_ASSIGNMENT, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public string getIdentifiedBy()
        {
            return this.getProperty("identifiedBy").ToString();
        }

        public void setIdentifiedBy(string identifiedBy)
        {
            this.setProperty("identifiedBy", identifiedBy);
        }

        public DateTime getStartDate()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate(DateTime startDate)
        {
            this.setProperty("startDate", startDate);
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

