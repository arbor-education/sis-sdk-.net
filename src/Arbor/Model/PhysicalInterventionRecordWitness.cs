using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PhysicalInterventionRecordWitness : ModelBase
    {
        protected string resourceType = ResourceType.PHYSICAL_INTERVENTION_RECORD_WITNESS;
        public const string PHYSICAL_INTERVENTION_RECORD = "physicalInterventionRecord";
        public const string WITNESS = "witness";
        public const string NARRATIVE = "narrative";
        public const string CONFIRMED_DATETIME = "confirmedDatetime";
        public const string REJECTED_DATETIME = "rejectedDatetime";

        public PhysicalInterventionRecordWitness()
        {
            base.resourceType = this.resourceType;
        }

        public PhysicalInterventionRecordWitness(string resourceType = "PhysicalInterventionRecordWitness", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PhysicalInterventionRecordWitness> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PhysicalInterventionRecordWitness");
            RestGateway gateway = (RestGateway)PhysicalInterventionRecordWitness.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PhysicalInterventionRecordWitness> physicalinterventionrecordwitnessCollection = new ModelCollection<PhysicalInterventionRecordWitness>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                physicalinterventionrecordwitnessCollection.add((PhysicalInterventionRecordWitness)model);
            }

            return physicalinterventionrecordwitnessCollection;
        }

        public static PhysicalInterventionRecordWitness retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PhysicalInterventionRecordWitness.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PhysicalInterventionRecordWitness)gateway.retrieve(ResourceType.PHYSICAL_INTERVENTION_RECORD_WITNESS, id);
        }

        public PhysicalInterventionRecord getPhysicalInterventionRecord()
        {
            return (PhysicalInterventionRecord)this.getProperty("physicalInterventionRecord");
        }

        public void setPhysicalInterventionRecord(PhysicalInterventionRecord physicalInterventionRecord)
        {
            this.setProperty("physicalInterventionRecord", physicalInterventionRecord);
        }

        public ModelBase getWitness()
        {
            return (ModelBase)this.getProperty("witness");
        }

        public void setWitness(ModelBase witness)
        {
            this.setProperty("witness", witness);
        }

        public string getNarrative()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative(string narrative)
        {
            this.setProperty("narrative", narrative);
        }

        public DateTime getConfirmedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("confirmedDatetime"));
        }

        public void setConfirmedDatetime(DateTime confirmedDatetime)
        {
            this.setProperty("confirmedDatetime", confirmedDatetime);
        }

        public DateTime getRejectedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("rejectedDatetime"));
        }

        public void setRejectedDatetime(DateTime rejectedDatetime)
        {
            this.setProperty("rejectedDatetime", rejectedDatetime);
        }


    }
}

