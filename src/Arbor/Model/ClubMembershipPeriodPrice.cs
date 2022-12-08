using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ClubMembershipPeriodPrice : ModelBase
    {
        protected string resourceType = ResourceType.CLUB_MEMBERSHIP_PERIOD_PRICE;
        public const string CLUB_MEMBERSHIP_PERIOD = "clubMembershipPeriod";
        public const string PRICING_BASIS = "pricingBasis";
        public const string PRICE_EX_VAT = "priceExVat";
        public const string VAT_RATE = "vatRate";
        public const string APPLICABLE = "applicable";
        public const string VARIABLE_CONTRIBUTION = "variableContribution";

        public ClubMembershipPeriodPrice()
        {
            base.resourceType = this.resourceType;
        }

        public ClubMembershipPeriodPrice(string resourceType = "ClubMembershipPeriodPrice", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ClubMembershipPeriodPrice> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ClubMembershipPeriodPrice");
            RestGateway gateway = (RestGateway)ClubMembershipPeriodPrice.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ClubMembershipPeriodPrice> clubmembershipperiodpriceCollection = new ModelCollection<ClubMembershipPeriodPrice>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                clubmembershipperiodpriceCollection.add((ClubMembershipPeriodPrice)model);
            }

            return clubmembershipperiodpriceCollection;
        }

        public static ClubMembershipPeriodPrice retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ClubMembershipPeriodPrice.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ClubMembershipPeriodPrice)gateway.retrieve(ResourceType.CLUB_MEMBERSHIP_PERIOD_PRICE, id);
        }

        public ClubMembershipPeriod getClubMembershipPeriod()
        {
            return (ClubMembershipPeriod)this.getProperty("clubMembershipPeriod");
        }

        public void setClubMembershipPeriod(ClubMembershipPeriod clubMembershipPeriod)
        {
            this.setProperty("clubMembershipPeriod", clubMembershipPeriod);
        }

        public string getPricingBasis()
        {
            return this.getProperty("pricingBasis").ToString();
        }

        public void setPricingBasis(string pricingBasis)
        {
            this.setProperty("pricingBasis", pricingBasis);
        }

        public string getPriceExVat()
        {
            return this.getProperty("priceExVat").ToString();
        }

        public void setPriceExVat(string priceExVat)
        {
            this.setProperty("priceExVat", priceExVat);
        }

        public VatRate getVatRate()
        {
            return (VatRate)this.getProperty("vatRate");
        }

        public void setVatRate(VatRate vatRate)
        {
            this.setProperty("vatRate", vatRate);
        }

        public ModelBase getApplicable()
        {
            return (ModelBase)this.getProperty("applicable");
        }

        public void setApplicable(ModelBase applicable)
        {
            this.setProperty("applicable", applicable);
        }

        public bool getVariableContribution()
        {
            return Convert.ToBoolean(this.getProperty("variableContribution"));
        }

        public void setVariableContribution(bool variableContribution)
        {
            this.setProperty("variableContribution", variableContribution);
        }


    }
}

