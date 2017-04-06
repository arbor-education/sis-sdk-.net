using System;
using System.Collections;
using Arbor.Resource.Finance;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.Finance
{
    public class BankStatementLine : ModelBase
    {
        protected string resourceType = ResourceType.FINANCE_BANK_STATEMENT_LINE;
        public const string BANK_STATEMENT = "bankStatement";
        public const string ISSUED_CHEQUE = "issuedCheque";
        public const string OUTGOING_CARD_TRANSACTION = "outgoingCardTransaction";
        public const string OUTGOING_BANK_TRANSACTION = "outgoingBankTransaction";
        public const string SUPPLIER_DIRECT_DEBIT_PAYMENT = "supplierDirectDebitPayment";
        public const string TRANSACTION_TYPE = "transactionType";
        public const string LINE_ENTRY_DATE = "lineEntryDate";
        public const string LINE_CREDIT_AMOUNT = "lineCreditAmount";
        public const string LINE_DEBIT_AMOUNT = "lineDebitAmount";
        public const string BALANCE = "balance";
        public const string PAYMENT_REFERENCE = "paymentReference";
        public const string NARRATIVE = "narrative";
        public const string LINE_NUMBER = "lineNumber";
        public const string MATCHING_SORT_CODE = "matchingSortCode";
        public const string MATCHING_SWIFT_CODE = "matchingSwiftCode";
        public const string MATCHING_IBAN = "matchingIban";
        public const string RECONCILED_DATETIME = "reconciledDatetime";
        public const string MATCHING_ACCOUNT_NUMBER = "matchingAccountNumber";

        public BankStatementLine ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BankStatementLine (string resourceType = "BankStatementLine", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BankStatementLine> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Finance_BankStatementLine");
        	RestGateway gateway = (RestGateway) BankStatementLine.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BankStatementLine> bankstatementlineCollection = new ModelCollection<BankStatementLine> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    bankstatementlineCollection.add((BankStatementLine) model);
        	}
        
        	return bankstatementlineCollection;
        }

        public static BankStatementLine retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BankStatementLine.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BankStatementLine) gateway.retrieve(ResourceType.FINANCE_BANK_STATEMENT_LINE, id);
        }

        public ModelBase getBankStatement ()
        {
            return (ModelBase) this.getProperty("bankStatement");
        }

        public void setBankStatement (ModelBase bankStatement)
        {
            this.setProperty("bankStatement", bankStatement);
        }

        public ModelBase getIssuedCheque ()
        {
            return (ModelBase) this.getProperty("issuedCheque");
        }

        public void setIssuedCheque (ModelBase issuedCheque)
        {
            this.setProperty("issuedCheque", issuedCheque);
        }

        public ModelBase getOutgoingCardTransaction ()
        {
            return (ModelBase) this.getProperty("outgoingCardTransaction");
        }

        public void setOutgoingCardTransaction (ModelBase outgoingCardTransaction)
        {
            this.setProperty("outgoingCardTransaction", outgoingCardTransaction);
        }

        public ModelBase getOutgoingBankTransaction ()
        {
            return (ModelBase) this.getProperty("outgoingBankTransaction");
        }

        public void setOutgoingBankTransaction (ModelBase outgoingBankTransaction)
        {
            this.setProperty("outgoingBankTransaction", outgoingBankTransaction);
        }

        public ModelBase getSupplierDirectDebitPayment ()
        {
            return (ModelBase) this.getProperty("supplierDirectDebitPayment");
        }

        public void setSupplierDirectDebitPayment (ModelBase supplierDirectDebitPayment)
        {
            this.setProperty("supplierDirectDebitPayment", supplierDirectDebitPayment);
        }

        public string getTransactionType ()
        {
            return this.getProperty("transactionType").ToString();
        }

        public void setTransactionType (string transactionType)
        {
            this.setProperty("transactionType", transactionType);
        }

        public DateTime getLineEntryDate ()
        {
            return (DateTime) this.getProperty("lineEntryDate");
        }

        public void setLineEntryDate (DateTime lineEntryDate)
        {
            this.setProperty("lineEntryDate", lineEntryDate);
        }

        public string getLineCreditAmount ()
        {
            return this.getProperty("lineCreditAmount").ToString();
        }

        public void setLineCreditAmount (string lineCreditAmount)
        {
            this.setProperty("lineCreditAmount", lineCreditAmount);
        }

        public string getLineDebitAmount ()
        {
            return this.getProperty("lineDebitAmount").ToString();
        }

        public void setLineDebitAmount (string lineDebitAmount)
        {
            this.setProperty("lineDebitAmount", lineDebitAmount);
        }

        public string getBalance ()
        {
            return this.getProperty("balance").ToString();
        }

        public void setBalance (string balance)
        {
            this.setProperty("balance", balance);
        }

        public string getPaymentReference ()
        {
            return this.getProperty("paymentReference").ToString();
        }

        public void setPaymentReference (string paymentReference)
        {
            this.setProperty("paymentReference", paymentReference);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public int getLineNumber ()
        {
            return Convert.ToInt32(this.getProperty("lineNumber"));
        }

        public void setLineNumber (int lineNumber)
        {
            this.setProperty("lineNumber", lineNumber);
        }

        public string getMatchingSortCode ()
        {
            return this.getProperty("matchingSortCode").ToString();
        }

        public void setMatchingSortCode (string matchingSortCode)
        {
            this.setProperty("matchingSortCode", matchingSortCode);
        }

        public string getMatchingSwiftCode ()
        {
            return this.getProperty("matchingSwiftCode").ToString();
        }

        public void setMatchingSwiftCode (string matchingSwiftCode)
        {
            this.setProperty("matchingSwiftCode", matchingSwiftCode);
        }

        public string getMatchingIban ()
        {
            return this.getProperty("matchingIban").ToString();
        }

        public void setMatchingIban (string matchingIban)
        {
            this.setProperty("matchingIban", matchingIban);
        }

        public DateTime getReconciledDatetime ()
        {
            return (DateTime) this.getProperty("reconciledDatetime");
        }

        public void setReconciledDatetime (DateTime reconciledDatetime)
        {
            this.setProperty("reconciledDatetime", reconciledDatetime);
        }

        public int getMatchingAccountNumber ()
        {
            return Convert.ToInt32(this.getProperty("matchingAccountNumber"));
        }

        public void setMatchingAccountNumber (int matchingAccountNumber)
        {
            this.setProperty("matchingAccountNumber", matchingAccountNumber);
        }


    }
}

