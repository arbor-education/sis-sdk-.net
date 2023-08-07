using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Widget : ModelBase
    {
        protected string resourceType = ResourceType.WIDGET;
        public const string ZONE_IDENTIFIER = "zoneIdentifier";
        public const string OBJECT = "object";
        public const string WIDGET_TYPE = "widgetType";
        public const string SETTINGS = "settings";
        public const string POSITION_COLUMN = "positionColumn";
        public const string POSITION_ROW = "positionRow";

        public Widget()
        {
            base.resourceType = this.resourceType;
        }

        public Widget(string resourceType = "Widget", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Widget> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Widget");
            RestGateway gateway = (RestGateway)Widget.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Widget> widgetCollection = new ModelCollection<Widget>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                widgetCollection.add((Widget)model);
            }

            return widgetCollection;
        }

        public static Widget retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Widget.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Widget)gateway.retrieve(ResourceType.WIDGET, id);
        }

        public string getZoneIdentifier()
        {
            return this.getProperty("zoneIdentifier").ToString();
        }

        public void setZoneIdentifier(string zoneIdentifier)
        {
            this.setProperty("zoneIdentifier", zoneIdentifier);
        }

        public ModelBase getObject()
        {
            return (ModelBase)this.getProperty("object");
        }

        public void setObject(ModelBase _object)
        {
            this.setProperty("object", _object);
        }

        public WidgetType getWidgetType()
        {
            return (WidgetType)this.getProperty("widgetType");
        }

        public void setWidgetType(WidgetType widgetType)
        {
            this.setProperty("widgetType", widgetType);
        }

        public string getSettings()
        {
            return this.getProperty("settings").ToString();
        }

        public void setSettings(string settings)
        {
            this.setProperty("settings", settings);
        }

        public int getPositionColumn()
        {
            return Convert.ToInt32(this.getProperty("positionColumn"));
        }

        public void setPositionColumn(int positionColumn)
        {
            this.setProperty("positionColumn", positionColumn);
        }

        public int getPositionRow()
        {
            return Convert.ToInt32(this.getProperty("positionRow"));
        }

        public void setPositionRow(int positionRow)
        {
            this.setProperty("positionRow", positionRow);
        }


    }
}

