using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MarkApproval : ModelBase
    {
        protected string resourceType = ResourceType.MARK_APPROVAL;
        public const string MARK = "mark";
        public const string APPROVAL_LEVEL = "approvalLevel";
        public const string ASSESSMENT_DATA_COLLECTION_ITEM = "assessmentDataCollectionItem";

        public MarkApproval()
        {
            base.resourceType = this.resourceType;
        }

        public MarkApproval(string resourceType = "MarkApproval", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<MarkApproval> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("MarkApproval");
            RestGateway gateway = (RestGateway)MarkApproval.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<MarkApproval> markapprovalCollection = new ModelCollection<MarkApproval>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                markapprovalCollection.add((MarkApproval)model);
            }

            return markapprovalCollection;
        }

        public static MarkApproval retrieve(string id)
        {
            RestGateway gateway = (RestGateway)MarkApproval.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (MarkApproval)gateway.retrieve(ResourceType.MARK_APPROVAL, id);
        }

        public ModelBase getMark()
        {
            return (ModelBase)this.getProperty("mark");
        }

        public void setMark(ModelBase mark)
        {
            this.setProperty("mark", mark);
        }

        public string getApprovalLevel()
        {
            return this.getProperty("approvalLevel").ToString();
        }

        public void setApprovalLevel(string approvalLevel)
        {
            this.setProperty("approvalLevel", approvalLevel);
        }

        public AssessmentDataCollectionItem getAssessmentDataCollectionItem()
        {
            return (AssessmentDataCollectionItem)this.getProperty("assessmentDataCollectionItem");
        }

        public void setAssessmentDataCollectionItem(AssessmentDataCollectionItem assessmentDataCollectionItem)
        {
            this.setProperty("assessmentDataCollectionItem", assessmentDataCollectionItem);
        }


    }
}

