using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationSchemeAwardRelation : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_SCHEME_AWARD_RELATION;
        public const string QUALIFICATION_SCHEME = "qualificationScheme";
        public const string QUALIFICATION_AWARD = "qualificationAward";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public QualificationSchemeAwardRelation ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationSchemeAwardRelation (string resourceType = "QualificationSchemeAwardRelation", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationSchemeAwardRelation> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationSchemeAwardRelation");
        	RestGateway gateway = (RestGateway) QualificationSchemeAwardRelation.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationSchemeAwardRelation> qualificationschemeawardrelationCollection = new ModelCollection<QualificationSchemeAwardRelation> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationschemeawardrelationCollection.add((QualificationSchemeAwardRelation) model);
        	}
        
        	return qualificationschemeawardrelationCollection;
        }

        public static QualificationSchemeAwardRelation retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationSchemeAwardRelation.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationSchemeAwardRelation) gateway.retrieve(ResourceType.QUALIFICATION_SCHEME_AWARD_RELATION, id);
        }

        public QualificationScheme getQualificationScheme ()
        {
            return (QualificationScheme) this.getProperty("qualificationScheme");
        }

        public void setQualificationScheme (QualificationScheme qualificationScheme)
        {
            this.setProperty("qualificationScheme", qualificationScheme);
        }

        public QualificationAward getQualificationAward ()
        {
            return (QualificationAward) this.getProperty("qualificationAward");
        }

        public void setQualificationAward (QualificationAward qualificationAward)
        {
            this.setProperty("qualificationAward", qualificationAward);
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

