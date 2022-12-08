using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class RegistrationFormMembership : ModelBase
    {
        protected string resourceType = ResourceType.REGISTRATION_FORM_MEMBERSHIP;
        public const string REGISTRATION_FORM = "registrationForm";
        public const string STUDENT = "student";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public RegistrationFormMembership()
        {
            base.resourceType = this.resourceType;
        }

        public RegistrationFormMembership(string resourceType = "RegistrationFormMembership", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<RegistrationFormMembership> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("RegistrationFormMembership");
            RestGateway gateway = (RestGateway)RegistrationFormMembership.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<RegistrationFormMembership> registrationformmembershipCollection = new ModelCollection<RegistrationFormMembership>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                registrationformmembershipCollection.add((RegistrationFormMembership)model);
            }

            return registrationformmembershipCollection;
        }

        public static RegistrationFormMembership retrieve(string id)
        {
            RestGateway gateway = (RestGateway)RegistrationFormMembership.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (RegistrationFormMembership)gateway.retrieve(ResourceType.REGISTRATION_FORM_MEMBERSHIP, id);
        }

        public RegistrationForm getRegistrationForm()
        {
            return (RegistrationForm)this.getProperty("registrationForm");
        }

        public void setRegistrationForm(RegistrationForm registrationForm)
        {
            this.setProperty("registrationForm", registrationForm);
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


    }
}

