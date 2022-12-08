using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DietaryRequirement : ModelBase
    {
        protected string resourceType = ResourceType.DIETARY_REQUIREMENT;
        public const string PERSON = "person";
        public const string DIETARY_REQUIREMENT_TYPE = "dietaryRequirementType";
        public const string NOTE = "note";

        public DietaryRequirement()
        {
            base.resourceType = this.resourceType;
        }

        public DietaryRequirement(string resourceType = "DietaryRequirement", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<DietaryRequirement> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("DietaryRequirement");
            RestGateway gateway = (RestGateway)DietaryRequirement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<DietaryRequirement> dietaryrequirementCollection = new ModelCollection<DietaryRequirement>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                dietaryrequirementCollection.add((DietaryRequirement)model);
            }

            return dietaryrequirementCollection;
        }

        public static DietaryRequirement retrieve(string id)
        {
            RestGateway gateway = (RestGateway)DietaryRequirement.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (DietaryRequirement)gateway.retrieve(ResourceType.DIETARY_REQUIREMENT, id);
        }

        public ModelBase getPerson()
        {
            return (ModelBase)this.getProperty("person");
        }

        public void setPerson(ModelBase person)
        {
            this.setProperty("person", person);
        }

        public DietaryRequirementType getDietaryRequirementType()
        {
            return (DietaryRequirementType)this.getProperty("dietaryRequirementType");
        }

        public void setDietaryRequirementType(DietaryRequirementType dietaryRequirementType)
        {
            this.setProperty("dietaryRequirementType", dietaryRequirementType);
        }

        public string getNote()
        {
            return this.getProperty("note").ToString();
        }

        public void setNote(string note)
        {
            this.setProperty("note", note);
        }


    }
}

