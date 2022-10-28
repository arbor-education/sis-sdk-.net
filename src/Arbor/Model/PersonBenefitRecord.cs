using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PersonBenefitRecord : ModelBase
    {
        protected new string resourceType = ResourceType.PERSON_BENEFIT_RECORD;
        public const string PERSON = "person";
        public const string BENEFIT_RECORD_TYPE = "benefitRecordType";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public PersonBenefitRecord()
        {
            base.resourceType = this.resourceType;
        }

        public PersonBenefitRecord(string resourceType = "PersonBenefitRecord", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PersonBenefitRecord> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PersonBenefitRecord");
            RestGateway gateway = (RestGateway)PersonBenefitRecord.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PersonBenefitRecord> personbenefitrecordCollection = new ModelCollection<PersonBenefitRecord>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                personbenefitrecordCollection.add((PersonBenefitRecord)model);
            }

            return personbenefitrecordCollection;
        }

        public static PersonBenefitRecord retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PersonBenefitRecord.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PersonBenefitRecord)gateway.retrieve(ResourceType.PERSON_BENEFIT_RECORD, id);
        }

        public ModelBase getPerson()
        {
            return (ModelBase)this.getProperty("person");
        }

        public void setPerson(ModelBase person)
        {
            this.setProperty("person", person);
        }

        public BenefitRecordType getBenefitRecordType()
        {
            return (BenefitRecordType)this.getProperty("benefitRecordType");
        }

        public void setBenefitRecordType(BenefitRecordType benefitRecordType)
        {
            this.setProperty("benefitRecordType", benefitRecordType);
        }

        public DateTime getStartDate()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate(DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate(DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

