using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InHouseExamGrade : ModelBase
    {
        protected string resourceType = ResourceType.IN_HOUSE_EXAM_GRADE;
        public const string IN_HOUSE_EXAM = "inHouseExam";
        public const string QUALIFICATION_GRADE = "qualificationGrade";
        public const string SHORT_NAME = "shortName";
        public const string LONG_NAME = "longName";
        public const string GRADE_VALUE = "gradeValue";
        public const string ACTIVE = "active";

        public InHouseExamGrade()
        {
            base.resourceType = this.resourceType;
        }

        public InHouseExamGrade(string resourceType = "InHouseExamGrade", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<InHouseExamGrade> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("InHouseExamGrade");
            RestGateway gateway = (RestGateway)InHouseExamGrade.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<InHouseExamGrade> inhouseexamgradeCollection = new ModelCollection<InHouseExamGrade>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                inhouseexamgradeCollection.add((InHouseExamGrade)model);
            }

            return inhouseexamgradeCollection;
        }

        public static InHouseExamGrade retrieve(string id)
        {
            RestGateway gateway = (RestGateway)InHouseExamGrade.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (InHouseExamGrade)gateway.retrieve(ResourceType.IN_HOUSE_EXAM_GRADE, id);
        }

        public InHouseExam getInHouseExam()
        {
            return (InHouseExam)this.getProperty("inHouseExam");
        }

        public void setInHouseExam(InHouseExam inHouseExam)
        {
            this.setProperty("inHouseExam", inHouseExam);
        }

        public QualificationGrade getQualificationGrade()
        {
            return (QualificationGrade)this.getProperty("qualificationGrade");
        }

        public void setQualificationGrade(QualificationGrade qualificationGrade)
        {
            this.setProperty("qualificationGrade", qualificationGrade);
        }

        public string getShortName()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName(string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public string getLongName()
        {
            return this.getProperty("longName").ToString();
        }

        public void setLongName(string longName)
        {
            this.setProperty("longName", longName);
        }

        public float getGradeValue()
        {
            return (float)this.getProperty("gradeValue");
        }

        public void setGradeValue(float gradeValue)
        {
            this.setProperty("gradeValue", gradeValue);
        }

        public bool getActive()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive(bool active)
        {
            this.setProperty("active", active);
        }


    }
}

