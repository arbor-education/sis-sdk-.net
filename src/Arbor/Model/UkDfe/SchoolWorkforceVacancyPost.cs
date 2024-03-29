using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class SchoolWorkforceVacancyPost : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_SCHOOL_WORKFORCE_VACANCY_POST;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string POST = "post";

        public SchoolWorkforceVacancyPost()
        {
            base.resourceType = this.resourceType;
        }

        public SchoolWorkforceVacancyPost(string resourceType = "SchoolWorkforceVacancyPost", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SchoolWorkforceVacancyPost> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_SchoolWorkforceVacancyPost");
            RestGateway gateway = (RestGateway)SchoolWorkforceVacancyPost.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SchoolWorkforceVacancyPost> schoolworkforcevacancypostCollection = new ModelCollection<SchoolWorkforceVacancyPost>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                schoolworkforcevacancypostCollection.add((SchoolWorkforceVacancyPost)model);
            }

            return schoolworkforcevacancypostCollection;
        }

        public static SchoolWorkforceVacancyPost retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SchoolWorkforceVacancyPost.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SchoolWorkforceVacancyPost)gateway.retrieve(ResourceType.UK_DFE_SCHOOL_WORKFORCE_VACANCY_POST, id);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive(bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder(int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getPost()
        {
            return this.getProperty("post").ToString();
        }

        public void setPost(string post)
        {
            this.setProperty("post", post);
        }


    }
}

