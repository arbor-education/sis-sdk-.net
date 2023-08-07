using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AssessmentDataCollectionItemAssignedStaff : ModelBase
    {
        protected new string resourceType = ResourceType.ASSESSMENT_DATA_COLLECTION_ITEM_ASSIGNED_STAFF;
        public const string ASSESSMENT_DATA_COLLECTION_ITEM = "assessmentDataCollectionItem";
        public const string ASSIGNED_STAFF = "assignedStaff";

        public AssessmentDataCollectionItemAssignedStaff ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AssessmentDataCollectionItemAssignedStaff (string resourceType = "AssessmentDataCollectionItemAssignedStaff", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AssessmentDataCollectionItemAssignedStaff> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AssessmentDataCollectionItemAssignedStaff");
        	RestGateway gateway = (RestGateway) AssessmentDataCollectionItemAssignedStaff.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AssessmentDataCollectionItemAssignedStaff> assessmentdatacollectionitemassignedstaffCollection = new ModelCollection<AssessmentDataCollectionItemAssignedStaff> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    assessmentdatacollectionitemassignedstaffCollection.add((AssessmentDataCollectionItemAssignedStaff) model);
        	}
        
        	return assessmentdatacollectionitemassignedstaffCollection;
        }

        public static AssessmentDataCollectionItemAssignedStaff retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AssessmentDataCollectionItemAssignedStaff.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AssessmentDataCollectionItemAssignedStaff) gateway.retrieve(ResourceType.ASSESSMENT_DATA_COLLECTION_ITEM_ASSIGNED_STAFF, id);
        }

        public AssessmentDataCollectionItem getAssessmentDataCollectionItem ()
        {
            return (AssessmentDataCollectionItem) this.getProperty("assessmentDataCollectionItem");
        }

        public void setAssessmentDataCollectionItem (AssessmentDataCollectionItem assessmentDataCollectionItem)
        {
            this.setProperty("assessmentDataCollectionItem", assessmentDataCollectionItem);
        }

        public Staff getAssignedStaff ()
        {
            return (Staff) this.getProperty("assignedStaff");
        }

        public void setAssignedStaff (Staff assignedStaff)
        {
            this.setProperty("assignedStaff", assignedStaff);
        }


    }
}

