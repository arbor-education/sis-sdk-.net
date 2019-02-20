using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProfessionalQualificationSubject : ModelBase
    {
        protected string resourceType = ResourceType.PROFESSIONAL_QUALIFICATION_SUBJECT;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string SUBJECT_NAME = "subjectName";

        public ProfessionalQualificationSubject ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ProfessionalQualificationSubject (string resourceType = "ProfessionalQualificationSubject", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ProfessionalQualificationSubject> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ProfessionalQualificationSubject");
        	RestGateway gateway = (RestGateway) ProfessionalQualificationSubject.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ProfessionalQualificationSubject> professionalqualificationsubjectCollection = new ModelCollection<ProfessionalQualificationSubject> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    professionalqualificationsubjectCollection.add((ProfessionalQualificationSubject) model);
        	}
        
        	return professionalqualificationsubjectCollection;
        }

        public static ProfessionalQualificationSubject retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ProfessionalQualificationSubject.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ProfessionalQualificationSubject) gateway.retrieve(ResourceType.PROFESSIONAL_QUALIFICATION_SUBJECT, id);
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

        public string getSubjectName ()
        {
            return this.getProperty("subjectName").ToString();
        }

        public void setSubjectName (string subjectName)
        {
            this.setProperty("subjectName", subjectName);
        }


    }
}

