using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentIntervention : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_INTERVENTION;
        public const string STUDENT = "student";
        public const string INTERVENTION = "intervention";
        public const string INTERVENTION_GROUP = "interventionGroup";
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string PRIORITY = "priority";
        public const string STATUS = "status";
        public const string MONITORING = "monitoring";
        public const string AIMS = "aims";
        public const string STRATEGIES = "strategies";
        public const string SUCCESS_CRITERIA = "successCriteria";
        public const string REASON = "reason";
        public const string SEN_NEED = "senNeed";
        public const string LANGUAGE_ABILITY = "languageAbility";
        public const string MEDICAL_CONDITION = "medicalCondition";
        public const string SUCCESS = "success";
        public const string ESTIMATED_DURATION = "estimatedDuration";

        public StudentIntervention ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentIntervention (string resourceType = "StudentIntervention", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentIntervention> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentIntervention");
        	RestGateway gateway = (RestGateway) StudentIntervention.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentIntervention> studentinterventionCollection = new ModelCollection<StudentIntervention> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentinterventionCollection.add((StudentIntervention) model);
        	}
        
        	return studentinterventionCollection;
        }

        public static StudentIntervention retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentIntervention.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentIntervention) gateway.retrieve(ResourceType.STUDENT_INTERVENTION, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public Intervention getIntervention ()
        {
            return (Intervention) this.getProperty("intervention");
        }

        public void setIntervention (Intervention intervention)
        {
            this.setProperty("intervention", intervention);
        }

        public InterventionGroup getInterventionGroup ()
        {
            return (InterventionGroup) this.getProperty("interventionGroup");
        }

        public void setInterventionGroup (InterventionGroup interventionGroup)
        {
            this.setProperty("interventionGroup", interventionGroup);
        }

        public DateTime getStartDatetime ()
        {
            return (DateTime) this.getProperty("startDatetime");
        }

        public void setStartDatetime (DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime ()
        {
            return (DateTime) this.getProperty("endDatetime");
        }

        public void setEndDatetime (DateTime endDatetime)
        {
            this.setProperty("endDatetime", endDatetime);
        }

        public string getPriority ()
        {
            return this.getProperty("priority").ToString();
        }

        public void setPriority (string priority)
        {
            this.setProperty("priority", priority);
        }

        public string getStatus ()
        {
            return this.getProperty("status").ToString();
        }

        public void setStatus (string status)
        {
            this.setProperty("status", status);
        }

        public string getMonitoring ()
        {
            return this.getProperty("monitoring").ToString();
        }

        public void setMonitoring (string monitoring)
        {
            this.setProperty("monitoring", monitoring);
        }

        public string getAims ()
        {
            return this.getProperty("aims").ToString();
        }

        public void setAims (string aims)
        {
            this.setProperty("aims", aims);
        }

        public string getStrategies ()
        {
            return this.getProperty("strategies").ToString();
        }

        public void setStrategies (string strategies)
        {
            this.setProperty("strategies", strategies);
        }

        public string getSuccessCriteria ()
        {
            return this.getProperty("successCriteria").ToString();
        }

        public void setSuccessCriteria (string successCriteria)
        {
            this.setProperty("successCriteria", successCriteria);
        }

        public string getReason ()
        {
            return this.getProperty("reason").ToString();
        }

        public void setReason (string reason)
        {
            this.setProperty("reason", reason);
        }

        public SenNeed getSenNeed ()
        {
            return (SenNeed) this.getProperty("senNeed");
        }

        public void setSenNeed (SenNeed senNeed)
        {
            this.setProperty("senNeed", senNeed);
        }

        public LanguageAbility getLanguageAbility ()
        {
            return (LanguageAbility) this.getProperty("languageAbility");
        }

        public void setLanguageAbility (LanguageAbility languageAbility)
        {
            this.setProperty("languageAbility", languageAbility);
        }

        public MedicalCondition getMedicalCondition ()
        {
            return (MedicalCondition) this.getProperty("medicalCondition");
        }

        public void setMedicalCondition (MedicalCondition medicalCondition)
        {
            this.setProperty("medicalCondition", medicalCondition);
        }

        public string getSuccess ()
        {
            return this.getProperty("success").ToString();
        }

        public void setSuccess (string success)
        {
            this.setProperty("success", success);
        }

        public string getEstimatedDuration ()
        {
            return this.getProperty("estimatedDuration").ToString();
        }

        public void setEstimatedDuration (string estimatedDuration)
        {
            this.setProperty("estimatedDuration", estimatedDuration);
        }


    }
}

