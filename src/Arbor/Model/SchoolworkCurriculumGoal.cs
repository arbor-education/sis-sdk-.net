using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SchoolworkCurriculumGoal : ModelBase
    {
        protected string resourceType = ResourceType.SCHOOLWORK_CURRICULUM_GOAL;
        public const string SCHOOLWORK = "schoolwork";
        public const string CURRICULUM_GOAL = "curriculumGoal";

        public SchoolworkCurriculumGoal ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SchoolworkCurriculumGoal (string resourceType = "SchoolworkCurriculumGoal", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SchoolworkCurriculumGoal> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SchoolworkCurriculumGoal");
        	RestGateway gateway = (RestGateway) SchoolworkCurriculumGoal.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SchoolworkCurriculumGoal> schoolworkcurriculumgoalCollection = new ModelCollection<SchoolworkCurriculumGoal> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schoolworkcurriculumgoalCollection.add((SchoolworkCurriculumGoal) model);
        	}
        
        	return schoolworkcurriculumgoalCollection;
        }

        public static SchoolworkCurriculumGoal retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SchoolworkCurriculumGoal.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SchoolworkCurriculumGoal) gateway.retrieve(ResourceType.SCHOOLWORK_CURRICULUM_GOAL, id);
        }

        public Schoolwork getSchoolwork ()
        {
            return (Schoolwork) this.getProperty("schoolwork");
        }

        public void setSchoolwork (Schoolwork schoolwork)
        {
            this.setProperty("schoolwork", schoolwork);
        }

        public CurriculumGoal getCurriculumGoal ()
        {
            return (CurriculumGoal) this.getProperty("curriculumGoal");
        }

        public void setCurriculumGoal (CurriculumGoal curriculumGoal)
        {
            this.setProperty("curriculumGoal", curriculumGoal);
        }


    }
}

