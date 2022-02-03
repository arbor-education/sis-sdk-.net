using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DepartmentResponsibility : ModelBase
    {
        protected string resourceType = ResourceType.DEPARTMENT_RESPONSIBILITY;
        public const string DEPARTMENT_RESPONSIBILITY_TYPE = "departmentResponsibilityType";
        public const string DEPARTMENT = "department";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public DepartmentResponsibility ()
        {
            base.resourceType = this.resourceType;
        }
        
        public DepartmentResponsibility (string resourceType = "DepartmentResponsibility", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<DepartmentResponsibility> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("DepartmentResponsibility");
        	RestGateway gateway = (RestGateway) DepartmentResponsibility.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<DepartmentResponsibility> departmentresponsibilityCollection = new ModelCollection<DepartmentResponsibility> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    departmentresponsibilityCollection.add((DepartmentResponsibility) model);
        	}
        
        	return departmentresponsibilityCollection;
        }

        public static DepartmentResponsibility retrieve (string id)
        {
            RestGateway gateway = (RestGateway) DepartmentResponsibility.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (DepartmentResponsibility) gateway.retrieve(ResourceType.DEPARTMENT_RESPONSIBILITY, id);
        }

        public DepartmentResponsibilityType getDepartmentResponsibilityType ()
        {
            return (DepartmentResponsibilityType) this.getProperty("departmentResponsibilityType");
        }

        public void setDepartmentResponsibilityType (DepartmentResponsibilityType departmentResponsibilityType)
        {
            this.setProperty("departmentResponsibilityType", departmentResponsibilityType);
        }

        public Department getDepartment ()
        {
            return (Department) this.getProperty("department");
        }

        public void setDepartment (Department department)
        {
            this.setProperty("department", department);
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

