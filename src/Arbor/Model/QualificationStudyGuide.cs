using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationStudyGuide : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_STUDY_GUIDE;
        public const string RELATED_QUALIFICATION_AWARD = "relatedQualificationAward";
        public const string STUDY_GUIDE_TITLE = "studyGuideTitle";
        public const string STUDY_GUIDE_PUBLISHER_NAME = "studyGuidePublisherName";
        public const string STUDY_GUIDE_PUBLISHER_ISBN = "studyGuidePublisherIsbn";
        public const string STUDY_GUIDE_PUBLISHER_URL = "studyGuidePublisherUrl";
        public const string STUDY_GUIDE_MEDIUM_TYPE = "studyGuideMediumType";

        public QualificationStudyGuide ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationStudyGuide (string resourceType = "QualificationStudyGuide", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationStudyGuide> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationStudyGuide");
        	RestGateway gateway = (RestGateway) QualificationStudyGuide.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationStudyGuide> qualificationstudyguideCollection = new ModelCollection<QualificationStudyGuide> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationstudyguideCollection.add((QualificationStudyGuide) model);
        	}
        
        	return qualificationstudyguideCollection;
        }

        public static QualificationStudyGuide retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationStudyGuide.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationStudyGuide) gateway.retrieve(ResourceType.QUALIFICATION_STUDY_GUIDE, id);
        }

        public QualificationAward getRelatedQualificationAward ()
        {
            return (QualificationAward) this.getProperty("relatedQualificationAward");
        }

        public void setRelatedQualificationAward (QualificationAward relatedQualificationAward)
        {
            this.setProperty("relatedQualificationAward", relatedQualificationAward);
        }

        public string getStudyGuideTitle ()
        {
            return this.getProperty("studyGuideTitle").ToString();
        }

        public void setStudyGuideTitle (string studyGuideTitle)
        {
            this.setProperty("studyGuideTitle", studyGuideTitle);
        }

        public string getStudyGuidePublisherName ()
        {
            return this.getProperty("studyGuidePublisherName").ToString();
        }

        public void setStudyGuidePublisherName (string studyGuidePublisherName)
        {
            this.setProperty("studyGuidePublisherName", studyGuidePublisherName);
        }

        public string getStudyGuidePublisherIsbn ()
        {
            return this.getProperty("studyGuidePublisherIsbn").ToString();
        }

        public void setStudyGuidePublisherIsbn (string studyGuidePublisherIsbn)
        {
            this.setProperty("studyGuidePublisherIsbn", studyGuidePublisherIsbn);
        }

        public string getStudyGuidePublisherUrl ()
        {
            return this.getProperty("studyGuidePublisherUrl").ToString();
        }

        public void setStudyGuidePublisherUrl (string studyGuidePublisherUrl)
        {
            this.setProperty("studyGuidePublisherUrl", studyGuidePublisherUrl);
        }

        public string getStudyGuideMediumType ()
        {
            return this.getProperty("studyGuideMediumType").ToString();
        }

        public void setStudyGuideMediumType (string studyGuideMediumType)
        {
            this.setProperty("studyGuideMediumType", studyGuideMediumType);
        }


    }
}

