using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MedicalConditionMedication : ModelBase
    {
        protected string resourceType = ResourceType.MEDICAL_CONDITION_MEDICATION;
        public const string MEDICAL_CONDITION = "medicalCondition";
        public const string MEDICATION = "medication";
        public const string DOSAGE = "dosage";
        public const string FREQUENCY = "frequency";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public MedicalConditionMedication()
        {
            base.resourceType = this.resourceType;
        }

        public MedicalConditionMedication(string resourceType = "MedicalConditionMedication", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<MedicalConditionMedication> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("MedicalConditionMedication");
            RestGateway gateway = (RestGateway)MedicalConditionMedication.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<MedicalConditionMedication> medicalconditionmedicationCollection = new ModelCollection<MedicalConditionMedication>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                medicalconditionmedicationCollection.add((MedicalConditionMedication)model);
            }

            return medicalconditionmedicationCollection;
        }

        public static MedicalConditionMedication retrieve(string id)
        {
            RestGateway gateway = (RestGateway)MedicalConditionMedication.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (MedicalConditionMedication)gateway.retrieve(ResourceType.MEDICAL_CONDITION_MEDICATION, id);
        }

        public MedicalCondition getMedicalCondition()
        {
            return (MedicalCondition)this.getProperty("medicalCondition");
        }

        public void setMedicalCondition(MedicalCondition medicalCondition)
        {
            this.setProperty("medicalCondition", medicalCondition);
        }

        public Medication getMedication()
        {
            return (Medication)this.getProperty("medication");
        }

        public void setMedication(Medication medication)
        {
            this.setProperty("medication", medication);
        }

        public string getDosage()
        {
            return this.getProperty("dosage").ToString();
        }

        public void setDosage(string dosage)
        {
            this.setProperty("dosage", dosage);
        }

        public string getFrequency()
        {
            return this.getProperty("frequency").ToString();
        }

        public void setFrequency(string frequency)
        {
            this.setProperty("frequency", frequency);
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

