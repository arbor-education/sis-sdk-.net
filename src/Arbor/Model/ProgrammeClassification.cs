using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProgrammeClassification : ModelBase
    {
        protected new string resourceType = ResourceType.PROGRAMME_CLASSIFICATION;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string LABEL = "label";
        public const string IS_MAIN_PROGRAMME = "isMainProgramme";
        public const string EXPORT_VALUE = "exportValue";

        public ProgrammeClassification()
        {
            base.resourceType = this.resourceType;
        }

        public ProgrammeClassification(string resourceType = "ProgrammeClassification", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ProgrammeClassification> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ProgrammeClassification");
            RestGateway gateway = (RestGateway)ProgrammeClassification.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ProgrammeClassification> programmeclassificationCollection = new ModelCollection<ProgrammeClassification>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                programmeclassificationCollection.add((ProgrammeClassification)model);
            }

            return programmeclassificationCollection;
        }

        public static ProgrammeClassification retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ProgrammeClassification.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ProgrammeClassification)gateway.retrieve(ResourceType.PROGRAMME_CLASSIFICATION, id);
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

        public bool getIsMainProgramme()
        {
            return Convert.ToBoolean(this.getProperty("isMainProgramme"));
        }

        public void setIsMainProgramme(bool isMainProgramme)
        {
            this.setProperty("isMainProgramme", isMainProgramme);
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

