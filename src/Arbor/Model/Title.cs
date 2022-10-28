using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Title : ModelBase
    {
        protected new string resourceType = ResourceType.TITLE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string TITLE = "title";
        public const string IS_MALE = "isMale";
        public const string IS_FEMALE = "isFemale";

        public Title ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Title (string resourceType = "Title", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Title> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Title");
        	RestGateway gateway = (RestGateway) Title.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Title> titleCollection = new ModelCollection<Title> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    titleCollection.add((Title) model);
        	}
        
        	return titleCollection;
        }

        public static Title retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Title.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Title) gateway.retrieve(ResourceType.TITLE, id);
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

        public string getTitle ()
        {
            return this.getProperty("title").ToString();
        }

        public void setTitle (string title)
        {
            this.setProperty("title", title);
        }

        public bool getIsMale ()
        {
            return Convert.ToBoolean(this.getProperty("isMale"));
        }

        public void setIsMale (bool isMale)
        {
            this.setProperty("isMale", isMale);
        }

        public bool getIsFemale ()
        {
            return Convert.ToBoolean(this.getProperty("isFemale"));
        }

        public void setIsFemale (bool isFemale)
        {
            this.setProperty("isFemale", isFemale);
        }


    }
}

