using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class UserActivity : ModelBase
    {
        protected string resourceType = ResourceType.USER_ACTIVITY;
        public const string USER = "user";
        public const string PRODUCT_AREA = "productArea";
        public const string DAY = "day";
        public const string HOUR = "hour";
        public const string REQUESTS = "requests";

        public UserActivity ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UserActivity (string resourceType = "UserActivity", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UserActivity> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UserActivity");
        	RestGateway gateway = (RestGateway) UserActivity.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UserActivity> useractivityCollection = new ModelCollection<UserActivity> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    useractivityCollection.add((UserActivity) model);
        	}
        
        	return useractivityCollection;
        }

        public static UserActivity retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UserActivity.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UserActivity) gateway.retrieve(ResourceType.USER_ACTIVITY, id);
        }

        public User getUser ()
        {
            return (User) this.getProperty("user");
        }

        public void setUser (User user)
        {
            this.setProperty("user", user);
        }

        public string getProductArea ()
        {
            return this.getProperty("productArea").ToString();
        }

        public void setProductArea (string productArea)
        {
            this.setProperty("productArea", productArea);
        }

        public DateTime getDay ()
        {
            return (DateTime) this.getProperty("day");
        }

        public void setDay (DateTime day)
        {
            this.setProperty("day", day);
        }

        public DateTime getHour ()
        {
            return (DateTime) this.getProperty("hour");
        }

        public void setHour (DateTime hour)
        {
            this.setProperty("hour", hour);
        }

        public int getRequests ()
        {
            return Convert.ToInt32(this.getProperty("requests"));
        }

        public void setRequests (int requests)
        {
            this.setProperty("requests", requests);
        }


    }
}

