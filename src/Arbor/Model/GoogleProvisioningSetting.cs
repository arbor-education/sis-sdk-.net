using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class GoogleProvisioningSetting : ModelBase
    {
        protected string resourceType = ResourceType.GOOGLE_PROVISIONING_SETTING;
        public const string PROVISION_STAFF_USERS = "provisionStaffUsers";
        public const string PROVISION_STUDENT_USERS = "provisionStudentUsers";
        public const string AUTH_CONFIG = "authConfig";
        public const string ACCESS_TOKEN = "accessToken";
        public const string LAST_SYNC_DATETIME = "lastSyncDatetime";

        public GoogleProvisioningSetting()
        {
            base.resourceType = this.resourceType;
        }

        public GoogleProvisioningSetting(string resourceType = "GoogleProvisioningSetting", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<GoogleProvisioningSetting> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("GoogleProvisioningSetting");
            RestGateway gateway = (RestGateway)GoogleProvisioningSetting.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<GoogleProvisioningSetting> googleprovisioningsettingCollection = new ModelCollection<GoogleProvisioningSetting>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                googleprovisioningsettingCollection.add((GoogleProvisioningSetting)model);
            }

            return googleprovisioningsettingCollection;
        }

        public static GoogleProvisioningSetting retrieve(string id)
        {
            RestGateway gateway = (RestGateway)GoogleProvisioningSetting.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (GoogleProvisioningSetting)gateway.retrieve(ResourceType.GOOGLE_PROVISIONING_SETTING, id);
        }

        public bool getProvisionStaffUsers()
        {
            return Convert.ToBoolean(this.getProperty("provisionStaffUsers"));
        }

        public void setProvisionStaffUsers(bool provisionStaffUsers)
        {
            this.setProperty("provisionStaffUsers", provisionStaffUsers);
        }

        public bool getProvisionStudentUsers()
        {
            return Convert.ToBoolean(this.getProperty("provisionStudentUsers"));
        }

        public void setProvisionStudentUsers(bool provisionStudentUsers)
        {
            this.setProperty("provisionStudentUsers", provisionStudentUsers);
        }

        public string getAuthConfig()
        {
            return this.getProperty("authConfig").ToString();
        }

        public void setAuthConfig(string authConfig)
        {
            this.setProperty("authConfig", authConfig);
        }

        public string getAccessToken()
        {
            return this.getProperty("accessToken").ToString();
        }

        public void setAccessToken(string accessToken)
        {
            this.setProperty("accessToken", accessToken);
        }

        public DateTime getLastSyncDatetime()
        {
            return Convert.ToDateTime(this.getProperty("lastSyncDatetime"));
        }

        public void setLastSyncDatetime(DateTime lastSyncDatetime)
        {
            this.setProperty("lastSyncDatetime", lastSyncDatetime);
        }


    }
}

