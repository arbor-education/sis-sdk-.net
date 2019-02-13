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
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string QUALIFICATION_ELEMENT = "qualificationElement";
        public const string GRADE_INDEX = "gradeIndex";
        public const string NUMERIC_MARK_TYPE = "numericMarkType";
        public const string DECIMAL_PLACES = "decimalPlaces";
        public const string MINIMUM_NUMERIC_VALUE = "minimumNumericValue";
        public const string MAXIMUM_NUMERIC_VALUE = "maximumNumericValue";
        public const string RESULT_GRADE_SET = "resultGradeSet";
        public const string FORECAST_GRADE_SET = "forecastGradeSet";
        public const string ENDORSEMENT_GRADE_SET = "endorsementGradeSet";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

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
            return Convert.ToBoolean(this.getProperty("active"))
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

        public ModelBase getQualificationElement ()
        {
            return (ModelBase) this.getProperty("qualificationElement");
        }

        public void setQualificationElement (ModelBase qualificationElement)
        {
            this.setProperty("qualificationElement", qualificationElement);
        }

        public int getGradeIndex ()
        {
            return Convert.ToInt32(this.getProperty("gradeIndex"));
        }

        public void setGradeIndex (int gradeIndex)
        {
            this.setProperty("gradeIndex", gradeIndex);
        }

        public string getNumericMarkType ()
        {
            return this.getProperty("numericMarkType").ToString();
        }

        public void setNumericMarkType (string numericMarkType)
        {
            this.setProperty("numericMarkType", numericMarkType);
        }

        public int getDecimalPlaces ()
        {
            return Convert.ToInt32(this.getProperty("decimalPlaces"));
        }

        public void setDecimalPlaces (int decimalPlaces)
        {
            this.setProperty("decimalPlaces", decimalPlaces);
        }

        public float getMinimumNumericValue ()
        {
            return (float) this.getProperty("minimumNumericValue");
        }

        public void setMinimumNumericValue (float minimumNumericValue)
        {
            this.setProperty("minimumNumericValue", minimumNumericValue);
        }

        public float getMaximumNumericValue ()
        {
            return (float) this.getProperty("maximumNumericValue");
        }

        public void setMaximumNumericValue (float maximumNumericValue)
        {
            this.setProperty("maximumNumericValue", maximumNumericValue);
        }

        public QualificationGradeSet getResultGradeSet ()
        {
            return (QualificationGradeSet) this.getProperty("resultGradeSet");
        }

        public void setResultGradeSet (QualificationGradeSet resultGradeSet)
        {
            this.setProperty("resultGradeSet", resultGradeSet);
        }

        public QualificationGradeSet getForecastGradeSet ()
        {
            return (QualificationGradeSet) this.getProperty("forecastGradeSet");
        }

        public void setForecastGradeSet (QualificationGradeSet forecastGradeSet)
        {
            this.setProperty("forecastGradeSet", forecastGradeSet);
        }

        public QualificationGradeSet getEndorsementGradeSet ()
        {
            return (QualificationGradeSet) this.getProperty("endorsementGradeSet");
        }

        public void setEndorsementGradeSet (QualificationGradeSet endorsementGradeSet)
        {
            this.setProperty("endorsementGradeSet", endorsementGradeSet);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"))
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

