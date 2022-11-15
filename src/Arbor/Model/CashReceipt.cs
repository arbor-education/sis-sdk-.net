using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CashReceipt : ModelBase
    {
        protected new string resourceType = ResourceType.CASH_RECEIPT;
        public const string BILL_PAYER = "billPayer";
        public const string BANK_DEPOSIT = "bankDeposit";
        public const string RECEIVED_DATE = "receivedDate";
        public const string CANCELLED_DATETIME = "cancelledDatetime";
        public const string RECEIVED_PAYMENT = "receivedPayment";

        public CashReceipt()
        {
            base.resourceType = this.resourceType;
        }

        public CashReceipt(string resourceType = "CashReceipt", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CashReceipt> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CashReceipt");
            RestGateway gateway = (RestGateway)CashReceipt.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CashReceipt> cashreceiptCollection = new ModelCollection<CashReceipt>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                cashreceiptCollection.add((CashReceipt)model);
            }

            return cashreceiptCollection;
        }

        public static CashReceipt retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CashReceipt.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CashReceipt)gateway.retrieve(ResourceType.CASH_RECEIPT, id);
        }

        public BillPayer getBillPayer()
        {
            return (BillPayer)this.getProperty("billPayer");
        }

        public void setBillPayer(BillPayer billPayer)
        {
            this.setProperty("billPayer", billPayer);
        }

        public BankDeposit getBankDeposit()
        {
            return (BankDeposit)this.getProperty("bankDeposit");
        }

        public void setBankDeposit(BankDeposit bankDeposit)
        {
            this.setProperty("bankDeposit", bankDeposit);
        }

        public DateTime getReceivedDate()
        {
            return Convert.ToDateTime(this.getProperty("receivedDate"));
        }

        public void setReceivedDate(DateTime receivedDate)
        {
            this.setProperty("receivedDate", receivedDate);
        }

        public DateTime getCancelledDatetime()
        {
            return Convert.ToDateTime(this.getProperty("cancelledDatetime"));
        }

        public void setCancelledDatetime(DateTime cancelledDatetime)
        {
            this.setProperty("cancelledDatetime", cancelledDatetime);
        }

        public string getReceivedPayment()
        {
            return this.getProperty("receivedPayment").ToString();
        }

        public void setReceivedPayment(string receivedPayment)
        {
            this.setProperty("receivedPayment", receivedPayment);
        }


    }
}

