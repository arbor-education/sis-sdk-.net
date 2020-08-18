using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_SenNeedType : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SEN_NEED_TYPE;
        public const string D00237 = "d00237";
        public const string EXPORT_CODE = "exportCode";

        public UkDfe_SenNeedType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_SenNeedType (string resourceType = "UkDfe_SenNeedType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_SenNeedType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_SenNeedType");
        	RestGateway gateway = (RestGateway) UkDfe_SenNeedType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_SenNeedType> ukdfe_senneedtypeCollection = new ModelCollection<UkDfe_SenNeedType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_senneedtypeCollection.add((UkDfe_SenNeedType) model);
        	}
        
        	return ukdfe_senneedtypeCollection;
        }

        public static UkDfe_SenNeedType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_SenNeedType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_SenNeedType) gateway.retrieve(ResourceType.UK_DFE_SEN_NEED_TYPE, id);
        }

        public string getD00237 ()
        {
            return this.getProperty("d00237").ToString();
        }

        public void setD00237 (string d00237)
        {
            this.setProperty("d00237", d00237);
        }

        public string getExportCode ()
        {
            return this.getProperty("exportCode").ToString();
        }

        public void setExportCode (string exportCode)
        {
            this.setProperty("exportCode", exportCode);
        }


    }
}

