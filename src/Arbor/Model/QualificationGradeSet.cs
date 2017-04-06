using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationGradeSet : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_GRADE_SET;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string QUALIFICATION_GRADE_SET_NAME = "qualificationGradeSetName";
        public const string SCALE_DIRECTION = "scaleDirection";
        public const string GRADE_POINT_SCALE = "gradePointScale";

        public QualificationGradeSet ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationGradeSet (string resourceType = "QualificationGradeSet", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationGradeSet> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationGradeSet");
        	RestGateway gateway = (RestGateway) QualificationGradeSet.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationGradeSet> qualificationgradesetCollection = new ModelCollection<QualificationGradeSet> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationgradesetCollection.add((QualificationGradeSet) model);
        	}
        
        	return qualificationgradesetCollection;
        }

        public static QualificationGradeSet retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationGradeSet.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationGradeSet) gateway.retrieve(ResourceType.QUALIFICATION_GRADE_SET, id);
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

        public string getQualificationGradeSetName ()
        {
            return this.getProperty("qualificationGradeSetName").ToString();
        }

        public void setQualificationGradeSetName (string qualificationGradeSetName)
        {
            this.setProperty("qualificationGradeSetName", qualificationGradeSetName);
        }

        public string getScaleDirection ()
        {
            return this.getProperty("scaleDirection").ToString();
        }

        public void setScaleDirection (string scaleDirection)
        {
            this.setProperty("scaleDirection", scaleDirection);
        }

        public GradePointScale getGradePointScale ()
        {
            return (GradePointScale) this.getProperty("gradePointScale");
        }

        public void setGradePointScale (GradePointScale gradePointScale)
        {
            this.setProperty("gradePointScale", gradePointScale);
        }


    }
}

