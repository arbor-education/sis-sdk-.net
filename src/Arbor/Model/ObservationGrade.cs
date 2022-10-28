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
        protected new string resourceType = ResourceType.OBSERVATION_GRADE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string OBSERVATION_GRADE_SET = "observationGradeSet";
        public const string SHORT_NAME = "shortName";
        public const string NAME = "name";
        public const string OBSERVATION_GRADE_VALUE = "observationGradeValue";
        public const string LOWER_VALUE = "lowerValue";
        public const string UPPER_VALUE = "upperValue";
        public const string STATISTICAL_VALUE = "statisticalValue";
        public const string GRADE_ORDER = "gradeOrder";

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

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
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

        public float getLowerValue ()
        {
            return (float) this.getProperty("lowerValue");
        }

        public void setLowerValue (float lowerValue)
        {
            this.setProperty("lowerValue", lowerValue);
        }

        public float getUpperValue ()
        {
            return (float) this.getProperty("upperValue");
        }

        public void setUpperValue (float upperValue)
        {
            this.setProperty("upperValue", upperValue);
        }

        public float getStatisticalValue ()
        {
            return (float) this.getProperty("statisticalValue");
        }

        public void setStatisticalValue (float statisticalValue)
        {
            this.setProperty("statisticalValue", statisticalValue);
        }

        public int getGradeOrder ()
        {
            return Convert.ToInt32(this.getProperty("gradeOrder"));
        }

        public void setGradeOrder (int gradeOrder)
        {
            this.setProperty("gradeOrder", gradeOrder);
        }


    }
}

