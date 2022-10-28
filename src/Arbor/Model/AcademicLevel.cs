using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;
using System.Collections;

namespace Arbor.Model
{
    public class AcademicLevel : ModelBase
    {
        protected new string resourceType = ResourceType.ACADEMIC_LEVEL;
        public const string ACADEMIC_LEVEL_NAME = "academicLevelName";
        public const string SHORT_NAME = "shortName";
        public const string CURRICULUM_GRADE = "curriculumGrade";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string PROMOTED_TO_ACADEMIC_LEVEL = "promotedToAcademicLevel";
        public const string PROMOTED_DATETIME = "promotedDatetime";
        public const string COPIED_TO_ACADEMIC_LEVEL = "copiedToAcademicLevel";
        public const string DISPLAY_ORDER = "displayOrder";
        public const string TARGET_ENROLMENT = "targetEnrolment";

        public AcademicLevel ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicLevel (string resourceType = "AcademicLevel", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicLevel> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicLevel");
        	RestGateway gateway = (RestGateway) AcademicLevel.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicLevel> academiclevelCollection = new ModelCollection<AcademicLevel> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academiclevelCollection.add((AcademicLevel) model);
        	}
        
        	return academiclevelCollection;
        }

        public static AcademicLevel retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicLevel.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicLevel) gateway.retrieve(ResourceType.ACADEMIC_LEVEL, id);
        }

        public string getAcademicLevelName ()
        {
            return this.getProperty("academicLevelName").ToString();
        }

        public void setAcademicLevelName (string academicLevelName)
        {
            this.setProperty("academicLevelName", academicLevelName);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public CurriculumGrade getCurriculumGrade ()
        {
            return (CurriculumGrade) this.getProperty("curriculumGrade");
        }

        public void setCurriculumGrade (CurriculumGrade curriculumGrade)
        {
            this.setProperty("curriculumGrade", curriculumGrade);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public AcademicLevel getPromotedToAcademicLevel ()
        {
            return (AcademicLevel) this.getProperty("promotedToAcademicLevel");
        }

        public void setPromotedToAcademicLevel (AcademicLevel promotedToAcademicLevel)
        {
            this.setProperty("promotedToAcademicLevel", promotedToAcademicLevel);
        }

        public DateTime getPromotedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("promotedDatetime"));
        }

        public void setPromotedDatetime (DateTime promotedDatetime)
        {
            this.setProperty("promotedDatetime", promotedDatetime);
        }

        public AcademicLevel getCopiedToAcademicLevel ()
        {
            return (AcademicLevel) this.getProperty("copiedToAcademicLevel");
        }

        public void setCopiedToAcademicLevel (AcademicLevel copiedToAcademicLevel)
        {
            this.setProperty("copiedToAcademicLevel", copiedToAcademicLevel);
        }

        public int getDisplayOrder ()
        {
            return Convert.ToInt32(this.getProperty("displayOrder"));
        }

        public void setDisplayOrder (int displayOrder)
        {
            this.setProperty("displayOrder", displayOrder);
        }

        public int getTargetEnrolment ()
        {
            return Convert.ToInt32(this.getProperty("targetEnrolment"));
        }

        public void setTargetEnrolment (int targetEnrolment)
        {
            this.setProperty("targetEnrolment", targetEnrolment);
        }

        public ModelCollection<AcademicLevelTutor> getTutorMemberships ()
        {
            ModelCollection<ModelBase> collection = (ModelCollection<ModelBase>) this.getCollectionProperty("tutorMemberships");
        	return (ModelCollection<AcademicLevelTutor>) this.getApiGateway().castCollection<AcademicLevelTutor>(collection);
        }


    }
}

