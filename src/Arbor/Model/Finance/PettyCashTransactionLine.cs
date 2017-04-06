using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class PettyCashTransactionLine : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_PETTY_CASH_TRANSACTION_LINE;
        public const string PETTY_CASH_TRANSACTION = "pettyCashTransaction";
        public const string DESTINATION_LEDGER = "destinationLedger";
        public const string COST_CENTER = "costCenter";
        public const string AMOUNT_EX_VAT = "amountExVat";
        public const string VAT_AMOUNT = "vatAmount";
        public const string AMOUNT_ATTRIBUTED_TO_COST_CENTER = "amountAttributedToCostCenter";
        public const string NARRATIVE = "narrative";
        public const string TRANSACTION_DATETIME = "transactionDatetime";

        public PettyCashTransactionLine ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PettyCashTransactionLine (string resourceType = "PettyCashTransactionLine", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PettyCashTransactionLine> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_PettyCashTransactionLine");
        	RestGateway gateway = (RestGateway) PettyCashTransactionLine.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PettyCashTransactionLine> pettycashtransactionlineCollection = new ModelCollection<PettyCashTransactionLine> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    pettycashtransactionlineCollection.add((PettyCashTransactionLine) model);
        	}
        
        	return pettycashtransactionlineCollection;
        }

        public static PettyCashTransactionLine retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PettyCashTransactionLine.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PettyCashTransactionLine) gateway.retrieve(ResourceType.FINANCE_PETTY_CASH_TRANSACTION_LINE, id);
        }

        public ModelBase getPettyCashTransaction ()
        {
            return (ModelBase) this.getProperty("pettyCashTransaction");
        }

        public void setPettyCashTransaction (ModelBase pettyCashTransaction)
        {
            this.setProperty("pettyCashTransaction", pettyCashTransaction);
        }

        public ModelBase getDestinationLedger ()
        {
            return (ModelBase) this.getProperty("destinationLedger");
        }

        public void setDestinationLedger (ModelBase destinationLedger)
        {
            this.setProperty("destinationLedger", destinationLedger);
        }

        public ModelBase getCostCenter ()
        {
            return (ModelBase) this.getProperty("costCenter");
        }

        public void setCostCenter (ModelBase costCenter)
        {
            this.setProperty("costCenter", costCenter);
        }

        public string getAmountExVat ()
        {
            return this.getProperty("amountExVat").ToString();
        }

        public void setAmountExVat (string amountExVat)
        {
            this.setProperty("amountExVat", amountExVat);
        }

        public string getVatAmount ()
        {
            return this.getProperty("vatAmount").ToString();
        }

        public void setVatAmount (string vatAmount)
        {
            this.setProperty("vatAmount", vatAmount);
        }

        public string getAmountAttributedToCostCenter ()
        {
            return this.getProperty("amountAttributedToCostCenter").ToString();
        }

        public void setAmountAttributedToCostCenter (string amountAttributedToCostCenter)
        {
            this.setProperty("amountAttributedToCostCenter", amountAttributedToCostCenter);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public DateTime getTransactionDatetime ()
        {
            return (DateTime) this.getProperty("transactionDatetime");
        }

        public void setTransactionDatetime (DateTime transactionDatetime)
        {
            this.setProperty("transactionDatetime", transactionDatetime);
        }


    }
}

