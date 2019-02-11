using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProgrammeWithdrawalReason : ModelBase
    {
        protected string resourceType = ResourceType.PROGRAMME_WITHDRAWAL_REASON;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";

        public ProgrammeWithdrawalReason ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ProgrammeWithdrawalReason (string resourceType = "ProgrammeWithdrawalReason", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ProgrammeWithdrawalReason> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ProgrammeWithdrawalReason");
        	RestGateway gateway = (RestGateway) ProgrammeWithdrawalReason.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ProgrammeWithdrawalReason> programmewithdrawalreasonCollection = new ModelCollection<ProgrammeWithdrawalReason> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    programmewithdrawalreasonCollection.add((ProgrammeWithdrawalReason) model);
        	}
        
        	return programmewithdrawalreasonCollection;
        }

        public static ProgrammeWithdrawalReason retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ProgrammeWithdrawalReason.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ProgrammeWithdrawalReason) gateway.retrieve(ResourceType.PROGRAMME_WITHDRAWAL_REASON, id);
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
            return Convert.ToBoolean( this.getProperty("active"));
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

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }


    }
}

