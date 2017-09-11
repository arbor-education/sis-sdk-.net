using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ClubEligibility : ModelBase
    {
        protected string resourceType = ResourceType.CLUB_ELIGIBILITY;
        public const string CLUB = "club";
        public const string ELIGIBLE = "eligible";

        public ClubEligibility ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ClubEligibility (string resourceType = "ClubEligibility", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ClubEligibility> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ClubEligibility");
        	RestGateway gateway = (RestGateway) ClubEligibility.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ClubEligibility> clubeligibilityCollection = new ModelCollection<ClubEligibility> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    clubeligibilityCollection.add((ClubEligibility) model);
        	}
        
        	return clubeligibilityCollection;
        }

        public static ClubEligibility retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ClubEligibility.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ClubEligibility) gateway.retrieve(ResourceType.CLUB_ELIGIBILITY, id);
        }

        public Club getClub ()
        {
            return (Club) this.getProperty("club");
        }

        public void setClub (Club club)
        {
            this.setProperty("club", club);
        }

        public ModelBase getEligible ()
        {
            return (ModelBase) this.getProperty("eligible");
        }

        public void setEligible (ModelBase eligible)
        {
            this.setProperty("eligible", eligible);
        }


    }
}

