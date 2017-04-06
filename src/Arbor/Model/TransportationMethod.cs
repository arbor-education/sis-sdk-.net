using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TransportationMethod : ModelBase
    {
        protected string resourceType = ResourceType.TRANSPORTATION_METHOD;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string TRANSPORTATION_METHOD_NAME = "transportationMethodName";
        public const string ROUTE_NUMBER = "routeNumber";

        public TransportationMethod ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TransportationMethod (string resourceType = "TransportationMethod", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TransportationMethod> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("TransportationMethod");
        	RestGateway gateway = (RestGateway) TransportationMethod.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TransportationMethod> transportationmethodCollection = new ModelCollection<TransportationMethod> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    transportationmethodCollection.add((TransportationMethod) model);
        	}
        
        	return transportationmethodCollection;
        }

        public static TransportationMethod retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TransportationMethod.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TransportationMethod) gateway.retrieve(ResourceType.TRANSPORTATION_METHOD, id);
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
            return (bool) this.getProperty("active");
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

        public string getTransportationMethodName ()
        {
            return this.getProperty("transportationMethodName").ToString();
        }

        public void setTransportationMethodName (string transportationMethodName)
        {
            this.setProperty("transportationMethodName", transportationMethodName);
        }

        public string getRouteNumber ()
        {
            return this.getProperty("routeNumber").ToString();
        }

        public void setRouteNumber (string routeNumber)
        {
            this.setProperty("routeNumber", routeNumber);
        }


    }
}

