using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Intervention : ModelBase
    {
        protected string resourceType = ResourceType.INTERVENTION;
        public const string INTERVENTION_DEFINITION = "interventionDefinition";
        public const string NAME = "name";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string TERM = "term";
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string MONITORING = "monitoring";
        public const string AIMS_OF_INTERVENTION = "aimsOfIntervention";
        public const string STRATEGIES = "strategies";
        public const string SUCCESS_CRITERIA = "successCriteria";
        public const string NEXT_REVIEW_DATE = "nextReviewDate";
        public const string ESTIMATED_DURATION = "estimatedDuration";
        public const string SUBJECT = "subject";
        public const string CATEGORY = "category";
        public const string IS_COMPLETED = "isCompleted";
        public const string LOCATION = "location";
        public const string COPIED_TO_INTERVENTION = "copiedToIntervention";

        public Intervention ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Intervention (string resourceType = "Intervention", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Intervention> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Intervention");
        	RestGateway gateway = (RestGateway) Intervention.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Intervention> interventionCollection = new ModelCollection<Intervention> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    interventionCollection.add((Intervention) model);
        	}
        
        	return interventionCollection;
        }

        public static Intervention retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Intervention.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Intervention) gateway.retrieve(ResourceType.INTERVENTION, id);
        }

        public InterventionDefinition getInterventionDefinition ()
        {
            return (InterventionDefinition) this.getProperty("interventionDefinition");
        }

        public void setInterventionDefinition (InterventionDefinition interventionDefinition)
        {
            this.setProperty("interventionDefinition", interventionDefinition);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public Term getTerm ()
        {
            return (Term) this.getProperty("term");
        }

        public void setTerm (Term term)
        {
            this.setProperty("term", term);
        }

        public DateTime getStartDatetime (){
            return Convert.ToDateTime(this.getProperty("startDatetime"));
        }

        public void setStartDatetime (DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime (){
            return Convert.ToDateTime(this.getProperty("endDatetime"));
        }

        public void setEndDatetime (DateTime endDatetime)
        {
            this.setProperty("endDatetime", endDatetime);
        }

        public string getMonitoring ()
        {
            return this.getProperty("monitoring").ToString();
        }

        public void setMonitoring (string monitoring)
        {
            this.setProperty("monitoring", monitoring);
        }

        public string getAimsOfIntervention ()
        {
            return this.getProperty("aimsOfIntervention").ToString();
        }

        public void setAimsOfIntervention (string aimsOfIntervention)
        {
            this.setProperty("aimsOfIntervention", aimsOfIntervention);
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

        public DateTime getNextReviewDate (){
            return Convert.ToDateTime(this.getProperty("nextReviewDate"));
        }

        public void setNextReviewDate (DateTime nextReviewDate)
        {
            this.setProperty("nextReviewDate", nextReviewDate);
        }

        public string getEstimatedDuration ()
        {
            return this.getProperty("estimatedDuration").ToString();
        }

        public void setEstimatedDuration (string estimatedDuration)
        {
            this.setProperty("estimatedDuration", estimatedDuration);
        }

        public Subject getSubject ()
        {
            return (Subject) this.getProperty("subject");
        }

        public void setSubject (Subject subject)
        {
            this.setProperty("subject", subject);
        }

        public InterventionCategory getCategory ()
        {
            return (InterventionCategory) this.getProperty("category");
        }

        public void setCategory (InterventionCategory category)
        {
            this.setProperty("category", category);
        }

        public bool getIsCompleted ()
        {
            return Convert.ToBoolean( this.getProperty("isCompleted"));
        }

        public void setIsCompleted (bool isCompleted)
        {
            this.setProperty("isCompleted", isCompleted);
        }

        public ModelBase getLocation ()
        {
            return (ModelBase) this.getProperty("location");
        }

        public void setLocation (ModelBase location)
        {
            this.setProperty("location", location);
        }

        public Intervention getCopiedToIntervention ()
        {
            return (Intervention) this.getProperty("copiedToIntervention");
        }

        public void setCopiedToIntervention (Intervention copiedToIntervention)
        {
            this.setProperty("copiedToIntervention", copiedToIntervention);
        }


    }
}

