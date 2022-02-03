using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Subject : ModelBase
    {
        protected string resourceType = ResourceType.SUBJECT;
        public const string USED_IN_SWF_ONLY = "usedInSwfOnly";
        public const string USED_IN_CBDS_ONLY = "usedInCbdsOnly";
        public const string D00115 = "d00115";
        public const string D00220 = "d00220";
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string SUBJECT_NAME = "subjectName";
        public const string PARENT_SUBJECT = "parentSubject";

        public Subject ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Subject (string resourceType = "Subject", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Subject> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Subject");
        	RestGateway gateway = (RestGateway) Subject.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Subject> subjectCollection = new ModelCollection<Subject> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    subjectCollection.add((Subject) model);
        	}
        
        	return subjectCollection;
        }

        public static Subject retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Subject.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Subject) gateway.retrieve(ResourceType.SUBJECT, id);
        }

        public bool getUsedInSwfOnly ()
        {
            return Convert.ToBoolean(this.getProperty("usedInSwfOnly"));
        }

        public void setUsedInSwfOnly (bool usedInSwfOnly)
        {
            this.setProperty("usedInSwfOnly", usedInSwfOnly);
        }

        public bool getUsedInCbdsOnly ()
        {
            return Convert.ToBoolean(this.getProperty("usedInCbdsOnly"));
        }

        public void setUsedInCbdsOnly (bool usedInCbdsOnly)
        {
            this.setProperty("usedInCbdsOnly", usedInCbdsOnly);
        }

        public string getD00115 ()
        {
            return this.getProperty("d00115").ToString();
        }

        public void setD00115 (string d00115)
        {
            this.setProperty("d00115", d00115);
        }

        public string getD00220 ()
        {
            return this.getProperty("d00220").ToString();
        }

        public void setD00220 (string d00220)
        {
            this.setProperty("d00220", d00220);
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
            return Convert.ToBoolean(this.getProperty("active"));
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

        public string getSubjectName ()
        {
            return this.getProperty("subjectName").ToString();
        }

        public void setSubjectName (string subjectName)
        {
            this.setProperty("subjectName", subjectName);
        }

        public Subject getParentSubject ()
        {
            return (Subject) this.getProperty("parentSubject");
        }

        public void setParentSubject (Subject parentSubject)
        {
            this.setProperty("parentSubject", parentSubject);
        }


    }
}

