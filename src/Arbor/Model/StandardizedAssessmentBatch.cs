using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StandardizedAssessmentBatch : ModelBase
    {
        protected new string resourceType = ResourceType.STANDARDIZED_ASSESSMENT_BATCH;
        public const string ACADEMIC_YEAR = "academicYear";
        public const string BATCH_NAME = "batchName";
        public const string STANDARDIZED_ASSESSMENT_TEMPLATE = "standardizedAssessmentTemplate";
        public const string ASSESSMENT_DATE = "assessmentDate";
        public const string SEN_STUDENTS_ONLY = "senStudentsOnly";

        public StandardizedAssessmentBatch()
        {
            base.resourceType = this.resourceType;
        }

        public StandardizedAssessmentBatch(string resourceType = "StandardizedAssessmentBatch", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<StandardizedAssessmentBatch> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("StandardizedAssessmentBatch");
            RestGateway gateway = (RestGateway)StandardizedAssessmentBatch.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<StandardizedAssessmentBatch> standardizedassessmentbatchCollection = new ModelCollection<StandardizedAssessmentBatch>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                standardizedassessmentbatchCollection.add((StandardizedAssessmentBatch)model);
            }

            return standardizedassessmentbatchCollection;
        }

        public static StandardizedAssessmentBatch retrieve(string id)
        {
            RestGateway gateway = (RestGateway)StandardizedAssessmentBatch.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (StandardizedAssessmentBatch)gateway.retrieve(ResourceType.STANDARDIZED_ASSESSMENT_BATCH, id);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public string getBatchName()
        {
            return this.getProperty("batchName").ToString();
        }

        public void setBatchName(string batchName)
        {
            this.setProperty("batchName", batchName);
        }

        public StandardizedAssessmentTemplate getStandardizedAssessmentTemplate()
        {
            return (StandardizedAssessmentTemplate)this.getProperty("standardizedAssessmentTemplate");
        }

        public void setStandardizedAssessmentTemplate(StandardizedAssessmentTemplate standardizedAssessmentTemplate)
        {
            this.setProperty("standardizedAssessmentTemplate", standardizedAssessmentTemplate);
        }

        public DateTime getAssessmentDate()
        {
            return Convert.ToDateTime(this.getProperty("assessmentDate"));
        }

        public void setAssessmentDate(DateTime assessmentDate)
        {
            this.setProperty("assessmentDate", assessmentDate);
        }

        public bool getSenStudentsOnly()
        {
            return Convert.ToBoolean(this.getProperty("senStudentsOnly"));
        }

        public void setSenStudentsOnly(bool senStudentsOnly)
        {
            this.setProperty("senStudentsOnly", senStudentsOnly);
        }


    }
}

