using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class SupplierPayment : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_SUPPLIER_PAYMENT;
        public const string PAYMENT_RUN = "paymentRun";
        public const string SUPPLIER_DIRECT_DEBIT = "supplierDirectDebit";
        public const string OUTGOING_CARD_TRANSACTION = "outgoingCardTransaction";
        public const string CHEQUE_PAYMENT = "chequePayment";
        public const string AUTHORIZING_STAFF = "authorizingStaff";
        public const string CANCEL_GENERAL_JOURNAL_ENTRY = "cancelGeneralJournalEntry";
        public const string AUTHORIZED_DATETIME = "authorizedDatetime";
        public const string CANCELLED_DATETIME = "cancelledDatetime";
        public const string CANCELLATION_NARRATIVE = "cancellationNarrative";

        public SupplierPayment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SupplierPayment (string resourceType = "SupplierPayment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SupplierPayment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_SupplierPayment");
        	RestGateway gateway = (RestGateway) SupplierPayment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SupplierPayment> supplierpaymentCollection = new ModelCollection<SupplierPayment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    supplierpaymentCollection.add((SupplierPayment) model);
        	}
        
        	return supplierpaymentCollection;
        }

        public static SupplierPayment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SupplierPayment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SupplierPayment) gateway.retrieve(ResourceType.FINANCE_SUPPLIER_PAYMENT, id);
        }

        public ModelBase getPaymentRun ()
        {
            return (ModelBase) this.getProperty("paymentRun");
        }

        public void setPaymentRun (ModelBase paymentRun)
        {
            this.setProperty("paymentRun", paymentRun);
        }

        public ModelBase getSupplierDirectDebit ()
        {
            return (ModelBase) this.getProperty("supplierDirectDebit");
        }

        public void setSupplierDirectDebit (ModelBase supplierDirectDebit)
        {
            this.setProperty("supplierDirectDebit", supplierDirectDebit);
        }

        public ModelBase getOutgoingCardTransaction ()
        {
            return (ModelBase) this.getProperty("outgoingCardTransaction");
        }

        public void setOutgoingCardTransaction (ModelBase outgoingCardTransaction)
        {
            this.setProperty("outgoingCardTransaction", outgoingCardTransaction);
        }

        public ModelBase getChequePayment ()
        {
            return (ModelBase) this.getProperty("chequePayment");
        }

        public void setChequePayment (ModelBase chequePayment)
        {
            this.setProperty("chequePayment", chequePayment);
        }

        public Staff getAuthorizingStaff ()
        {
            return (Staff) this.getProperty("authorizingStaff");
        }

        public void setAuthorizingStaff (Staff authorizingStaff)
        {
            this.setProperty("authorizingStaff", authorizingStaff);
        }

        public ModelBase getCancelGeneralJournalEntry ()
        {
            return (ModelBase) this.getProperty("cancelGeneralJournalEntry");
        }

        public void setCancelGeneralJournalEntry (ModelBase cancelGeneralJournalEntry)
        {
            this.setProperty("cancelGeneralJournalEntry", cancelGeneralJournalEntry);
        }

        public DateTime getAuthorizedDatetime ()
        {
            return (DateTime) this.getProperty("authorizedDatetime");
        }

        public void setAuthorizedDatetime (DateTime authorizedDatetime)
        {
            this.setProperty("authorizedDatetime", authorizedDatetime);
        }

        public DateTime getCancelledDatetime ()
        {
            return (DateTime) this.getProperty("cancelledDatetime");
        }

        public void setCancelledDatetime (DateTime cancelledDatetime)
        {
            this.setProperty("cancelledDatetime", cancelledDatetime);
        }

        public string getCancellationNarrative ()
        {
            return this.getProperty("cancellationNarrative").ToString();
        }

        public void setCancellationNarrative (string cancellationNarrative)
        {
            this.setProperty("cancellationNarrative", cancellationNarrative);
        }


    }
}

