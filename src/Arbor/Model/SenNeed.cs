using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SenNeed : ModelBase
    {
        protected string resourceType = ResourceType.SEN_NEED;
        public const string STUDENT = "student";
        public const string SEN_NEED_TYPE = "senNeedType";
        public const string DESCRIPTION = "description";
        public const string RANKING = "ranking";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public SenNeed()
        {
            base.resourceType = this.resourceType;
        }

        public SenNeed(string resourceType = "SenNeed", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SenNeed> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("SenNeed");
            RestGateway gateway = (RestGateway)SenNeed.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SenNeed> senneedCollection = new ModelCollection<SenNeed>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                senneedCollection.add((SenNeed)model);
            }

            return senneedCollection;
        }

        public static SenNeed retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SenNeed.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SenNeed)gateway.retrieve(ResourceType.SEN_NEED, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public SenNeedType getSenNeedType()
        {
            return (SenNeedType)this.getProperty("senNeedType");
        }

        public void setSenNeedType(SenNeedType senNeedType)
        {
            this.setProperty("senNeedType", senNeedType);
        }

        public string getDescription()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription(string description)
        {
            this.setProperty("description", description);
        }

        public int getRanking()
        {
            return Convert.ToInt32(this.getProperty("ranking"));
        }

        public void setRanking(int ranking)
        {
            this.setProperty("ranking", ranking);
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

