using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationLearningUnitLevel : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_LEARNING_UNIT_LEVEL;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";

        public QualificationLearningUnitLevel ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationLearningUnitLevel (string resourceType = "QualificationLearningUnitLevel", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationLearningUnitLevel> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationLearningUnitLevel");
        	RestGateway gateway = (RestGateway) QualificationLearningUnitLevel.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationLearningUnitLevel> qualificationlearningunitlevelCollection = new ModelCollection<QualificationLearningUnitLevel> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationlearningunitlevelCollection.add((QualificationLearningUnitLevel) model);
        	}
        
        	return qualificationlearningunitlevelCollection;
        }

        public static QualificationLearningUnitLevel retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationLearningUnitLevel.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationLearningUnitLevel) gateway.retrieve(ResourceType.QUALIFICATION_LEARNING_UNIT_LEVEL, id);
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

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }


    }
}

