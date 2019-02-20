using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class FacultyMembership : ModelBase
    {
        protected string resourceType = ResourceType.FACULTY_MEMBERSHIP;
        public const string FACULTY_RESPONSIBILITY = "facultyResponsibility";
        public const string FACULTY = "faculty";
        public const string STAFF = "staff";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public FacultyMembership ()
        {
            base.resourceType = this.resourceType;
        }
        
        public FacultyMembership (string resourceType = "FacultyMembership", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<FacultyMembership> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("FacultyMembership");
        	RestGateway gateway = (RestGateway) FacultyMembership.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<FacultyMembership> facultymembershipCollection = new ModelCollection<FacultyMembership> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    facultymembershipCollection.add((FacultyMembership) model);
        	}
        
        	return facultymembershipCollection;
        }

        public static FacultyMembership retrieve (string id)
        {
            RestGateway gateway = (RestGateway) FacultyMembership.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (FacultyMembership) gateway.retrieve(ResourceType.FACULTY_MEMBERSHIP, id);
        }

        public FacultyResponsibility getFacultyResponsibility ()
        {
            return (FacultyResponsibility) this.getProperty("facultyResponsibility");
        }

        public void setFacultyResponsibility (FacultyResponsibility facultyResponsibility)
        {
            this.setProperty("facultyResponsibility", facultyResponsibility);
        }

        public Faculty getFaculty ()
        {
            return (Faculty) this.getProperty("faculty");
        }

        public void setFaculty (Faculty faculty)
        {
            this.setProperty("faculty", faculty);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public DateTime getStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

