using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicLevelTutor : ModelBase
    {
        protected string resourceType = ResourceType.ACADEMIC_LEVEL_TUTOR;
        public const string ACADEMIC_LEVEL = "academicLevel";
        public const string STAFF = "staff";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public AcademicLevelTutor ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicLevelTutor (string resourceType = "AcademicLevelTutor", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicLevelTutor> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicLevelTutor");
        	RestGateway gateway = (RestGateway) AcademicLevelTutor.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicLevelTutor> academicleveltutorCollection = new ModelCollection<AcademicLevelTutor> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academicleveltutorCollection.add((AcademicLevelTutor) model);
        	}
        
        	return academicleveltutorCollection;
        }

        public static AcademicLevelTutor retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicLevelTutor.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicLevelTutor) gateway.retrieve(ResourceType.ACADEMIC_LEVEL_TUTOR, id);
        }

        public AcademicLevel getAcademicLevel ()
        {
            return (AcademicLevel) this.getProperty("academicLevel");
        }

        public void setAcademicLevel (AcademicLevel academicLevel)
        {
            this.setProperty("academicLevel", academicLevel);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public DateTime getStartDate (){
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate (){
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

