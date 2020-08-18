using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_CensusSchoolPhase : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_CENSUS_SCHOOL_PHASE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string LABEL = "label";

        public UkDfe_CensusSchoolPhase ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_CensusSchoolPhase (string resourceType = "UkDfe_CensusSchoolPhase", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_CensusSchoolPhase> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_CensusSchoolPhase");
        	RestGateway gateway = (RestGateway) UkDfe_CensusSchoolPhase.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_CensusSchoolPhase> ukdfe_censusschoolphaseCollection = new ModelCollection<UkDfe_CensusSchoolPhase> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_censusschoolphaseCollection.add((UkDfe_CensusSchoolPhase) model);
        	}
        
        	return ukdfe_censusschoolphaseCollection;
        }

        public static UkDfe_CensusSchoolPhase retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_CensusSchoolPhase.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_CensusSchoolPhase) gateway.retrieve(ResourceType.UK_DFE_CENSUS_SCHOOL_PHASE, id);
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
            return Convert.ToBoolean(this.getProperty("active"));
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

