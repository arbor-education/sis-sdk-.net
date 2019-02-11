using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class SchoolWorkforceCensus : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SCHOOL_WORKFORCE_CENSUS;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string CENSUS_YEAR = "censusYear";
        public const string CENSUS_REFERENCE_DATE = "censusReferenceDate";
        public const string CENSUS_SUBMISSION_DEADLINE_DATE = "censusSubmissionDeadlineDate";

        public SchoolWorkforceCensus ()
        {
            base.resourceType = this.resourceType;
        }
        
        public SchoolWorkforceCensus (string resourceType = "SchoolWorkforceCensus", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<SchoolWorkforceCensus> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_SchoolWorkforceCensus");
        	RestGateway gateway = (RestGateway) SchoolWorkforceCensus.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<SchoolWorkforceCensus> schoolworkforcecensusCollection = new ModelCollection<SchoolWorkforceCensus> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    schoolworkforcecensusCollection.add((SchoolWorkforceCensus) model);
        	}
        
        	return schoolworkforcecensusCollection;
        }

        public static SchoolWorkforceCensus retrieve (string id)
        {
            RestGateway gateway = (RestGateway) SchoolWorkforceCensus.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (SchoolWorkforceCensus) gateway.retrieve(ResourceType.UK_DFE_SCHOOL_WORKFORCE_CENSUS, id);
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
            return Convert.ToBoolean( this.getProperty("active"));
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

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public string getCensusYear ()
        {
            return this.getProperty("censusYear").ToString();
        }

        public void setCensusYear (string censusYear)
        {
            this.setProperty("censusYear", censusYear);
        }

        public DateTime getCensusReferenceDate (){
            return Convert.ToDateTime(this.getProperty("censusReferenceDate"));
        }

        public void setCensusReferenceDate (DateTime censusReferenceDate)
        {
            this.setProperty("censusReferenceDate", censusReferenceDate);
        }

        public DateTime getCensusSubmissionDeadlineDate (){
            return Convert.ToDateTime(this.getProperty("censusSubmissionDeadlineDate"));
        }

        public void setCensusSubmissionDeadlineDate (DateTime censusSubmissionDeadlineDate)
        {
            this.setProperty("censusSubmissionDeadlineDate", censusSubmissionDeadlineDate);
        }


    }
}

