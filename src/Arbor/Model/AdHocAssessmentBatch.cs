using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AdHocAssessmentBatch : ModelBase
    {
        protected new string resourceType = ResourceType.AD_HOC_ASSESSMENT_BATCH;
        public const string AD_HOC_ASSESSMENT = "adHocAssessment";
        public const string PROGRESS_MEASUREMENT_PERIOD = "progressMeasurementPeriod";
        public const string ASSESSMENT_REFERENCE_DATE = "assessmentReferenceDate";

        public AdHocAssessmentBatch()
        {
            base.resourceType = this.resourceType;
        }

        public AdHocAssessmentBatch(string resourceType = "AdHocAssessmentBatch", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AdHocAssessmentBatch> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AdHocAssessmentBatch");
            RestGateway gateway = (RestGateway)AdHocAssessmentBatch.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AdHocAssessmentBatch> adhocassessmentbatchCollection = new ModelCollection<AdHocAssessmentBatch>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                adhocassessmentbatchCollection.add((AdHocAssessmentBatch)model);
            }

            return adhocassessmentbatchCollection;
        }

        public static AdHocAssessmentBatch retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AdHocAssessmentBatch.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AdHocAssessmentBatch)gateway.retrieve(ResourceType.AD_HOC_ASSESSMENT_BATCH, id);
        }

        public AdHocAssessment getAdHocAssessment()
        {
            return (AdHocAssessment)this.getProperty("adHocAssessment");
        }

        public void setAdHocAssessment(AdHocAssessment adHocAssessment)
        {
            this.setProperty("adHocAssessment", adHocAssessment);
        }

        public ProgressMeasurementPeriod getProgressMeasurementPeriod()
        {
            return (ProgressMeasurementPeriod)this.getProperty("progressMeasurementPeriod");
        }

        public void setProgressMeasurementPeriod(ProgressMeasurementPeriod progressMeasurementPeriod)
        {
            this.setProperty("progressMeasurementPeriod", progressMeasurementPeriod);
        }

        public DateTime getAssessmentReferenceDate()
        {
            return Convert.ToDateTime(this.getProperty("assessmentReferenceDate"));
        }

        public void setAssessmentReferenceDate(DateTime assessmentReferenceDate)
        {
            this.setProperty("assessmentReferenceDate", assessmentReferenceDate);
        }


    }
}

