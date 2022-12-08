using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationElementDisallowedCombination : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_ELEMENT_DISALLOWED_COMBINATION;
        public const string FIRST_ELEMENT = "firstElement";
        public const string SECOND_ELEMENT = "secondElement";

        public QualificationElementDisallowedCombination()
        {
            base.resourceType = this.resourceType;
        }

        public QualificationElementDisallowedCombination(string resourceType = "QualificationElementDisallowedCombination", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<QualificationElementDisallowedCombination> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("QualificationElementDisallowedCombination");
            RestGateway gateway = (RestGateway)QualificationElementDisallowedCombination.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<QualificationElementDisallowedCombination> qualificationelementdisallowedcombinationCollection = new ModelCollection<QualificationElementDisallowedCombination>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                qualificationelementdisallowedcombinationCollection.add((QualificationElementDisallowedCombination)model);
            }

            return qualificationelementdisallowedcombinationCollection;
        }

        public static QualificationElementDisallowedCombination retrieve(string id)
        {
            RestGateway gateway = (RestGateway)QualificationElementDisallowedCombination.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (QualificationElementDisallowedCombination)gateway.retrieve(ResourceType.QUALIFICATION_ELEMENT_DISALLOWED_COMBINATION, id);
        }

        public ModelBase getFirstElement()
        {
            return (ModelBase)this.getProperty("firstElement");
        }

        public void setFirstElement(ModelBase firstElement)
        {
            this.setProperty("firstElement", firstElement);
        }

        public ModelBase getSecondElement()
        {
            return (ModelBase)this.getProperty("secondElement");
        }

        public void setSecondElement(ModelBase secondElement)
        {
            this.setProperty("secondElement", secondElement);
        }


    }
}

