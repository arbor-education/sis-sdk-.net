using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class GuardianRelationshipType : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_GUARDIAN_RELATIONSHIP_TYPE;
        public const string D00033 = "d00033";
        public const string D00034 = "d00034";
        public const string CTF_EXPORT_CODE = "ctfExportCode";

        public GuardianRelationshipType()
        {
            base.resourceType = this.resourceType;
        }

        public GuardianRelationshipType(string resourceType = "GuardianRelationshipType", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<GuardianRelationshipType> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_GuardianRelationshipType");
            RestGateway gateway = (RestGateway)GuardianRelationshipType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<GuardianRelationshipType> guardianrelationshiptypeCollection = new ModelCollection<GuardianRelationshipType>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                guardianrelationshiptypeCollection.add((GuardianRelationshipType)model);
            }

            return guardianrelationshiptypeCollection;
        }

        public static GuardianRelationshipType retrieve(string id)
        {
            RestGateway gateway = (RestGateway)GuardianRelationshipType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (GuardianRelationshipType)gateway.retrieve(ResourceType.UK_DFE_GUARDIAN_RELATIONSHIP_TYPE, id);
        }

        public string getD00033()
        {
            return this.getProperty("d00033").ToString();
        }

        public void setD00033(string d00033)
        {
            this.setProperty("d00033", d00033);
        }

        public string getD00034()
        {
            return this.getProperty("d00034").ToString();
        }

        public void setD00034(string d00034)
        {
            this.setProperty("d00034", d00034);
        }

        public string getCtfExportCode()
        {
            return this.getProperty("ctfExportCode").ToString();
        }

        public void setCtfExportCode(string ctfExportCode)
        {
            this.setProperty("ctfExportCode", ctfExportCode);
        }


    }
}

