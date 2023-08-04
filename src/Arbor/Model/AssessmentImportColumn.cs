using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentImportColumn : ModelBase
    {
        protected new string resourceType = ResourceType.ASSESSMENT_IMPORT_COLUMN;
        public const string MAPPED_ASSESSMENT_ASPECT = "mappedAssessmentAspect";

        public AssessmentImportColumn ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentImportColumn (string resourceType = "AssessmentImportColumn", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentImportColumn> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentImportColumn");
        	RestGateway gateway = (RestGateway) AssessmentImportColumn.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentImportColumn> assessmentimportcolumnCollection = new ModelCollection<AssessmentImportColumn> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentimportcolumnCollection.add((AssessmentImportColumn) model);
        	}
        
        	return assessmentimportcolumnCollection;
        }

        public static AssessmentImportColumn retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentImportColumn.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentImportColumn) gateway.retrieve(ResourceType.ASSESSMENT_IMPORT_COLUMN, id);
        }

        public ModelBase getMappedAssessmentAspect ()
        {
            return (ModelBase) this.getProperty("mappedAssessmentAspect");
        }

        public void setMappedAssessmentAspect (ModelBase mappedAssessmentAspect)
        {
            this.setProperty("mappedAssessmentAspect", mappedAssessmentAspect);
        }


    }
}

