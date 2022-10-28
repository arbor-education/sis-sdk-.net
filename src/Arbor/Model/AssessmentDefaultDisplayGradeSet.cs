using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentDefaultDisplayGradeSet : ModelBase
    {
        protected new string resourceType = ResourceType.ASSESSMENT_DEFAULT_DISPLAY_GRADE_SET;
        public const string PROGRESS_ASSESSMENT_BATCH = "progressAssessmentBatch";
        public const string GRADE_SET = "gradeSet";

        public AssessmentDefaultDisplayGradeSet ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentDefaultDisplayGradeSet (string resourceType = "AssessmentDefaultDisplayGradeSet", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentDefaultDisplayGradeSet> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentDefaultDisplayGradeSet");
        	RestGateway gateway = (RestGateway) AssessmentDefaultDisplayGradeSet.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentDefaultDisplayGradeSet> assessmentdefaultdisplaygradesetCollection = new ModelCollection<AssessmentDefaultDisplayGradeSet> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentdefaultdisplaygradesetCollection.add((AssessmentDefaultDisplayGradeSet) model);
        	}
        
        	return assessmentdefaultdisplaygradesetCollection;
        }

        public static AssessmentDefaultDisplayGradeSet retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentDefaultDisplayGradeSet.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentDefaultDisplayGradeSet) gateway.retrieve(ResourceType.ASSESSMENT_DEFAULT_DISPLAY_GRADE_SET, id);
        }

        public ProgressAssessmentBatch getProgressAssessmentBatch ()
        {
            return (ProgressAssessmentBatch) this.getProperty("progressAssessmentBatch");
        }

        public void setProgressAssessmentBatch (ProgressAssessmentBatch progressAssessmentBatch)
        {
            this.setProperty("progressAssessmentBatch", progressAssessmentBatch);
        }

        public GradeSet getGradeSet ()
        {
            return (GradeSet) this.getProperty("gradeSet");
        }

        public void setGradeSet (GradeSet gradeSet)
        {
            this.setProperty("gradeSet", gradeSet);
        }


    }
}

