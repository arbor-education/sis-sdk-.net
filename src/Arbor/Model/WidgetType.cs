using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class WidgetType : ModelBase
    {
        protected string resourceType = ResourceType.WIDGET_TYPE;
        public const string WIDGET_TYPE_IDENTIFIER = "widgetTypeIdentifier";
        public const string WIDGET_TYPE_NAME = "widgetTypeName";

        public WidgetType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public WidgetType (string resourceType = "WidgetType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<WidgetType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("WidgetType");
        	RestGateway gateway = (RestGateway) WidgetType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<WidgetType> widgettypeCollection = new ModelCollection<WidgetType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    widgettypeCollection.add((WidgetType) model);
        	}
        
        	return widgettypeCollection;
        }

        public static WidgetType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) WidgetType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (WidgetType) gateway.retrieve(ResourceType.WIDGET_TYPE, id);
        }

        public string getWidgetTypeIdentifier ()
        {
            return this.getProperty("widgetTypeIdentifier").ToString();
        }

        public void setWidgetTypeIdentifier (string widgetTypeIdentifier)
        {
            this.setProperty("widgetTypeIdentifier", widgetTypeIdentifier);
        }

        public string getWidgetTypeName ()
        {
            return this.getProperty("widgetTypeName").ToString();
        }

        public void setWidgetTypeName (string widgetTypeName)
        {
            this.setProperty("widgetTypeName", widgetTypeName);
        }


    }
}

