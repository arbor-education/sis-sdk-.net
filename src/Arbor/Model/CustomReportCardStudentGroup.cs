using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomReportCardStudentGroup : ModelBase
    {
        protected new string resourceType = ResourceType.CUSTOM_REPORT_CARD_STUDENT_GROUP;
        public const string CUSTOM_REPORT_CARD = "customReportCard";
        public const string STUDENT_GROUP = "studentGroup";
        public const string ENROLMENT_DATE = "enrolmentDate";

        public CustomReportCardStudentGroup ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomReportCardStudentGroup (string resourceType = "CustomReportCardStudentGroup", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomReportCardStudentGroup> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CustomReportCardStudentGroup");
        	RestGateway gateway = (RestGateway) CustomReportCardStudentGroup.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomReportCardStudentGroup> customreportcardstudentgroupCollection = new ModelCollection<CustomReportCardStudentGroup> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customreportcardstudentgroupCollection.add((CustomReportCardStudentGroup) model);
        	}
        
        	return customreportcardstudentgroupCollection;
        }

        public static CustomReportCardStudentGroup retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomReportCardStudentGroup.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomReportCardStudentGroup) gateway.retrieve(ResourceType.CUSTOM_REPORT_CARD_STUDENT_GROUP, id);
        }

        public CustomReportCard getCustomReportCard ()
        {
            return (CustomReportCard) this.getProperty("customReportCard");
        }

        public void setCustomReportCard (CustomReportCard customReportCard)
        {
            this.setProperty("customReportCard", customReportCard);
        }

        public ModelBase getStudentGroup ()
        {
            return (ModelBase) this.getProperty("studentGroup");
        }

        public void setStudentGroup (ModelBase studentGroup)
        {
            this.setProperty("studentGroup", studentGroup);
        }

        public DateTime getEnrolmentDate ()
        {
            return Convert.ToDateTime(this.getProperty("enrolmentDate"));
        }

        public void setEnrolmentDate (DateTime enrolmentDate)
        {
            this.setProperty("enrolmentDate", enrolmentDate);
        }


    }
}

