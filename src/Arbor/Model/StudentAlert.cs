using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentAlert : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_ALERT;
        public const string STAFF = "staff";
        public const string STUDENT = "student";
        public const string TYPE = "type";
        public const string ALERT_DATETIME = "alertDatetime";
        public const string PARAMS = "params";

        public StudentAlert ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentAlert (string resourceType = "StudentAlert", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentAlert> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentAlert");
        	RestGateway gateway = (RestGateway) StudentAlert.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentAlert> studentalertCollection = new ModelCollection<StudentAlert> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentalertCollection.add((StudentAlert) model);
        	}
        
        	return studentalertCollection;
        }

        public static StudentAlert retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentAlert.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentAlert) gateway.retrieve(ResourceType.STUDENT_ALERT, id);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public string getType ()
        {
            return this.getProperty("type").ToString();
        }

        public void setType (string type)
        {
            this.setProperty("type", type);
        }

        public DateTime getAlertDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("alertDatetime"));
        }

        public void setAlertDatetime (DateTime alertDatetime)
        {
            this.setProperty("alertDatetime", alertDatetime);
        }

        public string getParams ()
        {
            return this.getProperty("params").ToString();
        }

        public void setParams (string paramsData)
        {
            this.setProperty("params", paramsData);
        }


    }
}

