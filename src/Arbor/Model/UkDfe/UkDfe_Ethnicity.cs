using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_Ethnicity : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_ETHNICITY;
        public const string DFES_MAIN_CODE = "dfesMainCode";
        public const string D00005 = "d00005";
        public const string ONS_CODE = "onsCode";
        public const string D00250 = "d00250";

        public UkDfe_Ethnicity ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_Ethnicity (string resourceType = "UkDfe_Ethnicity", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_Ethnicity> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_Ethnicity");
        	RestGateway gateway = (RestGateway) UkDfe_Ethnicity.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_Ethnicity> ukdfe_ethnicityCollection = new ModelCollection<UkDfe_Ethnicity> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_ethnicityCollection.add((UkDfe_Ethnicity) model);
        	}
        
        	return ukdfe_ethnicityCollection;
        }

        public static UkDfe_Ethnicity retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_Ethnicity.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_Ethnicity) gateway.retrieve(ResourceType.UK_DFE_ETHNICITY, id);
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

        public string getD00250 ()
        {
            return this.getProperty("d00250").ToString();
        }

        public void setD00250 (string d00250)
        {
            this.setProperty("d00250", d00250);
        }


    }
}

