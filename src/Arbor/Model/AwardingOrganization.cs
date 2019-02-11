using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AwardingOrganization : ModelBase
    {
        protected string resourceType = ResourceType.AWARDING_ORGANIZATION;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";
        public const string SHORT_NAME = "shortName";
        public const string ISSUED_CENTER_NUMBER = "issuedCenterNumber";
        public const string CENTER_NUMBER_ISSUED_DATE = "centerNumberIssuedDate";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public AwardingOrganization ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AwardingOrganization (string resourceType = "AwardingOrganization", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AwardingOrganization> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AwardingOrganization");
        	RestGateway gateway = (RestGateway) AwardingOrganization.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AwardingOrganization> awardingorganizationCollection = new ModelCollection<AwardingOrganization> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    awardingorganizationCollection.add((AwardingOrganization) model);
        	}
        
        	return awardingorganizationCollection;
        }

        public static AwardingOrganization retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AwardingOrganization.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AwardingOrganization) gateway.retrieve(ResourceType.AWARDING_ORGANIZATION, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return Convert.ToBoolean( this.getProperty("active"));
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public string getIssuedCenterNumber ()
        {
            return this.getProperty("issuedCenterNumber").ToString();
        }

        public void setIssuedCenterNumber (string issuedCenterNumber)
        {
            this.setProperty("issuedCenterNumber", issuedCenterNumber);
        }

        public DateTime getCenterNumberIssuedDate (){
            return Convert.ToDateTime(this.getProperty("centerNumberIssuedDate"));
        }

        public void setCenterNumberIssuedDate (DateTime centerNumberIssuedDate)
        {
            this.setProperty("centerNumberIssuedDate", centerNumberIssuedDate);
        }

        public DateTime getEffectiveDate (){
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate (){
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

