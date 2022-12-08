using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BehaviouralIncidentStudentInvolvement : ModelBase
    {
        protected string resourceType = ResourceType.BEHAVIOURAL_INCIDENT_STUDENT_INVOLVEMENT;
        public const string BEHAVIOURAL_INCIDENT = "behaviouralIncident";
        public const string STUDENT = "student";
        public const string RESOLVED_BY = "resolvedBy";
        public const string RESOLVED_DATETIME = "resolvedDatetime";
        public const string COMMENT = "comment";
        public const string SEVERITY = "severity";
        public const string ASSIGNEE = "assignee";

        public BehaviouralIncidentStudentInvolvement()
        {
            base.resourceType = this.resourceType;
        }

        public BehaviouralIncidentStudentInvolvement(string resourceType = "BehaviouralIncidentStudentInvolvement", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<BehaviouralIncidentStudentInvolvement> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("BehaviouralIncidentStudentInvolvement");
            RestGateway gateway = (RestGateway)BehaviouralIncidentStudentInvolvement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<BehaviouralIncidentStudentInvolvement> behaviouralincidentstudentinvolvementCollection = new ModelCollection<BehaviouralIncidentStudentInvolvement>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                behaviouralincidentstudentinvolvementCollection.add((BehaviouralIncidentStudentInvolvement)model);
            }

            return behaviouralincidentstudentinvolvementCollection;
        }

        public static BehaviouralIncidentStudentInvolvement retrieve(string id)
        {
            RestGateway gateway = (RestGateway)BehaviouralIncidentStudentInvolvement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (BehaviouralIncidentStudentInvolvement)gateway.retrieve(ResourceType.BEHAVIOURAL_INCIDENT_STUDENT_INVOLVEMENT, id);
        }

        public BehaviouralIncident getBehaviouralIncident()
        {
            return (BehaviouralIncident)this.getProperty("behaviouralIncident");
        }

        public void setBehaviouralIncident(BehaviouralIncident behaviouralIncident)
        {
            this.setProperty("behaviouralIncident", behaviouralIncident);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public Staff getResolvedBy()
        {
            return (Staff)this.getProperty("resolvedBy");
        }

        public void setResolvedBy(Staff resolvedBy)
        {
            this.setProperty("resolvedBy", resolvedBy);
        }

        public DateTime getResolvedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("resolvedDatetime"));
        }

        public void setResolvedDatetime(DateTime resolvedDatetime)
        {
            this.setProperty("resolvedDatetime", resolvedDatetime);
        }

        public string getComment()
        {
            return this.getProperty("comment").ToString();
        }

        public void setComment(string comment)
        {
            this.setProperty("comment", comment);
        }

        public int getSeverity()
        {
            return Convert.ToInt32(this.getProperty("severity"));
        }

        public void setSeverity(int severity)
        {
            this.setProperty("severity", severity);
        }

        public Staff getAssignee()
        {
            return (Staff)this.getProperty("assignee");
        }

        public void setAssignee(Staff assignee)
        {
            this.setProperty("assignee", assignee);
        }


    }
}

