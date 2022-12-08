using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CheckType : ModelBase
    {
        protected string resourceType = ResourceType.CHECK_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string CHECK_NAME = "checkName";
        public const string IS_REQUESTED = "isRequested";
        public const string HAS_EXPIRY_DATE = "hasExpiryDate";
        public const string HAS_REFERENCE_NUMBER = "hasReferenceNumber";
        public const string EVIDENCE_REQUIRED = "evidenceRequired";
        public const string RELATED_ENTITY_TYPE = "relatedEntityType";
        public const string REQUEST_FROM_ALL_STAFF = "requestFromAllStaff";
        public const string REQUEST_FROM_TEACHING_STAFF = "requestFromTeachingStaff";

        public CheckType()
        {
            base.resourceType = this.resourceType;
        }

        public CheckType(string resourceType = "CheckType", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<CheckType> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("CheckType");
            RestGateway gateway = (RestGateway)CheckType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<CheckType> checktypeCollection = new ModelCollection<CheckType>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                checktypeCollection.add((CheckType)model);
            }

            return checktypeCollection;
        }

        public static CheckType retrieve(string id)
        {
            RestGateway gateway = (RestGateway)CheckType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (CheckType)gateway.retrieve(ResourceType.CHECK_TYPE, id);
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

        public string getCheckName()
        {
            return this.getProperty("checkName").ToString();
        }

        public void setCheckName(string checkName)
        {
            this.setProperty("checkName", checkName);
        }

        public bool getIsRequested()
        {
            return Convert.ToBoolean(this.getProperty("isRequested"));
        }

        public void setIsRequested(bool isRequested)
        {
            this.setProperty("isRequested", isRequested);
        }

        public bool getHasExpiryDate()
        {
            return Convert.ToBoolean(this.getProperty("hasExpiryDate"));
        }

        public void setHasExpiryDate(bool hasExpiryDate)
        {
            this.setProperty("hasExpiryDate", hasExpiryDate);
        }

        public bool getHasReferenceNumber()
        {
            return Convert.ToBoolean(this.getProperty("hasReferenceNumber"));
        }

        public void setHasReferenceNumber(bool hasReferenceNumber)
        {
            this.setProperty("hasReferenceNumber", hasReferenceNumber);
        }

        public bool getEvidenceRequired()
        {
            return Convert.ToBoolean(this.getProperty("evidenceRequired"));
        }

        public void setEvidenceRequired(bool evidenceRequired)
        {
            this.setProperty("evidenceRequired", evidenceRequired);
        }

        public string getRelatedEntityType()
        {
            return this.getProperty("relatedEntityType").ToString();
        }

        public void setRelatedEntityType(string relatedEntityType)
        {
            this.setProperty("relatedEntityType", relatedEntityType);
        }

        public string getRequestFromAllStaff()
        {
            return this.getProperty("requestFromAllStaff").ToString();
        }

        public void setRequestFromAllStaff(string requestFromAllStaff)
        {
            this.setProperty("requestFromAllStaff", requestFromAllStaff);
        }

        public string getRequestFromTeachingStaff()
        {
            return this.getProperty("requestFromTeachingStaff").ToString();
        }

        public void setRequestFromTeachingStaff(string requestFromTeachingStaff)
        {
            this.setProperty("requestFromTeachingStaff", requestFromTeachingStaff);
        }


    }
}

