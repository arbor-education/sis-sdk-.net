using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class Position : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_POSITION;
        public const string POSITION_CATEGORY = "positionCategory";
        public const string WORKFORCE_VACANCY_POST = "workforceVacancyPost";

        public Position ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Position (string resourceType = "Position", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Position> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_Position");
        	RestGateway gateway = (RestGateway) Position.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Position> positionCollection = new ModelCollection<Position> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    positionCollection.add((Position) model);
        	}
        
        	return positionCollection;
        }

        public static Position retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Position.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Position) gateway.retrieve(ResourceType.UK_DFE_POSITION, id);
        }

        public ModelBase getPositionCategory ()
        {
            return (ModelBase) this.getProperty("positionCategory");
        }

        public void setPositionCategory (ModelBase positionCategory)
        {
            this.setProperty("positionCategory", positionCategory);
        }

        public ModelBase getWorkforceVacancyPost ()
        {
            return (ModelBase) this.getProperty("workforceVacancyPost");
        }

        public void setWorkforceVacancyPost (ModelBase workforceVacancyPost)
        {
            this.setProperty("workforceVacancyPost", workforceVacancyPost);
        }


    }
}

