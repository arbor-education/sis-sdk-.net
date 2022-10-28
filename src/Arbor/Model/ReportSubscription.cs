using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ReportSubscription : ModelBase
    {
        protected new string resourceType = ResourceType.REPORT_SUBSCRIPTION;
        public const string REPORT_IDENTIFIER = "reportIdentifier";
        public const string SUBSCRIBER = "subscriber";

        public ReportSubscription ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ReportSubscription (string resourceType = "ReportSubscription", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ReportSubscription> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ReportSubscription");
        	RestGateway gateway = (RestGateway) ReportSubscription.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ReportSubscription> reportsubscriptionCollection = new ModelCollection<ReportSubscription> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    reportsubscriptionCollection.add((ReportSubscription) model);
        	}
        
        	return reportsubscriptionCollection;
        }

        public static ReportSubscription retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ReportSubscription.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ReportSubscription) gateway.retrieve(ResourceType.REPORT_SUBSCRIPTION, id);
        }

        public string getReportIdentifier ()
        {
            return this.getProperty("reportIdentifier").ToString();
        }

        public void setReportIdentifier (string reportIdentifier)
        {
            this.setProperty("reportIdentifier", reportIdentifier);
        }

        public Staff getSubscriber ()
        {
            return (Staff) this.getProperty("subscriber");
        }

        public void setSubscriber (Staff subscriber)
        {
            this.setProperty("subscriber", subscriber);
        }


    }
}

