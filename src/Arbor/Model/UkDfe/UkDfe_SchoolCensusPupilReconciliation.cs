using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_SchoolCensusPupilReconciliation : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SCHOOL_CENSUS_PUPIL_RECONCILIATION;
        public const string SCHOOL_CENSUS = "schoolCensus";
        public const string PART_TIME_NOT_IN = "partTimeNotIn";
        public const string PRIVATE_STUDY = "privateStudy";
        public const string AT_OTHER_SCHOOL = "atOtherSchool";
        public const string WORK_EXPERIENCE = "workExperience";
        public const string F_E_COLLEGE = "fECollege";

        public UkDfe_SchoolCensusPupilReconciliation ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_SchoolCensusPupilReconciliation (string resourceType = "UkDfe_SchoolCensusPupilReconciliation", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_SchoolCensusPupilReconciliation> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_SchoolCensusPupilReconciliation");
        	RestGateway gateway = (RestGateway) UkDfe_SchoolCensusPupilReconciliation.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_SchoolCensusPupilReconciliation> ukdfe_schoolcensuspupilreconciliationCollection = new ModelCollection<UkDfe_SchoolCensusPupilReconciliation> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_schoolcensuspupilreconciliationCollection.add((UkDfe_SchoolCensusPupilReconciliation) model);
        	}
        
        	return ukdfe_schoolcensuspupilreconciliationCollection;
        }

        public static UkDfe_SchoolCensusPupilReconciliation retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_SchoolCensusPupilReconciliation.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_SchoolCensusPupilReconciliation) gateway.retrieve(ResourceType.UK_DFE_SCHOOL_CENSUS_PUPIL_RECONCILIATION, id);
        }

        public SchoolCensus getSchoolCensus ()
        {
            return (SchoolCensus) this.getProperty("schoolCensus");
        }

        public void setSchoolCensus (SchoolCensus schoolCensus)
        {
            this.setProperty("schoolCensus", schoolCensus);
        }

        public int getPartTimeNotIn ()
        {
            return Convert.ToInt32(this.getProperty("partTimeNotIn"));
        }

        public void setPartTimeNotIn (int partTimeNotIn)
        {
            this.setProperty("partTimeNotIn", partTimeNotIn);
        }

        public int getPrivateStudy ()
        {
            return Convert.ToInt32(this.getProperty("privateStudy"));
        }

        public void setPrivateStudy (int privateStudy)
        {
            this.setProperty("privateStudy", privateStudy);
        }

        public int getAtOtherSchool ()
        {
            return Convert.ToInt32(this.getProperty("atOtherSchool"));
        }

        public void setAtOtherSchool (int atOtherSchool)
        {
            this.setProperty("atOtherSchool", atOtherSchool);
        }

        public int getWorkExperience ()
        {
            return Convert.ToInt32(this.getProperty("workExperience"));
        }

        public void setWorkExperience (int workExperience)
        {
            this.setProperty("workExperience", workExperience);
        }

        public int getFECollege ()
        {
            return Convert.ToInt32(this.getProperty("fECollege"));
        }

        public void setFECollege (int fECollege)
        {
            this.setProperty("fECollege", fECollege);
        }


    }
}

