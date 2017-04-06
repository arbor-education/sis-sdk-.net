using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Aspect : ModelBase
    {
        protected string resourceType = ResourceType.ASPECT;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string ASPECT_SET = "aspectSet";
        public const string ASPECT_NAME = "aspectName";
        public const string ASPECT_TYPE = "aspectType";
        public const string ASPECT_DATA_TYPE = "aspectDataType";
        public const string GRADE_SET = "gradeSet";
        public const string MARK_MIN_VALUE = "markMinValue";
        public const string MARK_MAX_VALUE = "markMaxValue";
        public const string SCALE_DIRECTION = "scaleDirection";

        public Aspect ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Aspect (string resourceType = "Aspect", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Aspect> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Aspect");
        	RestGateway gateway = (RestGateway) Aspect.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Aspect> aspectCollection = new ModelCollection<Aspect> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    aspectCollection.add((Aspect) model);
        	}
        
        	return aspectCollection;
        }

        public static Aspect retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Aspect.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Aspect) gateway.retrieve(ResourceType.ASPECT, id);
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
            return (bool) this.getProperty("active");
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

        public AspectSet getAspectSet ()
        {
            return (AspectSet) this.getProperty("aspectSet");
        }

        public void setAspectSet (AspectSet aspectSet)
        {
            this.setProperty("aspectSet", aspectSet);
        }

        public string getAspectName ()
        {
            return this.getProperty("aspectName").ToString();
        }

        public void setAspectName (string aspectName)
        {
            this.setProperty("aspectName", aspectName);
        }

        public string getAspectType ()
        {
            return this.getProperty("aspectType").ToString();
        }

        public void setAspectType (string aspectType)
        {
            this.setProperty("aspectType", aspectType);
        }

        public string getAspectDataType ()
        {
            return this.getProperty("aspectDataType").ToString();
        }

        public void setAspectDataType (string aspectDataType)
        {
            this.setProperty("aspectDataType", aspectDataType);
        }

        public GradeSet getGradeSet ()
        {
            return (GradeSet) this.getProperty("gradeSet");
        }

        public void setGradeSet (GradeSet gradeSet)
        {
            this.setProperty("gradeSet", gradeSet);
        }

        public float getMarkMinValue ()
        {
            return (float) this.getProperty("markMinValue");
        }

        public void setMarkMinValue (float markMinValue)
        {
            this.setProperty("markMinValue", markMinValue);
        }

        public float getMarkMaxValue ()
        {
            return (float) this.getProperty("markMaxValue");
        }

        public void setMarkMaxValue (float markMaxValue)
        {
            this.setProperty("markMaxValue", markMaxValue);
        }

        public string getScaleDirection ()
        {
            return this.getProperty("scaleDirection").ToString();
        }

        public void setScaleDirection (string scaleDirection)
        {
            this.setProperty("scaleDirection", scaleDirection);
        }


    }
}

