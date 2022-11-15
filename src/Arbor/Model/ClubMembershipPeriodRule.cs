using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ClubMembershipPeriodRule : ModelBase
    {
        protected new string resourceType = ResourceType.CLUB_MEMBERSHIP_PERIOD_RULE;
        public const string RULE_IDENTIFIER = "ruleIdentifier";
        public const string RULE_VALUE = "ruleValue";
        public const string CLUB_MEMBERSHIP_PERIOD = "clubMembershipPeriod";

        public ClubMembershipPeriodRule()
        {
            base.resourceType = this.resourceType;
        }

        public ClubMembershipPeriodRule(string resourceType = "ClubMembershipPeriodRule", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ClubMembershipPeriodRule> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ClubMembershipPeriodRule");
            RestGateway gateway = (RestGateway)ClubMembershipPeriodRule.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ClubMembershipPeriodRule> clubmembershipperiodruleCollection = new ModelCollection<ClubMembershipPeriodRule>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                clubmembershipperiodruleCollection.add((ClubMembershipPeriodRule)model);
            }

            return clubmembershipperiodruleCollection;
        }

        public static ClubMembershipPeriodRule retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ClubMembershipPeriodRule.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ClubMembershipPeriodRule)gateway.retrieve(ResourceType.CLUB_MEMBERSHIP_PERIOD_RULE, id);
        }

        public string getRuleIdentifier()
        {
            return this.getProperty("ruleIdentifier").ToString();
        }

        public void setRuleIdentifier(string ruleIdentifier)
        {
            this.setProperty("ruleIdentifier", ruleIdentifier);
        }

        public string getRuleValue()
        {
            return this.getProperty("ruleValue").ToString();
        }

        public void setRuleValue(string ruleValue)
        {
            this.setProperty("ruleValue", ruleValue);
        }

        public ClubMembershipPeriod getClubMembershipPeriod()
        {
            return (ClubMembershipPeriod)this.getProperty("clubMembershipPeriod");
        }

        public void setClubMembershipPeriod(ClubMembershipPeriod clubMembershipPeriod)
        {
            this.setProperty("clubMembershipPeriod", clubMembershipPeriod);
        }


    }
}

