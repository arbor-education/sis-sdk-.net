using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Book : ModelBase
    {
        protected string resourceType = ResourceType.BOOK;
        public const string BOOK_TYPE = "bookType";
        public const string PREFIX = "prefix";
        public const string FIRST_NUMBER = "firstNumber";
        public const string LAST_NUMBER = "lastNumber";
        public const string NEXT_NUMBER = "nextNumber";
        public const string OPEN = "open";
        public const string BANK_ACCOUNT = "bankAccount";

        public Book ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Book (string resourceType = "Book", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Book> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Book");
        	RestGateway gateway = (RestGateway) Book.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Book> bookCollection = new ModelCollection<Book> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    bookCollection.add((Book) model);
        	}
        
        	return bookCollection;
        }

        public static Book retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Book.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Book) gateway.retrieve(ResourceType.BOOK, id);
        }

        public string getBookType ()
        {
            return this.getProperty("bookType").ToString();
        }

        public void setBookType (string bookType)
        {
            this.setProperty("bookType", bookType);
        }

        public string getPrefix ()
        {
            return this.getProperty("prefix").ToString();
        }

        public void setPrefix (string prefix)
        {
            this.setProperty("prefix", prefix);
        }

        public int getFirstNumber ()
        {
            return Convert.ToInt32(this.getProperty("firstNumber"));
        }

        public void setFirstNumber (int firstNumber)
        {
            this.setProperty("firstNumber", firstNumber);
        }

        public int getLastNumber ()
        {
            return Convert.ToInt32(this.getProperty("lastNumber"));
        }

        public void setLastNumber (int lastNumber)
        {
            this.setProperty("lastNumber", lastNumber);
        }

        public int getNextNumber ()
        {
            return Convert.ToInt32(this.getProperty("nextNumber"));
        }

        public void setNextNumber (int nextNumber)
        {
            this.setProperty("nextNumber", nextNumber);
        }

        public bool getOpen ()
        {
            return Convert.ToBoolean(this.getProperty("open"))
        }

        public void setOpen (bool open)
        {
            this.setProperty("open", open);
        }

        public BankAccount getBankAccount ()
        {
            return (BankAccount) this.getProperty("bankAccount");
        }

        public void setBankAccount (BankAccount bankAccount)
        {
            this.setProperty("bankAccount", bankAccount);
        }


    }
}

