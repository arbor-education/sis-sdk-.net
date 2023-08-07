using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DashboardSection : ModelBase
    {
        protected string resourceType = ResourceType.DASHBOARD_SECTION;
        public const string DASHBOARD = "dashboard";
        public const string CODE = "code";
        public const string TITLE = "title";
        public const string ICON = "icon";
        public const string DISPLAY_ORDER = "displayOrder";

        public DashboardSection()
        {
            base.resourceType = this.resourceType;
        }

        public DashboardSection(string resourceType = "DashboardSection", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<DashboardSection> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("DashboardSection");
            RestGateway gateway = (RestGateway)DashboardSection.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<DashboardSection> dashboardsectionCollection = new ModelCollection<DashboardSection>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                dashboardsectionCollection.add((DashboardSection)model);
            }

            return dashboardsectionCollection;
        }

        public static DashboardSection retrieve(string id)
        {
            RestGateway gateway = (RestGateway)DashboardSection.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (DashboardSection)gateway.retrieve(ResourceType.DASHBOARD_SECTION, id);
        }

        public Dashboard getDashboard()
        {
            return (Dashboard)this.getProperty("dashboard");
        }

        public void setDashboard(Dashboard dashboard)
        {
            this.setProperty("dashboard", dashboard);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }

        public string getTitle()
        {
            return this.getProperty("title").ToString();
        }

        public void setTitle(string title)
        {
            this.setProperty("title", title);
        }

        public string getIcon()
        {
            return this.getProperty("icon").ToString();
        }

        public void setIcon(string icon)
        {
            this.setProperty("icon", icon);
        }

        public int getDisplayOrder()
        {
            return Convert.ToInt32(this.getProperty("displayOrder"));
        }

        public void setDisplayOrder(int displayOrder)
        {
            this.setProperty("displayOrder", displayOrder);
        }


    }
}

