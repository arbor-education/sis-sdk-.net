using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DepartmentResponsibilityType : ModelBase
    {
        protected string resourceType = ResourceType.DEPARTMENT_RESPONSIBILITY_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string RESPONSIBILITY_TYPE_NAME = "responsibilityTypeName";

        public DepartmentResponsibilityType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public DepartmentResponsibilityType (string resourceType = "DepartmentResponsibilityType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<DepartmentResponsibilityType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("DepartmentResponsibilityType");
        	RestGateway gateway = (RestGateway) DepartmentResponsibilityType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<DepartmentResponsibilityType> departmentresponsibilitytypeCollection = new ModelCollection<DepartmentResponsibilityType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    departmentresponsibilitytypeCollection.add((DepartmentResponsibilityType) model);
        	}
        
        	return departmentresponsibilitytypeCollection;
        }

        public static DepartmentResponsibilityType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) DepartmentResponsibilityType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (DepartmentResponsibilityType) gateway.retrieve(ResourceType.DEPARTMENT_RESPONSIBILITY_TYPE, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return Convert.ToBoolean( this.getProperty("active"));
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getResponsibilityTypeName ()
        {
            return this.getProperty("responsibilityTypeName").ToString();
        }

        public void setResponsibilityTypeName (string responsibilityTypeName)
        {
            this.setProperty("responsibilityTypeName", responsibilityTypeName);
        }


    }
}

