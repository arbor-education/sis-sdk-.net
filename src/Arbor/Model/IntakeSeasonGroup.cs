using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IntakeSeasonGroup : ModelBase
    {
        protected new string resourceType = ResourceType.INTAKE_SEASON_GROUP;
        public const string GROUP_NAME = "groupName";
        public const string INTAKE_SEASON = "intakeSeason";
        public const string EXPECTED_ADMISSION_DATE = "expectedAdmissionDate";

        public IntakeSeasonGroup()
        {
            base.resourceType = this.resourceType;
        }

        public IntakeSeasonGroup(string resourceType = "IntakeSeasonGroup", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<IntakeSeasonGroup> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("IntakeSeasonGroup");
            RestGateway gateway = (RestGateway)IntakeSeasonGroup.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<IntakeSeasonGroup> intakeseasongroupCollection = new ModelCollection<IntakeSeasonGroup>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                intakeseasongroupCollection.add((IntakeSeasonGroup)model);
            }

            return intakeseasongroupCollection;
        }

        public static IntakeSeasonGroup retrieve(string id)
        {
            RestGateway gateway = (RestGateway)IntakeSeasonGroup.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (IntakeSeasonGroup)gateway.retrieve(ResourceType.INTAKE_SEASON_GROUP, id);
        }

        public string getGroupName()
        {
            return this.getProperty("groupName").ToString();
        }

        public void setGroupName(string groupName)
        {
            this.setProperty("groupName", groupName);
        }

        public IntakeSeason getIntakeSeason()
        {
            return (IntakeSeason)this.getProperty("intakeSeason");
        }

        public void setIntakeSeason(IntakeSeason intakeSeason)
        {
            this.setProperty("intakeSeason", intakeSeason);
        }

        public DateTime getExpectedAdmissionDate()
        {
            return Convert.ToDateTime(this.getProperty("expectedAdmissionDate"));
        }

        public void setExpectedAdmissionDate(DateTime expectedAdmissionDate)
        {
            this.setProperty("expectedAdmissionDate", expectedAdmissionDate);
        }


    }
}

