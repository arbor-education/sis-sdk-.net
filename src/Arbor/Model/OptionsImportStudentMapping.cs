using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class OptionsImportStudentMapping : ModelBase
    {
        protected new string resourceType = ResourceType.OPTIONS_IMPORT_STUDENT_MAPPING;
        public const string OPTIONS_IMPORT_RESULT = "optionsImportResult";
        public const string STUDENT_NAME = "studentName";
        public const string STUDENT_IDENTIFIER = "studentIdentifier";
        public const string MAPPING_ACTION = "mappingAction";
        public const string MAPPED_STUDENT = "mappedStudent";

        public OptionsImportStudentMapping ()
        {
            base.resourceType = this.resourceType;
        }
        
        public OptionsImportStudentMapping (string resourceType = "OptionsImportStudentMapping", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<OptionsImportStudentMapping> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("OptionsImportStudentMapping");
        	RestGateway gateway = (RestGateway) OptionsImportStudentMapping.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<OptionsImportStudentMapping> optionsimportstudentmappingCollection = new ModelCollection<OptionsImportStudentMapping> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    optionsimportstudentmappingCollection.add((OptionsImportStudentMapping) model);
        	}
        
        	return optionsimportstudentmappingCollection;
        }

        public static OptionsImportStudentMapping retrieve (string id)
        {
            RestGateway gateway = (RestGateway) OptionsImportStudentMapping.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (OptionsImportStudentMapping) gateway.retrieve(ResourceType.OPTIONS_IMPORT_STUDENT_MAPPING, id);
        }

        public OptionsImportResult getOptionsImportResult ()
        {
            return (OptionsImportResult) this.getProperty("optionsImportResult");
        }

        public void setOptionsImportResult (OptionsImportResult optionsImportResult)
        {
            this.setProperty("optionsImportResult", optionsImportResult);
        }

        public string getStudentName ()
        {
            return this.getProperty("studentName").ToString();
        }

        public void setStudentName (string studentName)
        {
            this.setProperty("studentName", studentName);
        }

        public string getStudentIdentifier ()
        {
            return this.getProperty("studentIdentifier").ToString();
        }

        public void setStudentIdentifier (string studentIdentifier)
        {
            this.setProperty("studentIdentifier", studentIdentifier);
        }

        public string getMappingAction ()
        {
            return this.getProperty("mappingAction").ToString();
        }

        public void setMappingAction (string mappingAction)
        {
            this.setProperty("mappingAction", mappingAction);
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

