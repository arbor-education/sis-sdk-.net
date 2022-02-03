using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CovidTestingTest : ModelBase
    {
        protected string resourceType = ResourceType.COVID_TESTING_TEST;
        public const string PERSON = "person";
        public const string TEST_TYPE = "testType";
        public const string BARCODE = "barcode";
        public const string RESULT = "result";
        public const string RESULT_DATETIME = "resultDatetime";
        public const string ADMINISTERED_BY = "administeredBy";
        public const string ADMINISTERED_DATETIME = "administeredDatetime";

        public CovidTestingTest ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CovidTestingTest (string resourceType = "CovidTestingTest", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CovidTestingTest> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CovidTestingTest");
        	RestGateway gateway = (RestGateway) CovidTestingTest.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CovidTestingTest> covidtestingtestCollection = new ModelCollection<CovidTestingTest> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    covidtestingtestCollection.add((CovidTestingTest) model);
        	}
        
        	return covidtestingtestCollection;
        }

        public static CovidTestingTest retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CovidTestingTest.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CovidTestingTest) gateway.retrieve(ResourceType.COVID_TESTING_TEST, id);
        }

        public ModelBase getPerson ()
        {
            return (ModelBase) this.getProperty("person");
        }

        public void setPerson (ModelBase person)
        {
            this.setProperty("person", person);
        }

        public string getTestType ()
        {
            return this.getProperty("testType").ToString();
        }

        public void setTestType (string testType)
        {
            this.setProperty("testType", testType);
        }

        public string getBarcode ()
        {
            return this.getProperty("barcode").ToString();
        }

        public void setBarcode (string barcode)
        {
            this.setProperty("barcode", barcode);
        }

        public string getResult ()
        {
            return this.getProperty("result").ToString();
        }

        public void setResult (string result)
        {
            this.setProperty("result", result);
        }

        public DateTime getResultDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("resultDatetime"));
        }

        public void setResultDatetime (DateTime resultDatetime)
        {
            this.setProperty("resultDatetime", resultDatetime);
        }

        public ModelBase getAdministeredBy ()
        {
            return (ModelBase) this.getProperty("administeredBy");
        }

        public void setAdministeredBy (ModelBase administeredBy)
        {
            this.setProperty("administeredBy", administeredBy);
        }

        public DateTime getAdministeredDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("administeredDatetime"));
        }

        public void setAdministeredDatetime (DateTime administeredDatetime)
        {
            this.setProperty("administeredDatetime", administeredDatetime);
        }


    }
}

