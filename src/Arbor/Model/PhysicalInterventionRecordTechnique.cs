using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PhysicalInterventionRecordTechnique : ModelBase
    {
        protected string resourceType = ResourceType.PHYSICAL_INTERVENTION_RECORD_TECHNIQUE;
        public const string PHYSICAL_INTERVENTION_RECORD = "physicalInterventionRecord";
        public const string PHYSICAL_INTERVENTION_TECHNIQUE = "physicalInterventionTechnique";

        public PhysicalInterventionRecordTechnique()
        {
            base.resourceType = this.resourceType;
        }

        public PhysicalInterventionRecordTechnique(string resourceType = "PhysicalInterventionRecordTechnique", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PhysicalInterventionRecordTechnique> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PhysicalInterventionRecordTechnique");
            RestGateway gateway = (RestGateway)PhysicalInterventionRecordTechnique.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PhysicalInterventionRecordTechnique> physicalinterventionrecordtechniqueCollection = new ModelCollection<PhysicalInterventionRecordTechnique>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                physicalinterventionrecordtechniqueCollection.add((PhysicalInterventionRecordTechnique)model);
            }

            return physicalinterventionrecordtechniqueCollection;
        }

        public static PhysicalInterventionRecordTechnique retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PhysicalInterventionRecordTechnique.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PhysicalInterventionRecordTechnique)gateway.retrieve(ResourceType.PHYSICAL_INTERVENTION_RECORD_TECHNIQUE, id);
        }

        public PhysicalInterventionRecord getPhysicalInterventionRecord()
        {
            return (PhysicalInterventionRecord)this.getProperty("physicalInterventionRecord");
        }

        public void setPhysicalInterventionRecord(PhysicalInterventionRecord physicalInterventionRecord)
        {
            this.setProperty("physicalInterventionRecord", physicalInterventionRecord);
        }

        public PhysicalInterventionTechnique getPhysicalInterventionTechnique()
        {
            return (PhysicalInterventionTechnique)this.getProperty("physicalInterventionTechnique");
        }

        public void setPhysicalInterventionTechnique(PhysicalInterventionTechnique physicalInterventionTechnique)
        {
            this.setProperty("physicalInterventionTechnique", physicalInterventionTechnique);
        }


    }
}

