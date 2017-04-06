using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class TestModel : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_TEST_MODEL;
        public const string STUDENT = "student";
        public const string UPN = "upn";
        public const string ISSUED_ACADEMIC_YEAR = "issuedAcademicYear";
        public const string ISSUED_SERIAL_NUMBER = "issuedSerialNumber";
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string IS_TEMPORARY = "isTemporary";

        public TestModel ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TestModel (string resourceType = "TestModel", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TestModel> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_TestModel");
        	RestGateway gateway = (RestGateway) TestModel.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TestModel> testmodelCollection = new ModelCollection<TestModel> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    testmodelCollection.add((TestModel) model);
        	}
        
        	return testmodelCollection;
        }

        public static TestModel retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TestModel.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TestModel) gateway.retrieve(ResourceType.UK_DFE_TEST_MODEL, id);
        }

        public string getStudent ()
        {
            return this.getProperty("student").ToString();
        }

        public void setStudent (string student)
        {
            this.setProperty("student", student);
        }

        public string getUpn ()
        {
            return this.getProperty("upn").ToString();
        }

        public void setUpn (string upn)
        {
            this.setProperty("upn", upn);
        }

        public AcademicYear getIssuedAcademicYear ()
        {
            return (AcademicYear) this.getProperty("issuedAcademicYear");
        }

        public void setIssuedAcademicYear (AcademicYear issuedAcademicYear)
        {
            this.setProperty("issuedAcademicYear", issuedAcademicYear);
        }

        public int getIssuedSerialNumber ()
        {
            return Convert.ToInt32(this.getProperty("issuedSerialNumber"));
        }

        public void setIssuedSerialNumber (int issuedSerialNumber)
        {
            this.setProperty("issuedSerialNumber", issuedSerialNumber);
        }

        public DateTime getStartDatetime ()
        {
            return (DateTime) this.getProperty("startDatetime");
        }

        public void setStartDatetime (DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime ()
        {
            return (DateTime) this.getProperty("endDatetime");
        }

        public void setEndDatetime (DateTime endDatetime)
        {
            this.setProperty("endDatetime", endDatetime);
        }

        public bool getIsTemporary ()
        {
            return (bool) this.getProperty("isTemporary");
        }

        public void setIsTemporary (bool isTemporary)
        {
            this.setProperty("isTemporary", isTemporary);
        }


    }
}

