using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IncomingCashlessCateringSystemTransaction : ModelBase
    {
        protected string resourceType = ResourceType.INCOMING_CASHLESS_CATERING_SYSTEM_TRANSACTION;
        public const string BILL_PAYER = "billPayer";
        public const string SOURCE = "source";
        public const string TRANSACTION_IDENTIFIER = "transactionIdentifier";
        public const string NARRATIVE = "narrative";
        public const string CUSTOMER_ACCOUNT = "customerAccount";
        public const string TRANSACTION_AMOUNT = "transactionAmount";
        public const string TRANSACTION_FEE_AMOUNT = "transactionFeeAmount";
        public const string VAT_AMOUNT = "vatAmount";
        public const string TRANSACTION_DATE = "transactionDate";
        public const string RELATED_ENTITY = "relatedEntity";

        public IncomingCashlessCateringSystemTransaction()
        {
            base.resourceType = this.resourceType;
        }

        public IncomingCashlessCateringSystemTransaction(string resourceType = "IncomingCashlessCateringSystemTransaction", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<IncomingCashlessCateringSystemTransaction> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("IncomingCashlessCateringSystemTransaction");
            RestGateway gateway = (RestGateway)IncomingCashlessCateringSystemTransaction.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<IncomingCashlessCateringSystemTransaction> incomingcashlesscateringsystemtransactionCollection = new ModelCollection<IncomingCashlessCateringSystemTransaction>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                incomingcashlesscateringsystemtransactionCollection.add((IncomingCashlessCateringSystemTransaction)model);
            }

            return incomingcashlesscateringsystemtransactionCollection;
        }

        public static IncomingCashlessCateringSystemTransaction retrieve(string id)
        {
            RestGateway gateway = (RestGateway)IncomingCashlessCateringSystemTransaction.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (IncomingCashlessCateringSystemTransaction)gateway.retrieve(ResourceType.INCOMING_CASHLESS_CATERING_SYSTEM_TRANSACTION, id);
        }

        public BillPayer getBillPayer()
        {
            return (BillPayer)this.getProperty("billPayer");
        }

        public void setBillPayer(BillPayer billPayer)
        {
            this.setProperty("billPayer", billPayer);
        }

        public string getSource()
        {
            return this.getProperty("source").ToString();
        }

        public void setSource(string source)
        {
            this.setProperty("source", source);
        }

        public string getTransactionIdentifier()
        {
            return this.getProperty("transactionIdentifier").ToString();
        }

        public void setTransactionIdentifier(string transactionIdentifier)
        {
            this.setProperty("transactionIdentifier", transactionIdentifier);
        }

        public string getNarrative()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative(string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public CustomerAccount getCustomerAccount()
        {
            return (CustomerAccount)this.getProperty("customerAccount");
        }

        public void setCustomerAccount(CustomerAccount customerAccount)
        {
            this.setProperty("customerAccount", customerAccount);
        }

        public string getTransactionAmount()
        {
            return this.getProperty("transactionAmount").ToString();
        }

        public void setTransactionAmount(string transactionAmount)
        {
            this.setProperty("transactionAmount", transactionAmount);
        }

        public string getTransactionFeeAmount()
        {
            return this.getProperty("transactionFeeAmount").ToString();
        }

        public void setTransactionFeeAmount(string transactionFeeAmount)
        {
            this.setProperty("transactionFeeAmount", transactionFeeAmount);
        }

        public string getVatAmount()
        {
            return this.getProperty("vatAmount").ToString();
        }

        public void setVatAmount(string vatAmount)
        {
            this.setProperty("vatAmount", vatAmount);
        }

        public DateTime getTransactionDate()
        {
            return Convert.ToDateTime(this.getProperty("transactionDate"));
        }

        public void setTransactionDate(DateTime transactionDate)
        {
            this.setProperty("transactionDate", transactionDate);
        }

        public ModelBase getRelatedEntity()
        {
            return (ModelBase)this.getProperty("relatedEntity");
        }

        public void setRelatedEntity(ModelBase relatedEntity)
        {
            this.setProperty("relatedEntity", relatedEntity);
        }


    }
}

