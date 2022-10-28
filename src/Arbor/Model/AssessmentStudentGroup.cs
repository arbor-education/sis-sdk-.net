using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentStudentGroup : ModelBase
    {
        protected new string resourceType = ResourceType.ASSESSMENT_STUDENT_GROUP;
        public const string ACADEMIC_YEAR_ASSESSMENT = "academicYearAssessment";
        public const string STUDENT_GROUP = "studentGroup";

        public AssessmentStudentGroup ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentStudentGroup (string resourceType = "AssessmentStudentGroup", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentStudentGroup> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentStudentGroup");
        	RestGateway gateway = (RestGateway) AssessmentStudentGroup.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentStudentGroup> assessmentstudentgroupCollection = new ModelCollection<AssessmentStudentGroup> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentstudentgroupCollection.add((AssessmentStudentGroup) model);
        	}
        
        	return assessmentstudentgroupCollection;
        }

        public static AssessmentStudentGroup retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentStudentGroup.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentStudentGroup) gateway.retrieve(ResourceType.ASSESSMENT_STUDENT_GROUP, id);
        }

        public AcademicYearAssessment getAcademicYearAssessment ()
        {
            return (AcademicYearAssessment) this.getProperty("academicYearAssessment");
        }

        public void setAcademicYearAssessment (AcademicYearAssessment academicYearAssessment)
        {
            this.setProperty("academicYearAssessment", academicYearAssessment);
        }

        public ModelBase getStudentGroup ()
        {
            return (ModelBase) this.getProperty("studentGroup");
        }

        public void setStudentGroup (ModelBase studentGroup)
        {
            this.setProperty("studentGroup", studentGroup);
        }


    }
}

