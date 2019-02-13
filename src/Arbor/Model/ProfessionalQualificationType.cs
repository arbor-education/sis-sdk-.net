using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProfessionalQualificationType : ModelBase
    {
        protected string resourceType = ResourceType.PROFESSIONAL_QUALIFICATION_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string DESCRIPTION = "description";
        public const string IS_VOCATIONAL_QUALIFICATION = "isVocationalQualification";

        public ProfessionalQualificationType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ProfessionalQualificationType (string resourceType = "ProfessionalQualificationType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ProfessionalQualificationType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ProfessionalQualificationType");
        	RestGateway gateway = (RestGateway) ProfessionalQualificationType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ProfessionalQualificationType> professionalqualificationtypeCollection = new ModelCollection<ProfessionalQualificationType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    professionalqualificationtypeCollection.add((ProfessionalQualificationType) model);
        	}
        
        	return professionalqualificationtypeCollection;
        }

        public static ProfessionalQualificationType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ProfessionalQualificationType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ProfessionalQualificationType) gateway.retrieve(ResourceType.PROFESSIONAL_QUALIFICATION_TYPE, id);
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

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }

        public bool getIsVocationalQualification ()
        {
            return Convert.ToBoolean(this.getProperty("isVocationalQualification"))
        }

        public void setIsVocationalQualification (bool isVocationalQualification)
        {
            this.setProperty("isVocationalQualification", isVocationalQualification);
        }


    }
}

