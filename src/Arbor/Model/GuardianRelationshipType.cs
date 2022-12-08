using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class GuardianRelationshipType : ModelBase
    {
        protected string resourceType = ResourceType.GUARDIAN_RELATIONSHIP_TYPE;
        public const string D00033 = "d00033";
        public const string D00034 = "d00034";
        public const string CTF_EXPORT_CODE = "ctfExportCode";
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string RELATIONSHIP_NAME = "relationshipName";
        public const string SHORT_NAME = "shortName";
        public const string IS_MALE = "isMale";
        public const string IS_FEMALE = "isFemale";
        public const string IS_SIBLING = "isSibling";

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
            query.setResourceType("GuardianRelationshipType");
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
            return (GuardianRelationshipType)gateway.retrieve(ResourceType.GUARDIAN_RELATIONSHIP_TYPE, id);
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

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive(bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder(int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getRelationshipName()
        {
            return this.getProperty("relationshipName").ToString();
        }

        public void setRelationshipName(string relationshipName)
        {
            this.setProperty("relationshipName", relationshipName);
        }

        public string getShortName()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName(string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public bool getIsMale()
        {
            return Convert.ToBoolean(this.getProperty("isMale"));
        }

        public void setIsMale(bool isMale)
        {
            this.setProperty("isMale", isMale);
        }

        public bool getIsFemale()
        {
            return Convert.ToBoolean(this.getProperty("isFemale"));
        }

        public void setIsFemale(bool isFemale)
        {
            this.setProperty("isFemale", isFemale);
        }

        public bool getIsSibling()
        {
            return Convert.ToBoolean(this.getProperty("isSibling"));
        }

        public void setIsSibling(bool isSibling)
        {
            this.setProperty("isSibling", isSibling);
        }


    }
}

