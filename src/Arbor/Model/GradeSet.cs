using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class GradeSet : ModelBase
    {
        protected string resourceType = ResourceType.GRADE_SET;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string GRADE_SET_NAME = "gradeSetName";
        public const string SHORT_NAME = "shortName";
        public const string GRADE_POINT_SCALE = "gradePointScale";
        public const string SCALE_DIRECTION = "scaleDirection";

        public GradeSet ()
        {
            base.resourceType = this.resourceType;
        }
        
        public GradeSet (string resourceType = "GradeSet", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<GradeSet> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("GradeSet");
        	RestGateway gateway = (RestGateway) GradeSet.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<GradeSet> gradesetCollection = new ModelCollection<GradeSet> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    gradesetCollection.add((GradeSet) model);
        	}
        
        	return gradesetCollection;
        }

        public static GradeSet retrieve (string id)
        {
            RestGateway gateway = (RestGateway) GradeSet.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (GradeSet) gateway.retrieve(ResourceType.GRADE_SET, id);
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

        public string getGradeSetName ()
        {
            return this.getProperty("gradeSetName").ToString();
        }

        public void setGradeSetName (string gradeSetName)
        {
            this.setProperty("gradeSetName", gradeSetName);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public GradePointScale getGradePointScale ()
        {
            return (GradePointScale) this.getProperty("gradePointScale");
        }

        public void setGradePointScale (GradePointScale gradePointScale)
        {
            this.setProperty("gradePointScale", gradePointScale);
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

