using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class EducationPlanContributor : ModelBase
    {
        protected string resourceType = ResourceType.EDUCATION_PLAN_CONTRIBUTOR;
        public const string EDUCATION_PLAN = "educationPlan";
        public const string CONTRIBUTOR = "contributor";

        public EducationPlanContributor ()
        {
            base.resourceType = this.resourceType;
        }
        
        public EducationPlanContributor (string resourceType = "EducationPlanContributor", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<EducationPlanContributor> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("EducationPlanContributor");
        	RestGateway gateway = (RestGateway) EducationPlanContributor.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<EducationPlanContributor> educationplancontributorCollection = new ModelCollection<EducationPlanContributor> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    educationplancontributorCollection.add((EducationPlanContributor) model);
        	}
        
        	return educationplancontributorCollection;
        }

        public static EducationPlanContributor retrieve (string id)
        {
            RestGateway gateway = (RestGateway) EducationPlanContributor.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (EducationPlanContributor) gateway.retrieve(ResourceType.EDUCATION_PLAN_CONTRIBUTOR, id);
        }

        public EducationPlan getEducationPlan ()
        {
            return (EducationPlan) this.getProperty("educationPlan");
        }

        public void setEducationPlan (EducationPlan educationPlan)
        {
            this.setProperty("educationPlan", educationPlan);
        }

        public ModelBase getContributor ()
        {
            return (ModelBase) this.getProperty("contributor");
        }

        public void setContributor (ModelBase contributor)
        {
            this.setProperty("contributor", contributor);
        }


    }
}

