using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ObservationGrade : ModelBase
    {
        protected string resourceType = ResourceType.OBSERVATION_GRADE;
        public const string OBSERVATION_GRADE_SET = "observationGradeSet";
        public const string SHORT_NAME = "shortName";
        public const string NAME = "name";
        public const string OBSERVATION_GRADE_VALUE = "observationGradeValue";

        public ObservationGrade ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ObservationGrade (string resourceType = "ObservationGrade", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ObservationGrade> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ObservationGrade");
        	RestGateway gateway = (RestGateway) ObservationGrade.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ObservationGrade> observationgradeCollection = new ModelCollection<ObservationGrade> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    observationgradeCollection.add((ObservationGrade) model);
        	}
        
        	return observationgradeCollection;
        }

        public static ObservationGrade retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ObservationGrade.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ObservationGrade) gateway.retrieve(ResourceType.OBSERVATION_GRADE, id);
        }

        public ObservationGradeSet getObservationGradeSet ()
        {
            return (ObservationGradeSet) this.getProperty("observationGradeSet");
        }

        public void setObservationGradeSet (ObservationGradeSet observationGradeSet)
        {
            this.setProperty("observationGradeSet", observationGradeSet);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public float getObservationGradeValue ()
        {
            return (float) this.getProperty("observationGradeValue");
        }

        public void setObservationGradeValue (float observationGradeValue)
        {
            this.setProperty("observationGradeValue", observationGradeValue);
        }


    }
}

