using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class SenNeedType : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SEN_NEED_TYPE;
        public const string D00237 = "d00237";
        public const string EXPORT_CODE = "exportCode";

        public SenNeedType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SenNeedType (string resourceType = "SenNeedType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SenNeedType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_SenNeedType");
        	RestGateway gateway = (RestGateway) SenNeedType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SenNeedType> senneedtypeCollection = new ModelCollection<SenNeedType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    senneedtypeCollection.add((SenNeedType) model);
        	}
        
        	return senneedtypeCollection;
        }

        public static SenNeedType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SenNeedType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SenNeedType) gateway.retrieve(ResourceType.UK_DFE_SEN_NEED_TYPE, id);
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

