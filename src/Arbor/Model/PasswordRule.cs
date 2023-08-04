using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PasswordRule : ModelBase
    {
        protected string resourceType = ResourceType.PASSWORD_RULE;
        public const string APPLIES_FOR = "appliesFor";
        public const string MIN_LENGTH = "minLength";
        public const string DAYS_VALID = "daysValid";
        public const string REQUIRE_NUMBER = "requireNumber";
        public const string REQUIRE_LETTER = "requireLetter";
        public const string REQUIRE_MIXED_CASE = "requireMixedCase";

        public PasswordRule()
        {
            base.resourceType = this.resourceType;
        }

        public PasswordRule(string resourceType = "PasswordRule", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PasswordRule> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PasswordRule");
            RestGateway gateway = (RestGateway)PasswordRule.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PasswordRule> passwordruleCollection = new ModelCollection<PasswordRule>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                passwordruleCollection.add((PasswordRule)model);
            }

            return passwordruleCollection;
        }

        public static PasswordRule retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PasswordRule.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PasswordRule)gateway.retrieve(ResourceType.PASSWORD_RULE, id);
        }

        public string getAppliesFor()
        {
            return this.getProperty("appliesFor").ToString();
        }

        public void setAppliesFor(string appliesFor)
        {
            this.setProperty("appliesFor", appliesFor);
        }

        public int getMinLength()
        {
            return Convert.ToInt32(this.getProperty("minLength"));
        }

        public void setMinLength(int minLength)
        {
            this.setProperty("minLength", minLength);
        }

        public int getDaysValid()
        {
            return Convert.ToInt32(this.getProperty("daysValid"));
        }

        public void setDaysValid(int daysValid)
        {
            this.setProperty("daysValid", daysValid);
        }

        public bool getRequireNumber()
        {
            return (bool)this.getProperty("requireNumber");
        }

        public void setRequireNumber(bool requireNumber)
        {
            this.setProperty("requireNumber", requireNumber);
        }

        public bool getRequireLetter()
        {
            return (bool)this.getProperty("requireLetter");
        }

        public void setRequireLetter(bool requireLetter)
        {
            this.setProperty("requireLetter", requireLetter);
        }

        public bool getRequireMixedCase()
        {
            return (bool)this.getProperty("requireMixedCase");
        }

        public void setRequireMixedCase(bool requireMixedCase)
        {
            this.setProperty("requireMixedCase", requireMixedCase);
        }


    }
}

