using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_Staff : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_STAFF;
        public const string ELIGIBLE_FOR_SCHOOL_WORKFORCE_RETURN = "eligibleForSchoolWorkforceReturn";
        public const string QUALIFIED_TEACHER_STATUS = "qualifiedTeacherStatus";
        public const string QUALIFIED_TEACHER_LEARNING_AND_SKILLS_STATUS = "qualifiedTeacherLearningAndSkillsStatus";
        public const string EARLY_YEARS_TEACHER_STATUS = "earlyYearsTeacherStatus";
        public const string QUALIFIED_TEACHER_ROUTE = "qualifiedTeacherRoute";
        public const string HLTA_STATUS = "hltaStatus";

        public UkDfe_Staff ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_Staff (string resourceType = "UkDfe_Staff", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_Staff> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_Staff");
        	RestGateway gateway = (RestGateway) UkDfe_Staff.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_Staff> ukdfe_staffCollection = new ModelCollection<UkDfe_Staff> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_staffCollection.add((UkDfe_Staff) model);
        	}
        
        	return ukdfe_staffCollection;
        }

        public static UkDfe_Staff retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_Staff.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_Staff) gateway.retrieve(ResourceType.UK_DFE_STAFF, id);
        }

        public bool getEligibleForSchoolWorkforceReturn ()
        {
            return Convert.ToBoolean(this.getProperty("eligibleForSchoolWorkforceReturn"));
        }

        public void setEligibleForSchoolWorkforceReturn (bool eligibleForSchoolWorkforceReturn)
        {
            this.setProperty("eligibleForSchoolWorkforceReturn", eligibleForSchoolWorkforceReturn);
        }

        public bool getQualifiedTeacherStatus ()
        {
            return Convert.ToBoolean(this.getProperty("qualifiedTeacherStatus"));
        }

        public void setQualifiedTeacherStatus (bool qualifiedTeacherStatus)
        {
            this.setProperty("qualifiedTeacherStatus", qualifiedTeacherStatus);
        }

        public bool getQualifiedTeacherLearningAndSkillsStatus ()
        {
            return Convert.ToBoolean(this.getProperty("qualifiedTeacherLearningAndSkillsStatus"));
        }

        public void setQualifiedTeacherLearningAndSkillsStatus (bool qualifiedTeacherLearningAndSkillsStatus)
        {
            this.setProperty("qualifiedTeacherLearningAndSkillsStatus", qualifiedTeacherLearningAndSkillsStatus);
        }

        public bool getEarlyYearsTeacherStatus ()
        {
            return Convert.ToBoolean(this.getProperty("earlyYearsTeacherStatus"));
        }

        public void setEarlyYearsTeacherStatus (bool earlyYearsTeacherStatus)
        {
            this.setProperty("earlyYearsTeacherStatus", earlyYearsTeacherStatus);
        }

        public QualifiedTeacherRoute getQualifiedTeacherRoute ()
        {
            return (QualifiedTeacherRoute) this.getProperty("qualifiedTeacherRoute");
        }

        public void setQualifiedTeacherRoute (QualifiedTeacherRoute qualifiedTeacherRoute)
        {
            this.setProperty("qualifiedTeacherRoute", qualifiedTeacherRoute);
        }

        public bool getHltaStatus ()
        {
            return Convert.ToBoolean(this.getProperty("hltaStatus"));
        }

        public void setHltaStatus (bool hltaStatus)
        {
            this.setProperty("hltaStatus", hltaStatus);
        }


    }
}
