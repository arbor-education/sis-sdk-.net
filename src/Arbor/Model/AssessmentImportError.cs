using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentImportError : ModelBase
    {
        protected new string resourceType = ResourceType.ASSESSMENT_IMPORT_ERROR;
        public const string ERROR_MESSAGE = "errorMessage";

        public AssessmentImportError()
        {
            base.resourceType = this.resourceType;
        }

        public AssessmentImportError(string resourceType = "AssessmentImportError", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AssessmentImportError> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AssessmentImportError");
            RestGateway gateway = (RestGateway)AssessmentImportError.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AssessmentImportError> assessmentimporterrorCollection = new ModelCollection<AssessmentImportError>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                assessmentimporterrorCollection.add((AssessmentImportError)model);
            }

            return assessmentimporterrorCollection;
        }

        public static AssessmentImportError retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AssessmentImportError.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AssessmentImportError)gateway.retrieve(ResourceType.ASSESSMENT_IMPORT_ERROR, id);
        }

        public string getErrorMessage()
        {
            return this.getProperty("errorMessage").ToString();
        }

        public void setErrorMessage(string errorMessage)
        {
            this.setProperty("errorMessage", errorMessage);
        }


    }
}

