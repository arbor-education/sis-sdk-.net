using System;
using Arbor.Api.Gateway;
using Arbor.Model;
using Arbor.Query;
using Arbor.Resource;
using Arbor.Model.Api;
using Newtonsoft.Json.Linq;
using System.Xml;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Arbor.ChangeLog;
using Arbor.Tools.Services;
using Arbor.Service;


namespace ArborSdkExamples
{
    class MainClass
    {
        /**
		 * Copy "config-dist.xml" to "config.xml", then set your
		 * api  credentials into it.
		 */
        static string USERNAME = "";
        static string PASSWORD = "";
        static string URL = "";
        const string USER_AGENT = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/57.0.2987.133 Safari/537.36";

        public static void Main(string[] args)
        {
            XmlDocument conf = new XmlDocument();
            string confPath = Environment.CurrentDirectory + @"\..\..\config-dist.xml";
            conf.Load(confPath);
            USERNAME = conf["config"]["api"]["auth"]["user"].InnerText;
            PASSWORD = conf["config"]["api"]["auth"]["password"].InnerText;
            URL = conf["config"]["api"]["baseUrl"].InnerText;

            Console.WriteLine("Arbor SDK EXAMPLES");

            #region Test Methods

            //// Retrieve model
            //MainClass.studentRetrieve(ResourceType.STUDENT, "1");

            //// Query for students
            //MainClass.studentQueryViaStaticMethod();

            //// Student listing
            //MainClass.studentListing();

            //// Student query
            //MainClass.studentQuery();

            //// Update student Ukdfe fields
            //MainClass.studentUpdateUkdfeFields();

            //// Update student tags
            //MainClass.studentUpdateUserTags();

            //// Update student
             //MainClass.studentUpdate();

            // Create student
            //MainClass.studentCreate();

            // Create student with Ukdfe fields
            //MainClass.studentCreateWithUkdfeFields();

            /************* Ukdfe examples *************/

            // Create local authority
           // MainClass.localAuthorityCreate();

            // Query local authority
             //MainClass.localAuthorityQuery();

            // Retrieve local authority
            //MainClass.localAuthorityRetrieve();

            //MainClass.studentGetTags();

            /***************** Change log examples ******************/

            //MainClass.getChanges();

            /***************** API Tools examples ******************/

            // Current students
            //MainClass.getCurrentStudents();

            // Write attendance marks
            //MainClass.writeAttendanceMarks();

            // Query staff via tagging (find all teachers)
            //MainClass.staffQueryViaTagging();

            // Query registration form
            //MainClass.registrationFormQuery ();

            // Get eligibility records
           //MainClass.getEligibilityRecords();

            // Get student by demographic tag
            //MainClass.getStudentByDemographicTag();

            #endregion

            Console.ReadKey();

        }//Main()

        public static void studentRetrieve(string modelName, string id)
        {
            // Retrieve model
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            ModelBase model = gateway.retrieve(modelName, id);

            // Display logic
            Hydrator hydrator = new Hydrator();
            JObject extractedModel = hydrator.extractArray(model);
            Console.WriteLine("Example: retrieve model by ID. \n");
            Console.WriteLine("Retrieved model (extracted):" + extractedModel.ToString());
        }

        public static void studentQueryViaStaticMethod()
        {
            // Query model
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            ModelBase.setDefaultGateway(gateway);

            // Get ethnicity to be used as search parameter
            Ethnicity ethnicity = (Ethnicity)gateway.retrieve(ResourceType.ETHNICITY, "AAFR");

            SimpleQuery query = new SimpleQuery();
            query.addPropertyFilter("ethnicity", SimpleQuery.OPERATOR_EQUALS, ethnicity);
            ModelCollection<Student> modelCollection = Student.query(query);

            // Display logic
            Console.WriteLine("Example: query student model via static method. \n");
            Console.WriteLine("Models count: " + modelCollection.Count.ToString());
            Console.WriteLine("Models (extracted): \n");

            Hydrator hydrator = new Hydrator();
            foreach (Student model in modelCollection)
            {
                Console.WriteLine(hydrator.extractArray(model) + "\n");
            }
        }

