using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationElementAvailability : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_ELEMENT_AVAILABILITY;
        public const string QUALIFICATION_AVAILABILITY_INSTANCE = "qualificationAvailabilityInstance";
        public const string QUALIFICATION_ELEMENT = "qualificationElement";

        public QualificationElementAvailability()
        {
            base.resourceType = this.resourceType;
        }

        public QualificationElementAvailability(string resourceType = "QualificationElementAvailability", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<QualificationElementAvailability> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("QualificationElementAvailability");
            RestGateway gateway = (RestGateway)QualificationElementAvailability.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<QualificationElementAvailability> qualificationelementavailabilityCollection = new ModelCollection<QualificationElementAvailability>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                qualificationelementavailabilityCollection.add((QualificationElementAvailability)model);
            }

            return qualificationelementavailabilityCollection;
        }

        public static QualificationElementAvailability retrieve(string id)
        {
            RestGateway gateway = (RestGateway)QualificationElementAvailability.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (QualificationElementAvailability)gateway.retrieve(ResourceType.QUALIFICATION_ELEMENT_AVAILABILITY, id);
        }

        public QualificationAvailabilityInstance getQualificationAvailabilityInstance()
        {
            return (QualificationAvailabilityInstance)this.getProperty("qualificationAvailabilityInstance");
        }

        public void setQualificationAvailabilityInstance(QualificationAvailabilityInstance qualificationAvailabilityInstance)
        {
            this.setProperty("qualificationAvailabilityInstance", qualificationAvailabilityInstance);
        }

        public ModelBase getQualificationElement()
        {
            return (ModelBase)this.getProperty("qualificationElement");
        }

        public void setQualificationElement(ModelBase qualificationElement)
        {
            this.setProperty("qualificationElement", qualificationElement);
        }


    }
}

