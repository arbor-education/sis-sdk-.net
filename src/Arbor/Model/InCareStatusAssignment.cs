using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InCareStatusAssignment : ModelBase
    {
        protected string resourceType = ResourceType.IN_CARE_STATUS_ASSIGNMENT;
        public const string RESPONSIBLE_LOCAL_AUTHORITY = "responsibleLocalAuthority";
        public const string IN_CARE_STATUS = "inCareStatus";
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public InCareStatusAssignment()
        {
            base.resourceType = this.resourceType;
        }

        public InCareStatusAssignment(string resourceType = "InCareStatusAssignment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<InCareStatusAssignment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("InCareStatusAssignment");
            RestGateway gateway = (RestGateway)InCareStatusAssignment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<InCareStatusAssignment> incarestatusassignmentCollection = new ModelCollection<InCareStatusAssignment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                incarestatusassignmentCollection.add((InCareStatusAssignment)model);
            }

            return incarestatusassignmentCollection;
        }

        public static InCareStatusAssignment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)InCareStatusAssignment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (InCareStatusAssignment)gateway.retrieve(ResourceType.IN_CARE_STATUS_ASSIGNMENT, id);
        }

        public LocalAuthority getResponsibleLocalAuthority()
        {
            return (LocalAuthority)this.getProperty("responsibleLocalAuthority");
        }

        public void setResponsibleLocalAuthority(LocalAuthority responsibleLocalAuthority)
        {
            this.setProperty("responsibleLocalAuthority", responsibleLocalAuthority);
        }

        public InCareStatus getInCareStatus()
        {
            return (InCareStatus)this.getProperty("inCareStatus");
        }

        public void setInCareStatus(InCareStatus inCareStatus)
        {
            this.setProperty("inCareStatus", inCareStatus);
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

