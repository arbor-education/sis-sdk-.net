using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_SchoolCensus : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SCHOOL_CENSUS;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string SCHOOL_CENSUS_YEAR = "schoolCensusYear";
        public const string SCHOOL_CENSUS_TERM = "schoolCensusTerm";
        public const string SCHOOL_CENSUS_REFERENCE_DATE = "schoolCensusReferenceDate";
        public const string SCHOOL_CENSUS_RETURN_DEADLINE_DATE = "schoolCensusReturnDeadlineDate";
        public const string SCHOOL_CENSUS_DATABASE_CLOSURE_DATE = "schoolCensusDatabaseClosureDate";
        public const string SCHOOL_CENSUS_SPECIFIC_TIME = "schoolCensusSpecificTime";

        public UkDfe_SchoolCensus ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_SchoolCensus (string resourceType = "UkDfe_SchoolCensus", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_SchoolCensus> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_SchoolCensus");
        	RestGateway gateway = (RestGateway) UkDfe_SchoolCensus.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_SchoolCensus> ukdfe_schoolcensusCollection = new ModelCollection<UkDfe_SchoolCensus> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_schoolcensusCollection.add((UkDfe_SchoolCensus) model);
        	}
        
        	return ukdfe_schoolcensusCollection;
        }

        public static UkDfe_SchoolCensus retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_SchoolCensus.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_SchoolCensus) gateway.retrieve(ResourceType.UK_DFE_SCHOOL_CENSUS, id);
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

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public string getSchoolCensusYear ()
        {
            return this.getProperty("schoolCensusYear").ToString();
        }

        public void setSchoolCensusYear (string schoolCensusYear)
        {
            this.setProperty("schoolCensusYear", schoolCensusYear);
        }

        public string getSchoolCensusTerm ()
        {
            return this.getProperty("schoolCensusTerm").ToString();
        }

        public void setSchoolCensusTerm (string schoolCensusTerm)
        {
            this.setProperty("schoolCensusTerm", schoolCensusTerm);
        }

        public DateTime getSchoolCensusReferenceDate ()
        {
            return Convert.ToDateTime(this.getProperty("schoolCensusReferenceDate"))
        }

        public void setSchoolCensusReferenceDate (DateTime schoolCensusReferenceDate)
        {
            this.setProperty("schoolCensusReferenceDate", schoolCensusReferenceDate);
        }

        public DateTime getSchoolCensusReturnDeadlineDate ()
        {
            return Convert.ToDateTime(this.getProperty("schoolCensusReturnDeadlineDate"))
        }

        public void setSchoolCensusReturnDeadlineDate (DateTime schoolCensusReturnDeadlineDate)
        {
            this.setProperty("schoolCensusReturnDeadlineDate", schoolCensusReturnDeadlineDate);
        }

        public DateTime getSchoolCensusDatabaseClosureDate ()
        {
            return Convert.ToDateTime(this.getProperty("schoolCensusDatabaseClosureDate"))
        }

        public void setSchoolCensusDatabaseClosureDate (DateTime schoolCensusDatabaseClosureDate)
        {
            this.setProperty("schoolCensusDatabaseClosureDate", schoolCensusDatabaseClosureDate);
        }

        public DateTime getSchoolCensusSpecificTime ()
        {
            return Convert.ToDateTime(this.getProperty("schoolCensusSpecificTime"))
        }

        public void setSchoolCensusSpecificTime (DateTime schoolCensusSpecificTime)
        {
            this.setProperty("schoolCensusSpecificTime", schoolCensusSpecificTime);
        }


    }
}

