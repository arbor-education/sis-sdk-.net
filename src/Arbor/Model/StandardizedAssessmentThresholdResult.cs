using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StandardizedAssessmentThresholdResult : ModelBase
    {
        protected new string resourceType = ResourceType.STANDARDIZED_ASSESSMENT_THRESHOLD_RESULT;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string STANDARDIZED_ASSESSMENT_THRESHOLD = "standardizedAssessmentThreshold";
        public const string LOWER_RESULT_VALUE = "lowerResultValue";
        public const string UPPER_RESULT_VALUE = "upperResultValue";
        public const string GRADE = "grade";

        public StandardizedAssessmentThresholdResult()
        {
            base.resourceType = this.resourceType;
        }

        public StandardizedAssessmentThresholdResult(string resourceType = "StandardizedAssessmentThresholdResult", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StandardizedAssessmentThresholdResult> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StandardizedAssessmentThresholdResult");
            RestGateway gateway = (RestGateway)StandardizedAssessmentThresholdResult.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StandardizedAssessmentThresholdResult> standardizedassessmentthresholdresultCollection = new ModelCollection<StandardizedAssessmentThresholdResult>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                standardizedassessmentthresholdresultCollection.add((StandardizedAssessmentThresholdResult)model);
            }

            return standardizedassessmentthresholdresultCollection;
        }

        public static StandardizedAssessmentThresholdResult retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StandardizedAssessmentThresholdResult.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StandardizedAssessmentThresholdResult)gateway.retrieve(ResourceType.STANDARDIZED_ASSESSMENT_THRESHOLD_RESULT, id);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive(bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder(int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public StandardizedAssessmentThreshold getStandardizedAssessmentThreshold()
        {
            return (StandardizedAssessmentThreshold)this.getProperty("standardizedAssessmentThreshold");
        }

        public void setStandardizedAssessmentThreshold(StandardizedAssessmentThreshold standardizedAssessmentThreshold)
        {
            this.setProperty("standardizedAssessmentThreshold", standardizedAssessmentThreshold);
        }

        public float getLowerResultValue()
        {
            return (float)this.getProperty("lowerResultValue");
        }

        public void setLowerResultValue(float lowerResultValue)
        {
            this.setProperty("lowerResultValue", lowerResultValue);
        }

        public float getUpperResultValue()
        {
            return (float)this.getProperty("upperResultValue");
        }

        public void setUpperResultValue(float upperResultValue)
        {
            this.setProperty("upperResultValue", upperResultValue);
        }

        public Grade getGrade()
        {
            return (Grade)this.getProperty("grade");
        }

        public void setGrade(Grade grade)
        {
            this.setProperty("grade", grade);
        }


    }
}

