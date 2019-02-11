using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ClubMembershipPeriod : ModelBase
    {
        protected string resourceType = ResourceType.CLUB_MEMBERSHIP_PERIOD;
        public const string CLUB = "club";
        public const string NAME = "name";
        public const string PURCHASE_START_DATE = "purchaseStartDate";
        public const string PURCHASE_END_DATE = "purchaseEndDate";
        public const string MEMBERSHIP_PERIOD_TYPE = "membershipPeriodType";
        public const string ALLOW_GUARDIAN_PORTAL_SIGNUP = "allowGuardianPortalSignup";

        public ClubMembershipPeriod ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ClubMembershipPeriod (string resourceType = "ClubMembershipPeriod", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ClubMembershipPeriod> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ClubMembershipPeriod");
        	RestGateway gateway = (RestGateway) ClubMembershipPeriod.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ClubMembershipPeriod> clubmembershipperiodCollection = new ModelCollection<ClubMembershipPeriod> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    clubmembershipperiodCollection.add((ClubMembershipPeriod) model);
        	}
        
        	return clubmembershipperiodCollection;
        }

        public static ClubMembershipPeriod retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ClubMembershipPeriod.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ClubMembershipPeriod) gateway.retrieve(ResourceType.CLUB_MEMBERSHIP_PERIOD, id);
        }

        public Club getClub ()
        {
            return (Club) this.getProperty("club");
        }

        public void setClub (Club club)
        {
            this.setProperty("club", club);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public DateTime getPurchaseStartDate (){
            return Convert.ToDateTime(this.getProperty("purchaseStartDate"));
        }

        public void setPurchaseStartDate (DateTime purchaseStartDate)
        {
            this.setProperty("purchaseStartDate", purchaseStartDate);
        }

        public DateTime getPurchaseEndDate (){
            return Convert.ToDateTime(this.getProperty("purchaseEndDate"));
        }

        public void setPurchaseEndDate (DateTime purchaseEndDate)
        {
            this.setProperty("purchaseEndDate", purchaseEndDate);
        }

        public string getMembershipPeriodType ()
        {
            return this.getProperty("membershipPeriodType").ToString();
        }

        public void setMembershipPeriodType (string membershipPeriodType)
        {
            this.setProperty("membershipPeriodType", membershipPeriodType);
        }

        public bool getAllowGuardianPortalSignup ()
        {
            return Convert.ToBoolean( this.getProperty("allowGuardianPortalSignup"));
        }

        public void setAllowGuardianPortalSignup (bool allowGuardianPortalSignup)
        {
            this.setProperty("allowGuardianPortalSignup", allowGuardianPortalSignup);
        }


    }
}

