using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class OptionsImportAcademicUnitMapping : ModelBase
    {
        protected new string resourceType = ResourceType.OPTIONS_IMPORT_ACADEMIC_UNIT_MAPPING;
        public const string OPTIONS_IMPORT_RESULT = "optionsImportResult";
        public const string ACADEMIC_UNIT_NAME = "academicUnitName";
        public const string MAPPING_ACTION = "mappingAction";
        public const string MAPPED_ACADEMIC_UNIT = "mappedAcademicUnit";

        public OptionsImportAcademicUnitMapping ()
        {
            base.resourceType = this.resourceType;
        }
        
        public OptionsImportAcademicUnitMapping (string resourceType = "OptionsImportAcademicUnitMapping", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<OptionsImportAcademicUnitMapping> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("OptionsImportAcademicUnitMapping");
        	RestGateway gateway = (RestGateway) OptionsImportAcademicUnitMapping.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<OptionsImportAcademicUnitMapping> optionsimportacademicunitmappingCollection = new ModelCollection<OptionsImportAcademicUnitMapping> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    optionsimportacademicunitmappingCollection.add((OptionsImportAcademicUnitMapping) model);
        	}
        
        	return optionsimportacademicunitmappingCollection;
        }

        public static OptionsImportAcademicUnitMapping retrieve (string id)
        {
            RestGateway gateway = (RestGateway) OptionsImportAcademicUnitMapping.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (OptionsImportAcademicUnitMapping) gateway.retrieve(ResourceType.OPTIONS_IMPORT_ACADEMIC_UNIT_MAPPING, id);
        }

        public OptionsImportResult getOptionsImportResult ()
        {
            return (OptionsImportResult) this.getProperty("optionsImportResult");
        }

        public void setOptionsImportResult (OptionsImportResult optionsImportResult)
        {
            this.setProperty("optionsImportResult", optionsImportResult);
        }

        public string getAcademicUnitName ()
        {
            return this.getProperty("academicUnitName").ToString();
        }

        public void setAcademicUnitName (string academicUnitName)
        {
            this.setProperty("academicUnitName", academicUnitName);
        }

        public string getMappingAction ()
        {
            return this.getProperty("mappingAction").ToString();
        }

        public void setMappingAction (string mappingAction)
        {
            this.setProperty("mappingAction", mappingAction);
        }

        public AcademicUnit getMappedAcademicUnit ()
        {
            return (AcademicUnit) this.getProperty("mappedAcademicUnit");
        }

        public void setMappedAcademicUnit (AcademicUnit mappedAcademicUnit)
        {
            this.setProperty("mappedAcademicUnit", mappedAcademicUnit);
        }


    }
}

