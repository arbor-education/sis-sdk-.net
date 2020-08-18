using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_Position : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_POSITION;
        public const string POSITION_CATEGORY = "positionCategory";
        public const string WORKFORCE_VACANCY_POST = "workforceVacancyPost";
        public const string WORKFORCE_CENSUS_ROLE_IDENTIFIER = "workforceCensusRoleIdentifier";

        public UkDfe_Position ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_Position (string resourceType = "UkDfe_Position", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_Position> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_Position");
        	RestGateway gateway = (RestGateway) UkDfe_Position.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_Position> ukdfe_positionCollection = new ModelCollection<UkDfe_Position> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_positionCollection.add((UkDfe_Position) model);
        	}
        
        	return ukdfe_positionCollection;
        }

        public static UkDfe_Position retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_Position.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_Position) gateway.retrieve(ResourceType.UK_DFE_POSITION, id);
        }

        public PositionCategory getPositionCategory ()
        {
            return (PositionCategory) this.getProperty("positionCategory");
        }

        public void setPositionCategory (PositionCategory positionCategory)
        {
            this.setProperty("positionCategory", positionCategory);
        }

        public SchoolWorkforceVacancyPost getWorkforceVacancyPost ()
        {
            return (SchoolWorkforceVacancyPost) this.getProperty("workforceVacancyPost");
        }

        public void setWorkforceVacancyPost (SchoolWorkforceVacancyPost workforceVacancyPost)
        {
            this.setProperty("workforceVacancyPost", workforceVacancyPost);
        }

        public string getWorkforceCensusRoleIdentifier ()
        {
            return this.getProperty("workforceCensusRoleIdentifier").ToString();
        }

        public void setWorkforceCensusRoleIdentifier (string workforceCensusRoleIdentifier)
        {
            this.setProperty("workforceCensusRoleIdentifier", workforceCensusRoleIdentifier);
        }


    }
}

