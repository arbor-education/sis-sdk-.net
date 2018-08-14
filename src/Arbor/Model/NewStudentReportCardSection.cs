using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class NewStudentReportCardSection : ModelBase
    {
        protected string resourceType = ResourceType.NEW_STUDENT_REPORT_CARD_SECTION;
        public const string STUDENT_REPORT_CARD = "studentReportCard";
        public const string LINKED_ENTITY = "linkedEntity";
        public const string COMPLETED_DATETIME = "completedDatetime";
        public const string APPROVED_DATETIME = "approvedDatetime";

        public NewStudentReportCardSection ()
        {
            base.resourceType = this.resourceType;
        }
        
        public NewStudentReportCardSection (string resourceType = "NewStudentReportCardSection", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<NewStudentReportCardSection> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("NewStudentReportCardSection");
        	RestGateway gateway = (RestGateway) NewStudentReportCardSection.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<NewStudentReportCardSection> newstudentreportcardsectionCollection = new ModelCollection<NewStudentReportCardSection> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    newstudentreportcardsectionCollection.add((NewStudentReportCardSection) model);
        	}
        
        	return newstudentreportcardsectionCollection;
        }

        public static NewStudentReportCardSection retrieve (string id)
        {
            RestGateway gateway = (RestGateway) NewStudentReportCardSection.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (NewStudentReportCardSection) gateway.retrieve(ResourceType.NEW_STUDENT_REPORT_CARD_SECTION, id);
        }

        public NewStudentReportCard getStudentReportCard ()
        {
            return (NewStudentReportCard) this.getProperty("studentReportCard");
        }

        public void setStudentReportCard (NewStudentReportCard studentReportCard)
        {
            this.setProperty("studentReportCard", studentReportCard);
        }

        public ModelBase getLinkedEntity ()
        {
            return (ModelBase) this.getProperty("linkedEntity");
        }

        public void setLinkedEntity (ModelBase linkedEntity)
        {
            this.setProperty("linkedEntity", linkedEntity);
        }

        public DateTime getCompletedDatetime (){
            return Convert.ToDateTime(this.getProperty("completedDatetime"));
        }

        public void setCompletedDatetime (DateTime completedDatetime)
        {
            this.setProperty("completedDatetime", completedDatetime);
        }

        public DateTime getApprovedDatetime (){
            return Convert.ToDateTime(this.getProperty("approvedDatetime"));
        }

        public void setApprovedDatetime (DateTime approvedDatetime)
        {
            this.setProperty("approvedDatetime", approvedDatetime);
        }


    }
}

