using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicYearSetupTask : ModelBase
    {
        protected string resourceType = ResourceType.ACADEMIC_YEAR_SETUP_TASK;
        public const string ACADEMIC_YEAR = "academicYear";
        public const string TYPE = "type";
        public const string APPROVED_DATETIME = "approvedDatetime";
        public const string SKIPPED_DATETIME = "skippedDatetime";

        public AcademicYearSetupTask ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicYearSetupTask (string resourceType = "AcademicYearSetupTask", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicYearSetupTask> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicYearSetupTask");
        	RestGateway gateway = (RestGateway) AcademicYearSetupTask.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicYearSetupTask> academicyearsetuptaskCollection = new ModelCollection<AcademicYearSetupTask> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academicyearsetuptaskCollection.add((AcademicYearSetupTask) model);
        	}
        
        	return academicyearsetuptaskCollection;
        }

        public static AcademicYearSetupTask retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicYearSetupTask.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicYearSetupTask) gateway.retrieve(ResourceType.ACADEMIC_YEAR_SETUP_TASK, id);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public string getType ()
        {
            return this.getProperty("type").ToString();
        }

        public void setType (string type)
        {
            this.setProperty("type", type);
        }

        public DateTime getApprovedDatetime (){
            return Convert.ToDateTime(this.getProperty("approvedDatetime"));
        }

        public void setApprovedDatetime (DateTime approvedDatetime)
        {
            this.setProperty("approvedDatetime", approvedDatetime);
        }

        public DateTime getSkippedDatetime (){
            return Convert.ToDateTime(this.getProperty("skippedDatetime"));
        }

        public void setSkippedDatetime (DateTime skippedDatetime)
        {
            this.setProperty("skippedDatetime", skippedDatetime);
        }


    }
}

