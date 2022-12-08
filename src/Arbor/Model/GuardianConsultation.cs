using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class GuardianConsultation : ModelBase
    {
        protected string resourceType = ResourceType.GUARDIAN_CONSULTATION;
        public const string GUARDIAN_CONSULTATION_NAME = "guardianConsultationName";
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string SELF_SCHEDULING_OPENS_DATETIME = "selfSchedulingOpensDatetime";
        public const string SELF_SCHEDULING_CLOSES_DATETIME = "selfSchedulingClosesDatetime";

        public GuardianConsultation()
        {
            base.resourceType = this.resourceType;
        }

        public GuardianConsultation(string resourceType = "GuardianConsultation", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<GuardianConsultation> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("GuardianConsultation");
            RestGateway gateway = (RestGateway)GuardianConsultation.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<GuardianConsultation> guardianconsultationCollection = new ModelCollection<GuardianConsultation>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                guardianconsultationCollection.add((GuardianConsultation)model);
            }

            return guardianconsultationCollection;
        }

        public static GuardianConsultation retrieve(string id)
        {
            RestGateway gateway = (RestGateway)GuardianConsultation.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (GuardianConsultation)gateway.retrieve(ResourceType.GUARDIAN_CONSULTATION, id);
        }

        public string getGuardianConsultationName()
        {
            return this.getProperty("guardianConsultationName").ToString();
        }

        public void setGuardianConsultationName(string guardianConsultationName)
        {
            this.setProperty("guardianConsultationName", guardianConsultationName);
        }

        public DateTime getStartDatetime()
        {
            return Convert.ToDateTime(this.getProperty("startDatetime"));
        }

        public void setStartDatetime(DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime()
        {
            return Convert.ToDateTime(this.getProperty("endDatetime"));
        }

        public void setEndDatetime(DateTime endDatetime)
        {
            this.setProperty("endDatetime", endDatetime);
        }

        public DateTime getSelfSchedulingOpensDatetime()
        {
            return Convert.ToDateTime(this.getProperty("selfSchedulingOpensDatetime"));
        }

        public void setSelfSchedulingOpensDatetime(DateTime selfSchedulingOpensDatetime)
        {
            this.setProperty("selfSchedulingOpensDatetime", selfSchedulingOpensDatetime);
        }

        public DateTime getSelfSchedulingClosesDatetime()
        {
            return Convert.ToDateTime(this.getProperty("selfSchedulingClosesDatetime"));
        }

        public void setSelfSchedulingClosesDatetime(DateTime selfSchedulingClosesDatetime)
        {
            this.setProperty("selfSchedulingClosesDatetime", selfSchedulingClosesDatetime);
        }


    }
}

