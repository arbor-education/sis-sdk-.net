using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UciAssignment : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_UCI_ASSIGNMENT;
        public const string STUDENT = "student";
        public const string UCI = "uci";
        public const string ISSUED_YEAR = "issuedYear";
        public const string ISSUED_CENTER_NUMBER = "issuedCenterNumber";
        public const string ISSUED_AWARDING_ORGANIZATION_IDENTIFIER = "issuedAwardingOrganizationIdentifier";
        public const string ISSUED_SERIAL_NUMBER = "issuedSerialNumber";
        public const string ISSUED_DATETIME = "issuedDatetime";
        public const string CANCELLED_DATETIME = "cancelledDatetime";

        public UciAssignment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UciAssignment (string resourceType = "UciAssignment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UciAssignment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_UciAssignment");
        	RestGateway gateway = (RestGateway) UciAssignment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UciAssignment> uciassignmentCollection = new ModelCollection<UciAssignment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    uciassignmentCollection.add((UciAssignment) model);
        	}
        
        	return uciassignmentCollection;
        }

        public static UciAssignment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UciAssignment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UciAssignment) gateway.retrieve(ResourceType.UK_DFE_UCI_ASSIGNMENT, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public string getUci ()
        {
            return this.getProperty("uci").ToString();
        }

        public void setUci (string uci)
        {
            this.setProperty("uci", uci);
        }

        public int getIssuedYear ()
        {
            return Convert.ToInt32(this.getProperty("issuedYear"));
        }

        public void setIssuedYear (int issuedYear)
        {
            this.setProperty("issuedYear", issuedYear);
        }

        public int getIssuedCenterNumber ()
        {
            return Convert.ToInt32(this.getProperty("issuedCenterNumber"));
        }

        public void setIssuedCenterNumber (int issuedCenterNumber)
        {
            this.setProperty("issuedCenterNumber", issuedCenterNumber);
        }

        public int getIssuedAwardingOrganizationIdentifier ()
        {
            return Convert.ToInt32(this.getProperty("issuedAwardingOrganizationIdentifier"));
        }

        public void setIssuedAwardingOrganizationIdentifier (int issuedAwardingOrganizationIdentifier)
        {
            this.setProperty("issuedAwardingOrganizationIdentifier", issuedAwardingOrganizationIdentifier);
        }

        public int getIssuedSerialNumber ()
        {
            return Convert.ToInt32(this.getProperty("issuedSerialNumber"));
        }

        public void setIssuedSerialNumber (int issuedSerialNumber)
        {
            this.setProperty("issuedSerialNumber", issuedSerialNumber);
        }

        public DateTime getIssuedDatetime ()
        {
            return (DateTime) this.getProperty("issuedDatetime");
        }

        public void setIssuedDatetime (DateTime issuedDatetime)
        {
            this.setProperty("issuedDatetime", issuedDatetime);
        }

        public DateTime getCancelledDatetime ()
        {
            return (DateTime) this.getProperty("cancelledDatetime");
        }

        public void setCancelledDatetime (DateTime cancelledDatetime)
        {
            this.setProperty("cancelledDatetime", cancelledDatetime);
        }


    }
}

