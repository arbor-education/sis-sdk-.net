using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PhysicalInterventionTechnique : ModelBase
    {
        protected new string resourceType = ResourceType.PHYSICAL_INTERVENTION_TECHNIQUE;
        public const string NAME = "name";
        public const string DESCRIPTION = "description";

        public PhysicalInterventionTechnique()
        {
            base.resourceType = this.resourceType;
        }

        public PhysicalInterventionTechnique(string resourceType = "PhysicalInterventionTechnique", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PhysicalInterventionTechnique> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PhysicalInterventionTechnique");
            RestGateway gateway = (RestGateway)PhysicalInterventionTechnique.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PhysicalInterventionTechnique> physicalinterventiontechniqueCollection = new ModelCollection<PhysicalInterventionTechnique>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                physicalinterventiontechniqueCollection.add((PhysicalInterventionTechnique)model);
            }

            return physicalinterventiontechniqueCollection;
        }

        public static PhysicalInterventionTechnique retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PhysicalInterventionTechnique.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PhysicalInterventionTechnique)gateway.retrieve(ResourceType.PHYSICAL_INTERVENTION_TECHNIQUE, id);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }

        public string getDescription()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription(string description)
        {
            this.setProperty("description", description);
        }


    }
}

