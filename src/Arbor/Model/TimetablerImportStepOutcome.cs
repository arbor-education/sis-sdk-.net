using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TimetablerImportStepOutcome : ModelBase
    {
        protected string resourceType = ResourceType.TIMETABLER_IMPORT_STEP_OUTCOME;
        public const string TIMETABLER_IMPORT_RESULT = "timetablerImportResult";
        public const string IDENTIFIER = "identifier";
        public const string DESCRIPTION = "description";
        public const string OPTION_TYPE = "optionType";
        public const string LINKED_OBJECT = "linkedObject";
        public const string STEP_TYPE = "stepType";

        public TimetablerImportStepOutcome ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TimetablerImportStepOutcome (string resourceType = "TimetablerImportStepOutcome", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TimetablerImportStepOutcome> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("TimetablerImportStepOutcome");
        	RestGateway gateway = (RestGateway) TimetablerImportStepOutcome.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TimetablerImportStepOutcome> timetablerimportstepoutcomeCollection = new ModelCollection<TimetablerImportStepOutcome> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    timetablerimportstepoutcomeCollection.add((TimetablerImportStepOutcome) model);
        	}
        
        	return timetablerimportstepoutcomeCollection;
        }

        public static TimetablerImportStepOutcome retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TimetablerImportStepOutcome.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TimetablerImportStepOutcome) gateway.retrieve(ResourceType.TIMETABLER_IMPORT_STEP_OUTCOME, id);
        }

        public TimetablerImportResult getTimetablerImportResult ()
        {
            return (TimetablerImportResult) this.getProperty("timetablerImportResult");
        }

        public void setTimetablerImportResult (TimetablerImportResult timetablerImportResult)
        {
            this.setProperty("timetablerImportResult", timetablerImportResult);
        }

        public string getIdentifier ()
        {
            return this.getProperty("identifier").ToString();
        }

        public void setIdentifier (string identifier)
        {
            this.setProperty("identifier", identifier);
        }

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }

        public string getOptionType ()
        {
            return this.getProperty("optionType").ToString();
        }

        public void setOptionType (string optionType)
        {
            this.setProperty("optionType", optionType);
        }

        public ModelBase getLinkedObject ()
        {
            return (ModelBase) this.getProperty("linkedObject");
        }

        public void setLinkedObject (ModelBase linkedObject)
        {
            this.setProperty("linkedObject", linkedObject);
        }

        public string getStepType ()
        {
            return this.getProperty("stepType").ToString();
        }

        public void setStepType (string stepType)
        {
            this.setProperty("stepType", stepType);
        }


    }
}

