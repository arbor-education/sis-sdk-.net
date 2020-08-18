using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_TwoYearOldFundingBasis : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_TWO_YEAR_OLD_FUNDING_BASIS;
        public const string STUDENT = "student";
        public const string FUNDING_BASIS = "fundingBasis";

        public UkDfe_TwoYearOldFundingBasis ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_TwoYearOldFundingBasis (string resourceType = "UkDfe_TwoYearOldFundingBasis", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_TwoYearOldFundingBasis> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_TwoYearOldFundingBasis");
        	RestGateway gateway = (RestGateway) UkDfe_TwoYearOldFundingBasis.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_TwoYearOldFundingBasis> ukdfe_twoyearoldfundingbasisCollection = new ModelCollection<UkDfe_TwoYearOldFundingBasis> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_twoyearoldfundingbasisCollection.add((UkDfe_TwoYearOldFundingBasis) model);
        	}
        
        	return ukdfe_twoyearoldfundingbasisCollection;
        }

        public static UkDfe_TwoYearOldFundingBasis retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_TwoYearOldFundingBasis.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_TwoYearOldFundingBasis) gateway.retrieve(ResourceType.UK_DFE_TWO_YEAR_OLD_FUNDING_BASIS, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public string getFundingBasis ()
        {
            return this.getProperty("fundingBasis").ToString();
        }

        public void setFundingBasis (string fundingBasis)
        {
            this.setProperty("fundingBasis", fundingBasis);
        }


    }
}

