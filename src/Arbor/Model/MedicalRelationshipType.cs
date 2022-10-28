using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MedicalRelationshipType : ModelBase
    {
        protected new string resourceType = ResourceType.MEDICAL_RELATIONSHIP_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string MEDICAL_RELATIONSHIP_TYPE_NAME = "medicalRelationshipTypeName";

        public MedicalRelationshipType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public MedicalRelationshipType (string resourceType = "MedicalRelationshipType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<MedicalRelationshipType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("MedicalRelationshipType");
        	RestGateway gateway = (RestGateway) MedicalRelationshipType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<MedicalRelationshipType> medicalrelationshiptypeCollection = new ModelCollection<MedicalRelationshipType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    medicalrelationshiptypeCollection.add((MedicalRelationshipType) model);
        	}
        
        	return medicalrelationshiptypeCollection;
        }

        public static MedicalRelationshipType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) MedicalRelationshipType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (MedicalRelationshipType) gateway.retrieve(ResourceType.MEDICAL_RELATIONSHIP_TYPE, id);
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

        public string getMedicalRelationshipTypeName ()
        {
            return this.getProperty("medicalRelationshipTypeName").ToString();
        }

        public void setMedicalRelationshipTypeName (string medicalRelationshipTypeName)
        {
            this.setProperty("medicalRelationshipTypeName", medicalRelationshipTypeName);
        }


    }
}

