using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MedicalCondition : ModelBase
    {
        protected string resourceType = ResourceType.MEDICAL_CONDITION;
        public const string PERSON = "person";
        public const string MEDICAL_CONDITION_TYPE = "medicalConditionType";
        public const string MEDICAL_CONDITION_NAME = "medicalConditionName";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string SEVERITY = "severity";
        public const string SYMPTOMS = "symptoms";
        public const string TREATMENT = "treatment";

        public MedicalCondition ()
        {
            base.resourceType = this.resourceType;
        }
        
        public MedicalCondition (string resourceType = "MedicalCondition", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<MedicalCondition> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("MedicalCondition");
        	RestGateway gateway = (RestGateway) MedicalCondition.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<MedicalCondition> medicalconditionCollection = new ModelCollection<MedicalCondition> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    medicalconditionCollection.add((MedicalCondition) model);
        	}
        
        	return medicalconditionCollection;
        }

        public static MedicalCondition retrieve (string id)
        {
            RestGateway gateway = (RestGateway) MedicalCondition.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (MedicalCondition) gateway.retrieve(ResourceType.MEDICAL_CONDITION, id);
        }

        public ModelBase getPerson ()
        {
            return (ModelBase) this.getProperty("person");
        }

        public void setPerson (ModelBase person)
        {
            this.setProperty("person", person);
        }

        public MedicalConditionType getMedicalConditionType ()
        {
            return (MedicalConditionType) this.getProperty("medicalConditionType");
        }

        public void setMedicalConditionType (MedicalConditionType medicalConditionType)
        {
            this.setProperty("medicalConditionType", medicalConditionType);
        }

        public string getMedicalConditionName ()
        {
            return this.getProperty("medicalConditionName").ToString();
        }

        public void setMedicalConditionName (string medicalConditionName)
        {
            this.setProperty("medicalConditionName", medicalConditionName);
        }

        public DateTime getStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getSeverity ()
        {
            return this.getProperty("severity").ToString();
        }

        public void setSeverity (string severity)
        {
            this.setProperty("severity", severity);
        }

        public string getSymptoms ()
        {
            return this.getProperty("symptoms").ToString();
        }

        public void setSymptoms (string symptoms)
        {
            this.setProperty("symptoms", symptoms);
        }

        public string getTreatment ()
        {
            return this.getProperty("treatment").ToString();
        }

        public void setTreatment (string treatment)
        {
            this.setProperty("treatment", treatment);
        }


    }
}

