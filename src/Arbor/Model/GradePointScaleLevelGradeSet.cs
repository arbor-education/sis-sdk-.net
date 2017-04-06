using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class GradePointScaleLevelGradeSet : ModelBase
    {
        protected string resourceType = ResourceType.GRADE_POINT_SCALE_LEVEL_GRADE_SET;
        public const string GRADE_POINT_SCALE = "gradePointScale";
        public const string GRADE_SET = "gradeSet";
        public const string LEVEL_TYPE = "levelType";
        public const string APPLIES_TO_SEN_STUDENT_ONLY = "appliesToSenStudentOnly";

        public GradePointScaleLevelGradeSet ()
        {
            base.resourceType = this.resourceType;
        }
        
        public GradePointScaleLevelGradeSet (string resourceType = "GradePointScaleLevelGradeSet", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<GradePointScaleLevelGradeSet> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("GradePointScaleLevelGradeSet");
        	RestGateway gateway = (RestGateway) GradePointScaleLevelGradeSet.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<GradePointScaleLevelGradeSet> gradepointscalelevelgradesetCollection = new ModelCollection<GradePointScaleLevelGradeSet> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    gradepointscalelevelgradesetCollection.add((GradePointScaleLevelGradeSet) model);
        	}
        
        	return gradepointscalelevelgradesetCollection;
        }

        public static GradePointScaleLevelGradeSet retrieve (string id)
        {
            RestGateway gateway = (RestGateway) GradePointScaleLevelGradeSet.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (GradePointScaleLevelGradeSet) gateway.retrieve(ResourceType.GRADE_POINT_SCALE_LEVEL_GRADE_SET, id);
        }

        public GradePointScale getGradePointScale ()
        {
            return (GradePointScale) this.getProperty("gradePointScale");
        }

        public void setGradePointScale (GradePointScale gradePointScale)
        {
            this.setProperty("gradePointScale", gradePointScale);
        }

        public GradeSet getGradeSet ()
        {
            return (GradeSet) this.getProperty("gradeSet");
        }

        public void setGradeSet (GradeSet gradeSet)
        {
            this.setProperty("gradeSet", gradeSet);
        }

        public string getLevelType ()
        {
            return this.getProperty("levelType").ToString();
        }

        public void setLevelType (string levelType)
        {
            this.setProperty("levelType", levelType);
        }

        public bool getAppliesToSenStudentOnly ()
        {
            return (bool) this.getProperty("appliesToSenStudentOnly");
        }

        public void setAppliesToSenStudentOnly (bool appliesToSenStudentOnly)
        {
            this.setProperty("appliesToSenStudentOnly", appliesToSenStudentOnly);
        }


    }
}

