using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class FacultyResponsibilityType : ModelBase
    {
        protected string resourceType = ResourceType.FACULTY_RESPONSIBILITY_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string RESPONSIBILITY_TYPE_NAME = "responsibilityTypeName";

        public FacultyResponsibilityType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public FacultyResponsibilityType (string resourceType = "FacultyResponsibilityType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<FacultyResponsibilityType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("FacultyResponsibilityType");
        	RestGateway gateway = (RestGateway) FacultyResponsibilityType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<FacultyResponsibilityType> facultyresponsibilitytypeCollection = new ModelCollection<FacultyResponsibilityType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    facultyresponsibilitytypeCollection.add((FacultyResponsibilityType) model);
        	}
        
        	return facultyresponsibilitytypeCollection;
        }

        public static FacultyResponsibilityType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) FacultyResponsibilityType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (FacultyResponsibilityType) gateway.retrieve(ResourceType.FACULTY_RESPONSIBILITY_TYPE, id);
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
            return Convert.ToBoolean(this.getProperty("active"))
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

