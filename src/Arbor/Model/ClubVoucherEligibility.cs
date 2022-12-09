using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ClubVoucherEligibility : ModelBase
    {
        protected new string resourceType = ResourceType.CLUB_VOUCHER_ELIGIBILITY;
        public const string CLUB = "club";
        public const string GROUP = "group";

        public ClubVoucherEligibility()
        {
            base.resourceType = this.resourceType;
        }

        public ClubVoucherEligibility(string resourceType = "ClubVoucherEligibility", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ClubVoucherEligibility> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ClubVoucherEligibility");
            RestGateway gateway = (RestGateway)ClubVoucherEligibility.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ClubVoucherEligibility> clubvouchereligibilityCollection = new ModelCollection<ClubVoucherEligibility>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                clubvouchereligibilityCollection.add((ClubVoucherEligibility)model);
            }

            return clubvouchereligibilityCollection;
        }

        public static ClubVoucherEligibility retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ClubVoucherEligibility.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ClubVoucherEligibility)gateway.retrieve(ResourceType.CLUB_VOUCHER_ELIGIBILITY, id);
        }

        public Club getClub()
        {
            return (Club)this.getProperty("club");
        }

        public void setClub(Club club)
        {
            this.setProperty("club", club);
        }

        public ModelBase getGroup()
        {
            return (ModelBase)this.getProperty("group");
        }

        public void setGroup(ModelBase group)
        {
            this.setProperty("group", group);
        }


    }
}

