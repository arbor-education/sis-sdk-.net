using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SenProvision : ModelBase
    {
        protected string resourceType = ResourceType.SEN_PROVISION;
        public const string SEN_NEED = "senNeed";
        public const string SEN_PROVISION_TYPE = "senProvisionType";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string FREQUENCY = "frequency";
        public const string COST = "cost";
        public const string COMMENTS = "comments";

        public SenProvision ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SenProvision (string resourceType = "SenProvision", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SenProvision> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("SenProvision");
        	RestGateway gateway = (RestGateway) SenProvision.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SenProvision> senprovisionCollection = new ModelCollection<SenProvision> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    senprovisionCollection.add((SenProvision) model);
        	}
        
        	return senprovisionCollection;
        }

        public static SenProvision retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SenProvision.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SenProvision) gateway.retrieve(ResourceType.SEN_PROVISION, id);
        }

        public SenNeed getSenNeed ()
        {
            return (SenNeed) this.getProperty("senNeed");
        }

        public void setSenNeed (SenNeed senNeed)
        {
            this.setProperty("senNeed", senNeed);
        }

        public SenProvisionType getSenProvisionType ()
        {
            return (SenProvisionType) this.getProperty("senProvisionType");
        }

        public void setSenProvisionType (SenProvisionType senProvisionType)
        {
            this.setProperty("senProvisionType", senProvisionType);
        }

        public DateTime getStartDate ()
        {
            return (DateTime) this.getProperty("startDate");
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return (DateTime) this.getProperty("endDate");
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getFrequency ()
        {
            return this.getProperty("frequency").ToString();
        }

        public void setFrequency (string frequency)
        {
            this.setProperty("frequency", frequency);
        }

        public string getCost ()
        {
            return this.getProperty("cost").ToString();
        }

        public void setCost (string cost)
        {
            this.setProperty("cost", cost);
        }

        public string getComments ()
        {
            return this.getProperty("comments").ToString();
        }

        public void setComments (string comments)
        {
            this.setProperty("comments", comments);
        }


    }
}

