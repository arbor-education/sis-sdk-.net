using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ClubLead : ModelBase
    {
        protected new string resourceType = ResourceType.CLUB_LEAD;
        public const string CLUB = "club";
        public const string STAFF = "staff";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public ClubLead()
        {
            base.resourceType = this.resourceType;
        }

        public ClubLead(string resourceType = "ClubLead", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ClubLead> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ClubLead");
            RestGateway gateway = (RestGateway)ClubLead.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ClubLead> clubleadCollection = new ModelCollection<ClubLead>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                clubleadCollection.add((ClubLead)model);
            }

            return clubleadCollection;
        }

        public static ClubLead retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ClubLead.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ClubLead)gateway.retrieve(ResourceType.CLUB_LEAD, id);
        }

        public Club getClub()
        {
            return (Club)this.getProperty("club");
        }

        public void setClub(Club club)
        {
            this.setProperty("club", club);
        }

        public Staff getStaff()
        {
            return (Staff)this.getProperty("staff");
        }

        public void setStaff(Staff staff)
        {
            this.setProperty("staff", staff);
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


    }
}

