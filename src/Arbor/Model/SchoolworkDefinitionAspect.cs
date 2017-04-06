using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SchoolworkDefinitionAspect : ModelBase
    {
        protected string resourceType = ResourceType.SCHOOLWORK_DEFINITION_ASPECT;
        public const string SCHOOLWORK_DEFINITION = "schoolworkDefinition";
        public const string ASPECT_NAME = "aspectName";
        public const string ASPECT_DATA_TYPE = "aspectDataType";
        public const string GRADE_SET = "gradeSet";
        public const string MARK_MIN_VALUE = "markMinValue";
        public const string MARK_MAX_VALUE = "markMaxValue";
        public const string SCALE_DIRECTION = "scaleDirection";

        public SchoolworkDefinitionAspect ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SchoolworkDefinitionAspect (string resourceType = "SchoolworkDefinitionAspect", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SchoolworkDefinitionAspect> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SchoolworkDefinitionAspect");
        	RestGateway gateway = (RestGateway) SchoolworkDefinitionAspect.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SchoolworkDefinitionAspect> schoolworkdefinitionaspectCollection = new ModelCollection<SchoolworkDefinitionAspect> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schoolworkdefinitionaspectCollection.add((SchoolworkDefinitionAspect) model);
        	}
        
        	return schoolworkdefinitionaspectCollection;
        }

        public static SchoolworkDefinitionAspect retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SchoolworkDefinitionAspect.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SchoolworkDefinitionAspect) gateway.retrieve(ResourceType.SCHOOLWORK_DEFINITION_ASPECT, id);
        }

        public SchoolworkDefinition getSchoolworkDefinition ()
        {
            return (SchoolworkDefinition) this.getProperty("schoolworkDefinition");
        }

        public void setSchoolworkDefinition (SchoolworkDefinition schoolworkDefinition)
        {
            this.setProperty("schoolworkDefinition", schoolworkDefinition);
        }

        public string getAspectName ()
        {
            return this.getProperty("aspectName").ToString();
        }

        public void setAspectName (string aspectName)
        {
            this.setProperty("aspectName", aspectName);
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

