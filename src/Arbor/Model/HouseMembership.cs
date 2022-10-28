using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class HouseMembership : ModelBase
    {
        protected new string resourceType = ResourceType.HOUSE_MEMBERSHIP;
        public const string HOUSE = "house";
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string HOUSE_AUTOMATIC_ENROLMENT = "houseAutomaticEnrolment";
        public const string ENROLMENT_DEPENDENCY = "enrolmentDependency";

        public HouseMembership()
        {
            base.resourceType = this.resourceType;
        }

        public HouseMembership(string resourceType = "HouseMembership", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<HouseMembership> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("HouseMembership");
            RestGateway gateway = (RestGateway)HouseMembership.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<HouseMembership> housemembershipCollection = new ModelCollection<HouseMembership>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                housemembershipCollection.add((HouseMembership)model);
            }

            return housemembershipCollection;
        }

        public static HouseMembership retrieve(string id)
        {
            RestGateway gateway = (RestGateway)HouseMembership.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (HouseMembership)gateway.retrieve(ResourceType.HOUSE_MEMBERSHIP, id);
        }

        public House getHouse()
        {
            return (House)this.getProperty("house");
        }

        public void setHouse(House house)
        {
            this.setProperty("house", house);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
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

        public HouseAutomaticEnrolment getHouseAutomaticEnrolment()
        {
            return (HouseAutomaticEnrolment)this.getProperty("houseAutomaticEnrolment");
        }

        public void setHouseAutomaticEnrolment(HouseAutomaticEnrolment houseAutomaticEnrolment)
        {
            this.setProperty("houseAutomaticEnrolment", houseAutomaticEnrolment);
        }

        public RegistrationFormMembership getEnrolmentDependency()
        {
            return (RegistrationFormMembership)this.getProperty("enrolmentDependency");
        }

        public void setEnrolmentDependency(RegistrationFormMembership enrolmentDependency)
        {
            this.setProperty("enrolmentDependency", enrolmentDependency);
        }


    }
}

