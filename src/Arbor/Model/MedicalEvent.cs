using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MedicalEvent : ModelBase
    {
        protected string resourceType = ResourceType.MEDICAL_EVENT;
        public const string PERSON = "person";
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string MEDICAL_EVENT_TYPE = "medicalEventType";
        public const string MEDICAL_EVENT_DESCRIPTION = "medicalEventDescription";
        public const string MEDICAL_CONDITION = "medicalCondition";

        public MedicalEvent()
        {
            base.resourceType = this.resourceType;
        }

        public MedicalEvent(string resourceType = "MedicalEvent", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<MedicalEvent> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("MedicalEvent");
            RestGateway gateway = (RestGateway)MedicalEvent.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<MedicalEvent> medicaleventCollection = new ModelCollection<MedicalEvent>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                medicaleventCollection.add((MedicalEvent)model);
            }

            return medicaleventCollection;
        }

        public static MedicalEvent retrieve(string id)
        {
            RestGateway gateway = (RestGateway)MedicalEvent.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (MedicalEvent)gateway.retrieve(ResourceType.MEDICAL_EVENT, id);
        }

        public ModelBase getPerson()
        {
            return (ModelBase)this.getProperty("person");
        }

        public void setPerson(ModelBase person)
        {
            this.setProperty("person", person);
        }

        public DateTime getStartDatetime()
        {
            return Convert.ToDateTime(this.getProperty("startDatetime"));
        }

        public void setStartDatetime(DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime()
        {
            return Convert.ToDateTime(this.getProperty("endDatetime"));
        }

        public void setEndDatetime(DateTime endDatetime)
        {
            this.setProperty("endDatetime", endDatetime);
        }

        public MedicalEventType getMedicalEventType()
        {
            return (MedicalEventType)this.getProperty("medicalEventType");
        }

        public void setMedicalEventType(MedicalEventType medicalEventType)
        {
            this.setProperty("medicalEventType", medicalEventType);
        }

        public string getMedicalEventDescription()
        {
            return this.getProperty("medicalEventDescription").ToString();
        }

        public void setMedicalEventDescription(string medicalEventDescription)
        {
            this.setProperty("medicalEventDescription", medicalEventDescription);
        }

        public MedicalCondition getMedicalCondition()
        {
            return (MedicalCondition)this.getProperty("medicalCondition");
        }

        public void setMedicalCondition(MedicalCondition medicalCondition)
        {
            this.setProperty("medicalCondition", medicalCondition);
        }


    }
}

