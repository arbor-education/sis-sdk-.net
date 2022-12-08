using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class GoogleUser : ModelBase
    {
        protected string resourceType = ResourceType.GOOGLE_USER;
        public const string GIVEN_NAME = "givenName";
        public const string FAMILY_NAME = "familyName";
        public const string PRIMARY_EMAIL = "primaryEmail";
        public const string GOOGLE_IDENTIFIER = "googleIdentifier";
        public const string MATCHED_PERSON = "matchedPerson";

        public GoogleUser()
        {
            base.resourceType = this.resourceType;
        }

        public GoogleUser(string resourceType = "GoogleUser", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<GoogleUser> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("GoogleUser");
            RestGateway gateway = (RestGateway)GoogleUser.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<GoogleUser> googleuserCollection = new ModelCollection<GoogleUser>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                googleuserCollection.add((GoogleUser)model);
            }

            return googleuserCollection;
        }

        public static GoogleUser retrieve(string id)
        {
            RestGateway gateway = (RestGateway)GoogleUser.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (GoogleUser)gateway.retrieve(ResourceType.GOOGLE_USER, id);
        }

        public string getGivenName()
        {
            return this.getProperty("givenName").ToString();
        }

        public void setGivenName(string givenName)
        {
            this.setProperty("givenName", givenName);
        }

        public string getFamilyName()
        {
            return this.getProperty("familyName").ToString();
        }

        public void setFamilyName(string familyName)
        {
            this.setProperty("familyName", familyName);
        }

        public string getPrimaryEmail()
        {
            return this.getProperty("primaryEmail").ToString();
        }

        public void setPrimaryEmail(string primaryEmail)
        {
            this.setProperty("primaryEmail", primaryEmail);
        }

        public string getGoogleIdentifier()
        {
            return this.getProperty("googleIdentifier").ToString();
        }

        public void setGoogleIdentifier(string googleIdentifier)
        {
            this.setProperty("googleIdentifier", googleIdentifier);
        }

        public ModelBase getMatchedPerson()
        {
            return (ModelBase)this.getProperty("matchedPerson");
        }

        public void setMatchedPerson(ModelBase matchedPerson)
        {
            this.setProperty("matchedPerson", matchedPerson);
        }


    }
}

