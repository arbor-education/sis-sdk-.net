using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SenNeedType : ModelBase
    {
        protected string resourceType = ResourceType.SEN_NEED_TYPE;
        public const string D00237 = "d00237";
        public const string EXPORT_CODE = "exportCode";
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string LABEL = "label";

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
        	query.setResourceType ("SenNeedType");
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
        	return (SenNeedType) gateway.retrieve(ResourceType.SEN_NEED_TYPE, id);
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
            return (bool) this.getProperty("active");
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

