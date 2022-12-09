using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CustomGroupMembershipCriterion : ModelBase
    {
        protected new string resourceType = ResourceType.CUSTOM_GROUP_MEMBERSHIP_CRITERION;
        public const string CUSTOM_GROUP = "customGroup";
        public const string FIELD_CLASS = "fieldClass";
        public const string FIELD_PARAMS = "fieldParams";
        public const string TRANSFORMATION_CLASS = "transformationClass";
        public const string CONDITION_CLASS = "conditionClass";
        public const string CONDITION_PARAMS = "conditionParams";

        public CustomGroupMembershipCriterion()
        {
            base.resourceType = this.resourceType;
        }

        public CustomGroupMembershipCriterion(string resourceType = "CustomGroupMembershipCriterion", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CustomGroupMembershipCriterion> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CustomGroupMembershipCriterion");
            RestGateway gateway = (RestGateway)CustomGroupMembershipCriterion.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CustomGroupMembershipCriterion> customgroupmembershipcriterionCollection = new ModelCollection<CustomGroupMembershipCriterion>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                customgroupmembershipcriterionCollection.add((CustomGroupMembershipCriterion)model);
            }

            return customgroupmembershipcriterionCollection;
        }

        public static CustomGroupMembershipCriterion retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CustomGroupMembershipCriterion.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CustomGroupMembershipCriterion)gateway.retrieve(ResourceType.CUSTOM_GROUP_MEMBERSHIP_CRITERION, id);
        }

        public CustomGroup getCustomGroup()
        {
            return (CustomGroup)this.getProperty("customGroup");
        }

        public void setCustomGroup(CustomGroup customGroup)
        {
            this.setProperty("customGroup", customGroup);
        }

        public string getFieldClass()
        {
            return this.getProperty("fieldClass").ToString();
        }

        public void setFieldClass(string fieldClass)
        {
            this.setProperty("fieldClass", fieldClass);
        }

        public string getFieldParams()
        {
            return this.getProperty("fieldParams").ToString();
        }

        public void setFieldParams(string fieldParams)
        {
            this.setProperty("fieldParams", fieldParams);
        }

        public string getTransformationClass()
        {
            return this.getProperty("transformationClass").ToString();
        }

        public void setTransformationClass(string transformationClass)
        {
            this.setProperty("transformationClass", transformationClass);
        }

        public string getConditionClass()
        {
            return this.getProperty("conditionClass").ToString();
        }

        public void setConditionClass(string conditionClass)
        {
            this.setProperty("conditionClass", conditionClass);
        }

        public string getConditionParams()
        {
            return this.getProperty("conditionParams").ToString();
        }

        public void setConditionParams(string conditionParams)
        {
            this.setProperty("conditionParams", conditionParams);
        }


    }
}

