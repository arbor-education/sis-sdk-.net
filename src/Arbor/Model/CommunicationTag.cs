using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CommunicationTag : ModelBase
    {
        protected string resourceType = ResourceType.COMMUNICATION_TAG;
        public const string COMMUNICATION = "communication";
        public const string TAGGED_ENTITY = "taggedEntity";
        public const string IS_SHARED = "isShared";

        public CommunicationTag ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CommunicationTag (string resourceType = "CommunicationTag", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CommunicationTag> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CommunicationTag");
        	RestGateway gateway = (RestGateway) CommunicationTag.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CommunicationTag> communicationtagCollection = new ModelCollection<CommunicationTag> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    communicationtagCollection.add((CommunicationTag) model);
        	}
        
        	return communicationtagCollection;
        }

        public static CommunicationTag retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CommunicationTag.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CommunicationTag) gateway.retrieve(ResourceType.COMMUNICATION_TAG, id);
        }

        public ModelBase getCommunication ()
        {
            return (ModelBase) this.getProperty("communication");
        }

        public void setCommunication (ModelBase communication)
        {
            this.setProperty("communication", communication);
        }

        public ModelBase getTaggedEntity ()
        {
            return (ModelBase) this.getProperty("taggedEntity");
        }

        public void setTaggedEntity (ModelBase taggedEntity)
        {
            this.setProperty("taggedEntity", taggedEntity);
        }

        public bool getIsShared ()
        {
            return Convert.ToBoolean(this.getProperty("isShared"));
        }

        public void setIsShared (bool isShared)
        {
            this.setProperty("isShared", isShared);
        }


    }
}

