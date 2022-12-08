using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StandardizedAssessmentAspect : ModelBase
    {
        protected string resourceType = ResourceType.STANDARDIZED_ASSESSMENT_ASPECT;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string STANDARDIZED_ASSESSMENT_ASPECT_CATEGORY = "standardizedAssessmentAspectCategory";
        public const string STANDARDIZED_ASSESSMENT_COMPONENT = "standardizedAssessmentComponent";
        public const string MARK_TYPE = "markType";
        public const string MARK_MIN_VALUE = "markMinValue";
        public const string MARK_MAX_VALUE = "markMaxValue";
        public const string GRADE_SET = "gradeSet";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public StandardizedAssessmentAspect()
        {
            base.resourceType = this.resourceType;
        }

        public StandardizedAssessmentAspect(string resourceType = "StandardizedAssessmentAspect", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StandardizedAssessmentAspect> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StandardizedAssessmentAspect");
            RestGateway gateway = (RestGateway)StandardizedAssessmentAspect.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StandardizedAssessmentAspect> standardizedassessmentaspectCollection = new ModelCollection<StandardizedAssessmentAspect>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                standardizedassessmentaspectCollection.add((StandardizedAssessmentAspect)model);
            }

            return standardizedassessmentaspectCollection;
        }

        public static StandardizedAssessmentAspect retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StandardizedAssessmentAspect.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StandardizedAssessmentAspect)gateway.retrieve(ResourceType.STANDARDIZED_ASSESSMENT_ASPECT, id);
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

        public StandardizedAssessmentAspectCategory getStandardizedAssessmentAspectCategory()
        {
            return (StandardizedAssessmentAspectCategory)this.getProperty("standardizedAssessmentAspectCategory");
        }

        public void setStandardizedAssessmentAspectCategory(StandardizedAssessmentAspectCategory standardizedAssessmentAspectCategory)
        {
            this.setProperty("standardizedAssessmentAspectCategory", standardizedAssessmentAspectCategory);
        }

        public StandardizedAssessmentComponent getStandardizedAssessmentComponent()
        {
            return (StandardizedAssessmentComponent)this.getProperty("standardizedAssessmentComponent");
        }

        public void setStandardizedAssessmentComponent(StandardizedAssessmentComponent standardizedAssessmentComponent)
        {
            this.setProperty("standardizedAssessmentComponent", standardizedAssessmentComponent);
        }

        public string getMarkType()
        {
            return this.getProperty("markType").ToString();
        }

        public void setMarkType(string markType)
        {
            this.setProperty("markType", markType);
        }

        public float getMarkMinValue()
        {
            return (float)this.getProperty("markMinValue");
        }

        public void setMarkMinValue(float markMinValue)
        {
            this.setProperty("markMinValue", markMinValue);
        }

        public float getMarkMaxValue()
        {
            return (float)this.getProperty("markMaxValue");
        }

        public void setMarkMaxValue(float markMaxValue)
        {
            this.setProperty("markMaxValue", markMaxValue);
        }

        public GradeSet getGradeSet()
        {
            return (GradeSet)this.getProperty("gradeSet");
        }

        public void setGradeSet(GradeSet gradeSet)
        {
            this.setProperty("gradeSet", gradeSet);
        }

        public DateTime getEffectiveDate()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate(DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate(DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

