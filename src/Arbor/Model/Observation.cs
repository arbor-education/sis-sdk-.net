using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Observation : ModelBase
    {
        protected string resourceType = ResourceType.OBSERVATION;
        public const string OBSERVING_STAFF = "observingStaff";
        public const string OBSERVED_STAFF = "observedStaff";
        public const string SESSION = "session";
        public const string OBSERVATION_START_DATETIME = "observationStartDatetime";
        public const string OBSERVATION_END_DATETIME = "observationEndDatetime";
        public const string SUBMITTED_DATETIME = "submittedDatetime";
        public const string OBSERVATION_FOCUS = "observationFocus";

        public Observation()
        {
            base.resourceType = this.resourceType;
        }

        public Observation(string resourceType = "Observation", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Observation> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Observation");
            RestGateway gateway = (RestGateway)Observation.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Observation> observationCollection = new ModelCollection<Observation>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                observationCollection.add((Observation)model);
            }

            return observationCollection;
        }

        public static Observation retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Observation.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Observation)gateway.retrieve(ResourceType.OBSERVATION, id);
        }

        public Staff getObservingStaff()
        {
            return (Staff)this.getProperty("observingStaff");
        }

        public void setObservingStaff(Staff observingStaff)
        {
            this.setProperty("observingStaff", observingStaff);
        }

        public Staff getObservedStaff()
        {
            return (Staff)this.getProperty("observedStaff");
        }

        public void setObservedStaff(Staff observedStaff)
        {
            this.setProperty("observedStaff", observedStaff);
        }

        public Session getSession()
        {
            return (Session)this.getProperty("session");
        }

        public void setSession(Session session)
        {
            this.setProperty("session", session);
        }

        public DateTime getObservationStartDatetime()
        {
            return Convert.ToDateTime(this.getProperty("observationStartDatetime"));
        }

        public void setObservationStartDatetime(DateTime observationStartDatetime)
        {
            this.setProperty("observationStartDatetime", observationStartDatetime);
        }

        public DateTime getObservationEndDatetime()
        {
            return Convert.ToDateTime(this.getProperty("observationEndDatetime"));
        }

        public void setObservationEndDatetime(DateTime observationEndDatetime)
        {
            this.setProperty("observationEndDatetime", observationEndDatetime);
        }

        public DateTime getSubmittedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("submittedDatetime"));
        }

        public void setSubmittedDatetime(DateTime submittedDatetime)
        {
            this.setProperty("submittedDatetime", submittedDatetime);
        }

        public string getObservationFocus()
        {
            return this.getProperty("observationFocus").ToString();
        }

        public void setObservationFocus(string observationFocus)
        {
            this.setProperty("observationFocus", observationFocus);
        }


    }
}

