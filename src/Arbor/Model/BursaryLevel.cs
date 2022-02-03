using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BursaryLevel : ModelBase
    {
        protected string resourceType = ResourceType.BURSARY_LEVEL;
        public const string NAME = "name";
        public const string BURSARY_TYPE = "bursaryType";

        public BursaryLevel ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BursaryLevel (string resourceType = "BursaryLevel", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BursaryLevel> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BursaryLevel");
        	RestGateway gateway = (RestGateway) BursaryLevel.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BursaryLevel> bursarylevelCollection = new ModelCollection<BursaryLevel> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    bursarylevelCollection.add((BursaryLevel) model);
        	}
        
        	return bursarylevelCollection;
        }

        public static BursaryLevel retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BursaryLevel.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BursaryLevel) gateway.retrieve(ResourceType.BURSARY_LEVEL, id);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public BursaryType getBursaryType ()
        {
            return (BursaryType) this.getProperty("bursaryType");
        }

        public void setBursaryType (BursaryType bursaryType)
        {
            this.setProperty("bursaryType", bursaryType);
        }


    }
}

