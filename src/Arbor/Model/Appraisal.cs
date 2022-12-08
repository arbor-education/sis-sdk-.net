using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Appraisal : ModelBase
    {
        protected string resourceType = ResourceType.APPRAISAL;
        public const string APPRAISEE = "appraisee";
        public const string APPRAISAL_DATE = "appraisalDate";
        public const string APPRAISER = "appraiser";
        public const string APPRAISAL_NOTES = "appraisalNotes";
        public const string COMPLETED_DATETIME = "completedDatetime";

        public Appraisal()
        {
            base.resourceType = this.resourceType;
        }

        public Appraisal(string resourceType = "Appraisal", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Appraisal> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Appraisal");
            RestGateway gateway = (RestGateway)Appraisal.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Appraisal> appraisalCollection = new ModelCollection<Appraisal>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                appraisalCollection.add((Appraisal)model);
            }

            return appraisalCollection;
        }

        public static Appraisal retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Appraisal.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Appraisal)gateway.retrieve(ResourceType.APPRAISAL, id);
        }

        public Staff getAppraisee()
        {
            return (Staff)this.getProperty("appraisee");
        }

        public void setAppraisee(Staff appraisee)
        {
            this.setProperty("appraisee", appraisee);
        }

        public DateTime getAppraisalDate()
        {
            return Convert.ToDateTime(this.getProperty("appraisalDate"));
        }

        public void setAppraisalDate(DateTime appraisalDate)
        {
            this.setProperty("appraisalDate", appraisalDate);
        }

        public Staff getAppraiser()
        {
            return (Staff)this.getProperty("appraiser");
        }

        public void setAppraiser(Staff appraiser)
        {
            this.setProperty("appraiser", appraiser);
        }

        public string getAppraisalNotes()
        {
            return this.getProperty("appraisalNotes").ToString();
        }

        public void setAppraisalNotes(string appraisalNotes)
        {
            this.setProperty("appraisalNotes", appraisalNotes);
        }

        public DateTime getCompletedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("completedDatetime"));
        }

        public void setCompletedDatetime(DateTime completedDatetime)
        {
            this.setProperty("completedDatetime", completedDatetime);
        }


    }
}