        public static void studentListing()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            ModelCollection<ModelBase> collection = gateway.query(new SimpleQuery(ResourceType.STUDENT));

            // Display logic
            Console.WriteLine("Example: listing student objects. \n");
            Console.WriteLine("Models count: " + collection.Count.ToString());

            Hydrator hydrator = new Hydrator();
            foreach (Student model in collection)
            {
                Console.WriteLine(hydrator.extractArray(model) + "\n");
            }
        }

        public static void studentQuery()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);

            // Get ethnicity to be used as search parameter
            Ethnicity ethnicity = (Ethnicity)gateway.retrieve(ResourceType.ETHNICITY, "AAFR");

            SimpleQuery query = new SimpleQuery(ResourceType.STUDENT);
            query.addPropertyFilter("ethnicity", SimpleQuery.OPERATOR_EQUALS, ethnicity);
            ModelCollection<ModelBase> collection = gateway.query(query);

            // Display logic
            Console.WriteLine("Example: query student model. \n");
            Console.WriteLine("Models count: " + collection.Count.ToString());
            Console.WriteLine("Models (extracted): \n");

            Hydrator hydrator = new Hydrator();
            foreach (Student model in collection)
            {
                Console.WriteLine(hydrator.extractArray(model) + "\n");
            }
        }

        public static void studentUpdateUkdfeFields()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            Student student = (Student)gateway.retrieve(ResourceType.STUDENT, "137");

            int ulnBeforeUpdate = student.getUniqueLearnerNumber();
            student.setUniqueLearnerNumber(1000000000);

            student.save();

            int ulnAfterUpdate = student.getUniqueLearnerNumber();

            // Display logic
            Console.WriteLine("Example: student update. \n");
            Console.WriteLine("Unique learner number before update: " + ulnBeforeUpdate);
            Console.WriteLine("Unique learner number after update: " + ulnAfterUpdate);
        }

        public static void studentUpdateUserTags()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            Student student = (Student)gateway.retrieve(ResourceType.STUDENT, "137");

            student.getPerson().setDateOfBirth(new DateTime(2000, 1, 1));
            student.getPerson().setLegalFirstName("Simbad");
            student.getPerson().setLegalLastName("Sailor");
            student.getPerson().setGender((Gender)gateway.retrieve(ResourceType.GENDER, "FEMALE"));
            student.getPerson().setTitle((Title)gateway.retrieve(ResourceType.TITLE, "MR"));

            student.setEthnicity((Ethnicity)gateway.retrieve(ResourceType.ETHNICITY, "WBRI"));
            student.setReligion((Religion)gateway.retrieve(ResourceType.RELIGION, "CHRISTIAN"));
            student.tag("tagName", "123");

            student.getPerson().connect(gateway);
            student.getPerson().save();

            student.connect(gateway);
            student.save();

            // Display logic
            MainClass.studentRetrieve();
        }

        private static void studentRetrieve()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            Student student = (Student)gateway.retrieve(ResourceType.STUDENT, "137");

            // Display logic
            Console.WriteLine("Example: student retrieve. \n");
            Hydrator hydrator = new Hydrator();
            JObject jArr = hydrator.extractArray(student);
            Console.WriteLine(jArr);
        }

        public static void studentUpdate()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            Student student = (Student)gateway.retrieve(ResourceType.STUDENT, "137");

            student.getPerson().setDateOfBirth(new DateTime(2000, 1, 1));
            student.getPerson().setLegalFirstName("Simbad");
            student.getPerson().setLegalLastName("Sailor");
            student.getPerson().setGender((Gender)gateway.retrieve(ResourceType.GENDER, "MALE"));
            student.getPerson().setTitle((Title)gateway.retrieve(ResourceType.TITLE, "MR"));

            student.setEthnicity((Ethnicity)gateway.retrieve(ResourceType.ETHNICITY, "WBRI"));
            student.setReligion((Religion)gateway.retrieve(ResourceType.RELIGION, "CHRISTIAN"));

            student.getPerson().connect(gateway);
            student.getPerson().save();

            student.connect(gateway);
            student.save();

            //Display Logic
            Student studentCopy2 = (Student)gateway.retrieve(ResourceType.STUDENT, student.getResourceId().ToString());
            Hydrator hydrator = new Hydrator();
            JObject extractedModel = hydrator.extractArray(studentCopy2);
            Console.WriteLine("Example: update student ID. \n");
            Console.WriteLine("Retrieved model (extracted):" + extractedModel.ToString());
        }

        public static void studentCreate()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);

            Student student = new Student();
            student.setPerson(new Person());
            student.getPerson().setDateOfBirth(new DateTime(2000, 1, 1));
            student.getPerson().setLegalFirstName("Simbad");
            student.getPerson().setLegalLastName("Sailor");
            student.getPerson().setGender((Gender)gateway.retrieve(ResourceType.GENDER, "MALE"));
            student.getPerson().setTitle((Title)gateway.retrieve(ResourceType.TITLE, "MR"));
            student.getPerson().connect(gateway);
            student.getPerson().save();
            student.setEthnicity((Ethnicity)gateway.retrieve(ResourceType.ETHNICITY, "AAFR"));
            student.setReligion((Religion)gateway.retrieve(ResourceType.RELIGION, "CHRISTIAN"));
            student.tag("sims-id", 1234);
            student.connect(gateway);
            student.save();

            //Display Logic
            Console.WriteLine("Example: create student. \n");
            Student studentCopy2 = (Student)gateway.retrieve(ResourceType.STUDENT, student.getResourceId().ToString());

            Hydrator hydrator = new Hydrator();
            JObject extractedModel = hydrator.extractArray(studentCopy2);
            Console.WriteLine("Student: \n" + extractedModel.ToString());
        }

        public static void studentCreateWithUkdfeFields()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);

            Student student = new Student();
            student.setPerson(new Person());
            student.getPerson().setDateOfBirth(new DateTime(2000, 1, 1));
            student.getPerson().setLegalFirstName("Simbad");
            student.getPerson().setLegalLastName("Sailor");
            student.getPerson().setGender((Gender)gateway.retrieve(ResourceType.GENDER, "MALE"));
            student.getPerson().setTitle((Title)gateway.retrieve(ResourceType.TITLE, "MR"));
            student.getPerson().connect(gateway);
            student.getPerson().save();
            student.setEthnicity((Ethnicity)gateway.retrieve(ResourceType.ETHNICITY, "AAFR"));
            student.setReligion((Religion)gateway.retrieve(ResourceType.RELIGION, "CHRISTIAN"));
            student.setUniqueLearnerNumber(1000000000);
            student.setStudentNumber("TEST123456");
            student.tag("sims-id", 123);
            student.connect(gateway);
            student.save();

            //Display Logic
            Console.WriteLine("Example: create student. \n");
            Student studentCopy2 = (Student)gateway.retrieve(ResourceType.STUDENT, student.getResourceId().ToString());

            Hydrator hydrator = new Hydrator();
            JObject extractedModel = hydrator.extractArray(studentCopy2);
            Console.WriteLine("Student: \n" + extractedModel.ToString());
        }

        public static void updateStudentTags()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            Student student = (Student)gateway.retrieve(ResourceType.STUDENT, "1");

            Hashtable tags = new Hashtable();
            tags.Add("tag1", "Tag 1 value");
            tags.Add("tag2", "Tag 2 value");
            student.setUserTags(new Tag("New Tags", tags, gateway));
            student.connect(gateway);

            student.save();

            // Display Logic
            Student studentCopy2 = (Student)gateway.retrieve(ResourceType.STUDENT, student.getResourceId().ToString());
            Hydrator hydrator = new Hydrator();
            JObject extractedModel = hydrator.extractArray(studentCopy2);
            Console.WriteLine("Example: update / add student tags. \n");
            Console.WriteLine("Retrieved model (extracted):" + extractedModel.ToString());
        }

        /***************** Ukdfe examples ******************/

        public static void localAuthorityCreate()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            ModelBase.setDefaultGateway(gateway);

            Arbor.Model.UkDfe.LocalAuthority model = new Arbor.Model.UkDfe.LocalAuthority();
            model.setProperty("name", "TestAuthorotah");
            model.setProperty("shortName", "AuthorotaaAah");
            model.save();

            // Display Logic
            Hydrator hydrator = new Hydrator();
            JObject extractedModel = hydrator.extractArray(model);
            Console.WriteLine("Example: create local authority \n");
            Console.WriteLine("Retrieved model (extracted):" + extractedModel.ToString());
        }

        public static void localAuthorityQuery()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            ModelBase.setDefaultGateway(gateway);

            SimpleQuery query = new SimpleQuery();
            query.addUserTagFilter("colour", "green");
            ModelCollection<Arbor.Model.UkDfe.LocalAuthority> modelCollection = Arbor.Model.UkDfe.LocalAuthority.query(query);


            // Display logic
            Console.WriteLine("Example: query student model via static method. \n");
            Console.WriteLine("Models count: " + modelCollection.Count.ToString());
            Console.WriteLine("Models (extracted): \n");

            Hydrator hydrator = new Hydrator();
            foreach (Arbor.Model.UkDfe.LocalAuthority model in modelCollection)
            {
                Console.WriteLine(hydrator.extractArray(model) + "\n");
            }
        }

        public static void localAuthorityRetrieve()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            ModelBase.setDefaultGateway(gateway);

            Arbor.Model.UkDfe.LocalAuthority model =
                (Arbor.Model.UkDfe.LocalAuthority)gateway.retrieve(Arbor.Resource.UkDfe.ResourceType.UK_DFE_LOCAL_AUTHORITY.ToString(), "1");

            // Display Logic
            Hydrator hydrator = new Hydrator();
            JObject extractedModel = hydrator.extractArray(model);
            Console.WriteLine("Example: retrieve local authority \n");
            Console.WriteLine("Retrieved model (extracted):" + extractedModel.ToString());
        }

        public static void localAuthorityUpdate()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            ModelBase.setDefaultGateway(gateway);

            Arbor.Model.UkDfe.LocalAuthority model =
                (Arbor.Model.UkDfe.LocalAuthority)gateway.retrieve(Arbor.Resource.UkDfe.ResourceType.UK_DFE_LOCAL_AUTHORITY.ToString(), "1");
            model.setProperty("shortName", "AuthorotaaAah");
            model.save();

            // Display Logic
            Hydrator hydrator = new Hydrator();
            JObject extractedModel = hydrator.extractArray(model);
            Console.WriteLine("Example: retrieve local authority \n");
            Console.WriteLine("Retrieved model (extracted):" + extractedModel.ToString());
        }


        /***************** Change log examples ******************/

        public static void getChanges()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            List<Change> changes = gateway.getChanges(ResourceType.STUDENT, 43322);

            // Display logic
            Console.WriteLine("Example: get changes. \n");
            Console.WriteLine("Changes count: " + changes.Count.ToString());
            Console.WriteLine("Changes: \n");

            foreach (Change change in changes)
            {
                string line = " Object: "
                    + change.getChangedResource().getResourceType()
                    + ", ID:" + change.getChangedResource().getResourceId().ToString()
                    + " has been " + change.getChangeType() + "ed";
                Console.WriteLine(line);
            }
        }

        /***************** API Tools examples ******************/

        public static void getCurrentStudents()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            StudentService.setDefaultGateway(gateway);

            ModelCollection<Student> studentCollection = StudentService.getCurrentStudents();

            // Display logic
            Console.WriteLine("Example: get current students. \n");
            Console.WriteLine("Students count: " + studentCollection.Count.ToString());
            Console.WriteLine("Students: \n");

            Hydrator hydrator = new Hydrator();
            foreach (Student student in studentCollection)
            {
                Console.WriteLine(hydrator.extractArray(student) + "\n");
            }
        }

        public static void writeAttendanceMarks()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            AttendanceRegistration attendanceService = new AttendanceRegistration(gateway);
            ModelBase.setDefaultGateway(gateway);
            AttendanceMark.setDefaultGateway(gateway);
            // Set session start time to today 9AM
            DateTime sessionStartTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0);

            // Get some students which we are going to mark
            Student student12 = Student.retrieve("12");
            Student student13 = Student.retrieve("13");
            Student student14 = Student.retrieve("14");

            // Get some valid attendance marks
            AttendanceMark attMarkPresent = AttendanceMark.retrieve("PRESENT");
            AttendanceMark attMarkLate = AttendanceMark.retrieve("LATE");

            // Assign marks to students
            attendanceService.awardAttendanceMark(student12, sessionStartTime, attMarkPresent);
            attendanceService.awardAttendanceMark(student13, sessionStartTime, attMarkPresent);
            attendanceService.awardAttendanceMark(student14, sessionStartTime, attMarkLate, 16, "Says he missed the bus");

            // Write marks to the server
            attendanceService.saveMarks();
        }

        public static void staffQueryViaTagging()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);

            SimpleQuery query = new SimpleQuery(ResourceType.STAFF);
            List<object> taggings = new List<object>();
            taggings.Add("STAFF__CURRENT_TEACHING_STAFF");

            query.setTaggings(taggings);
            ModelCollection<ModelBase> collection = gateway.query(query);

            // Display logic
            Console.WriteLine("Example: query student model. \n");
            Console.WriteLine("Models count: " + collection.Count.ToString());
            Console.WriteLine("Models (extracted): \n");

            Hydrator hydrator = new Hydrator();
            foreach (Staff model in collection)
            {
                Console.WriteLine(hydrator.extractArray(model) + "\n");
            }
        }

        public static void studentGetTags()
        {
            // Retrieve model
            string userId = "251";
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            Student student = (Student)gateway.retrieve(ResourceType.STUDENT, userId);

            // Create tag
            Hashtable tags = new Hashtable();
            string tagKey1;
            tagKey1 = "tag1";
            tags.Add(tagKey1, "Tag_1_value");

            // Set a student with tag
            Tag userTags = new Tag(ResourceType.TAG, tags, gateway);
            student.setUserTags(userTags);
            student.save();

            // Get studnet with added / updated tag
            student = (Student)gateway.retrieve(ResourceType.STUDENT, userId);
            JObject newUserTags = student.getUserTags();
            JToken tagValue1 = newUserTags.GetValue("tag1");

            Console.WriteLine("New tag value for tag key '" + tagKey1 + "' is: '" + tagValue1 + "'");

            // Query students by tag key / value
            SimpleQuery query = new SimpleQuery();
            query.addPropertyFilter("tags." + tagKey1, SimpleQuery.OPERATOR_EQUALS, tagValue1);
            Student.setDefaultGateway(gateway);
            ModelCollection<Student> modelCollection = Student.query(query);

            Console.WriteLine("List of students found for searched tag: ");
            Hydrator hydrator = new Hydrator();
            foreach (Student model in modelCollection)
            {
                Console.WriteLine(hydrator.extractArray(model) + "\n");
            }
        }

        public static void registrationFormQuery()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            ModelBase.setDefaultGateway(gateway);

            SimpleQuery query = new SimpleQuery("RegistrationForm");
            query.addPropertyFilter("shortName", SimpleQuery.OPERATOR_EQUALS, "10C");

            ModelCollection<ModelBase> modelCollection = gateway.query(query);

            /*
			 * Bellow is an alternative way to perform the same query
			 * 
			 */
            //			List<IDictionary<string, object>> list = new List<IDictionary<string, object>> ();
            //			IDictionary<string, object> dict = new Dictionary<string, object> ();
            //
            //			dict.Add ("propertyName", "shortName");
            //			dict.Add ("operator", SimpleQuery.OPERATOR_EQUALS);
            //			dict.Add ("value", "10C");
            //			list.Add (dict);
            //
            //			SimpleQuery query = new SimpleQuery ("RegistrationForm", list);

            if (modelCollection.Count > 0)
            {
                Hydrator hydrator = new Hydrator();
                foreach (RegistrationForm model in modelCollection)
                {
                    Console.WriteLine(hydrator.extractArray(model) + "\n");
                }
            }
        }

        public static void getEligibilityRecords()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            ModelBase.setDefaultGateway(gateway);

            SimpleQuery query = new SimpleQuery(ResourceType.ELIGIBILITY_RECORD);
            ModelCollection<ModelBase> collection = gateway.query(query); // All eligibility records

            foreach (EligibilityRecord eligibilityRecrd in collection)
            {
                EligibilityRecord elrecDetail = (EligibilityRecord)eligibilityRecrd.getApiGateway()
                    .retrieve(ResourceType.ELIGIBILITY_RECORD, eligibilityRecrd.getResourceId().ToString());

                // Or you can use gateway you've already set:
                /*
				EligibilityRecord elrecDetail2 = (EligibilityRecord) gateway
					.retrieve(ResourceType.ELIGIBILITY_RECORD, eligibilityRecrd.getResourceId().ToString());
				*/

                Eligibility eligibility = elrecDetail.getEligibility();
                Console.WriteLine("Eligibility name: " + eligibility.getEligibilityName());
            }
        }

        public static void getStudentByDemographicTag()
        {
            RestGateway gateway = new RestGateway(URL, USERNAME, PASSWORD, USER_AGENT);
            ModelBase.setDefaultGateway(gateway);

            SimpleQuery query = new SimpleQuery();
            query.addPropertyFilter("self", "tagged", "DEMOGRAPHIC__STUDENT__UK_DFE__PUPIL_PREMIUM");
            Student.setDefaultGateway(gateway);
            ModelCollection<Student> modelCollection = Student.query(query);

            Console.WriteLine("List of students found for searched tag: ");
            Hydrator hydrator = new Hydrator();
            List<JObject> studentCollectionFullProperties = new List<JObject>();
            List<ModelBase> fullStudentCollectionRetrieve = new List<ModelBase>();
            foreach (Student model in modelCollection)
            {
                ModelBase current = gateway.retrieve(ResourceType.STUDENT, model.getResourceId().ToString());
                fullStudentCollectionRetrieve.Add(current);
                studentCollectionFullProperties.Add(hydrator.extractArray(model));
            }

            int i = 0;
            List<Student> fullPropertyStudentList = new List<Student>();
            foreach (ModelBase currentStudent in fullStudentCollectionRetrieve)
            {
                Student current = (Student)hydrator.hydrateModel(currentStudent, studentCollectionFullProperties[i]);
                fullPropertyStudentList.Add(current);
                i++;
            }

            Person firstStudentPerson = fullPropertyStudentList.First().getPerson();
            object dateOfBirthTakenByModelBaseCall = firstStudentPerson.getProperty("dateOfBirth");
            DateTime convertedDateTimeByDateTimeCast = Convert.ToDateTime(dateOfBirthTakenByModelBaseCall);
            var sortedListOfStudent = fullPropertyStudentList.OrderBy(t => t.getPerson().getDateOfBirth()).ToList();

            Console.ReadKey();
        }

    }//class
}//namespace
