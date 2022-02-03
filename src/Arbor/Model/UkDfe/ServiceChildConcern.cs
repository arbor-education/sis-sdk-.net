using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class ServiceChildConcern : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SERVICE_CHILD_CONCERN;
        public const string STUDENT = "student";
        public const string MOVE_CONCERN = "moveConcern";
        public const string DEPLOYMENT_CONCERN = "deploymentConcern";
        public const string SEPARATION_CONCERN = "separationConcern";
        public const string NOTES = "notes";
        public const string ASSESSMENT_DATE = "assessmentDate";
        public const string IMPORTED = "imported";

        public ServiceChildConcern ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ServiceChildConcern (string resourceType = "ServiceChildConcern", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ServiceChildConcern> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_ServiceChildConcern");
        	RestGateway gateway = (RestGateway) ServiceChildConcern.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ServiceChildConcern> servicechildconcernCollection = new ModelCollection<ServiceChildConcern> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    servicechildconcernCollection.add((ServiceChildConcern) model);
        	}
        
        	return servicechildconcernCollection;
        }

        public static ServiceChildConcern retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ServiceChildConcern.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ServiceChildConcern) gateway.retrieve(ResourceType.UK_DFE_SERVICE_CHILD_CONCERN, id);
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


    }
}

