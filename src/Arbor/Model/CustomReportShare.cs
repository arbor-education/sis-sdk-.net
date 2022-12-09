using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomReportShare : ModelBase
    {
        protected new string resourceType = ResourceType.CUSTOM_REPORT_SHARE;
        public const string CUSTOM_REPORT = "customReport";
        public const string SHARED_WITH = "sharedWith";
        public const string PERMISSION_LEVEL = "permissionLevel";

        public CustomReportShare()
        {
            base.resourceType = this.resourceType;
        }

        public CustomReportShare(string resourceType = "CustomReportShare", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CustomReportShare> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CustomReportShare");
            RestGateway gateway = (RestGateway)CustomReportShare.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CustomReportShare> customreportshareCollection = new ModelCollection<CustomReportShare>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                customreportshareCollection.add((CustomReportShare)model);
            }

            return customreportshareCollection;
        }

        public static CustomReportShare retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CustomReportShare.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CustomReportShare)gateway.retrieve(ResourceType.CUSTOM_REPORT_SHARE, id);
        }

        public CustomReport getCustomReport()
        {
            return (CustomReport)this.getProperty("customReport");
        }

        public void setCustomReport(CustomReport customReport)
        {
            this.setProperty("customReport", customReport);
        }

        public ModelBase getSharedWith()
        {
            return (ModelBase)this.getProperty("sharedWith");
        }

        public void setSharedWith(ModelBase sharedWith)
        {
            this.setProperty("sharedWith", sharedWith);
        }

        public string getPermissionLevel()
        {
            return this.getProperty("permissionLevel").ToString();
        }

        public void setPermissionLevel(string permissionLevel)
        {
            this.setProperty("permissionLevel", permissionLevel);
        }


    }
}

