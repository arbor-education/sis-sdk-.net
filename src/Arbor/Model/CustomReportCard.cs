using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomReportCard : ModelBase
    {
        protected new string resourceType = ResourceType.CUSTOM_REPORT_CARD;
        public const string ACADEMIC_YEAR = "academicYear";
        public const string TITLE = "title";
        public const string DATE = "date";
        public const string CUSTOM_REPORT = "customReport";
        public const string ORIENTATION = "orientation";
        public const string REMOVE_BLANK_ROWS = "removeBlankRows";
        public const string TEMPLATE = "template";
        public const string SHARED_WITH_GUARDIANS = "sharedWithGuardians";
        public const string SHARED_WITH_STUDENTS = "sharedWithStudents";
        public const string DELETION_STARTED_DATETIME = "deletionStartedDatetime";

        public CustomReportCard()
        {
            base.resourceType = this.resourceType;
        }

        public CustomReportCard(string resourceType = "CustomReportCard", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CustomReportCard> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CustomReportCard");
            RestGateway gateway = (RestGateway)CustomReportCard.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CustomReportCard> customreportcardCollection = new ModelCollection<CustomReportCard>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                customreportcardCollection.add((CustomReportCard)model);
            }

            return customreportcardCollection;
        }

        public static CustomReportCard retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CustomReportCard.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CustomReportCard)gateway.retrieve(ResourceType.CUSTOM_REPORT_CARD, id);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public string getTitle()
        {
            return this.getProperty("title").ToString();
        }

        public void setTitle(string title)
        {
            this.setProperty("title", title);
        }

        public DateTime getDate()
        {
            return Convert.ToDateTime(this.getProperty("date"));
        }

        public void setDate(DateTime date)
        {
            this.setProperty("date", date);
        }

        public CustomReport getCustomReport()
        {
            return (CustomReport)this.getProperty("customReport");
        }

        public void setCustomReport(CustomReport customReport)
        {
            this.setProperty("customReport", customReport);
        }

        public string getOrientation()
        {
            return this.getProperty("orientation").ToString();
        }

        public void setOrientation(string orientation)
        {
            this.setProperty("orientation", orientation);
        }

        public bool getRemoveBlankRows()
        {
            return Convert.ToBoolean(this.getProperty("removeBlankRows"));
        }

        public void setRemoveBlankRows(bool removeBlankRows)
        {
            this.setProperty("removeBlankRows", removeBlankRows);
        }

        public string getTemplate()
        {
            return this.getProperty("template").ToString();
        }

        public void setTemplate(string template)
        {
            this.setProperty("template", template);
        }

        public bool getSharedWithGuardians()
        {
            return Convert.ToBoolean(this.getProperty("sharedWithGuardians"));
        }

        public void setSharedWithGuardians(bool sharedWithGuardians)
        {
            this.setProperty("sharedWithGuardians", sharedWithGuardians);
        }

        public bool getSharedWithStudents()
        {
            return Convert.ToBoolean(this.getProperty("sharedWithStudents"));
        }

        public void setSharedWithStudents(bool sharedWithStudents)
        {
            this.setProperty("sharedWithStudents", sharedWithStudents);
        }

        public DateTime getDeletionStartedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("deletionStartedDatetime"));
        }

        public void setDeletionStartedDatetime(DateTime deletionStartedDatetime)
        {
            this.setProperty("deletionStartedDatetime", deletionStartedDatetime);
        }


    }
}

