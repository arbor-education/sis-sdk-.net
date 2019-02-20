using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Gender : ModelBase
    {
        protected string resourceType = ResourceType.GENDER;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string SHORT_NAME = "shortName";
        public const string LONG_NAME = "longName";

        public Gender ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Gender (string resourceType = "Gender", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Gender> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Gender");
        	RestGateway gateway = (RestGateway) Gender.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Gender> genderCollection = new ModelCollection<Gender> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    genderCollection.add((Gender) model);
        	}
        
        	return genderCollection;
        }

        public static Gender retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Gender.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Gender) gateway.retrieve(ResourceType.GENDER, id);
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

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public string getLongName ()
        {
            return this.getProperty("longName").ToString();
        }

        public void setLongName (string longName)
        {
            this.setProperty("longName", longName);
        }


    }
}

