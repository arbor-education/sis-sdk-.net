using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StandardizedAssessmentMark : ModelBase
    {
        protected new string resourceType = ResourceType.STANDARDIZED_ASSESSMENT_MARK;
        public const string STUDENT = "student";
        public const string STANDARDIZED_ASSESSMENT_ASPECT = "standardizedAssessmentAspect";
        public const string MARK_GRADE = "markGrade";
        public const string MARK_INTEGER = "markInteger";
        public const string MARK_DECIMAL = "markDecimal";
        public const string MARK_COMMENT = "markComment";
        public const string ASSESSMENT_DATE = "assessmentDate";
        public const string ASSESSMENT_IMPORT_ITEM = "assessmentImportItem";

        public StandardizedAssessmentMark ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StandardizedAssessmentMark (string resourceType = "StandardizedAssessmentMark", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StandardizedAssessmentMark> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StandardizedAssessmentMark");
        	RestGateway gateway = (RestGateway) StandardizedAssessmentMark.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StandardizedAssessmentMark> standardizedassessmentmarkCollection = new ModelCollection<StandardizedAssessmentMark> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    standardizedassessmentmarkCollection.add((StandardizedAssessmentMark) model);
        	}
        
        	return standardizedassessmentmarkCollection;
        }

        public static StandardizedAssessmentMark retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StandardizedAssessmentMark.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StandardizedAssessmentMark) gateway.retrieve(ResourceType.STANDARDIZED_ASSESSMENT_MARK, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public StandardizedAssessmentAspect getStandardizedAssessmentAspect ()
        {
            return (StandardizedAssessmentAspect) this.getProperty("standardizedAssessmentAspect");
        }

        public void setStandardizedAssessmentAspect (StandardizedAssessmentAspect standardizedAssessmentAspect)
        {
            this.setProperty("standardizedAssessmentAspect", standardizedAssessmentAspect);
        }

        public Grade getMarkGrade ()
        {
            return (Grade) this.getProperty("markGrade");
        }

        public void setMarkGrade (Grade markGrade)
        {
            this.setProperty("markGrade", markGrade);
        }

        public int getMarkInteger ()
        {
            return Convert.ToInt32(this.getProperty("markInteger"));
        }

        public void setMarkInteger (int markInteger)
        {
            this.setProperty("markInteger", markInteger);
        }

        public float getMarkDecimal ()
        {
            return (float) this.getProperty("markDecimal");
        }

        public void setMarkDecimal (float markDecimal)
        {
            this.setProperty("markDecimal", markDecimal);
        }

        public string getMarkComment ()
        {
            return this.getProperty("markComment").ToString();
        }

        public void setMarkComment (string markComment)
        {
            this.setProperty("markComment", markComment);
        }

        public DateTime getAssessmentDate ()
        {
            return Convert.ToDateTime(this.getProperty("assessmentDate"));
        }

        public void setAssessmentDate (DateTime assessmentDate)
        {
            this.setProperty("assessmentDate", assessmentDate);
        }

        public AssessmentImportItem getAssessmentImportItem ()
        {
            return (AssessmentImportItem) this.getProperty("assessmentImportItem");
        }

        public void setAssessmentImportItem (AssessmentImportItem assessmentImportItem)
        {
            this.setProperty("assessmentImportItem", assessmentImportItem);
        }


    }
}

