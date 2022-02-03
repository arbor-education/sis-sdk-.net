using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationSubscription : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_SUBSCRIPTION;
        public const string QUALIFICATION_ELEMENT_TYPE = "qualificationElementType";
        public const string QUALIFICATION_ELEMENT_CODE = "qualificationElementCode";
        public const string HASH = "hash";

        public QualificationSubscription ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationSubscription (string resourceType = "QualificationSubscription", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationSubscription> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationSubscription");
        	RestGateway gateway = (RestGateway) QualificationSubscription.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationSubscription> qualificationsubscriptionCollection = new ModelCollection<QualificationSubscription> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationsubscriptionCollection.add((QualificationSubscription) model);
        	}
        
        	return qualificationsubscriptionCollection;
        }

        public static QualificationSubscription retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationSubscription.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationSubscription) gateway.retrieve(ResourceType.QUALIFICATION_SUBSCRIPTION, id);
        }

        public string getQualificationElementType ()
        {
            return this.getProperty("qualificationElementType").ToString();
        }

        public void setQualificationElementType (string qualificationElementType)
        {
            this.setProperty("qualificationElementType", qualificationElementType);
        }

        public string getQualificationElementCode ()
        {
            return this.getProperty("qualificationElementCode").ToString();
        }

        public void setQualificationElementCode (string qualificationElementCode)
        {
            this.setProperty("qualificationElementCode", qualificationElementCode);
        }

        public string getHash ()
        {
            return this.getProperty("hash").ToString();
        }

        public void setHash (string hash)
        {
            this.setProperty("hash", hash);
        }


    }
}

