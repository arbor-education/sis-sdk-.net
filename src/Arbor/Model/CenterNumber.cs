using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CenterNumber : ModelBase
    {
        protected string resourceType = ResourceType.CENTER_NUMBER;
        public const string ISSUED_CENTER_NUMBER = "issuedCenterNumber";
        public const string ISSUING_ORGANIZATION = "issuingOrganization";
        public const string ISSUE_DATE = "issueDate";

        public CenterNumber ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CenterNumber (string resourceType = "CenterNumber", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CenterNumber> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CenterNumber");
        	RestGateway gateway = (RestGateway) CenterNumber.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CenterNumber> centernumberCollection = new ModelCollection<CenterNumber> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    centernumberCollection.add((CenterNumber) model);
        	}
        
        	return centernumberCollection;
        }

        public static CenterNumber retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CenterNumber.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CenterNumber) gateway.retrieve(ResourceType.CENTER_NUMBER, id);
        }

        public string getIssuedCenterNumber ()
        {
            return this.getProperty("issuedCenterNumber").ToString();
        }

        public void setIssuedCenterNumber (string issuedCenterNumber)
        {
            this.setProperty("issuedCenterNumber", issuedCenterNumber);
        }

        public Company getIssuingOrganization ()
        {
            return (Company) this.getProperty("issuingOrganization");
        }

        public void setIssuingOrganization (Company issuingOrganization)
        {
            this.setProperty("issuingOrganization", issuingOrganization);
        }

        public DateTime getIssueDate ()
        {
            return (DateTime) this.getProperty("issueDate");
        }

        public void setIssueDate (DateTime issueDate)
        {
            this.setProperty("issueDate", issueDate);
        }


    }
}

