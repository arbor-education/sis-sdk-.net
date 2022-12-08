using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class ServiceChildStatusAssignment : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SERVICE_CHILD_STATUS_ASSIGNMENT;
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public ServiceChildStatusAssignment()
        {
            base.resourceType = this.resourceType;
        }

        public ServiceChildStatusAssignment(string resourceType = "ServiceChildStatusAssignment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ServiceChildStatusAssignment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_ServiceChildStatusAssignment");
            RestGateway gateway = (RestGateway)ServiceChildStatusAssignment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ServiceChildStatusAssignment> servicechildstatusassignmentCollection = new ModelCollection<ServiceChildStatusAssignment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                servicechildstatusassignmentCollection.add((ServiceChildStatusAssignment)model);
            }

            return servicechildstatusassignmentCollection;
        }

        public static ServiceChildStatusAssignment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ServiceChildStatusAssignment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ServiceChildStatusAssignment)gateway.retrieve(ResourceType.UK_DFE_SERVICE_CHILD_STATUS_ASSIGNMENT, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
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

