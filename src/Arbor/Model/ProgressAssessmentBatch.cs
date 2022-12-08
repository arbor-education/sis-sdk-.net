using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProgressAssessmentBatch : ModelBase
    {
        protected string resourceType = ResourceType.PROGRESS_ASSESSMENT_BATCH;
        public const string BATCH_NAME = "batchName";
        public const string ASSESSMENT = "assessment";
        public const string PROGRESS_MEASUREMENT_PERIOD_SET = "progressMeasurementPeriodSet";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string IS_BASELINE_LOCKED = "isBaselineLocked";
        public const string IS_TARGET_LOCKED = "isTargetLocked";
        public const string SHOW_RANK_ORDER = "showRankOrder";
        public const string SHOW_CURRENT_VS_BASELINE = "showCurrentVsBaseline";
        public const string SHOW_CURRENT_VS_YEAR_TARGET = "showCurrentVsYearTarget";
        public const string SHOW_CURRENT_VS_PREDICTED = "showCurrentVsPredicted";
        public const string SHOW_CURRENT_VS_PREVIOUS = "showCurrentVsPrevious";

        public ProgressAssessmentBatch()
        {
            base.resourceType = this.resourceType;
        }

        public ProgressAssessmentBatch(string resourceType = "ProgressAssessmentBatch", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ProgressAssessmentBatch> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ProgressAssessmentBatch");
            RestGateway gateway = (RestGateway)ProgressAssessmentBatch.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ProgressAssessmentBatch> progressassessmentbatchCollection = new ModelCollection<ProgressAssessmentBatch>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                progressassessmentbatchCollection.add((ProgressAssessmentBatch)model);
            }

            return progressassessmentbatchCollection;
        }

        public static ProgressAssessmentBatch retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ProgressAssessmentBatch.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ProgressAssessmentBatch)gateway.retrieve(ResourceType.PROGRESS_ASSESSMENT_BATCH, id);
        }

        public string getBatchName()
        {
            return this.getProperty("batchName").ToString();
        }

        public void setBatchName(string batchName)
        {
            this.setProperty("batchName", batchName);
        }

        public Assessment getAssessment()
        {
            return (Assessment)this.getProperty("assessment");
        }

        public void setAssessment(Assessment assessment)
        {
            this.setProperty("assessment", assessment);
        }

        public ProgressMeasurementPeriodSet getProgressMeasurementPeriodSet()
        {
            return (ProgressMeasurementPeriodSet)this.getProperty("progressMeasurementPeriodSet");
        }

        public void setProgressMeasurementPeriodSet(ProgressMeasurementPeriodSet progressMeasurementPeriodSet)
        {
            this.setProperty("progressMeasurementPeriodSet", progressMeasurementPeriodSet);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public bool getIsBaselineLocked()
        {
            return Convert.ToBoolean(this.getProperty("isBaselineLocked"));
        }

        public void setIsBaselineLocked(bool isBaselineLocked)
        {
            this.setProperty("isBaselineLocked", isBaselineLocked);
        }

        public bool getIsTargetLocked()
        {
            return Convert.ToBoolean(this.getProperty("isTargetLocked"));
        }

        public void setIsTargetLocked(bool isTargetLocked)
        {
            this.setProperty("isTargetLocked", isTargetLocked);
        }

        public bool getShowRankOrder()
        {
            return Convert.ToBoolean(this.getProperty("showRankOrder"));
        }

        public void setShowRankOrder(bool showRankOrder)
        {
            this.setProperty("showRankOrder", showRankOrder);
        }

        public bool getShowCurrentVsBaseline()
        {
            return Convert.ToBoolean(this.getProperty("showCurrentVsBaseline"));
        }

        public void setShowCurrentVsBaseline(bool showCurrentVsBaseline)
        {
            this.setProperty("showCurrentVsBaseline", showCurrentVsBaseline);
        }

        public bool getShowCurrentVsYearTarget()
        {
            return Convert.ToBoolean(this.getProperty("showCurrentVsYearTarget"));
        }

        public void setShowCurrentVsYearTarget(bool showCurrentVsYearTarget)
        {
            this.setProperty("showCurrentVsYearTarget", showCurrentVsYearTarget);
        }

        public bool getShowCurrentVsPredicted()
        {
            return Convert.ToBoolean(this.getProperty("showCurrentVsPredicted"));
        }

        public void setShowCurrentVsPredicted(bool showCurrentVsPredicted)
        {
            this.setProperty("showCurrentVsPredicted", showCurrentVsPredicted);
        }

        public bool getShowCurrentVsPrevious()
        {
            return Convert.ToBoolean(this.getProperty("showCurrentVsPrevious"));
        }

        public void setShowCurrentVsPrevious(bool showCurrentVsPrevious)
        {
            this.setProperty("showCurrentVsPrevious", showCurrentVsPrevious);
        }


    }
}

