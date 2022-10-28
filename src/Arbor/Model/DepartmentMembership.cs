using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DepartmentMembership : ModelBase
    {
        protected new string resourceType = ResourceType.DEPARTMENT_MEMBERSHIP;
        public const string DEPARTMENT_RESPONSIBILITY = "departmentResponsibility";
        public const string DEPARTMENT = "department";
        public const string STAFF = "staff";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public DepartmentMembership ()
        {
            base.resourceType = this.resourceType;
        }
        
        public DepartmentMembership (string resourceType = "DepartmentMembership", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<DepartmentMembership> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("DepartmentMembership");
        	RestGateway gateway = (RestGateway) DepartmentMembership.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<DepartmentMembership> departmentmembershipCollection = new ModelCollection<DepartmentMembership> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    departmentmembershipCollection.add((DepartmentMembership) model);
        	}
        
        	return departmentmembershipCollection;
        }

        public static DepartmentMembership retrieve (string id)
        {
            RestGateway gateway = (RestGateway) DepartmentMembership.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (DepartmentMembership) gateway.retrieve(ResourceType.DEPARTMENT_MEMBERSHIP, id);
        }

        public DepartmentResponsibility getDepartmentResponsibility ()
        {
            return (DepartmentResponsibility) this.getProperty("departmentResponsibility");
        }

        public void setDepartmentResponsibility (DepartmentResponsibility departmentResponsibility)
        {
            this.setProperty("departmentResponsibility", departmentResponsibility);
        }

        public Department getDepartment ()
        {
            return (Department) this.getProperty("department");
        }

        public void setDepartment (Department department)
        {
            this.setProperty("department", department);
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

