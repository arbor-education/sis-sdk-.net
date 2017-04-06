using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MedicalConditionType : ModelBase
    {
        protected string resourceType = ResourceType.MEDICAL_CONDITION_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string MEDICAL_CONDITION_TYPE = "medicalConditionType";
        public const string IS_ALLERGY = "isAllergy";

        public MedicalConditionType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public MedicalConditionType (string resourceType = "MedicalConditionType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<MedicalConditionType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("MedicalConditionType");
        	RestGateway gateway = (RestGateway) MedicalConditionType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<MedicalConditionType> medicalconditiontypeCollection = new ModelCollection<MedicalConditionType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    medicalconditiontypeCollection.add((MedicalConditionType) model);
        	}
        
        	return medicalconditiontypeCollection;
        }

        public static MedicalConditionType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) MedicalConditionType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (MedicalConditionType) gateway.retrieve(ResourceType.MEDICAL_CONDITION_TYPE, id);
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
            return (bool) this.getProperty("active");
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

        public string getMedicalConditionType ()
        {
            return this.getProperty("medicalConditionType").ToString();
        }

        public void setMedicalConditionType (string medicalConditionType)
        {
            this.setProperty("medicalConditionType", medicalConditionType);
        }

        public bool getIsAllergy ()
        {
            return (bool) this.getProperty("isAllergy");
        }

        public void setIsAllergy (bool isAllergy)
        {
            this.setProperty("isAllergy", isAllergy);
        }


    }
}

