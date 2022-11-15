using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BursaryType : ModelBase
    {
        protected new string resourceType = ResourceType.BURSARY_TYPE;
        public const string NAME = "name";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string STUDENT_FUNDING_TYPE = "studentFundingType";
        public const string ALLOCATED_AMOUNT = "allocatedAmount";

        public BursaryType()
        {
            base.resourceType = this.resourceType;
        }

        public BursaryType(string resourceType = "BursaryType", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<BursaryType> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("BursaryType");
            RestGateway gateway = (RestGateway)BursaryType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<BursaryType> bursarytypeCollection = new ModelCollection<BursaryType>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                bursarytypeCollection.add((BursaryType)model);
            }

            return bursarytypeCollection;
        }

        public static BursaryType retrieve(string id)
        {
            RestGateway gateway = (RestGateway)BursaryType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (BursaryType)gateway.retrieve(ResourceType.BURSARY_TYPE, id);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public StudentFundingType getStudentFundingType()
        {
            return (StudentFundingType)this.getProperty("studentFundingType");
        }

        public void setStudentFundingType(StudentFundingType studentFundingType)
        {
            this.setProperty("studentFundingType", studentFundingType);
        }

        public string getAllocatedAmount()
        {
            return this.getProperty("allocatedAmount").ToString();
        }

        public void setAllocatedAmount(string allocatedAmount)
        {
            this.setProperty("allocatedAmount", allocatedAmount);
        }


    }
}

