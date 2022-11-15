using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class LocalAuthority : ModelBase
    {
        protected new string resourceType = ResourceType.LOCAL_AUTHORITY;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string COUNTRY = "country";
        public const string NAME = "name";
        public const string SHORT_NAME = "shortName";

        public LocalAuthority()
        {
            base.resourceType = this.resourceType;
        }

        public LocalAuthority(string resourceType = "LocalAuthority", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<LocalAuthority> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("LocalAuthority");
            RestGateway gateway = (RestGateway)LocalAuthority.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<LocalAuthority> localauthorityCollection = new ModelCollection<LocalAuthority>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                localauthorityCollection.add((LocalAuthority)model);
            }

            return localauthorityCollection;
        }

        public static LocalAuthority retrieve(string id)
        {
            RestGateway gateway = (RestGateway)LocalAuthority.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (LocalAuthority)gateway.retrieve(ResourceType.LOCAL_AUTHORITY, id);
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

        public Country getCountry()
        {
            return (Country)this.getProperty("country");
        }

        public void setCountry(Country country)
        {
            this.setProperty("country", country);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public string getShortName()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName(string shortName)
        {
            this.setProperty("shortName", shortName);
        }


    }
}

