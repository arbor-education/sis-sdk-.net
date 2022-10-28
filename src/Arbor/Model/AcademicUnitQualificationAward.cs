using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicUnitQualificationAward : ModelBase
    {
        protected new string resourceType = ResourceType.ACADEMIC_UNIT_QUALIFICATION_AWARD;
        public const string ACADEMIC_UNIT = "academicUnit";
        public const string QUALIFICATION_AWARD = "qualificationAward";

        public AcademicUnitQualificationAward ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicUnitQualificationAward (string resourceType = "AcademicUnitQualificationAward", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicUnitQualificationAward> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicUnitQualificationAward");
        	RestGateway gateway = (RestGateway) AcademicUnitQualificationAward.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicUnitQualificationAward> academicunitqualificationawardCollection = new ModelCollection<AcademicUnitQualificationAward> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academicunitqualificationawardCollection.add((AcademicUnitQualificationAward) model);
        	}
        
        	return academicunitqualificationawardCollection;
        }

        public static AcademicUnitQualificationAward retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicUnitQualificationAward.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicUnitQualificationAward) gateway.retrieve(ResourceType.ACADEMIC_UNIT_QUALIFICATION_AWARD, id);
        }

        public AcademicUnit getAcademicUnit ()
        {
            return (AcademicUnit) this.getProperty("academicUnit");
        }

        public void setAcademicUnit (AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }

        public QualificationAward getQualificationAward ()
        {
            return (QualificationAward) this.getProperty("qualificationAward");
        }

        public void setQualificationAward (QualificationAward qualificationAward)
        {
            this.setProperty("qualificationAward", qualificationAward);
        }


    }
}

