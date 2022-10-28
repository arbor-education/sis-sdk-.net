using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomerPayment : ModelBase
    {
        protected new string resourceType = ResourceType.CUSTOMER_PAYMENT;
        public const string CUSTOMER_INVOICE = "customerInvoice";
        public const string BILL_PAYER = "billPayer";
        public const string INCOMING_DIRECT_DEBIT_TRANSACTION = "incomingDirectDebitTransaction";
        public const string INCOMING_CARD_TRANSACTION = "incomingCardTransaction";
        public const string INCOMING_CASHLESS_CATERING_SYSTEM_TRANSACTION = "incomingCashlessCateringSystemTransaction";
        public const string INCOMING_BANK_TRANSACTION = "incomingBankTransaction";
        public const string RECEIVED_CHEQUE = "receivedCheque";
        public const string CASH_RECEIPT = "cashReceipt";
        public const string VOUCHER = "voucher";
        public const string PAYMENT_AMOUNT = "paymentAmount";
        public const string PAYMENT_DATETIME = "paymentDatetime";
        public const string PAYMENT_SUCCEEDED_DATETIME = "paymentSucceededDatetime";
        public const string PAYMENT_FAILED_DATETIME = "paymentFailedDatetime";
        public const string NARRATIVE = "narrative";
        public const string PAYMENT_CANCELLED_DATETIME = "paymentCancelledDatetime";

        public CustomerPayment()
        {
            base.resourceType = this.resourceType;
        }

        public CustomerPayment(string resourceType = "CustomerPayment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CustomerPayment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CustomerPayment");
            RestGateway gateway = (RestGateway)CustomerPayment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CustomerPayment> customerpaymentCollection = new ModelCollection<CustomerPayment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                customerpaymentCollection.add((CustomerPayment)model);
            }

            return customerpaymentCollection;
        }

        public static CustomerPayment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CustomerPayment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CustomerPayment)gateway.retrieve(ResourceType.CUSTOMER_PAYMENT, id);
        }

        public CustomerInvoice getCustomerInvoice()
        {
            return (CustomerInvoice)this.getProperty("customerInvoice");
        }

        public void setCustomerInvoice(CustomerInvoice customerInvoice)
        {
            this.setProperty("customerInvoice", customerInvoice);
        }

        public BillPayer getBillPayer()
        {
            return (BillPayer)this.getProperty("billPayer");
        }

        public void setBillPayer(BillPayer billPayer)
        {
            this.setProperty("billPayer", billPayer);
        }

        public IncomingDirectDebitTransaction getIncomingDirectDebitTransaction()
        {
            return (IncomingDirectDebitTransaction)this.getProperty("incomingDirectDebitTransaction");
        }

        public void setIncomingDirectDebitTransaction(IncomingDirectDebitTransaction incomingDirectDebitTransaction)
        {
            this.setProperty("incomingDirectDebitTransaction", incomingDirectDebitTransaction);
        }

        public IncomingCardTransaction getIncomingCardTransaction()
        {
            return (IncomingCardTransaction)this.getProperty("incomingCardTransaction");
        }

        public void setIncomingCardTransaction(IncomingCardTransaction incomingCardTransaction)
        {
            this.setProperty("incomingCardTransaction", incomingCardTransaction);
        }

        public IncomingCashlessCateringSystemTransaction getIncomingCashlessCateringSystemTransaction()
        {
            return (IncomingCashlessCateringSystemTransaction)this.getProperty("incomingCashlessCateringSystemTransaction");
        }

        public void setIncomingCashlessCateringSystemTransaction(IncomingCashlessCateringSystemTransaction incomingCashlessCateringSystemTransaction)
        {
            this.setProperty("incomingCashlessCateringSystemTransaction", incomingCashlessCateringSystemTransaction);
        }

        public IncomingBankTransaction getIncomingBankTransaction()
        {
            return (IncomingBankTransaction)this.getProperty("incomingBankTransaction");
        }

        public void setIncomingBankTransaction(IncomingBankTransaction incomingBankTransaction)
        {
            this.setProperty("incomingBankTransaction", incomingBankTransaction);
        }

        public ReceivedCheque getReceivedCheque()
        {
            return (ReceivedCheque)this.getProperty("receivedCheque");
        }

        public void setReceivedCheque(ReceivedCheque receivedCheque)
        {
            this.setProperty("receivedCheque", receivedCheque);
        }

        public CashReceipt getCashReceipt()
        {
            return (CashReceipt)this.getProperty("cashReceipt");
        }

        public void setCashReceipt(CashReceipt cashReceipt)
        {
            this.setProperty("cashReceipt", cashReceipt);
        }

        public Voucher getVoucher()
        {
            return (Voucher)this.getProperty("voucher");
        }

        public void setVoucher(Voucher voucher)
        {
            this.setProperty("voucher", voucher);
        }

        public string getPaymentAmount()
        {
            return this.getProperty("paymentAmount").ToString();
        }

        public void setPaymentAmount(string paymentAmount)
        {
            this.setProperty("paymentAmount", paymentAmount);
        }

        public DateTime getPaymentDatetime()
        {
            return Convert.ToDateTime(this.getProperty("paymentDatetime"));
        }

        public void setPaymentDatetime(DateTime paymentDatetime)
        {
            this.setProperty("paymentDatetime", paymentDatetime);
        }

        public DateTime getPaymentSucceededDatetime()
        {
            return Convert.ToDateTime(this.getProperty("paymentSucceededDatetime"));
        }

        public void setPaymentSucceededDatetime(DateTime paymentSucceededDatetime)
        {
            this.setProperty("paymentSucceededDatetime", paymentSucceededDatetime);
        }

        public DateTime getPaymentFailedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("paymentFailedDatetime"));
        }

        public void setPaymentFailedDatetime(DateTime paymentFailedDatetime)
        {
            this.setProperty("paymentFailedDatetime", paymentFailedDatetime);
        }

        public string getNarrative()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative(string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public DateTime getPaymentCancelledDatetime()
        {
            return Convert.ToDateTime(this.getProperty("paymentCancelledDatetime"));
        }

        public void setPaymentCancelledDatetime(DateTime paymentCancelledDatetime)
        {
            this.setProperty("paymentCancelledDatetime", paymentCancelledDatetime);
        }


    }
}

