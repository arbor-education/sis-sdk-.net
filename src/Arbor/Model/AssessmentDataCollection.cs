using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentDataCollection : ModelBase
    {
        protected string resourceType = ResourceType.ASSESSMENT_DATA_COLLECTION;
        public const string DEADLINE_DATE = "deadlineDate";
        public const string COLLECTION_RANGE_START_DATE = "collectionRangeStartDate";
        public const string COLLECTION_RANGE_END_DATE = "collectionRangeEndDate";

        public AssessmentDataCollection ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentDataCollection (string resourceType = "AssessmentDataCollection", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentDataCollection> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentDataCollection");
        	RestGateway gateway = (RestGateway) AssessmentDataCollection.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentDataCollection> assessmentdatacollectionCollection = new ModelCollection<AssessmentDataCollection> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentdatacollectionCollection.add((AssessmentDataCollection) model);
        	}
        
        	return assessmentdatacollectionCollection;
        }

        public static AssessmentDataCollection retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentDataCollection.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentDataCollection) gateway.retrieve(ResourceType.ASSESSMENT_DATA_COLLECTION, id);
        }

        public DateTime getDeadlineDate ()
        {
            return Convert.ToDateTime(this.getProperty("deadlineDate"));
        }

        public void setDeadlineDate (DateTime deadlineDate)
        {
            this.setProperty("deadlineDate", deadlineDate);
        }

        public DateTime getCollectionRangeStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("collectionRangeStartDate"));
        }

        public void setCollectionRangeStartDate (DateTime collectionRangeStartDate)
        {
            this.setProperty("collectionRangeStartDate", collectionRangeStartDate);
        }

        public DateTime getCollectionRangeEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("collectionRangeEndDate"));
        }

        public void setCollectionRangeEndDate (DateTime collectionRangeEndDate)
        {
            this.setProperty("collectionRangeEndDate", collectionRangeEndDate);
        }


    }
}

