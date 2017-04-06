using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentInterventionReview : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_INTERVENTION_REVIEW;
        public const string STUDENT_INTERVENTION = "studentIntervention";
        public const string INTERVENTION_REVIEW = "interventionReview";
        public const string REVIEW = "review";

        public StudentInterventionReview ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentInterventionReview (string resourceType = "StudentInterventionReview", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentInterventionReview> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentInterventionReview");
        	RestGateway gateway = (RestGateway) StudentInterventionReview.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentInterventionReview> studentinterventionreviewCollection = new ModelCollection<StudentInterventionReview> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentinterventionreviewCollection.add((StudentInterventionReview) model);
        	}
        
        	return studentinterventionreviewCollection;
        }

        public static StudentInterventionReview retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentInterventionReview.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentInterventionReview) gateway.retrieve(ResourceType.STUDENT_INTERVENTION_REVIEW, id);
        }

        public StudentIntervention getStudentIntervention ()
        {
            return (StudentIntervention) this.getProperty("studentIntervention");
        }

        public void setStudentIntervention (StudentIntervention studentIntervention)
        {
            this.setProperty("studentIntervention", studentIntervention);
        }

        public InterventionReview getInterventionReview ()
        {
            return (InterventionReview) this.getProperty("interventionReview");
        }

        public void setInterventionReview (InterventionReview interventionReview)
        {
            this.setProperty("interventionReview", interventionReview);
        }

        public string getReview ()
        {
            return this.getProperty("review").ToString();
        }

        public void setReview (string review)
        {
            this.setProperty("review", review);
        }


    }
}

