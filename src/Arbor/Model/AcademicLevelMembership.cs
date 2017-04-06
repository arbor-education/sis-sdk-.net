using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AcademicLevelMembership : ModelBase
    {
        protected string resourceType = ResourceType.ACADEMIC_LEVEL_MEMBERSHIP;
        public const string ACADEMIC_LEVEL = "academicLevel";
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public AcademicLevelMembership ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AcademicLevelMembership (string resourceType = "AcademicLevelMembership", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AcademicLevelMembership> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AcademicLevelMembership");
        	RestGateway gateway = (RestGateway) AcademicLevelMembership.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AcademicLevelMembership> academiclevelmembershipCollection = new ModelCollection<AcademicLevelMembership> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    academiclevelmembershipCollection.add((AcademicLevelMembership) model);
        	}
        
        	return academiclevelmembershipCollection;
        }

        public static AcademicLevelMembership retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AcademicLevelMembership.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AcademicLevelMembership) gateway.retrieve(ResourceType.ACADEMIC_LEVEL_MEMBERSHIP, id);
        }

        public AcademicLevel getAcademicLevel ()
        {
            return (AcademicLevel) this.getProperty("academicLevel");
        }

        public void setAcademicLevel (AcademicLevel academicLevel)
        {
            this.setProperty("academicLevel", academicLevel);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getStartDate ()
        {
            return (DateTime) this.getProperty("startDate");
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
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

