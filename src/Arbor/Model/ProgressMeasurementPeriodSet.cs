using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProgressMeasurementPeriodSet : ModelBase
    {
        protected new string resourceType = ResourceType.PROGRESS_MEASUREMENT_PERIOD_SET;
        public const string PERIOD_FREQUENCY = "periodFrequency";
        public const string SET_NAME = "setName";
        public const string ACADEMIC_YEAR = "academicYear";

        public ProgressMeasurementPeriodSet()
        {
            base.resourceType = this.resourceType;
        }

        public ProgressMeasurementPeriodSet(string resourceType = "ProgressMeasurementPeriodSet", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ProgressMeasurementPeriodSet> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ProgressMeasurementPeriodSet");
            RestGateway gateway = (RestGateway)ProgressMeasurementPeriodSet.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ProgressMeasurementPeriodSet> progressmeasurementperiodsetCollection = new ModelCollection<ProgressMeasurementPeriodSet>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                progressmeasurementperiodsetCollection.add((ProgressMeasurementPeriodSet)model);
            }

            return progressmeasurementperiodsetCollection;
        }

        public static ProgressMeasurementPeriodSet retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ProgressMeasurementPeriodSet.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ProgressMeasurementPeriodSet)gateway.retrieve(ResourceType.PROGRESS_MEASUREMENT_PERIOD_SET, id);
        }

        public string getPeriodFrequency()
        {
            return this.getProperty("periodFrequency").ToString();
        }

        public void setPeriodFrequency(string periodFrequency)
        {
            this.setProperty("periodFrequency", periodFrequency);
        }

        public string getSetName()
        {
            return this.getProperty("setName").ToString();
        }

        public void setSetName(string setName)
        {
            this.setProperty("setName", setName);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }


    }
}

