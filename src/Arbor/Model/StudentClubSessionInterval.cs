using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentClubSessionInterval : ModelBase
    {
        protected new string resourceType = ResourceType.STUDENT_CLUB_SESSION_INTERVAL;
        public const string STUDENT = "student";
        public const string CLUB_SESSION_INTERVAL = "clubSessionInterval";
        public const string CLUB_SESSION = "clubSession";
        public const string PRICE_EX_VAT = "priceExVat";
        public const string VAT_RATE = "vatRate";
        public const string CUSTOMER_INVOICE = "customerInvoice";
        public const string CUSTOMER_INVOICE_ITEM = "customerInvoiceItem";
        public const string HAS_MEALS = "hasMeals";

        public StudentClubSessionInterval ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentClubSessionInterval (string resourceType = "StudentClubSessionInterval", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentClubSessionInterval> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentClubSessionInterval");
        	RestGateway gateway = (RestGateway) StudentClubSessionInterval.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentClubSessionInterval> studentclubsessionintervalCollection = new ModelCollection<StudentClubSessionInterval> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentclubsessionintervalCollection.add((StudentClubSessionInterval) model);
        	}
        
        	return studentclubsessionintervalCollection;
        }

        public static StudentClubSessionInterval retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentClubSessionInterval.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentClubSessionInterval) gateway.retrieve(ResourceType.STUDENT_CLUB_SESSION_INTERVAL, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public ClubSessionInterval getClubSessionInterval ()
        {
            return (ClubSessionInterval) this.getProperty("clubSessionInterval");
        }

        public void setClubSessionInterval (ClubSessionInterval clubSessionInterval)
        {
            this.setProperty("clubSessionInterval", clubSessionInterval);
        }

        public ClubSession getClubSession ()
        {
            return (ClubSession) this.getProperty("clubSession");
        }

        public void setClubSession (ClubSession clubSession)
        {
            this.setProperty("clubSession", clubSession);
        }

        public string getPriceExVat ()
        {
            return this.getProperty("priceExVat").ToString();
        }

        public void setPriceExVat (string priceExVat)
        {
            this.setProperty("priceExVat", priceExVat);
        }

        public VatRate getVatRate ()
        {
            return (VatRate) this.getProperty("vatRate");
        }

        public void setVatRate (VatRate vatRate)
        {
            this.setProperty("vatRate", vatRate);
        }

        public CustomerInvoice getCustomerInvoice ()
        {
            return (CustomerInvoice) this.getProperty("customerInvoice");
        }

        public void setCustomerInvoice (CustomerInvoice customerInvoice)
        {
            this.setProperty("customerInvoice", customerInvoice);
        }

        public CustomerInvoiceItem getCustomerInvoiceItem ()
        {
            return (CustomerInvoiceItem) this.getProperty("customerInvoiceItem");
        }

        public void setCustomerInvoiceItem (CustomerInvoiceItem customerInvoiceItem)
        {
            this.setProperty("customerInvoiceItem", customerInvoiceItem);
        }

        public bool getHasMeals ()
        {
            return Convert.ToBoolean(this.getProperty("hasMeals"));
        }

        public void setHasMeals (bool hasMeals)
        {
            this.setProperty("hasMeals", hasMeals);
        }


    }
}

