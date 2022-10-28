using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class TwoYearOldFundingBasis : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_TWO_YEAR_OLD_FUNDING_BASIS;
        public const string STUDENT = "student";
        public const string FUNDING_BASIS = "fundingBasis";

        public TwoYearOldFundingBasis()
        {
            base.resourceType = this.resourceType;
        }

        public TwoYearOldFundingBasis(string resourceType = "TwoYearOldFundingBasis", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<TwoYearOldFundingBasis> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_TwoYearOldFundingBasis");
            RestGateway gateway = (RestGateway)TwoYearOldFundingBasis.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<TwoYearOldFundingBasis> twoyearoldfundingbasisCollection = new ModelCollection<TwoYearOldFundingBasis>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                twoyearoldfundingbasisCollection.add((TwoYearOldFundingBasis)model);
            }

            return twoyearoldfundingbasisCollection;
        }

        public static TwoYearOldFundingBasis retrieve(string id)
        {
            RestGateway gateway = (RestGateway)TwoYearOldFundingBasis.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (TwoYearOldFundingBasis)gateway.retrieve(ResourceType.UK_DFE_TWO_YEAR_OLD_FUNDING_BASIS, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public string getFundingBasis()
        {
            return this.getProperty("fundingBasis").ToString();
        }

        public void setFundingBasis(string fundingBasis)
        {
            this.setProperty("fundingBasis", fundingBasis);
        }


    }
}

