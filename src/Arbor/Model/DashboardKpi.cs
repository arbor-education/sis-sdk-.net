using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DashboardKpi : ModelBase
    {
        protected string resourceType = ResourceType.DASHBOARD_KPI;
        public const string DASHBOARD_SECTION = "dashboardSection";
        public const string KPI = "kpi";
        public const string FALLBACK_KPI = "fallbackKpi";
        public const string COMPARISON_KPI = "comparisonKpi";
        public const string DISPLAY_ORDER = "displayOrder";

        public DashboardKpi ()
        {
            base.resourceType = this.resourceType;
        }
        
        public DashboardKpi (string resourceType = "DashboardKpi", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<DashboardKpi> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("DashboardKpi");
        	RestGateway gateway = (RestGateway) DashboardKpi.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<DashboardKpi> dashboardkpiCollection = new ModelCollection<DashboardKpi> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    dashboardkpiCollection.add((DashboardKpi) model);
        	}
        
        	return dashboardkpiCollection;
        }

        public static DashboardKpi retrieve (string id)
        {
            RestGateway gateway = (RestGateway) DashboardKpi.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (DashboardKpi) gateway.retrieve(ResourceType.DASHBOARD_KPI, id);
        }

        public DashboardSection getDashboardSection ()
        {
            return (DashboardSection) this.getProperty("dashboardSection");
        }

        public void setDashboardSection (DashboardSection dashboardSection)
        {
            this.setProperty("dashboardSection", dashboardSection);
        }

        public Kpi getKpi ()
        {
            return (Kpi) this.getProperty("kpi");
        }

        public void setKpi (Kpi kpi)
        {
            this.setProperty("kpi", kpi);
        }

        public Kpi getFallbackKpi ()
        {
            return (Kpi) this.getProperty("fallbackKpi");
        }

        public void setFallbackKpi (Kpi fallbackKpi)
        {
            this.setProperty("fallbackKpi", fallbackKpi);
        }

        public Kpi getComparisonKpi ()
        {
            return (Kpi) this.getProperty("comparisonKpi");
        }

        public void setComparisonKpi (Kpi comparisonKpi)
        {
            this.setProperty("comparisonKpi", comparisonKpi);
        }

        public int getDisplayOrder ()
        {
            return Convert.ToInt32(this.getProperty("displayOrder"));
        }

        public void setDisplayOrder (int displayOrder)
        {
            this.setProperty("displayOrder", displayOrder);
        }


    }
}

