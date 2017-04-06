using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class FacultyMember : ModelBase
    {
        protected string resourceType = ResourceType.FACULTY_MEMBER;
        public const string FACULTY = "faculty";
        public const string STAFF = "staff";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public FacultyMember ()
        {
            base.resourceType = this.resourceType;
        }
        
        public FacultyMember (string resourceType = "FacultyMember", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<FacultyMember> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("FacultyMember");
        	RestGateway gateway = (RestGateway) FacultyMember.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<FacultyMember> facultymemberCollection = new ModelCollection<FacultyMember> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    facultymemberCollection.add((FacultyMember) model);
        	}
        
        	return facultymemberCollection;
        }

        public static FacultyMember retrieve (string id)
        {
            RestGateway gateway = (RestGateway) FacultyMember.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (FacultyMember) gateway.retrieve(ResourceType.FACULTY_MEMBER, id);
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

