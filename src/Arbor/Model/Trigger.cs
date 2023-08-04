using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Trigger : ModelBase
    {
        protected string resourceType = ResourceType.TRIGGER;
        public const string CODE = "code";
        public const string TRIGGER_CATEGORY = "triggerCategory";
        public const string TRIGGER_NAME = "triggerName";
        public const string DESCRIPTION = "description";
        public const string TRIGGER_CLASS = "triggerClass";
        public const string TRIGGER_CLASS_ARGS = "triggerClassArgs";
        public const string TEST_FOR_SCHOOL = "testForSchool";
        public const string TEST_FOR_GROUPS = "testForGroups";
        public const string TEST_FOR_ACADEMIC_UNITS = "testForAcademicUnits";
        public const string TEST_FOR_STUDENTS = "testForStudents";
        public const string TEST_FOR_STUDENT_ACADEMIC_UNIT_ENROLMENTS = "testForStudentAcademicUnitEnrolments";

        public Trigger()
        {
            base.resourceType = this.resourceType;
        }

        public Trigger(string resourceType = "Trigger", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Trigger> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Trigger");
            RestGateway gateway = (RestGateway)Trigger.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Trigger> triggerCollection = new ModelCollection<Trigger>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                triggerCollection.add((Trigger)model);
            }

            return triggerCollection;
        }

        public static Trigger retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Trigger.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Trigger)gateway.retrieve(ResourceType.TRIGGER, id);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }

        public string getTriggerCategory()
        {
            return this.getProperty("triggerCategory").ToString();
        }

        public void setTriggerCategory(string triggerCategory)
        {
            this.setProperty("triggerCategory", triggerCategory);
        }

        public string getTriggerName()
        {
            return this.getProperty("triggerName").ToString();
        }

        public void setTriggerName(string triggerName)
        {
            this.setProperty("triggerName", triggerName);
        }

        public string getDescription()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription(string description)
        {
            this.setProperty("description", description);
        }

        public string getTriggerClass()
        {
            return this.getProperty("triggerClass").ToString();
        }

        public void setTriggerClass(string triggerClass)
        {
            this.setProperty("triggerClass", triggerClass);
        }

        public string getTriggerClassArgs()
        {
            return this.getProperty("triggerClassArgs").ToString();
        }

        public void setTriggerClassArgs(string triggerClassArgs)
        {
            this.setProperty("triggerClassArgs", triggerClassArgs);
        }

        public bool getTestForSchool()
        {
            return (bool)this.getProperty("testForSchool");
        }

        public void setTestForSchool(bool testForSchool)
        {
            this.setProperty("testForSchool", testForSchool);
        }

        public bool getTestForGroups()
        {
            return (bool)this.getProperty("testForGroups");
        }

        public void setTestForGroups(bool testForGroups)
        {
            this.setProperty("testForGroups", testForGroups);
        }

        public bool getTestForAcademicUnits()
        {
            return (bool)this.getProperty("testForAcademicUnits");
        }

        public void setTestForAcademicUnits(bool testForAcademicUnits)
        {
            this.setProperty("testForAcademicUnits", testForAcademicUnits);
        }

        public bool getTestForStudents()
        {
            return (bool)this.getProperty("testForStudents");
        }

        public void setTestForStudents(bool testForStudents)
        {
            this.setProperty("testForStudents", testForStudents);
        }

        public bool getTestForStudentAcademicUnitEnrolments()
        {
            return (bool)this.getProperty("testForStudentAcademicUnitEnrolments");
        }

        public void setTestForStudentAcademicUnitEnrolments(bool testForStudentAcademicUnitEnrolments)
        {
            this.setProperty("testForStudentAcademicUnitEnrolments", testForStudentAcademicUnitEnrolments);
        }


    }
}

