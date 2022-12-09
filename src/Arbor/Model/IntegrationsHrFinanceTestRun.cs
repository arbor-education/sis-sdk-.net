using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IntegrationsHrFinanceTestRun : ModelBase
    {
        protected new string resourceType = ResourceType.INTEGRATIONS_HR_FINANCE_TEST_RUN;
        public const string INTEGRATIONS_HR_FINANCE_PROVIDER = "integrationsHrFinanceProvider";
        public const string REQUESTED_DATETIME = "requestedDatetime";
        public const string COMPLETED_DATETIME = "completedDatetime";

        public IntegrationsHrFinanceTestRun()
        {
            base.resourceType = this.resourceType;
        }

        public IntegrationsHrFinanceTestRun(string resourceType = "IntegrationsHrFinanceTestRun", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<IntegrationsHrFinanceTestRun> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("IntegrationsHrFinanceTestRun");
            RestGateway gateway = (RestGateway)IntegrationsHrFinanceTestRun.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<IntegrationsHrFinanceTestRun> integrationshrfinancetestrunCollection = new ModelCollection<IntegrationsHrFinanceTestRun>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                integrationshrfinancetestrunCollection.add((IntegrationsHrFinanceTestRun)model);
            }

            return integrationshrfinancetestrunCollection;
        }

        public static IntegrationsHrFinanceTestRun retrieve(string id)
        {
            RestGateway gateway = (RestGateway)IntegrationsHrFinanceTestRun.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (IntegrationsHrFinanceTestRun)gateway.retrieve(ResourceType.INTEGRATIONS_HR_FINANCE_TEST_RUN, id);
        }

        public IntegrationsHrFinanceProvider getIntegrationsHrFinanceProvider()
        {
            return (IntegrationsHrFinanceProvider)this.getProperty("integrationsHrFinanceProvider");
        }

        public void setIntegrationsHrFinanceProvider(IntegrationsHrFinanceProvider integrationsHrFinanceProvider)
        {
            this.setProperty("integrationsHrFinanceProvider", integrationsHrFinanceProvider);
        }

        public DateTime getRequestedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("requestedDatetime"));
        }

        public void setRequestedDatetime(DateTime requestedDatetime)
        {
            this.setProperty("requestedDatetime", requestedDatetime);
        }

        public DateTime getCompletedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("completedDatetime"));
        }

        public void setCompletedDatetime(DateTime completedDatetime)
        {
            this.setProperty("completedDatetime", completedDatetime);
        }


    }
}

