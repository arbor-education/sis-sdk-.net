using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProfessionalQualificationClass : ModelBase
    {
        protected string resourceType = ResourceType.PROFESSIONAL_QUALIFICATION_CLASS;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string PROFESSIONAL_QUALIFICATION_TYPE = "professionalQualificationType";
        public const string DESCRIPTION = "description";

        public ProfessionalQualificationClass ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ProfessionalQualificationClass (string resourceType = "ProfessionalQualificationClass", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ProfessionalQualificationClass> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ProfessionalQualificationClass");
        	RestGateway gateway = (RestGateway) ProfessionalQualificationClass.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ProfessionalQualificationClass> professionalqualificationclassCollection = new ModelCollection<ProfessionalQualificationClass> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    professionalqualificationclassCollection.add((ProfessionalQualificationClass) model);
        	}
        
        	return professionalqualificationclassCollection;
        }

        public static ProfessionalQualificationClass retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ProfessionalQualificationClass.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ProfessionalQualificationClass) gateway.retrieve(ResourceType.PROFESSIONAL_QUALIFICATION_CLASS, id);
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

        public ProfessionalQualificationType getProfessionalQualificationType ()
        {
            return (ProfessionalQualificationType) this.getProperty("professionalQualificationType");
        }

        public void setProfessionalQualificationType (ProfessionalQualificationType professionalQualificationType)
        {
            this.setProperty("professionalQualificationType", professionalQualificationType);
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

