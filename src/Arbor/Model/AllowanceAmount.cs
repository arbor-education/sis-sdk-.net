using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AllowanceAmount : ModelBase
    {
        protected string resourceType = ResourceType.ALLOWANCE_AMOUNT;
        public const string ALLOWANCE = "allowance";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string ALLOWANCE_AMOUNT = "allowanceAmount";

        public AllowanceAmount()
        {
            base.resourceType = this.resourceType;
        }

        public AllowanceAmount(string resourceType = "AllowanceAmount", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AllowanceAmount> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AllowanceAmount");
            RestGateway gateway = (RestGateway)AllowanceAmount.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AllowanceAmount> allowanceamountCollection = new ModelCollection<AllowanceAmount>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                allowanceamountCollection.add((AllowanceAmount)model);
            }

            return allowanceamountCollection;
        }

        public static AllowanceAmount retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AllowanceAmount.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AllowanceAmount)gateway.retrieve(ResourceType.ALLOWANCE_AMOUNT, id);
        }

        public Allowance getAllowance()
        {
            return (Allowance)this.getProperty("allowance");
        }

        public void setAllowance(Allowance allowance)
        {
            this.setProperty("allowance", allowance);
        }

        public DateTime getStartDate()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate(DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate(DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getAllowanceAmount()
        {
            return this.getProperty("allowanceAmount").ToString();
        }

        public void setAllowanceAmount(string allowanceAmount)
        {
            this.setProperty("allowanceAmount", allowanceAmount);
        }


    }
}

