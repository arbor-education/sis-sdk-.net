using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class GcseMathsFundingExemptionType : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_GCSE_MATHS_FUNDING_EXEMPTION_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string LABEL = "label";
        public const string EXPORT_VALUE = "exportValue";

        public GcseMathsFundingExemptionType()
        {
            base.resourceType = this.resourceType;
        }

        public GcseMathsFundingExemptionType(string resourceType = "GcseMathsFundingExemptionType", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<GcseMathsFundingExemptionType> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_GcseMathsFundingExemptionType");
            RestGateway gateway = (RestGateway)GcseMathsFundingExemptionType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<GcseMathsFundingExemptionType> gcsemathsfundingexemptiontypeCollection = new ModelCollection<GcseMathsFundingExemptionType>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                gcsemathsfundingexemptiontypeCollection.add((GcseMathsFundingExemptionType)model);
            }

            return gcsemathsfundingexemptiontypeCollection;
        }

        public static GcseMathsFundingExemptionType retrieve(string id)
        {
            RestGateway gateway = (RestGateway)GcseMathsFundingExemptionType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (GcseMathsFundingExemptionType)gateway.retrieve(ResourceType.UK_DFE_GCSE_MATHS_FUNDING_EXEMPTION_TYPE, id);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive(bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder(int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getLabel()
        {
            return this.getProperty("label").ToString();
        }

        public void setLabel(string label)
        {
            this.setProperty("label", label);
        }

        public string getExportValue()
        {
            return this.getProperty("exportValue").ToString();
        }

        public void setExportValue(string exportValue)
        {
            this.setProperty("exportValue", exportValue);
        }


    }
}

