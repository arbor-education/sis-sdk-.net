using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_ServiceChildConcern : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SERVICE_CHILD_CONCERN;
        public const string STUDENT = "student";
        public const string MOVE_CONCERN = "moveConcern";
        public const string DEPLOYMENT_CONCERN = "deploymentConcern";
        public const string SEPARATION_CONCERN = "separationConcern";
        public const string NOTES = "notes";
        public const string ASSESSMENT_DATE = "assessmentDate";
        public const string IMPORTED = "imported";
        public const string CTF_IMPORT_JOB_STUDENT = "ctfImportJobStudent";

        public UkDfe_ServiceChildConcern ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_ServiceChildConcern (string resourceType = "UkDfe_ServiceChildConcern", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_ServiceChildConcern> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_ServiceChildConcern");
        	RestGateway gateway = (RestGateway) UkDfe_ServiceChildConcern.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_ServiceChildConcern> ukdfe_servicechildconcernCollection = new ModelCollection<UkDfe_ServiceChildConcern> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_servicechildconcernCollection.add((UkDfe_ServiceChildConcern) model);
        	}
        
        	return ukdfe_servicechildconcernCollection;
        }

        public static UkDfe_ServiceChildConcern retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_ServiceChildConcern.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_ServiceChildConcern) gateway.retrieve(ResourceType.UK_DFE_SERVICE_CHILD_CONCERN, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public string getMoveConcern ()
        {
            return this.getProperty("moveConcern").ToString();
        }

        public void setMoveConcern (string moveConcern)
        {
            this.setProperty("moveConcern", moveConcern);
        }

        public string getDeploymentConcern ()
        {
            return this.getProperty("deploymentConcern").ToString();
        }

        public void setDeploymentConcern (string deploymentConcern)
        {
            this.setProperty("deploymentConcern", deploymentConcern);
        }

        public string getSeparationConcern ()
        {
            return this.getProperty("separationConcern").ToString();
        }

        public void setSeparationConcern (string separationConcern)
        {
            this.setProperty("separationConcern", separationConcern);
        }

        public string getNotes ()
        {
            return this.getProperty("notes").ToString();
        }

        public void setNotes (string notes)
        {
            this.setProperty("notes", notes);
        }

        public DateTime getAssessmentDate ()
        {
            return Convert.ToDateTime(this.getProperty("assessmentDate"));
        }

        public void setAssessmentDate (DateTime assessmentDate)
        {
            this.setProperty("assessmentDate", assessmentDate);
        }

        public bool getImported ()
        {
            return Convert.ToBoolean(this.getProperty("imported"));
        }

        public void setImported (bool imported)
        {
            this.setProperty("imported", imported);
        }

        public CtfImportJobStudent getCtfImportJobStudent ()
        {
            return (CtfImportJobStudent) this.getProperty("ctfImportJobStudent");
        }

        public void setCtfImportJobStudent (CtfImportJobStudent ctfImportJobStudent)
        {
            this.setProperty("ctfImportJobStudent", ctfImportJobStudent);
        }


    }
}

