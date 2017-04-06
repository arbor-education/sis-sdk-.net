using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentBatch : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_BATCH;
        public const string BATCH_NAME = "batchName";
        public const string ASSESSMENT = "assessment";
        public const string GRADE_POINT_SCALE_LEVEL_TYPE = "gradePointScaleLevelType";
        public const string ASSESSMENT_TEMPLATE = "assessmentTemplate";
        public const string ASSESSMENT_DATE = "assessmentDate";
        public const string SEN_STUDENTS_ONLY = "senStudentsOnly";

        public AssessmentBatch ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentBatch (string resourceType = "AssessmentBatch", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentBatch> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentBatch");
        	RestGateway gateway = (RestGateway) AssessmentBatch.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentBatch> assessmentbatchCollection = new ModelCollection<AssessmentBatch> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentbatchCollection.add((AssessmentBatch) model);
        	}
        
        	return assessmentbatchCollection;
        }

        public static AssessmentBatch retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentBatch.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentBatch) gateway.retrieve(ResourceType.ASSESSMENT_BATCH, id);
        }

        public string getBatchName ()
        {
            return this.getProperty("batchName").ToString();
        }

        public void setBatchName (string batchName)
        {
            this.setProperty("batchName", batchName);
        }

        public Assessment getAssessment ()
        {
            return (Assessment) this.getProperty("assessment");
        }

        public void setAssessment (Assessment assessment)
        {
            this.setProperty("assessment", assessment);
        }

        public string getGradePointScaleLevelType ()
        {
            return this.getProperty("gradePointScaleLevelType").ToString();
        }

        public void setGradePointScaleLevelType (string gradePointScaleLevelType)
        {
            this.setProperty("gradePointScaleLevelType", gradePointScaleLevelType);
        }

        public AssessmentTemplate getAssessmentTemplate ()
        {
            return (AssessmentTemplate) this.getProperty("assessmentTemplate");
        }

        public void setAssessmentTemplate (AssessmentTemplate assessmentTemplate)
        {
            this.setProperty("assessmentTemplate", assessmentTemplate);
        }

        public DateTime getAssessmentDate ()
        {
            return (DateTime) this.getProperty("assessmentDate");
        }

        public void setAssessmentDate (DateTime assessmentDate)
        {
            this.setProperty("assessmentDate", assessmentDate);
        }

        public bool getSenStudentsOnly ()
        {
            return (bool) this.getProperty("senStudentsOnly");
        }

        public void setSenStudentsOnly (bool senStudentsOnly)
        {
            this.setProperty("senStudentsOnly", senStudentsOnly);
        }


    }
}

