using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationAwardSubtype : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_AWARD_SUBTYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string QUALIFICATION_AWARD_TYPE = "qualificationAwardType";
        public const string NAME = "name";

        public QualificationAwardSubtype ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationAwardSubtype (string resourceType = "QualificationAwardSubtype", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationAwardSubtype> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationAwardSubtype");
        	RestGateway gateway = (RestGateway) QualificationAwardSubtype.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationAwardSubtype> qualificationawardsubtypeCollection = new ModelCollection<QualificationAwardSubtype> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationawardsubtypeCollection.add((QualificationAwardSubtype) model);
        	}
        
        	return qualificationawardsubtypeCollection;
        }

        public static QualificationAwardSubtype retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationAwardSubtype.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationAwardSubtype) gateway.retrieve(ResourceType.QUALIFICATION_AWARD_SUBTYPE, id);
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

        public QualificationAwardType getQualificationAwardType ()
        {
            return (QualificationAwardType) this.getProperty("qualificationAwardType");
        }

        public void setQualificationAwardType (QualificationAwardType qualificationAwardType)
        {
            this.setProperty("qualificationAwardType", qualificationAwardType);
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

