using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InHouseExamResult : ModelBase
    {
        protected new string resourceType = ResourceType.IN_HOUSE_EXAM_RESULT;
        public const string IN_HOUSE_EXAM = "inHouseExam";
        public const string STUDENT = "student";
        public const string IN_HOUSE_EXAM_ENTRY = "inHouseExamEntry";
        public const string NUMERIC_VALUE = "numericValue";
        public const string IN_HOUSE_EXAM_GRADE = "inHouseExamGrade";
        public const string RESULT_DATE = "resultDate";

        public InHouseExamResult()
        {
            base.resourceType = this.resourceType;
        }

        public InHouseExamResult(string resourceType = "InHouseExamResult", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<InHouseExamResult> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("InHouseExamResult");
            RestGateway gateway = (RestGateway)InHouseExamResult.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<InHouseExamResult> inhouseexamresultCollection = new ModelCollection<InHouseExamResult>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                inhouseexamresultCollection.add((InHouseExamResult)model);
            }

            return inhouseexamresultCollection;
        }

        public static InHouseExamResult retrieve(string id)
        {
            RestGateway gateway = (RestGateway)InHouseExamResult.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (InHouseExamResult)gateway.retrieve(ResourceType.IN_HOUSE_EXAM_RESULT, id);
        }

        public InHouseExam getInHouseExam()
        {
            return (InHouseExam)this.getProperty("inHouseExam");
        }

        public void setInHouseExam(InHouseExam inHouseExam)
        {
            this.setProperty("inHouseExam", inHouseExam);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public InHouseExamEntry getInHouseExamEntry()
        {
            return (InHouseExamEntry)this.getProperty("inHouseExamEntry");
        }

        public void setInHouseExamEntry(InHouseExamEntry inHouseExamEntry)
        {
            this.setProperty("inHouseExamEntry", inHouseExamEntry);
        }

        public float getNumericValue()
        {
            return (float)this.getProperty("numericValue");
        }

        public void setNumericValue(float numericValue)
        {
            this.setProperty("numericValue", numericValue);
        }

        public InHouseExamGrade getInHouseExamGrade()
        {
            return (InHouseExamGrade)this.getProperty("inHouseExamGrade");
        }

        public void setInHouseExamGrade(InHouseExamGrade inHouseExamGrade)
        {
            this.setProperty("inHouseExamGrade", inHouseExamGrade);
        }

        public DateTime getResultDate()
        {
            return Convert.ToDateTime(this.getProperty("resultDate"));
        }

        public void setResultDate(DateTime resultDate)
        {
            this.setProperty("resultDate", resultDate);
        }


    }
}

