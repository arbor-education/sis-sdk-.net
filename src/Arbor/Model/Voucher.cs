using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Voucher : ModelBase
    {
        protected new string resourceType = ResourceType.VOUCHER;
        public const string BILL_PAYER = "billPayer";
        public const string PAYMENT_RECEIVED_DATE = "paymentReceivedDate";
        public const string NARRATIVE = "narrative";
        public const string PAYMENT_AMOUNT = "paymentAmount";
        public const string CANCELLED_DATETIME = "cancelledDatetime";

        public Voucher ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Voucher (string resourceType = "Voucher", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Voucher> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Voucher");
        	RestGateway gateway = (RestGateway) Voucher.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Voucher> voucherCollection = new ModelCollection<Voucher> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    voucherCollection.add((Voucher) model);
        	}
        
        	return voucherCollection;
        }

        public static Voucher retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Voucher.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Voucher) gateway.retrieve(ResourceType.VOUCHER, id);
        }

        public BillPayer getBillPayer ()
        {
            return (BillPayer) this.getProperty("billPayer");
        }

        public void setBillPayer (BillPayer billPayer)
        {
            this.setProperty("billPayer", billPayer);
        }

        public DateTime getPaymentReceivedDate ()
        {
            return Convert.ToDateTime(this.getProperty("paymentReceivedDate"));
        }

        public void setPaymentReceivedDate (DateTime paymentReceivedDate)
        {
            this.setProperty("paymentReceivedDate", paymentReceivedDate);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public string getPaymentAmount ()
        {
            return this.getProperty("paymentAmount").ToString();
        }

        public void setPaymentAmount (string paymentAmount)
        {
            this.setProperty("paymentAmount", paymentAmount);
        }

        public DateTime getCancelledDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("cancelledDatetime"));
        }

        public void setCancelledDatetime (DateTime cancelledDatetime)
        {
            this.setProperty("cancelledDatetime", cancelledDatetime);
        }


    }
}

