using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomerCreditNote : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOMER_CREDIT_NOTE;
        public const string CUSTOMER_ACCOUNT = "customerAccount";
        public const string BILL_PAYER = "billPayer";
        public const string CREDIT_NOTE_DATE = "creditNoteDate";
        public const string TOTAL_AMOUNT_CREDITED = "totalAmountCredited";
        public const string CREDIT_NOTE_NUMBER = "creditNoteNumber";
        public const string NARRATIVE = "narrative";

        public CustomerCreditNote ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomerCreditNote (string resourceType = "CustomerCreditNote", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomerCreditNote> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CustomerCreditNote");
        	RestGateway gateway = (RestGateway) CustomerCreditNote.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomerCreditNote> customercreditnoteCollection = new ModelCollection<CustomerCreditNote> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customercreditnoteCollection.add((CustomerCreditNote) model);
        	}
        
        	return customercreditnoteCollection;
        }

        public static CustomerCreditNote retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomerCreditNote.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomerCreditNote) gateway.retrieve(ResourceType.CUSTOMER_CREDIT_NOTE, id);
        }

        public CustomerAccount getCustomerAccount ()
        {
            return (CustomerAccount) this.getProperty("customerAccount");
        }

        public void setCustomerAccount (CustomerAccount customerAccount)
        {
            this.setProperty("customerAccount", customerAccount);
        }

        public BillPayer getBillPayer ()
        {
            return (BillPayer) this.getProperty("billPayer");
        }

        public void setBillPayer (BillPayer billPayer)
        {
            this.setProperty("billPayer", billPayer);
        }

        public DateTime getCreditNoteDate (){
            return Convert.ToDateTime(this.getProperty("creditNoteDate"));
        }

        public void setCreditNoteDate (DateTime creditNoteDate)
        {
            this.setProperty("creditNoteDate", creditNoteDate);
        }

        public string getTotalAmountCredited ()
        {
            return this.getProperty("totalAmountCredited").ToString();
        }

        public void setTotalAmountCredited (string totalAmountCredited)
        {
            this.setProperty("totalAmountCredited", totalAmountCredited);
        }

        public string getCreditNoteNumber ()
        {
            return this.getProperty("creditNoteNumber").ToString();
        }

        public void setCreditNoteNumber (string creditNoteNumber)
        {
            this.setProperty("creditNoteNumber", creditNoteNumber);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }


    }
}

