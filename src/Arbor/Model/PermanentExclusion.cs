using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PermanentExclusion : ModelBase
    {
        protected new string resourceType = ResourceType.PERMANENT_EXCLUSION;
        public const string STUDENT = "student";
        public const string EXCLUSION_REASON = "exclusionReason";
        public const string FROM_DATE = "fromDate";
        public const string DECISION_DATETIME = "decisionDatetime";
        public const string NOTIFIED_STUDENT_DATETIME = "notifiedStudentDatetime";
        public const string NOTIFIED_GUARDIANS_DATETIME = "notifiedGuardiansDatetime";
        public const string NARRATIVE = "narrative";

        public PermanentExclusion()
        {
            base.resourceType = this.resourceType;
        }

        public PermanentExclusion(string resourceType = "PermanentExclusion", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PermanentExclusion> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PermanentExclusion");
            RestGateway gateway = (RestGateway)PermanentExclusion.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PermanentExclusion> permanentexclusionCollection = new ModelCollection<PermanentExclusion>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                permanentexclusionCollection.add((PermanentExclusion)model);
            }

            return permanentexclusionCollection;
        }

        public static PermanentExclusion retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PermanentExclusion.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PermanentExclusion)gateway.retrieve(ResourceType.PERMANENT_EXCLUSION, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public ExclusionReason getExclusionReason()
        {
            return (ExclusionReason)this.getProperty("exclusionReason");
        }

        public void setExclusionReason(ExclusionReason exclusionReason)
        {
            this.setProperty("exclusionReason", exclusionReason);
        }

        public DateTime getFromDate()
        {
            return Convert.ToDateTime(this.getProperty("fromDate"));
        }

        public void setFromDate(DateTime fromDate)
        {
            this.setProperty("fromDate", fromDate);
        }

        public DateTime getDecisionDatetime()
        {
            return Convert.ToDateTime(this.getProperty("decisionDatetime"));
        }

        public void setDecisionDatetime(DateTime decisionDatetime)
        {
            this.setProperty("decisionDatetime", decisionDatetime);
        }

        public DateTime getNotifiedStudentDatetime()
        {
            return Convert.ToDateTime(this.getProperty("notifiedStudentDatetime"));
        }

        public void setNotifiedStudentDatetime(DateTime notifiedStudentDatetime)
        {
            this.setProperty("notifiedStudentDatetime", notifiedStudentDatetime);
        }

        public DateTime getNotifiedGuardiansDatetime()
        {
            return Convert.ToDateTime(this.getProperty("notifiedGuardiansDatetime"));
        }

        public void setNotifiedGuardiansDatetime(DateTime notifiedGuardiansDatetime)
        {
            this.setProperty("notifiedGuardiansDatetime", notifiedGuardiansDatetime);
        }

        public string getNarrative()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative(string narrative)
        {
            this.setProperty("narrative", narrative);
        }


    }
}

