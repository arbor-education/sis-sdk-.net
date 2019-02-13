using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Language : ModelBase
    {
        protected string resourceType = ResourceType.LANGUAGE;
        public const string D00011_ALPHA3 = "d00011Alpha3";
        public const string D00011_ALPHA4 = "d00011Alpha4";
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string LABEL = "label";
        public const string ISO6391_ALPHA2 = "iso6391Alpha2";
        public const string ISO6392_ALPHA3 = "iso6392Alpha3";
        public const string ISO6392_ALPHA3_TERMINOLOGY = "iso6392Alpha3Terminology";
        public const string PARENT_CODE = "parentCode";

        public Language ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Language (string resourceType = "Language", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Language> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Language");
        	RestGateway gateway = (RestGateway) Language.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Language> languageCollection = new ModelCollection<Language> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    languageCollection.add((Language) model);
        	}
        
        	return languageCollection;
        }

        public static Language retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Language.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Language) gateway.retrieve(ResourceType.LANGUAGE, id);
        }

        public string getD00011Alpha3 ()
        {
            return this.getProperty("d00011Alpha3").ToString();
        }

        public void setD00011Alpha3 (string d00011Alpha3)
        {
            this.setProperty("d00011Alpha3", d00011Alpha3);
        }

        public string getD00011Alpha4 ()
        {
            return this.getProperty("d00011Alpha4").ToString();
        }

        public void setD00011Alpha4 (string d00011Alpha4)
        {
            this.setProperty("d00011Alpha4", d00011Alpha4);
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
            return Convert.ToBoolean(this.getProperty("active"))
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

        public string getLabel ()
        {
            return this.getProperty("label").ToString();
        }

        public void setLabel (string label)
        {
            this.setProperty("label", label);
        }

        public string getIso6391Alpha2 ()
        {
            return this.getProperty("iso6391Alpha2").ToString();
        }

        public void setIso6391Alpha2 (string iso6391Alpha2)
        {
            this.setProperty("iso6391Alpha2", iso6391Alpha2);
        }

        public string getIso6392Alpha3 ()
        {
            return this.getProperty("iso6392Alpha3").ToString();
        }

        public void setIso6392Alpha3 (string iso6392Alpha3)
        {
            this.setProperty("iso6392Alpha3", iso6392Alpha3);
        }

        public string getIso6392Alpha3Terminology ()
        {
            return this.getProperty("iso6392Alpha3Terminology").ToString();
        }

        public void setIso6392Alpha3Terminology (string iso6392Alpha3Terminology)
        {
            this.setProperty("iso6392Alpha3Terminology", iso6392Alpha3Terminology);
        }

        public string getParentCode ()
        {
            return this.getProperty("parentCode").ToString();
        }

        public void setParentCode (string parentCode)
        {
            this.setProperty("parentCode", parentCode);
        }


    }
}

