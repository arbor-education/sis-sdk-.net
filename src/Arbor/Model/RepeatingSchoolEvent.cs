using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class RepeatingSchoolEvent : ModelBase
    {
        protected new string resourceType = ResourceType.REPEATING_SCHOOL_EVENT;
        public const string ACADEMIC_YEAR = "academicYear";
        public const string SCHOOL_EVENT_TYPE = "schoolEventType";
        public const string SCHOOL_EVENT_NAME = "schoolEventName";
        public const string NARRATIVE = "narrative";
        public const string COVER_REQUIRED = "coverRequired";

        public RepeatingSchoolEvent()
        {
            base.resourceType = this.resourceType;
        }

        public RepeatingSchoolEvent(string resourceType = "RepeatingSchoolEvent", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<RepeatingSchoolEvent> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("RepeatingSchoolEvent");
            RestGateway gateway = (RestGateway)RepeatingSchoolEvent.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<RepeatingSchoolEvent> repeatingschooleventCollection = new ModelCollection<RepeatingSchoolEvent>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                repeatingschooleventCollection.add((RepeatingSchoolEvent)model);
            }

            return repeatingschooleventCollection;
        }

        public static RepeatingSchoolEvent retrieve(string id)
        {
            RestGateway gateway = (RestGateway)RepeatingSchoolEvent.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (RepeatingSchoolEvent)gateway.retrieve(ResourceType.REPEATING_SCHOOL_EVENT, id);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public SchoolEventType getSchoolEventType()
        {
            return (SchoolEventType)this.getProperty("schoolEventType");
        }

        public void setSchoolEventType(SchoolEventType schoolEventType)
        {
            this.setProperty("schoolEventType", schoolEventType);
        }

        public string getSchoolEventName()
        {
            return this.getProperty("schoolEventName").ToString();
        }

        public void setSchoolEventName(string schoolEventName)
        {
            this.setProperty("schoolEventName", schoolEventName);
        }

        public string getNarrative()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative(string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public bool getCoverRequired()
        {
            return Convert.ToBoolean(this.getProperty("coverRequired"));
        }

        public void setCoverRequired(bool coverRequired)
        {
            this.setProperty("coverRequired", coverRequired);
        }


    }
}

