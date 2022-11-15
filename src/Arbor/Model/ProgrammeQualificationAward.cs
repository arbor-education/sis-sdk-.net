using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProgrammeQualificationAward : ModelBase
    {
        protected new string resourceType = ResourceType.PROGRAMME_QUALIFICATION_AWARD;
        public const string PROGRAMME_INSTANCE = "programmeInstance";
        public const string QUALIFICATION_AWARD = "qualificationAward";

        public ProgrammeQualificationAward()
        {
            base.resourceType = this.resourceType;
        }

        public ProgrammeQualificationAward(string resourceType = "ProgrammeQualificationAward", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ProgrammeQualificationAward> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ProgrammeQualificationAward");
            RestGateway gateway = (RestGateway)ProgrammeQualificationAward.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ProgrammeQualificationAward> programmequalificationawardCollection = new ModelCollection<ProgrammeQualificationAward>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                programmequalificationawardCollection.add((ProgrammeQualificationAward)model);
            }

            return programmequalificationawardCollection;
        }

        public static ProgrammeQualificationAward retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ProgrammeQualificationAward.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ProgrammeQualificationAward)gateway.retrieve(ResourceType.PROGRAMME_QUALIFICATION_AWARD, id);
        }

        public ProgrammeInstance getProgrammeInstance()
        {
            return (ProgrammeInstance)this.getProperty("programmeInstance");
        }

        public void setProgrammeInstance(ProgrammeInstance programmeInstance)
        {
            this.setProperty("programmeInstance", programmeInstance);
        }

        public QualificationAward getQualificationAward()
        {
            return (QualificationAward)this.getProperty("qualificationAward");
        }

        public void setQualificationAward(QualificationAward qualificationAward)
        {
            this.setProperty("qualificationAward", qualificationAward);
        }


    }
}

