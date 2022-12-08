using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StandardizedAssessment : ModelBase
    {
        protected string resourceType = ResourceType.STANDARDIZED_ASSESSMENT;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string ASSESSMENT_NAME = "assessmentName";
        public const string ASSESSMENT_SHORT_NAME = "assessmentShortName";
        public const string SUBJECT = "subject";
        public const string GRADE_POINT_SCALE = "gradePointScale";

        public StandardizedAssessment()
        {
            base.resourceType = this.resourceType;
        }

        public StandardizedAssessment(string resourceType = "StandardizedAssessment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StandardizedAssessment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StandardizedAssessment");
            RestGateway gateway = (RestGateway)StandardizedAssessment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StandardizedAssessment> standardizedassessmentCollection = new ModelCollection<StandardizedAssessment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                standardizedassessmentCollection.add((StandardizedAssessment)model);
            }

            return standardizedassessmentCollection;
        }

        public static StandardizedAssessment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StandardizedAssessment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StandardizedAssessment)gateway.retrieve(ResourceType.STANDARDIZED_ASSESSMENT, id);
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

        public string getAssessmentName()
        {
            return this.getProperty("assessmentName").ToString();
        }

        public void setAssessmentName(string assessmentName)
        {
            this.setProperty("assessmentName", assessmentName);
        }

        public string getAssessmentShortName()
        {
            return this.getProperty("assessmentShortName").ToString();
        }

        public void setAssessmentShortName(string assessmentShortName)
        {
            this.setProperty("assessmentShortName", assessmentShortName);
        }

        public Subject getSubject()
        {
            return (Subject)this.getProperty("subject");
        }

        public void setSubject(Subject subject)
        {
            this.setProperty("subject", subject);
        }

        public GradePointScale getGradePointScale()
        {
            return (GradePointScale)this.getProperty("gradePointScale");
        }

        public void setGradePointScale(GradePointScale gradePointScale)
        {
            this.setProperty("gradePointScale", gradePointScale);
        }


    }
}

