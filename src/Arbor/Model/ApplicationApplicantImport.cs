using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ApplicationApplicantImport : ModelBase
    {
        protected new string resourceType = ResourceType.APPLICATION_APPLICANT_IMPORT;
        public const string APPLICATION = "application";
        public const string ROW_INDEX = "rowIndex";
        public const string ERRORS = "errors";
        public const string REQUIRED_ERRORS = "requiredErrors";

        public ApplicationApplicantImport()
        {
            base.resourceType = this.resourceType;
        }

        public ApplicationApplicantImport(string resourceType = "ApplicationApplicantImport", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ApplicationApplicantImport> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ApplicationApplicantImport");
            RestGateway gateway = (RestGateway)ApplicationApplicantImport.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ApplicationApplicantImport> applicationapplicantimportCollection = new ModelCollection<ApplicationApplicantImport>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                applicationapplicantimportCollection.add((ApplicationApplicantImport)model);
            }

            return applicationapplicantimportCollection;
        }

        public static ApplicationApplicantImport retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ApplicationApplicantImport.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ApplicationApplicantImport)gateway.retrieve(ResourceType.APPLICATION_APPLICANT_IMPORT, id);
        }

        public Application getApplication()
        {
            return (Application)this.getProperty("application");
        }

        public void setApplication(Application application)
        {
            this.setProperty("application", application);
        }

        public int getRowIndex()
        {
            return Convert.ToInt32(this.getProperty("rowIndex"));
        }

        public void setRowIndex(int rowIndex)
        {
            this.setProperty("rowIndex", rowIndex);
        }

        public string getErrors()
        {
            return this.getProperty("errors").ToString();
        }

        public void setErrors(string errors)
        {
            this.setProperty("errors", errors);
        }

        public string getRequiredErrors()
        {
            return this.getProperty("requiredErrors").ToString();
        }

        public void setRequiredErrors(string requiredErrors)
        {
            this.setProperty("requiredErrors", requiredErrors);
        }


    }
}

