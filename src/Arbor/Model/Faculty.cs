using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Faculty : ModelBase
    {
        protected string resourceType = ResourceType.FACULTY;
        public const string CODE = "code";
        public const string FACULTY_NAME = "facultyName";
        public const string IS_ACTIVE = "isActive";

        public Faculty ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Faculty (string resourceType = "Faculty", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Faculty> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Faculty");
        	RestGateway gateway = (RestGateway) Faculty.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Faculty> facultyCollection = new ModelCollection<Faculty> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    facultyCollection.add((Faculty) model);
        	}
        
        	return facultyCollection;
        }

        public static Faculty retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Faculty.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Faculty) gateway.retrieve(ResourceType.FACULTY, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public string getFacultyName ()
        {
            return this.getProperty("facultyName").ToString();
        }

        public void setFacultyName (string facultyName)
        {
            this.setProperty("facultyName", facultyName);
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

