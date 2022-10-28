using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IntegrationsHrFinanceTestRunResult : ModelBase
    {
        protected new string resourceType = ResourceType.INTEGRATIONS_HR_FINANCE_TEST_RUN_RESULT;
        public const string INTEGRATIONS_HR_FINANCE_TEST_RUN = "integrationsHrFinanceTestRun";
        public const string TYPE = "type";
        public const string ACTION = "action";
        public const string EXTERNAL_PERSON_IDENTIFIER = "externalPersonIdentifier";
        public const string EXTERNAL_CONTRACT_IDENTIFIER = "externalContractIdentifier";
        public const string PERSON_NAME = "personName";
        public const string ENTITY_OBJECT_TYPE_ID = "entityObjectTypeId";
        public const string ENTITY_OBJECT_ID = "entityObjectId";
        public const string OLD_DATA = "oldData";
        public const string NEW_DATA = "newData";
        public const string EXTERNAL_ENTITY_IDENTIFIER = "externalEntityIdentifier";
        public const string LABEL = "label";

        public IntegrationsHrFinanceTestRunResult ()
        {
            base.resourceType = this.resourceType;
        }
        
        public IntegrationsHrFinanceTestRunResult (string resourceType = "IntegrationsHrFinanceTestRunResult", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<IntegrationsHrFinanceTestRunResult> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("IntegrationsHrFinanceTestRunResult");
        	RestGateway gateway = (RestGateway) IntegrationsHrFinanceTestRunResult.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<IntegrationsHrFinanceTestRunResult> integrationshrfinancetestrunresultCollection = new ModelCollection<IntegrationsHrFinanceTestRunResult> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    integrationshrfinancetestrunresultCollection.add((IntegrationsHrFinanceTestRunResult) model);
        	}
        
        	return integrationshrfinancetestrunresultCollection;
        }

        public static IntegrationsHrFinanceTestRunResult retrieve (string id)
        {
            RestGateway gateway = (RestGateway) IntegrationsHrFinanceTestRunResult.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (IntegrationsHrFinanceTestRunResult) gateway.retrieve(ResourceType.INTEGRATIONS_HR_FINANCE_TEST_RUN_RESULT, id);
        }

        public IntegrationsHrFinanceTestRun getIntegrationsHrFinanceTestRun ()
        {
            return (IntegrationsHrFinanceTestRun) this.getProperty("integrationsHrFinanceTestRun");
        }

        public void setIntegrationsHrFinanceTestRun (IntegrationsHrFinanceTestRun integrationsHrFinanceTestRun)
        {
            this.setProperty("integrationsHrFinanceTestRun", integrationsHrFinanceTestRun);
        }

        public string getType ()
        {
            return this.getProperty("type").ToString();
        }

        public void setType (string type)
        {
            this.setProperty("type", type);
        }

        public string getAction ()
        {
            return this.getProperty("action").ToString();
        }

        public void setAction (string action)
        {
            this.setProperty("action", action);
        }

        public string getExternalPersonIdentifier ()
        {
            return this.getProperty("externalPersonIdentifier").ToString();
        }

        public void setExternalPersonIdentifier (string externalPersonIdentifier)
        {
            this.setProperty("externalPersonIdentifier", externalPersonIdentifier);
        }

        public string getExternalContractIdentifier ()
        {
            return this.getProperty("externalContractIdentifier").ToString();
        }

        public void setExternalContractIdentifier (string externalContractIdentifier)
        {
            this.setProperty("externalContractIdentifier", externalContractIdentifier);
        }

        public string getPersonName ()
        {
            return this.getProperty("personName").ToString();
        }

        public void setPersonName (string personName)
        {
            this.setProperty("personName", personName);
        }

        public int getEntityObjectTypeId ()
        {
            return Convert.ToInt32(this.getProperty("entityObjectTypeId"));
        }

        public void setEntityObjectTypeId (int entityObjectTypeId)
        {
            this.setProperty("entityObjectTypeId", entityObjectTypeId);
        }

        public int getEntityObjectId ()
        {
            return Convert.ToInt32(this.getProperty("entityObjectId"));
        }

        public void setEntityObjectId (int entityObjectId)
        {
            this.setProperty("entityObjectId", entityObjectId);
        }

        public string getOldData ()
        {
            return this.getProperty("oldData").ToString();
        }

        public void setOldData (string oldData)
        {
            this.setProperty("oldData", oldData);
        }

        public string getNewData ()
        {
            return this.getProperty("newData").ToString();
        }

        public void setNewData (string newData)
        {
            this.setProperty("newData", newData);
        }

        public string getExternalEntityIdentifier ()
        {
            return this.getProperty("externalEntityIdentifier").ToString();
        }

        public void setExternalEntityIdentifier (string externalEntityIdentifier)
        {
            this.setProperty("externalEntityIdentifier", externalEntityIdentifier);
        }

        public string getLabel ()
        {
            return this.getProperty("label").ToString();
        }

        public void setLabel (string label)
        {
            this.setProperty("label", label);
        }


    }
}

