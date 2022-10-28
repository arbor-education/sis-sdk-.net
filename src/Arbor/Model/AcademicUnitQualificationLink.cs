using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicUnitQualificationLink : ModelBase
    {
        protected new string resourceType = ResourceType.ACADEMIC_UNIT_QUALIFICATION_LINK;
        public const string ACADEMIC_UNIT = "academicUnit";
        public const string QUALIFICATION_ASSESSABLE = "qualificationAssessable";
        public const string AUTOMATIC_ENTRY = "automaticEntry";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public AcademicUnitQualificationLink ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicUnitQualificationLink (string resourceType = "AcademicUnitQualificationLink", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicUnitQualificationLink> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicUnitQualificationLink");
        	RestGateway gateway = (RestGateway) AcademicUnitQualificationLink.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicUnitQualificationLink> academicunitqualificationlinkCollection = new ModelCollection<AcademicUnitQualificationLink> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academicunitqualificationlinkCollection.add((AcademicUnitQualificationLink) model);
        	}
        
        	return academicunitqualificationlinkCollection;
        }

        public static AcademicUnitQualificationLink retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicUnitQualificationLink.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicUnitQualificationLink) gateway.retrieve(ResourceType.ACADEMIC_UNIT_QUALIFICATION_LINK, id);
        }

        public AcademicUnit getAcademicUnit ()
        {
            return (AcademicUnit) this.getProperty("academicUnit");
        }

        public void setAcademicUnit (AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }

        public QualificationAssessable getQualificationAssessable ()
        {
            return (QualificationAssessable) this.getProperty("qualificationAssessable");
        }

        public void setQualificationAssessable (QualificationAssessable qualificationAssessable)
        {
            this.setProperty("qualificationAssessable", qualificationAssessable);
        }

        public bool getAutomaticEntry ()
        {
            return Convert.ToBoolean(this.getProperty("automaticEntry"));
        }

        public void setAutomaticEntry (bool automaticEntry)
        {
            this.setProperty("automaticEntry", automaticEntry);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

