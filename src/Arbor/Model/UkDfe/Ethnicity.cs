using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class Ethnicity : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_ETHNICITY;
        public const string DFES_MAIN_CODE = "dfesMainCode";
        public const string D00005 = "d00005";
        public const string ONS_CODE = "onsCode";

        public Ethnicity ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Ethnicity (string resourceType = "Ethnicity", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Ethnicity> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_Ethnicity");
        	RestGateway gateway = (RestGateway) Ethnicity.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Ethnicity> ethnicityCollection = new ModelCollection<Ethnicity> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ethnicityCollection.add((Ethnicity) model);
        	}
        
        	return ethnicityCollection;
        }

        public static Ethnicity retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Ethnicity.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Ethnicity) gateway.retrieve(ResourceType.UK_DFE_ETHNICITY, id);
        }

        public string getDfesMainCode ()
        {
            return this.getProperty("dfesMainCode").ToString();
        }

        public void setDfesMainCode (string dfesMainCode)
        {
            this.setProperty("dfesMainCode", dfesMainCode);
        }

        public string getD00005 ()
        {
            return this.getProperty("d00005").ToString();
        }

        public void setD00005 (string d00005)
        {
            this.setProperty("d00005", d00005);
        }

        public string getOnsCode ()
        {
            return this.getProperty("onsCode").ToString();
        }

        public void setOnsCode (string onsCode)
        {
            this.setProperty("onsCode", onsCode);
        }


    }
}

