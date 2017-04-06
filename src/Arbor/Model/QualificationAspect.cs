using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationAspect : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_ASPECT;
        public const string QUALIFICATION_ELEMENT = "qualificationElement";
        public const string MARK_TYPE = "markType";
        public const string DECIMAL_PLACES = "decimalPlaces";
        public const string MIN_VALUE = "minValue";
        public const string MAX_VALUE = "maxValue";
        public const string RESULT_QUALIFICATION_GRADE_SET = "resultQualificationGradeSet";
        public const string QUALIFICATION_FORECAST_GRADE_SET = "qualificationForecastGradeSet";
        public const string DATA_ORDER = "dataOrder";

        public QualificationAspect ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationAspect (string resourceType = "QualificationAspect", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationAspect> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationAspect");
        	RestGateway gateway = (RestGateway) QualificationAspect.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationAspect> qualificationaspectCollection = new ModelCollection<QualificationAspect> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationaspectCollection.add((QualificationAspect) model);
        	}
        
        	return qualificationaspectCollection;
        }

        public static QualificationAspect retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationAspect.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationAspect) gateway.retrieve(ResourceType.QUALIFICATION_ASPECT, id);
        }

        public ModelBase getQualificationElement ()
        {
            return (ModelBase) this.getProperty("qualificationElement");
        }

        public void setQualificationElement (ModelBase qualificationElement)
        {
            this.setProperty("qualificationElement", qualificationElement);
        }

        public string getMarkType ()
        {
            return this.getProperty("markType").ToString();
        }

        public void setMarkType (string markType)
        {
            this.setProperty("markType", markType);
        }

        public int getDecimalPlaces ()
        {
            return Convert.ToInt32(this.getProperty("decimalPlaces"));
        }

        public void setDecimalPlaces (int decimalPlaces)
        {
            this.setProperty("decimalPlaces", decimalPlaces);
        }

        public float getMinValue ()
        {
            return (float) this.getProperty("minValue");
        }

        public void setMinValue (float minValue)
        {
            this.setProperty("minValue", minValue);
        }

        public float getMaxValue ()
        {
            return (float) this.getProperty("maxValue");
        }

        public void setMaxValue (float maxValue)
        {
            this.setProperty("maxValue", maxValue);
        }

        public QualificationGradeSet getResultQualificationGradeSet ()
        {
            return (QualificationGradeSet) this.getProperty("resultQualificationGradeSet");
        }

        public void setResultQualificationGradeSet (QualificationGradeSet resultQualificationGradeSet)
        {
            this.setProperty("resultQualificationGradeSet", resultQualificationGradeSet);
        }

        public QualificationGradeSet getQualificationForecastGradeSet ()
        {
            return (QualificationGradeSet) this.getProperty("qualificationForecastGradeSet");
        }

        public void setQualificationForecastGradeSet (QualificationGradeSet qualificationForecastGradeSet)
        {
            this.setProperty("qualificationForecastGradeSet", qualificationForecastGradeSet);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }


    }
}

