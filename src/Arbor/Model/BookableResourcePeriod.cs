using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BookableResourcePeriod : ModelBase
    {
        protected string resourceType = ResourceType.BOOKABLE_RESOURCE_PERIOD;
        public const string RESOURCE = "resource";
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";

        public BookableResourcePeriod ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BookableResourcePeriod (string resourceType = "BookableResourcePeriod", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BookableResourcePeriod> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BookableResourcePeriod");
        	RestGateway gateway = (RestGateway) BookableResourcePeriod.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BookableResourcePeriod> bookableresourceperiodCollection = new ModelCollection<BookableResourcePeriod> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    bookableresourceperiodCollection.add((BookableResourcePeriod) model);
        	}
        
        	return bookableresourceperiodCollection;
        }

        public static BookableResourcePeriod retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BookableResourcePeriod.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BookableResourcePeriod) gateway.retrieve(ResourceType.BOOKABLE_RESOURCE_PERIOD, id);
        }

        public ModelBase getResource ()
        {
            return (ModelBase) this.getProperty("resource");
        }

        public void setResource (ModelBase resource)
        {
            this.setProperty("resource", resource);
        }

        public DateTime getStartDatetime (){
            return Convert.ToDateTime(this.getProperty("startDatetime"));
        }

        public void setStartDatetime (DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime (){
            return Convert.ToDateTime(this.getProperty("endDatetime"));
        }

        public void setEndDatetime (DateTime endDatetime)
        {
            this.setProperty("endDatetime", endDatetime);
        }


    }
}

