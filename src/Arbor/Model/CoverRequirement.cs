using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CoverRequirement : ModelBase
    {
        protected new string resourceType = ResourceType.COVER_REQUIREMENT;
        public const string COVER_EVENT = "coverEvent";
        public const string ABSENT_STAFF = "absentStaff";
        public const string ABSENCE_EVENT = "absenceEvent";
        public const string COVER_PROPOSED_DATETIME = "coverProposedDatetime";
        public const string COVER_ARRANGED_DATETIME = "coverArrangedDatetime";
        public const string COVER_NOT_REQUIRED_DATETIME = "coverNotRequiredDatetime";

        public CoverRequirement()
        {
            base.resourceType = this.resourceType;
        }

        public CoverRequirement(string resourceType = "CoverRequirement", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CoverRequirement> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CoverRequirement");
            RestGateway gateway = (RestGateway)CoverRequirement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CoverRequirement> coverrequirementCollection = new ModelCollection<CoverRequirement>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                coverrequirementCollection.add((CoverRequirement)model);
            }

            return coverrequirementCollection;
        }

        public static CoverRequirement retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CoverRequirement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CoverRequirement)gateway.retrieve(ResourceType.COVER_REQUIREMENT, id);
        }

        public ModelBase getCoverEvent()
        {
            return (ModelBase)this.getProperty("coverEvent");
        }

        public void setCoverEvent(ModelBase coverEvent)
        {
            this.setProperty("coverEvent", coverEvent);
        }

        public Staff getAbsentStaff()
        {
            return (Staff)this.getProperty("absentStaff");
        }

        public void setAbsentStaff(Staff absentStaff)
        {
            this.setProperty("absentStaff", absentStaff);
        }

        public ModelBase getAbsenceEvent()
        {
            return (ModelBase)this.getProperty("absenceEvent");
        }

        public void setAbsenceEvent(ModelBase absenceEvent)
        {
            this.setProperty("absenceEvent", absenceEvent);
        }

        public DateTime getCoverProposedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("coverProposedDatetime"));
        }

        public void setCoverProposedDatetime(DateTime coverProposedDatetime)
        {
            this.setProperty("coverProposedDatetime", coverProposedDatetime);
        }

        public DateTime getCoverArrangedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("coverArrangedDatetime"));
        }

        public void setCoverArrangedDatetime(DateTime coverArrangedDatetime)
        {
            this.setProperty("coverArrangedDatetime", coverArrangedDatetime);
        }

        public DateTime getCoverNotRequiredDatetime()
        {
            return Convert.ToDateTime(this.getProperty("coverNotRequiredDatetime"));
        }

        public void setCoverNotRequiredDatetime(DateTime coverNotRequiredDatetime)
        {
            this.setProperty("coverNotRequiredDatetime", coverNotRequiredDatetime);
        }


    }
}

