using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class PaymentCard : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_PAYMENT_CARD;
        public const string BANK = "bank";
        public const string BANK_ACCOUNT = "bankAccount";
        public const string CARD_TYPE = "cardType";
        public const string CARD_NUMBER = "cardNumber";
        public const string VALID_FROM_DATE = "validFromDate";
        public const string VALID_UNTIL_DATE = "validUntilDate";
        public const string VERIFICATION_CODE = "verificationCode";
        public const string NAME_ON_CARD = "nameOnCard";
        public const string CREDIT_LIMIT_ACCOUNT = "creditLimitAccount";

        public PaymentCard ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PaymentCard (string resourceType = "PaymentCard", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PaymentCard> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_PaymentCard");
        	RestGateway gateway = (RestGateway) PaymentCard.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PaymentCard> paymentcardCollection = new ModelCollection<PaymentCard> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    paymentcardCollection.add((PaymentCard) model);
        	}
        
        	return paymentcardCollection;
        }

        public static PaymentCard retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PaymentCard.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PaymentCard) gateway.retrieve(ResourceType.FINANCE_PAYMENT_CARD, id);
        }

        public ModelBase getBank ()
        {
            return (ModelBase) this.getProperty("bank");
        }

        public void setBank (ModelBase bank)
        {
            this.setProperty("bank", bank);
        }

        public ModelBase getBankAccount ()
        {
            return (ModelBase) this.getProperty("bankAccount");
        }

        public void setBankAccount (ModelBase bankAccount)
        {
            this.setProperty("bankAccount", bankAccount);
        }

        public string getCardType ()
        {
            return this.getProperty("cardType").ToString();
        }

        public void setCardType (string cardType)
        {
            this.setProperty("cardType", cardType);
        }

        public int getCardNumber ()
        {
            return Convert.ToInt32(this.getProperty("cardNumber"));
        }

        public void setCardNumber (int cardNumber)
        {
            this.setProperty("cardNumber", cardNumber);
        }

        public DateTime getValidFromDate ()
        {
            return (DateTime) this.getProperty("validFromDate");
        }

        public void setValidFromDate (DateTime validFromDate)
        {
            this.setProperty("validFromDate", validFromDate);
        }

        public DateTime getValidUntilDate ()
        {
            return (DateTime) this.getProperty("validUntilDate");
        }

        public void setValidUntilDate (DateTime validUntilDate)
        {
            this.setProperty("validUntilDate", validUntilDate);
        }

        public int getVerificationCode ()
        {
            return Convert.ToInt32(this.getProperty("verificationCode"));
        }

        public void setVerificationCode (int verificationCode)
        {
            this.setProperty("verificationCode", verificationCode);
        }

        public string getNameOnCard ()
        {
            return this.getProperty("nameOnCard").ToString();
        }

        public void setNameOnCard (string nameOnCard)
        {
            this.setProperty("nameOnCard", nameOnCard);
        }

        public int getCreditLimitAccount ()
        {
            return Convert.ToInt32(this.getProperty("creditLimitAccount"));
        }

        public void setCreditLimitAccount (int creditLimitAccount)
        {
            this.setProperty("creditLimitAccount", creditLimitAccount);
        }


    }
}

