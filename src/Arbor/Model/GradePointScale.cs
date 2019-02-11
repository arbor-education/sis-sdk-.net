using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class GradePointScale : ModelBase
    {
        protected string resourceType = ResourceType.GRADE_POINT_SCALE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string GRADE_POINT_SCALE_NAME = "gradePointScaleName";
        public const string SHORT_NAME = "shortName";
        public const string POINT_NAME = "pointName";
        public const string MINIMUM_VALUE = "minimumValue";
        public const string MAXIMUM_VALUE = "maximumValue";
        public const string SCALE_INCREMENT = "scaleIncrement";
        public const string DEFAULT_GRADE_SET = "defaultGradeSet";

        public GradePointScale ()
        {
            base.resourceType = this.resourceType;
        }
        
        public GradePointScale (string resourceType = "GradePointScale", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<GradePointScale> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("GradePointScale");
        	RestGateway gateway = (RestGateway) GradePointScale.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<GradePointScale> gradepointscaleCollection = new ModelCollection<GradePointScale> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    gradepointscaleCollection.add((GradePointScale) model);
        	}
        
        	return gradepointscaleCollection;
        }

        public static GradePointScale retrieve (string id)
        {
            RestGateway gateway = (RestGateway) GradePointScale.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (GradePointScale) gateway.retrieve(ResourceType.GRADE_POINT_SCALE, id);
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
            return Convert.ToBoolean( this.getProperty("active"));
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

        public string getGradePointScaleName ()
        {
            return this.getProperty("gradePointScaleName").ToString();
        }

        public void setGradePointScaleName (string gradePointScaleName)
        {
            this.setProperty("gradePointScaleName", gradePointScaleName);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public string getPointName ()
        {
            return this.getProperty("pointName").ToString();
        }

        public void setPointName (string pointName)
        {
            this.setProperty("pointName", pointName);
        }

        public int getMinimumValue ()
        {
            return Convert.ToInt32(this.getProperty("minimumValue"));
        }

        public void setMinimumValue (int minimumValue)
        {
            this.setProperty("minimumValue", minimumValue);
        }

        public int getMaximumValue ()
        {
            return Convert.ToInt32(this.getProperty("maximumValue"));
        }

        public void setMaximumValue (int maximumValue)
        {
            this.setProperty("maximumValue", maximumValue);
        }

        public float getScaleIncrement ()
        {
            return (float) this.getProperty("scaleIncrement");
        }

        public void setScaleIncrement (float scaleIncrement)
        {
            this.setProperty("scaleIncrement", scaleIncrement);
        }

        public GradeSet getDefaultGradeSet ()
        {
            return (GradeSet) this.getProperty("defaultGradeSet");
        }

        public void setDefaultGradeSet (GradeSet defaultGradeSet)
        {
            this.setProperty("defaultGradeSet", defaultGradeSet);
        }


    }
}

