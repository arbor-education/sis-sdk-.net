using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ChildProtectionStatusAssignment : ModelBase
    {
        protected string resourceType = ResourceType.CHILD_PROTECTION_STATUS_ASSIGNMENT;
        public const string RESPONSIBLE_LOCAL_AUTHORITY = "responsibleLocalAuthority";
        public const string CHILD_PROTECTION_STATUS = "childProtectionStatus";
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string NOTES = "notes";

        public ChildProtectionStatusAssignment()
        {
            base.resourceType = this.resourceType;
        }

        public ChildProtectionStatusAssignment(string resourceType = "ChildProtectionStatusAssignment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ChildProtectionStatusAssignment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ChildProtectionStatusAssignment");
            RestGateway gateway = (RestGateway)ChildProtectionStatusAssignment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ChildProtectionStatusAssignment> childprotectionstatusassignmentCollection = new ModelCollection<ChildProtectionStatusAssignment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                childprotectionstatusassignmentCollection.add((ChildProtectionStatusAssignment)model);
            }

            return childprotectionstatusassignmentCollection;
        }

        public static ChildProtectionStatusAssignment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ChildProtectionStatusAssignment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ChildProtectionStatusAssignment)gateway.retrieve(ResourceType.CHILD_PROTECTION_STATUS_ASSIGNMENT, id);
        }

        public LocalAuthority getResponsibleLocalAuthority()
        {
            return (LocalAuthority)this.getProperty("responsibleLocalAuthority");
        }

        public void setResponsibleLocalAuthority(LocalAuthority responsibleLocalAuthority)
        {
            this.setProperty("responsibleLocalAuthority", responsibleLocalAuthority);
        }

        public ChildProtectionStatus getChildProtectionStatus()
        {
            return (ChildProtectionStatus)this.getProperty("childProtectionStatus");
        }

        public void setChildProtectionStatus(ChildProtectionStatus childProtectionStatus)
        {
            this.setProperty("childProtectionStatus", childProtectionStatus);
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

        public string getNotes()
        {
            return this.getProperty("notes").ToString();
        }

        public void setNotes(string notes)
        {
            this.setProperty("notes", notes);
        }


    }
}

