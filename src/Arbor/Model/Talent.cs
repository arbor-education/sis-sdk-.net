using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Talent : ModelBase
    {
        protected string resourceType = ResourceType.TALENT;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string TALENT_NAME = "talentName";

        public Talent ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Talent (string resourceType = "Talent", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Talent> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Talent");
        	RestGateway gateway = (RestGateway) Talent.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Talent> talentCollection = new ModelCollection<Talent> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    talentCollection.add((Talent) model);
        	}
        
        	return talentCollection;
        }

        public static Talent retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Talent.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Talent) gateway.retrieve(ResourceType.TALENT, id);
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

        public string getTalentName ()
        {
            return this.getProperty("talentName").ToString();
        }

        public void setTalentName (string talentName)
        {
            this.setProperty("talentName", talentName);
        }


    }
}

