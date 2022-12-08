using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class VisionTest : ModelBase
    {
        protected string resourceType = ResourceType.VISION_TEST;
        public const string STUDENT = "student";
        public const string TEST_DATE = "testDate";
        public const string COLOR_BLINDNESS = "colorBlindness";
        public const string NOTES = "notes";

        public VisionTest()
        {
            base.resourceType = this.resourceType;
        }

        public VisionTest(string resourceType = "VisionTest", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<VisionTest> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("VisionTest");
            RestGateway gateway = (RestGateway)VisionTest.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<VisionTest> visiontestCollection = new ModelCollection<VisionTest>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                visiontestCollection.add((VisionTest)model);
            }

            return visiontestCollection;
        }

        public static VisionTest retrieve(string id)
        {
            RestGateway gateway = (RestGateway)VisionTest.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (VisionTest)gateway.retrieve(ResourceType.VISION_TEST, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getTestDate()
        {
            return Convert.ToDateTime(this.getProperty("testDate"));
        }

        public void setTestDate(DateTime testDate)
        {
            this.setProperty("testDate", testDate);
        }

        public string getColorBlindness()
        {
            return this.getProperty("colorBlindness").ToString();
        }

        public void setColorBlindness(string colorBlindness)
        {
            this.setProperty("colorBlindness", colorBlindness);
        }

        public string getNotes()
        {
            return this.getProperty("notes").ToString();
        }

        public void setNotes(string notes)
        {
            this.setProperty("notes", notes);
        }


    }
}

