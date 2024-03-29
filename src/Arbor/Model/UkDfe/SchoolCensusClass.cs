using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class SchoolCensusClass : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_SCHOOL_CENSUS_CLASS;
        public const string SCHOOL_CENSUS = "schoolCensus";
        public const string SESSION = "session";
        public const string TEACHERS = "teachers";
        public const string NON_TEACHERS = "nonTeachers";
        public const string PPA_TEACHERS = "ppaTeachers";
        public const string ASC_ACTIVITY = "ascActivity";
        public const string HOME_PUPILS = "homePupils";
        public const string GUEST_PUPILS = "guestPupils";
        public const string INFANT_PUPIL_EXCEPTIONS = "infantPupilExceptions";

        public SchoolCensusClass()
        {
            base.resourceType = this.resourceType;
        }

        public SchoolCensusClass(string resourceType = "SchoolCensusClass", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SchoolCensusClass> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_SchoolCensusClass");
            RestGateway gateway = (RestGateway)SchoolCensusClass.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SchoolCensusClass> schoolcensusclassCollection = new ModelCollection<SchoolCensusClass>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                schoolcensusclassCollection.add((SchoolCensusClass)model);
            }

            return schoolcensusclassCollection;
        }

        public static SchoolCensusClass retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SchoolCensusClass.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SchoolCensusClass)gateway.retrieve(ResourceType.UK_DFE_SCHOOL_CENSUS_CLASS, id);
        }

        public SchoolCensus getSchoolCensus()
        {
            return (SchoolCensus)this.getProperty("schoolCensus");
        }

        public void setSchoolCensus(SchoolCensus schoolCensus)
        {
            this.setProperty("schoolCensus", schoolCensus);
        }

        public Session getSession()
        {
            return (Session)this.getProperty("session");
        }

        public void setSession(Session session)
        {
            this.setProperty("session", session);
        }

        public int getTeachers()
        {
            return Convert.ToInt32(this.getProperty("teachers"));
        }

        public void setTeachers(int teachers)
        {
            this.setProperty("teachers", teachers);
        }

        public int getNonTeachers()
        {
            return Convert.ToInt32(this.getProperty("nonTeachers"));
        }

        public void setNonTeachers(int nonTeachers)
        {
            this.setProperty("nonTeachers", nonTeachers);
        }

        public int getPpaTeachers()
        {
            return Convert.ToInt32(this.getProperty("ppaTeachers"));
        }

        public void setPpaTeachers(int ppaTeachers)
        {
            this.setProperty("ppaTeachers", ppaTeachers);
        }

        public string getAscActivity()
        {
            return this.getProperty("ascActivity").ToString();
        }

        public void setAscActivity(string ascActivity)
        {
            this.setProperty("ascActivity", ascActivity);
        }

        public int getHomePupils()
        {
            return Convert.ToInt32(this.getProperty("homePupils"));
        }

        public void setHomePupils(int homePupils)
        {
            this.setProperty("homePupils", homePupils);
        }

        public int getGuestPupils()
        {
            return Convert.ToInt32(this.getProperty("guestPupils"));
        }

        public void setGuestPupils(int guestPupils)
        {
            this.setProperty("guestPupils", guestPupils);
        }

        public string getInfantPupilExceptions()
        {
            return this.getProperty("infantPupilExceptions").ToString();
        }

        public void setInfantPupilExceptions(string infantPupilExceptions)
        {
            this.setProperty("infantPupilExceptions", infantPupilExceptions);
        }


    }
}

