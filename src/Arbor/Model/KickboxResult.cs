using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class KickboxResult : ModelBase
    {
        protected string resourceType = ResourceType.KICKBOX_RESULT;
        public const string RAW_EMAIL_ADDRESS = "rawEmailAddress";
        public const string RESULT = "result";
        public const string REASON = "reason";
        public const string ROLE = "role";
        public const string FREE = "free";
        public const string DISPOSABLE = "disposable";
        public const string ACCEPT_ALL = "acceptAll";
        public const string DID_YOU_MEAN = "didYouMean";
        public const string SENDEX = "sendex";
        public const string RESPONSE_CODE = "responseCode";
        public const string LAST_CHECKED_DATETIME = "lastCheckedDatetime";

        public KickboxResult()
        {
            base.resourceType = this.resourceType;
        }

        public KickboxResult(string resourceType = "KickboxResult", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<KickboxResult> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("KickboxResult");
            RestGateway gateway = (RestGateway)KickboxResult.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<KickboxResult> kickboxresultCollection = new ModelCollection<KickboxResult>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                kickboxresultCollection.add((KickboxResult)model);
            }

            return kickboxresultCollection;
        }

        public static KickboxResult retrieve(string id)
        {
            RestGateway gateway = (RestGateway)KickboxResult.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (KickboxResult)gateway.retrieve(ResourceType.KICKBOX_RESULT, id);
        }

        public string getRawEmailAddress()
        {
            return this.getProperty("rawEmailAddress").ToString();
        }

        public void setRawEmailAddress(string rawEmailAddress)
        {
            this.setProperty("rawEmailAddress", rawEmailAddress);
        }

        public string getResult()
        {
            return this.getProperty("result").ToString();
        }

        public void setResult(string result)
        {
            this.setProperty("result", result);
        }

        public string getReason()
        {
            return this.getProperty("reason").ToString();
        }

        public void setReason(string reason)
        {
            this.setProperty("reason", reason);
        }

        public bool getRole()
        {
            return (bool)this.getProperty("role");
        }

        public void setRole(bool role)
        {
            this.setProperty("role", role);
        }

        public bool getFree()
        {
            return (bool)this.getProperty("free");
        }

        public void setFree(bool free)
        {
            this.setProperty("free", free);
        }

        public bool getDisposable()
        {
            return (bool)this.getProperty("disposable");
        }

        public void setDisposable(bool disposable)
        {
            this.setProperty("disposable", disposable);
        }

        public bool getAcceptAll()
        {
            return (bool)this.getProperty("acceptAll");
        }

        public void setAcceptAll(bool acceptAll)
        {
            this.setProperty("acceptAll", acceptAll);
        }

        public string getDidYouMean()
        {
            return this.getProperty("didYouMean").ToString();
        }

        public void setDidYouMean(string didYouMean)
        {
            this.setProperty("didYouMean", didYouMean);
        }

        public float getSendex()
        {
            return (float)this.getProperty("sendex");
        }

        public void setSendex(float sendex)
        {
            this.setProperty("sendex", sendex);
        }

        public int getResponseCode()
        {
            return Convert.ToInt32(this.getProperty("responseCode"));
        }

        public void setResponseCode(int responseCode)
        {
            this.setProperty("responseCode", responseCode);
        }

        public DateTime getLastCheckedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("lastCheckedDatetime"));
        }

        public void setLastCheckedDatetime(DateTime lastCheckedDatetime)
        {
            this.setProperty("lastCheckedDatetime", lastCheckedDatetime);
        }


    }
}

