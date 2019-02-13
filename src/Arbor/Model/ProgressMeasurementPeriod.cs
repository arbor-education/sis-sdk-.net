using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProgressMeasurementPeriod : ModelBase
    {
        protected string resourceType = ResourceType.PROGRESS_MEASUREMENT_PERIOD;
        public const string PROGRESS_MEASUREMENT_PERIOD_SET = "progressMeasurementPeriodSet";
        public const string PERIOD_NAME = "periodName";
        public const string SHORT_NAME = "shortName";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public ProgressMeasurementPeriod ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ProgressMeasurementPeriod (string resourceType = "ProgressMeasurementPeriod", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ProgressMeasurementPeriod> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ProgressMeasurementPeriod");
        	RestGateway gateway = (RestGateway) ProgressMeasurementPeriod.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ProgressMeasurementPeriod> progressmeasurementperiodCollection = new ModelCollection<ProgressMeasurementPeriod> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    progressmeasurementperiodCollection.add((ProgressMeasurementPeriod) model);
        	}
        
        	return progressmeasurementperiodCollection;
        }

        public static ProgressMeasurementPeriod retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ProgressMeasurementPeriod.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ProgressMeasurementPeriod) gateway.retrieve(ResourceType.PROGRESS_MEASUREMENT_PERIOD, id);
        }

        public ProgressMeasurementPeriodSet getProgressMeasurementPeriodSet ()
        {
            return (ProgressMeasurementPeriodSet) this.getProperty("progressMeasurementPeriodSet");
        }

        public void setProgressMeasurementPeriodSet (ProgressMeasurementPeriodSet progressMeasurementPeriodSet)
        {
            this.setProperty("progressMeasurementPeriodSet", progressMeasurementPeriodSet);
        }

        public string getPeriodName ()
        {
            return this.getProperty("periodName").ToString();
        }

        public void setPeriodName (string periodName)
        {
            this.setProperty("periodName", periodName);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public DateTime getStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("startDate"))
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

