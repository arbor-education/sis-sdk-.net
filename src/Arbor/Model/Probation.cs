using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Probation : ModelBase
    {
        protected string resourceType = ResourceType.PROBATION;
        public const string STAFF_CONTRACT = "staffContract";
        public const string START_DATE = "startDate";
        public const string ORIGINAL_END_DATE = "originalEndDate";
        public const string CURRENT_END_DATE = "currentEndDate";
        public const string PROBATION_DECISION = "probationDecision";

        public Probation()
        {
            base.resourceType = this.resourceType;
        }

        public Probation(string resourceType = "Probation", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Probation> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Probation");
            RestGateway gateway = (RestGateway)Probation.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Probation> probationCollection = new ModelCollection<Probation>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                probationCollection.add((Probation)model);
            }

            return probationCollection;
        }

        public static Probation retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Probation.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Probation)gateway.retrieve(ResourceType.PROBATION, id);
        }

        public StaffContract getStaffContract()
        {
            return (StaffContract)this.getProperty("staffContract");
        }

        public void setStaffContract(StaffContract staffContract)
        {
            this.setProperty("staffContract", staffContract);
        }

        public DateTime getStartDate()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate(DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getOriginalEndDate()
        {
            return Convert.ToDateTime(this.getProperty("originalEndDate"));
        }

        public void setOriginalEndDate(DateTime originalEndDate)
        {
            this.setProperty("originalEndDate", originalEndDate);
        }

        public DateTime getCurrentEndDate()
        {
            return Convert.ToDateTime(this.getProperty("currentEndDate"));
        }

        public void setCurrentEndDate(DateTime currentEndDate)
        {
            this.setProperty("currentEndDate", currentEndDate);
        }

        public string getProbationDecision()
        {
            return this.getProperty("probationDecision").ToString();
        }

        public void setProbationDecision(string probationDecision)
        {
            this.setProperty("probationDecision", probationDecision);
        }


    }
}

