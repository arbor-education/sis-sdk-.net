using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationSchemeType : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_SCHEME_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string SCHEME_TYPE_NAME = "schemeTypeName";
        public const string DESCRIPTION = "description";

        public QualificationSchemeType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationSchemeType (string resourceType = "QualificationSchemeType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationSchemeType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationSchemeType");
        	RestGateway gateway = (RestGateway) QualificationSchemeType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationSchemeType> qualificationschemetypeCollection = new ModelCollection<QualificationSchemeType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationschemetypeCollection.add((QualificationSchemeType) model);
        	}
        
        	return qualificationschemetypeCollection;
        }

        public static QualificationSchemeType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationSchemeType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationSchemeType) gateway.retrieve(ResourceType.QUALIFICATION_SCHEME_TYPE, id);
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

        public string getSchemeTypeName ()
        {
            return this.getProperty("schemeTypeName").ToString();
        }

        public void setSchemeTypeName (string schemeTypeName)
        {
            this.setProperty("schemeTypeName", schemeTypeName);
        }

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }


    }
}

