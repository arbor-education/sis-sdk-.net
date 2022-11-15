using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PhysicalInterventionRecord : ModelBase
    {
        protected new string resourceType = ResourceType.PHYSICAL_INTERVENTION_RECORD;
        public const string BEHAVIOURAL_INCIDENT = "behaviouralIncident";
        public const string STUDENT = "student";
        public const string STAFF = "staff";
        public const string NARRATIVE = "narrative";
        public const string CONFIRMED_DATETIME = "confirmedDatetime";

        public PhysicalInterventionRecord()
        {
            base.resourceType = this.resourceType;
        }

        public PhysicalInterventionRecord(string resourceType = "PhysicalInterventionRecord", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PhysicalInterventionRecord> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PhysicalInterventionRecord");
            RestGateway gateway = (RestGateway)PhysicalInterventionRecord.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PhysicalInterventionRecord> physicalinterventionrecordCollection = new ModelCollection<PhysicalInterventionRecord>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                physicalinterventionrecordCollection.add((PhysicalInterventionRecord)model);
            }

            return physicalinterventionrecordCollection;
        }

        public static PhysicalInterventionRecord retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PhysicalInterventionRecord.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PhysicalInterventionRecord)gateway.retrieve(ResourceType.PHYSICAL_INTERVENTION_RECORD, id);
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

        public Staff getStaff()
        {
            return (Staff)this.getProperty("staff");
        }

        public void setStaff(Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public string getNarrative()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative(string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public DateTime getConfirmedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("confirmedDatetime"));
        }

        public void setConfirmedDatetime(DateTime confirmedDatetime)
        {
            this.setProperty("confirmedDatetime", confirmedDatetime);
        }


    }
}

