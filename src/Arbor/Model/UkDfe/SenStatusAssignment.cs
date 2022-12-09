using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class SenStatusAssignment : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_SEN_STATUS_ASSIGNMENT;
        public const string IS_MEMBER_OF_SEN_UNIT = "isMemberOfSenUnit";
        public const string HAS_RESOURCED_PROVISION = "hasResourcedProvision";

        public SenStatusAssignment()
        {
            base.resourceType = this.resourceType;
        }

        public SenStatusAssignment(string resourceType = "SenStatusAssignment", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SenStatusAssignment> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_SenStatusAssignment");
            RestGateway gateway = (RestGateway)SenStatusAssignment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SenStatusAssignment> senstatusassignmentCollection = new ModelCollection<SenStatusAssignment>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                senstatusassignmentCollection.add((SenStatusAssignment)model);
            }

            return senstatusassignmentCollection;
        }

        public static SenStatusAssignment retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SenStatusAssignment.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SenStatusAssignment)gateway.retrieve(ResourceType.UK_DFE_SEN_STATUS_ASSIGNMENT, id);
        }

        public bool getIsMemberOfSenUnit()
        {
            return Convert.ToBoolean(this.getProperty("isMemberOfSenUnit"));
        }

        public void setIsMemberOfSenUnit(bool isMemberOfSenUnit)
        {
            this.setProperty("isMemberOfSenUnit", isMemberOfSenUnit);
        }

        public bool getHasResourcedProvision()
        {
            return Convert.ToBoolean(this.getProperty("hasResourcedProvision"));
        }

        public void setHasResourcedProvision(bool hasResourcedProvision)
        {
            this.setProperty("hasResourcedProvision", hasResourcedProvision);
        }


    }
}

