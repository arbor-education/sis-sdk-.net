using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_SchoolWorkforceVacancyPost : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SCHOOL_WORKFORCE_VACANCY_POST;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string POST = "post";

        public UkDfe_SchoolWorkforceVacancyPost ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_SchoolWorkforceVacancyPost (string resourceType = "UkDfe_SchoolWorkforceVacancyPost", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_SchoolWorkforceVacancyPost> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_SchoolWorkforceVacancyPost");
        	RestGateway gateway = (RestGateway) UkDfe_SchoolWorkforceVacancyPost.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_SchoolWorkforceVacancyPost> ukdfe_schoolworkforcevacancypostCollection = new ModelCollection<UkDfe_SchoolWorkforceVacancyPost> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_schoolworkforcevacancypostCollection.add((UkDfe_SchoolWorkforceVacancyPost) model);
        	}
        
        	return ukdfe_schoolworkforcevacancypostCollection;
        }

        public static UkDfe_SchoolWorkforceVacancyPost retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_SchoolWorkforceVacancyPost.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_SchoolWorkforceVacancyPost) gateway.retrieve(ResourceType.UK_DFE_SCHOOL_WORKFORCE_VACANCY_POST, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getPost ()
        {
            return this.getProperty("post").ToString();
        }

        public void setPost (string post)
        {
            this.setProperty("post", post);
        }


    }
}

