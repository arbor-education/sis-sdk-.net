using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ChequeBook : ModelBase
    {
        protected string resourceType = ResourceType.CHEQUE_BOOK;
        public const string BANK_ACCOUNT = "bankAccount";
        public const string CHEQUE_NUMBER_LENGTH = "chequeNumberLength";
        public const string CHEQUE_NUMBER_START = "chequeNumberStart";
        public const string CHEQUE_NUMBER_END = "chequeNumberEnd";
        public const string NEXT_CHEQUE_NUMBER = "nextChequeNumber";

        public ChequeBook()
        {
            base.resourceType = this.resourceType;
        }

        public ChequeBook(string resourceType = "ChequeBook", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ChequeBook> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ChequeBook");
            RestGateway gateway = (RestGateway)ChequeBook.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ChequeBook> chequebookCollection = new ModelCollection<ChequeBook>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                chequebookCollection.add((ChequeBook)model);
            }

            return chequebookCollection;
        }

        public static ChequeBook retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ChequeBook.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ChequeBook)gateway.retrieve(ResourceType.CHEQUE_BOOK, id);
        }

        public BankAccount getBankAccount()
        {
            return (BankAccount)this.getProperty("bankAccount");
        }

        public void setBankAccount(BankAccount bankAccount)
        {
            this.setProperty("bankAccount", bankAccount);
        }

        public int getChequeNumberLength()
        {
            return Convert.ToInt32(this.getProperty("chequeNumberLength"));
        }

        public void setChequeNumberLength(int chequeNumberLength)
        {
            this.setProperty("chequeNumberLength", chequeNumberLength);
        }

        public int getChequeNumberStart()
        {
            return Convert.ToInt32(this.getProperty("chequeNumberStart"));
        }

        public void setChequeNumberStart(int chequeNumberStart)
        {
            this.setProperty("chequeNumberStart", chequeNumberStart);
        }

        public int getChequeNumberEnd()
        {
            return Convert.ToInt32(this.getProperty("chequeNumberEnd"));
        }

        public void setChequeNumberEnd(int chequeNumberEnd)
        {
            this.setProperty("chequeNumberEnd", chequeNumberEnd);
        }

        public int getNextChequeNumber()
        {
            return Convert.ToInt32(this.getProperty("nextChequeNumber"));
        }

        public void setNextChequeNumber(int nextChequeNumber)
        {
            this.setProperty("nextChequeNumber", nextChequeNumber);
        }


    }
}

