using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class HearingTest : ModelBase
    {
        protected string resourceType = ResourceType.HEARING_TEST;
        public const string STUDENT = "student";
        public const string TEST_DATE = "testDate";
        public const string NOTES = "notes";

        public HearingTest ()
        {
            base.resourceType = this.resourceType;
        }
        
        public HearingTest (string resourceType = "HearingTest", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<HearingTest> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("HearingTest");
        	RestGateway gateway = (RestGateway) HearingTest.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<HearingTest> hearingtestCollection = new ModelCollection<HearingTest> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    hearingtestCollection.add((HearingTest) model);
        	}
        
        	return hearingtestCollection;
        }

        public static HearingTest retrieve (string id)
        {
            RestGateway gateway = (RestGateway) HearingTest.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (HearingTest) gateway.retrieve(ResourceType.HEARING_TEST, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getTestDate ()
        {
            return Convert.ToDateTime(this.getProperty("testDate"))
        }

        public void setTestDate (DateTime testDate)
        {
            this.setProperty("testDate", testDate);
        }

        public string getNotes ()
        {
            return this.getProperty("notes").ToString();
        }

        public void setNotes (string notes)
        {
            this.setProperty("notes", notes);
        }


    }
}

