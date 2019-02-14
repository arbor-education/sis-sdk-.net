using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ApplicationWithdrawalReason : ModelBase
    {
        protected string resourceType = ResourceType.APPLICATION_WITHDRAWAL_REASON;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string APPLICATION_WITHDRAWAL_REASON_NAME = "applicationWithdrawalReasonName";

        public ApplicationWithdrawalReason ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ApplicationWithdrawalReason (string resourceType = "ApplicationWithdrawalReason", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ApplicationWithdrawalReason> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ApplicationWithdrawalReason");
        	RestGateway gateway = (RestGateway) ApplicationWithdrawalReason.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ApplicationWithdrawalReason> applicationwithdrawalreasonCollection = new ModelCollection<ApplicationWithdrawalReason> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    applicationwithdrawalreasonCollection.add((ApplicationWithdrawalReason) model);
        	}
        
        	return applicationwithdrawalreasonCollection;
        }

        public static ApplicationWithdrawalReason retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ApplicationWithdrawalReason.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ApplicationWithdrawalReason) gateway.retrieve(ResourceType.APPLICATION_WITHDRAWAL_REASON, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return Convert.ToBoolean(this.getProperty("active"))
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getApplicationWithdrawalReasonName ()
        {
            return this.getProperty("applicationWithdrawalReasonName").ToString();
        }

        public void setApplicationWithdrawalReasonName (string applicationWithdrawalReasonName)
        {
            this.setProperty("applicationWithdrawalReasonName", applicationWithdrawalReasonName);
        }


    }
}

