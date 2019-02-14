using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MedicalPlan : ModelBase
    {
        protected string resourceType = ResourceType.MEDICAL_PLAN;
        public const string STUDENT = "student";
        public const string SUMMARY = "summary";
        public const string CONTENT = "content";
        public const string START_DATE = "startDate";
        public const string SCHEDULED_REVIEW_DATE = "scheduledReviewDate";
        public const string END_DATE = "endDate";

        public MedicalPlan ()
        {
            base.resourceType = this.resourceType;
        }
        
        public MedicalPlan (string resourceType = "MedicalPlan", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<MedicalPlan> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("MedicalPlan");
        	RestGateway gateway = (RestGateway) MedicalPlan.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<MedicalPlan> medicalplanCollection = new ModelCollection<MedicalPlan> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    medicalplanCollection.add((MedicalPlan) model);
        	}
        
        	return medicalplanCollection;
        }

        public static MedicalPlan retrieve (string id)
        {
            RestGateway gateway = (RestGateway) MedicalPlan.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (MedicalPlan) gateway.retrieve(ResourceType.MEDICAL_PLAN, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public string getSummary ()
        {
            return this.getProperty("summary").ToString();
        }

        public void setSummary (string summary)
        {
            this.setProperty("summary", summary);
        }

        public string getContent ()
        {
            return this.getProperty("content").ToString();
        }

        public void setContent (string content)
        {
            this.setProperty("content", content);
        }

        public DateTime getStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("startDate"))
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getScheduledReviewDate ()
        {
            return Convert.ToDateTime(this.getProperty("scheduledReviewDate"))
        }

        public void setScheduledReviewDate (DateTime scheduledReviewDate)
        {
            this.setProperty("scheduledReviewDate", scheduledReviewDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

