using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Department : ModelBase
    {
        protected string resourceType = ResourceType.DEPARTMENT;
        public const string DEPARTMENT_CODE = "departmentCode";
        public const string DEPARTMENT_NAME = "departmentName";
        public const string IS_ACTIVE = "isActive";

        public Department ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Department (string resourceType = "Department", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Department> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Department");
        	RestGateway gateway = (RestGateway) Department.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Department> departmentCollection = new ModelCollection<Department> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    departmentCollection.add((Department) model);
        	}
        
        	return departmentCollection;
        }

        public static Department retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Department.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Department) gateway.retrieve(ResourceType.DEPARTMENT, id);
        }

        public string getDepartmentCode ()
        {
            return this.getProperty("departmentCode").ToString();
        }

        public void setDepartmentCode (string departmentCode)
        {
            this.setProperty("departmentCode", departmentCode);
        }

        public string getDepartmentName ()
        {
            return this.getProperty("departmentName").ToString();
        }

        public void setDepartmentName (string departmentName)
        {
            this.setProperty("departmentName", departmentName);
        }

        public bool getIsActive ()
        {
            return Convert.ToBoolean( this.getProperty("isActive"));
        }

        public void setIsActive (bool isActive)
        {
            this.setProperty("isActive", isActive);
        }


    }
}

