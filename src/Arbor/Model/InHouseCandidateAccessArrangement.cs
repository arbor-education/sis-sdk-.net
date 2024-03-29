using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InHouseCandidateAccessArrangement : ModelBase
    {
        protected new string resourceType = ResourceType.IN_HOUSE_CANDIDATE_ACCESS_ARRANGEMENT;
        public const string IN_HOUSE_CANDIDATE = "inHouseCandidate";
        public const string ACCESS_ARRANGEMENT = "accessArrangement";
        public const string EXTRA_TIME_PERCENTAGE = "extraTimePercentage";
        public const string REASON = "reason";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public InHouseCandidateAccessArrangement()
        {
            base.resourceType = this.resourceType;
        }

        public InHouseCandidateAccessArrangement(string resourceType = "InHouseCandidateAccessArrangement", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<InHouseCandidateAccessArrangement> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("InHouseCandidateAccessArrangement");
            RestGateway gateway = (RestGateway)InHouseCandidateAccessArrangement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<InHouseCandidateAccessArrangement> inhousecandidateaccessarrangementCollection = new ModelCollection<InHouseCandidateAccessArrangement>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                inhousecandidateaccessarrangementCollection.add((InHouseCandidateAccessArrangement)model);
            }

            return inhousecandidateaccessarrangementCollection;
        }

        public static InHouseCandidateAccessArrangement retrieve(string id)
        {
            RestGateway gateway = (RestGateway)InHouseCandidateAccessArrangement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (InHouseCandidateAccessArrangement)gateway.retrieve(ResourceType.IN_HOUSE_CANDIDATE_ACCESS_ARRANGEMENT, id);
        }

        public InHouseCandidate getInHouseCandidate()
        {
            return (InHouseCandidate)this.getProperty("inHouseCandidate");
        }

        public void setInHouseCandidate(InHouseCandidate inHouseCandidate)
        {
            this.setProperty("inHouseCandidate", inHouseCandidate);
        }

        public AccessArrangement getAccessArrangement()
        {
            return (AccessArrangement)this.getProperty("accessArrangement");
        }

        public void setAccessArrangement(AccessArrangement accessArrangement)
        {
            this.setProperty("accessArrangement", accessArrangement);
        }

        public float getExtraTimePercentage()
        {
            return (float)this.getProperty("extraTimePercentage");
        }

        public void setExtraTimePercentage(float extraTimePercentage)
        {
            this.setProperty("extraTimePercentage", extraTimePercentage);
        }

        public string getReason()
        {
            return this.getProperty("reason").ToString();
        }

        public void setReason(string reason)
        {
            this.setProperty("reason", reason);
        }

        public DateTime getEffectiveDate()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate(DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate(DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

