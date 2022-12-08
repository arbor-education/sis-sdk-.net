using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PostalAddress : ModelBase
    {
        protected string resourceType = ResourceType.POSTAL_ADDRESS;
        public const string ADDRESS1 = "address1";
        public const string ADDRESS2 = "address2";
        public const string ADDRESS3 = "address3";
        public const string POSTAL_TOWN = "postalTown";
        public const string POSTAL_STATE = "postalState";
        public const string POSTAL_CODE = "postalCode";
        public const string COUNTRY = "country";
        public const string LAT = "lat";
        public const string LNG = "lng";
        public const string GEOCODE_TYPE = "geocodeType";

        public PostalAddress()
        {
            base.resourceType = this.resourceType;
        }

        public PostalAddress(string resourceType = "PostalAddress", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PostalAddress> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PostalAddress");
            RestGateway gateway = (RestGateway)PostalAddress.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PostalAddress> postaladdressCollection = new ModelCollection<PostalAddress>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                postaladdressCollection.add((PostalAddress)model);
            }

            return postaladdressCollection;
        }

        public static PostalAddress retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PostalAddress.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PostalAddress)gateway.retrieve(ResourceType.POSTAL_ADDRESS, id);
        }

        public string getAddress1()
        {
            return this.getProperty("address1").ToString();
        }

        public void setAddress1(string address1)
        {
            this.setProperty("address1", address1);
        }

        public string getAddress2()
        {
            return this.getProperty("address2").ToString();
        }

        public void setAddress2(string address2)
        {
            this.setProperty("address2", address2);
        }

        public string getAddress3()
        {
            return this.getProperty("address3").ToString();
        }

        public void setAddress3(string address3)
        {
            this.setProperty("address3", address3);
        }

        public string getPostalTown()
        {
            return this.getProperty("postalTown").ToString();
        }

        public void setPostalTown(string postalTown)
        {
            this.setProperty("postalTown", postalTown);
        }

        public string getPostalState()
        {
            return this.getProperty("postalState").ToString();
        }

        public void setPostalState(string postalState)
        {
            this.setProperty("postalState", postalState);
        }

        public string getPostalCode()
        {
            return this.getProperty("postalCode").ToString();
        }

        public void setPostalCode(string postalCode)
        {
            this.setProperty("postalCode", postalCode);
        }

        public Country getCountry()
        {
            return (Country)this.getProperty("country");
        }

        public void setCountry(Country country)
        {
            this.setProperty("country", country);
        }

        public float getLat()
        {
            return (float)this.getProperty("lat");
        }

        public void setLat(float lat)
        {
            this.setProperty("lat", lat);
        }

        public float getLng()
        {
            return (float)this.getProperty("lng");
        }

        public void setLng(float lng)
        {
            this.setProperty("lng", lng);
        }

        public string getGeocodeType()
        {
            return this.getProperty("geocodeType").ToString();
        }

        public void setGeocodeType(string geocodeType)
        {
            this.setProperty("geocodeType", geocodeType);
        }


    }
}

