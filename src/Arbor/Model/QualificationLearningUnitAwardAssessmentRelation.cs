using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationLearningUnitAwardAssessmentRelation : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_LEARNING_UNIT_AWARD_ASSESSMENT_RELATION;
        public const string QUALIFICATION_AWARD_ASSESSMENT = "qualificationAwardAssessment";
        public const string QUALIFICATION_LEARNING_UNIT = "qualificationLearningUnit";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public QualificationLearningUnitAwardAssessmentRelation ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationLearningUnitAwardAssessmentRelation (string resourceType = "QualificationLearningUnitAwardAssessmentRelation", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationLearningUnitAwardAssessmentRelation> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationLearningUnitAwardAssessmentRelation");
        	RestGateway gateway = (RestGateway) QualificationLearningUnitAwardAssessmentRelation.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationLearningUnitAwardAssessmentRelation> qualificationlearningunitawardassessmentrelationCollection = new ModelCollection<QualificationLearningUnitAwardAssessmentRelation> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationlearningunitawardassessmentrelationCollection.add((QualificationLearningUnitAwardAssessmentRelation) model);
        	}
        
        	return qualificationlearningunitawardassessmentrelationCollection;
        }

        public static QualificationLearningUnitAwardAssessmentRelation retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationLearningUnitAwardAssessmentRelation.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationLearningUnitAwardAssessmentRelation) gateway.retrieve(ResourceType.QUALIFICATION_LEARNING_UNIT_AWARD_ASSESSMENT_RELATION, id);
        }

        public QualificationAwardAssessment getQualificationAwardAssessment ()
        {
            return (QualificationAwardAssessment) this.getProperty("qualificationAwardAssessment");
        }

        public void setQualificationAwardAssessment (QualificationAwardAssessment qualificationAwardAssessment)
        {
            this.setProperty("qualificationAwardAssessment", qualificationAwardAssessment);
        }

        public QualificationLearningUnit getQualificationLearningUnit ()
        {
            return (QualificationLearningUnit) this.getProperty("qualificationLearningUnit");
        }

        public void setQualificationLearningUnit (QualificationLearningUnit qualificationLearningUnit)
        {
            this.setProperty("qualificationLearningUnit", qualificationLearningUnit);
        }

        public DateTime getEffectiveDate ()
        {
            return (DateTime) this.getProperty("effectiveDate");
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return (DateTime) this.getProperty("endDate");
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

