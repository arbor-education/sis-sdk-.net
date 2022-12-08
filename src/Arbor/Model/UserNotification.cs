using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class UserNotification : ModelBase
    {
        protected string resourceType = ResourceType.USER_NOTIFICATION;
        public const string USER = "user";
        public const string IS_READ = "isRead";
        public const string STATUS = "status";
        public const string MODIFIED_GLOBAL_COUNTER = "modifiedGlobalCounter";
        public const string CREATED_DATETIME = "createdDatetime";
        public const string ACTION = "action";
        public const string ICON = "icon";
        public const string ORIGIN = "origin";
        public const string PARAMETERS = "parameters";
        public const string TYPE = "type";
        public const string DESCRIPTION = "description";
        public const string SUBJECT = "subject";

        public UserNotification()
        {
            base.resourceType = this.resourceType;
        }

        public UserNotification(string resourceType = "UserNotification", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<UserNotification> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UserNotification");
            RestGateway gateway = (RestGateway)UserNotification.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<UserNotification> usernotificationCollection = new ModelCollection<UserNotification>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                usernotificationCollection.add((UserNotification)model);
            }

            return usernotificationCollection;
        }

        public static UserNotification retrieve(string id)
        {
            RestGateway gateway = (RestGateway)UserNotification.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (UserNotification)gateway.retrieve(ResourceType.USER_NOTIFICATION, id);
        }

        public User getUser()
        {
            return (User)this.getProperty("user");
        }

        public void setUser(User user)
        {
            this.setProperty("user", user);
        }

        public bool getIsRead()
        {
            return Convert.ToBoolean(this.getProperty("isRead"));
        }

        public void setIsRead(bool isRead)
        {
            this.setProperty("isRead", isRead);
        }

        public string getStatus()
        {
            return this.getProperty("status").ToString();
        }

        public void setStatus(string status)
        {
            this.setProperty("status", status);
        }

        public int getModifiedGlobalCounter()
        {
            return Convert.ToInt32(this.getProperty("modifiedGlobalCounter"));
        }

        public void setModifiedGlobalCounter(int modifiedGlobalCounter)
        {
            this.setProperty("modifiedGlobalCounter", modifiedGlobalCounter);
        }

        public DateTime getCreatedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("createdDatetime"));
        }

        public void setCreatedDatetime(DateTime createdDatetime)
        {
            this.setProperty("createdDatetime", createdDatetime);
        }

        public string getAction()
        {
            return this.getProperty("action").ToString();
        }

        public void setAction(string action)
        {
            this.setProperty("action", action);
        }

        public string getIcon()
        {
            return this.getProperty("icon").ToString();
        }

        public void setIcon(string icon)
        {
            this.setProperty("icon", icon);
        }

        public string getOrigin()
        {
            return this.getProperty("origin").ToString();
        }

        public void setOrigin(string origin)
        {
            this.setProperty("origin", origin);
        }

        public string getParameters()
        {
            return this.getProperty("parameters").ToString();
        }

        public void setParameters(string parameters)
        {
            this.setProperty("parameters", parameters);
        }

        public string getType()
        {
            return this.getProperty("type").ToString();
        }

        public void setType(string type)
        {
            this.setProperty("type", type);
        }

        public string getDescription()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription(string description)
        {
            this.setProperty("description", description);
        }

        public string getSubject()
        {
            return this.getProperty("subject").ToString();
        }

        public void setSubject(string subject)
        {
            this.setProperty("subject", subject);
        }


    }
}

