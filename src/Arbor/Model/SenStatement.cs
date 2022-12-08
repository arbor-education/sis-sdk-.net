using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SenStatement : ModelBase
    {
        protected string resourceType = ResourceType.SEN_STATEMENT;
        public const string STUDENT = "student";
        public const string DATE_REQUESTED = "dateRequested";
        public const string DATE_PARENT_CONSULTED = "dateParentConsulted";
        public const string DISAPPLICATION_FROM_NC_PERMANENT_SUBJECTS = "disapplicationFromNcPermanentSubjects";
        public const string DISAPPLICATION_FROM_NC_TEMPORARY_SUBJECTS = "disapplicationFromNcTemporarySubjects";
        public const string LOCAL_AUTHORITY_OFFICER = "localAuthorityOfficer";
        public const string DECISION_STATUS = "decisionStatus";
        public const string SUBJECT_TO_SEN_TRIBUNAL = "subjectToSenTribunal";
        public const string APPEAL_NOTES = "appealNotes";
        public const string DATE_FINALIZED = "dateFinalized";
        public const string DATE_CEASED = "dateCeased";
        public const string COMMENTS = "comments";

        public SenStatement()
        {
            base.resourceType = this.resourceType;
        }

        public SenStatement(string resourceType = "SenStatement", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SenStatement> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("SenStatement");
            RestGateway gateway = (RestGateway)SenStatement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SenStatement> senstatementCollection = new ModelCollection<SenStatement>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                senstatementCollection.add((SenStatement)model);
            }

            return senstatementCollection;
        }

        public static SenStatement retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SenStatement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SenStatement)gateway.retrieve(ResourceType.SEN_STATEMENT, id);
        }

        public Student getStudent()
        {
            return (Student)this.getProperty("student");
        }

        public void setStudent(Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getDateRequested()
        {
            return Convert.ToDateTime(this.getProperty("dateRequested"));
        }

        public void setDateRequested(DateTime dateRequested)
        {
            this.setProperty("dateRequested", dateRequested);
        }

        public DateTime getDateParentConsulted()
        {
            return Convert.ToDateTime(this.getProperty("dateParentConsulted"));
        }

        public void setDateParentConsulted(DateTime dateParentConsulted)
        {
            this.setProperty("dateParentConsulted", dateParentConsulted);
        }

        public string getDisapplicationFromNcPermanentSubjects()
        {
            return this.getProperty("disapplicationFromNcPermanentSubjects").ToString();
        }

        public void setDisapplicationFromNcPermanentSubjects(string disapplicationFromNcPermanentSubjects)
        {
            this.setProperty("disapplicationFromNcPermanentSubjects", disapplicationFromNcPermanentSubjects);
        }

        public string getDisapplicationFromNcTemporarySubjects()
        {
            return this.getProperty("disapplicationFromNcTemporarySubjects").ToString();
        }

        public void setDisapplicationFromNcTemporarySubjects(string disapplicationFromNcTemporarySubjects)
        {
            this.setProperty("disapplicationFromNcTemporarySubjects", disapplicationFromNcTemporarySubjects);
        }

        public string getLocalAuthorityOfficer()
        {
            return this.getProperty("localAuthorityOfficer").ToString();
        }

        public void setLocalAuthorityOfficer(string localAuthorityOfficer)
        {
            this.setProperty("localAuthorityOfficer", localAuthorityOfficer);
        }

        public string getDecisionStatus()
        {
            return this.getProperty("decisionStatus").ToString();
        }

        public void setDecisionStatus(string decisionStatus)
        {
            this.setProperty("decisionStatus", decisionStatus);
        }

        public bool getSubjectToSenTribunal()
        {
            return Convert.ToBoolean(this.getProperty("subjectToSenTribunal"));
        }

        public void setSubjectToSenTribunal(bool subjectToSenTribunal)
        {
            this.setProperty("subjectToSenTribunal", subjectToSenTribunal);
        }

        public string getAppealNotes()
        {
            return this.getProperty("appealNotes").ToString();
        }

        public void setAppealNotes(string appealNotes)
        {
            this.setProperty("appealNotes", appealNotes);
        }

        public DateTime getDateFinalized()
        {
            return Convert.ToDateTime(this.getProperty("dateFinalized"));
        }

        public void setDateFinalized(DateTime dateFinalized)
        {
            this.setProperty("dateFinalized", dateFinalized);
        }

        public DateTime getDateCeased()
        {
            return Convert.ToDateTime(this.getProperty("dateCeased"));
        }

        public void setDateCeased(DateTime dateCeased)
        {
            this.setProperty("dateCeased", dateCeased);
        }

        public string getComments()
        {
            return this.getProperty("comments").ToString();
        }

        public void setComments(string comments)
        {
            this.setProperty("comments", comments);
        }


    }
}

