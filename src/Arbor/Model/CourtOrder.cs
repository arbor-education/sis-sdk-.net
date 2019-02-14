using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CourtOrder : ModelBase
    {
        protected string resourceType = ResourceType.COURT_ORDER;
        public const string SUMMARY = "summary";
        public const string CONTENT = "content";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public CourtOrder ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CourtOrder (string resourceType = "CourtOrder", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CourtOrder> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CourtOrder");
        	RestGateway gateway = (RestGateway) CourtOrder.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CourtOrder> courtorderCollection = new ModelCollection<CourtOrder> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    courtorderCollection.add((CourtOrder) model);
        	}
        
        	return courtorderCollection;
        }

        public static CourtOrder retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CourtOrder.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CourtOrder) gateway.retrieve(ResourceType.COURT_ORDER, id);
        }

        public string getSummary ()
        {
            return this.getProperty("summary").ToString();
        }

        public void setSummary (string summary)
        {
            this.setProperty("summary", summary);
        }

        public string getContent ()
        {
            return this.getProperty("content").ToString();
        }

        public void setContent (string content)
        {
            this.setProperty("content", content);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"))
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

