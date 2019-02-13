using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentImportRow : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_IMPORT_ROW;
        public const string ASSESSMENT_IMPORT_JOB = "assessmentImportJob";
        public const string MAPPED_STUDENT = "mappedStudent";

        public AssessmentImportRow ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentImportRow (string resourceType = "AssessmentImportRow", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentImportRow> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentImportRow");
        	RestGateway gateway = (RestGateway) AssessmentImportRow.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentImportRow> assessmentimportrowCollection = new ModelCollection<AssessmentImportRow> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentimportrowCollection.add((AssessmentImportRow) model);
        	}
        
        	return assessmentimportrowCollection;
        }

        public static AssessmentImportRow retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentImportRow.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentImportRow) gateway.retrieve(ResourceType.ASSESSMENT_IMPORT_ROW, id);
        }

        public AssessmentImportJob getAssessmentImportJob ()
        {
            return (AssessmentImportJob) this.getProperty("assessmentImportJob");
        }

        public void setAssessmentImportJob (AssessmentImportJob assessmentImportJob)
        {
            this.setProperty("assessmentImportJob", assessmentImportJob);
        }

        public Student getMappedStudent ()
        {
            return (Student) this.getProperty("mappedStudent");
        }

        public void setMappedStudent (Student mappedStudent)
        {
            this.setProperty("mappedStudent", mappedStudent);
        }


    }
}

