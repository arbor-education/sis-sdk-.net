using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomGroup : ModelBase
    {
        protected string resourceType = ResourceType.CUSTOM_GROUP;
        public const string CUSTOM_GROUP_NAME = "customGroupName";
        public const string DESCRIPTION = "description";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string CONTAINS_STUDENTS = "containsStudents";
        public const string CONTAINS_GUARDIANS = "containsGuardians";
        public const string CONTAINS_STAFF = "containsStaff";
        public const string IS_DYNAMIC = "isDynamic";

        public CustomGroup ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CustomGroup (string resourceType = "CustomGroup", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CustomGroup> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CustomGroup");
        	RestGateway gateway = (RestGateway) CustomGroup.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CustomGroup> customgroupCollection = new ModelCollection<CustomGroup> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    customgroupCollection.add((CustomGroup) model);
        	}
        
        	return customgroupCollection;
        }

        public static CustomGroup retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CustomGroup.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CustomGroup) gateway.retrieve(ResourceType.CUSTOM_GROUP, id);
        }

        public string getCustomGroupName ()
        {
            return this.getProperty("customGroupName").ToString();
        }

        public void setCustomGroupName (string customGroupName)
        {
            this.setProperty("customGroupName", customGroupName);
        }

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public string getContainsStudents ()
        {
            return this.getProperty("containsStudents").ToString();
        }

        public void setContainsStudents (string containsStudents)
        {
            this.setProperty("containsStudents", containsStudents);
        }

        public string getContainsGuardians ()
        {
            return this.getProperty("containsGuardians").ToString();
        }

        public void setContainsGuardians (string containsGuardians)
        {
            this.setProperty("containsGuardians", containsGuardians);
        }

        public string getContainsStaff ()
        {
            return this.getProperty("containsStaff").ToString();
        }

        public void setContainsStaff (string containsStaff)
        {
            this.setProperty("containsStaff", containsStaff);
        }

        public bool getIsDynamic ()
        {
            return Convert.ToBoolean(this.getProperty("isDynamic"));
        }

        public void setIsDynamic (bool isDynamic)
        {
            this.setProperty("isDynamic", isDynamic);
        }


    }
}

