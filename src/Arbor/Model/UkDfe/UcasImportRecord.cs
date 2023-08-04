using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UcasImportRecord : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_UCAS_IMPORT_RECORD;
        public const string UCAS_IMPORT = "ucasImport";
        public const string CSV_ROW = "csvRow";
        public const string MAPPED_STUDENT = "mappedStudent";
        public const string YEAR_OF_ENTRY = "yearOfEntry";
        public const string APPLICATION_SCHEME_CODE = "applicationSchemeCode";
        public const string INSTITUTION_CODE = "institutionCode";
        public const string INSTITUTION_NAME = "institutionName";
        public const string COURSE_CODE = "courseCode";
        public const string COURSE_NAME = "courseName";
        public const string CAMPUS_CODE = "campusCode";

        public UcasImportRecord ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UcasImportRecord (string resourceType = "UcasImportRecord", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UcasImportRecord> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_UcasImportRecord");
        	RestGateway gateway = (RestGateway) UcasImportRecord.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UcasImportRecord> ucasimportrecordCollection = new ModelCollection<UcasImportRecord> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ucasimportrecordCollection.add((UcasImportRecord) model);
        	}
        
        	return ucasimportrecordCollection;
        }

        public static UcasImportRecord retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UcasImportRecord.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UcasImportRecord) gateway.retrieve(ResourceType.UK_DFE_UCAS_IMPORT_RECORD, id);
        }

        public UcasImport getUcasImport ()
        {
            return (UcasImport) this.getProperty("ucasImport");
        }

        public void setUcasImport (UcasImport ucasImport)
        {
            this.setProperty("ucasImport", ucasImport);
        }

        public int getCsvRow ()
        {
            return Convert.ToInt32(this.getProperty("csvRow"));
        }

        public void setCsvRow (int csvRow)
        {
            this.setProperty("csvRow", csvRow);
        }

        public Student getMappedStudent ()
        {
            return (Student) this.getProperty("mappedStudent");
        }

        public void setMappedStudent (Student mappedStudent)
        {
            this.setProperty("mappedStudent", mappedStudent);
        }

        public int getYearOfEntry ()
        {
            return Convert.ToInt32(this.getProperty("yearOfEntry"));
        }

        public void setYearOfEntry (int yearOfEntry)
        {
            this.setProperty("yearOfEntry", yearOfEntry);
        }

        public string getApplicationSchemeCode ()
        {
            return this.getProperty("applicationSchemeCode").ToString();
        }

        public void setApplicationSchemeCode (string applicationSchemeCode)
        {
            this.setProperty("applicationSchemeCode", applicationSchemeCode);
        }

        public string getInstitutionCode ()
        {
            return this.getProperty("institutionCode").ToString();
        }

        public void setInstitutionCode (string institutionCode)
        {
            this.setProperty("institutionCode", institutionCode);
        }

        public string getInstitutionName ()
        {
            return this.getProperty("institutionName").ToString();
        }

        public void setInstitutionName (string institutionName)
        {
            this.setProperty("institutionName", institutionName);
        }

        public string getCourseCode ()
        {
            return this.getProperty("courseCode").ToString();
        }

        public void setCourseCode (string courseCode)
        {
            this.setProperty("courseCode", courseCode);
        }

        public string getCourseName ()
        {
            return this.getProperty("courseName").ToString();
        }

        public void setCourseName (string courseName)
        {
            this.setProperty("courseName", courseName);
        }

        public string getCampusCode ()
        {
            return this.getProperty("campusCode").ToString();
        }

        public void setCampusCode (string campusCode)
        {
            this.setProperty("campusCode", campusCode);
        }


    }
}

