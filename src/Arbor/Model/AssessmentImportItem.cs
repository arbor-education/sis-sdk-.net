using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentImportItem : ModelBase
    {
        protected new string resourceType = ResourceType.ASSESSMENT_IMPORT_ITEM;
        public const string ASSESSMENT_IMPORT_COLUMN = "assessmentImportColumn";
        public const string ASSESSMENT_IMPORT_ROW = "assessmentImportRow";
        public const string DATA_VALUE = "dataValue";
        public const string IMPORTED_DATETIME = "importedDatetime";

        public AssessmentImportItem()
        {
            base.resourceType = this.resourceType;
        }

        public AssessmentImportItem(string resourceType = "AssessmentImportItem", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AssessmentImportItem> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AssessmentImportItem");
            RestGateway gateway = (RestGateway)AssessmentImportItem.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AssessmentImportItem> assessmentimportitemCollection = new ModelCollection<AssessmentImportItem>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                assessmentimportitemCollection.add((AssessmentImportItem)model);
            }

            return assessmentimportitemCollection;
        }

        public static AssessmentImportItem retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AssessmentImportItem.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AssessmentImportItem)gateway.retrieve(ResourceType.ASSESSMENT_IMPORT_ITEM, id);
        }

        public AssessmentImportColumn getAssessmentImportColumn()
        {
            return (AssessmentImportColumn)this.getProperty("assessmentImportColumn");
        }

        public void setAssessmentImportColumn(AssessmentImportColumn assessmentImportColumn)
        {
            this.setProperty("assessmentImportColumn", assessmentImportColumn);
        }

        public AssessmentImportRow getAssessmentImportRow()
        {
            return (AssessmentImportRow)this.getProperty("assessmentImportRow");
        }

        public void setAssessmentImportRow(AssessmentImportRow assessmentImportRow)
        {
            this.setProperty("assessmentImportRow", assessmentImportRow);
        }

        public string getDataValue()
        {
            return this.getProperty("dataValue").ToString();
        }

        public void setDataValue(string dataValue)
        {
            this.setProperty("dataValue", dataValue);
        }

        public DateTime getImportedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("importedDatetime"));
        }

        public void setImportedDatetime(DateTime importedDatetime)
        {
            this.setProperty("importedDatetime", importedDatetime);
        }


    }
}

