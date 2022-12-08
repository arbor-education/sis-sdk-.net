using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IntakeSeason : ModelBase
    {
        protected string resourceType = ResourceType.INTAKE_SEASON;
        public const string INTAKE_SEASON_NAME = "intakeSeasonName";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string PUBLISHED_ADMISSIONS_NUMBER = "publishedAdmissionsNumber";
        public const string TARGET_APPLICATION_NUMBER = "targetApplicationNumber";

        public IntakeSeason()
        {
            base.resourceType = this.resourceType;
        }

        public IntakeSeason(string resourceType = "IntakeSeason", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<IntakeSeason> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("IntakeSeason");
            RestGateway gateway = (RestGateway)IntakeSeason.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<IntakeSeason> intakeseasonCollection = new ModelCollection<IntakeSeason>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                intakeseasonCollection.add((IntakeSeason)model);
            }

            return intakeseasonCollection;
        }

        public static IntakeSeason retrieve(string id)
        {
            RestGateway gateway = (RestGateway)IntakeSeason.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (IntakeSeason)gateway.retrieve(ResourceType.INTAKE_SEASON, id);
        }

        public string getIntakeSeasonName()
        {
            return this.getProperty("intakeSeasonName").ToString();
        }

        public void setIntakeSeasonName(string intakeSeasonName)
        {
            this.setProperty("intakeSeasonName", intakeSeasonName);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
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

        public int getPublishedAdmissionsNumber()
        {
            return Convert.ToInt32(this.getProperty("publishedAdmissionsNumber"));
        }

        public void setPublishedAdmissionsNumber(int publishedAdmissionsNumber)
        {
            this.setProperty("publishedAdmissionsNumber", publishedAdmissionsNumber);
        }

        public int getTargetApplicationNumber()
        {
            return Convert.ToInt32(this.getProperty("targetApplicationNumber"));
        }

        public void setTargetApplicationNumber(int targetApplicationNumber)
        {
            this.setProperty("targetApplicationNumber", targetApplicationNumber);
        }


    }
}

