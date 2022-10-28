using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ClubMembership : ModelBase
    {
        protected new string resourceType = ResourceType.CLUB_MEMBERSHIP;
        public const string CLUB = "club";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string CLUB_MEMBERSHIP_PERIOD = "clubMembershipPeriod";
        public const string STUDENT = "student";
        public const string CONSENT_RECEIVED = "consentReceived";
        public const string ACTIVATED_DATETIME = "activatedDatetime";
        public const string CUSTOMER_INVOICE = "customerInvoice";
        public const string CUSTOMER_INVOICE_ITEM = "customerInvoiceItem";
        public const string CANCELLED_DATETIME = "cancelledDatetime";
        public const string DISABLED_DATETIME = "disabledDatetime";

        public ClubMembership ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ClubMembership (string resourceType = "ClubMembership", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ClubMembership> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ClubMembership");
        	RestGateway gateway = (RestGateway) ClubMembership.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ClubMembership> clubmembershipCollection = new ModelCollection<ClubMembership> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    clubmembershipCollection.add((ClubMembership) model);
        	}
        
        	return clubmembershipCollection;
        }

        public static ClubMembership retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ClubMembership.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ClubMembership) gateway.retrieve(ResourceType.CLUB_MEMBERSHIP, id);
        }

        public Club getClub ()
        {
            return (Club) this.getProperty("club");
        }

        public void setClub (Club club)
        {
            this.setProperty("club", club);
        }

        public DateTime getStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public ClubMembershipPeriod getClubMembershipPeriod ()
        {
            return (ClubMembershipPeriod) this.getProperty("clubMembershipPeriod");
        }

        public void setClubMembershipPeriod (ClubMembershipPeriod clubMembershipPeriod)
        {
            this.setProperty("clubMembershipPeriod", clubMembershipPeriod);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public bool getConsentReceived ()
        {
            return Convert.ToBoolean(this.getProperty("consentReceived"));
        }

        public void setConsentReceived (bool consentReceived)
        {
            this.setProperty("consentReceived", consentReceived);
        }

        public DateTime getActivatedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("activatedDatetime"));
        }

        public void setActivatedDatetime (DateTime activatedDatetime)
        {
            this.setProperty("activatedDatetime", activatedDatetime);
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

        public DateTime getCancelledDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("cancelledDatetime"));
        }

        public void setCancelledDatetime (DateTime cancelledDatetime)
        {
            this.setProperty("cancelledDatetime", cancelledDatetime);
        }

        public DateTime getDisabledDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("disabledDatetime"));
        }

        public void setDisabledDatetime (DateTime disabledDatetime)
        {
            this.setProperty("disabledDatetime", disabledDatetime);
        }


    }
}

