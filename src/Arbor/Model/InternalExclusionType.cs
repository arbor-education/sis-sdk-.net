using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InternalExclusionType : ModelBase
    {
        protected new string resourceType = ResourceType.INTERNAL_EXCLUSION_TYPE;
        public const string INTERNAL_EXCLUSION_TYPE_NAME = "internalExclusionTypeName";
        public const string ACADEMIC_YEAR = "academicYear";

        public InternalExclusionType()
        {
            base.resourceType = this.resourceType;
        }

        public InternalExclusionType(string resourceType = "InternalExclusionType", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<InternalExclusionType> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("InternalExclusionType");
            RestGateway gateway = (RestGateway)InternalExclusionType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<InternalExclusionType> internalexclusiontypeCollection = new ModelCollection<InternalExclusionType>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                internalexclusiontypeCollection.add((InternalExclusionType)model);
            }

            return internalexclusiontypeCollection;
        }

        public static InternalExclusionType retrieve(string id)
        {
            RestGateway gateway = (RestGateway)InternalExclusionType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (InternalExclusionType)gateway.retrieve(ResourceType.INTERNAL_EXCLUSION_TYPE, id);
        }

        public string getInternalExclusionTypeName()
        {
            return this.getProperty("internalExclusionTypeName").ToString();
        }

        public void setInternalExclusionTypeName(string internalExclusionTypeName)
        {
            this.setProperty("internalExclusionTypeName", internalExclusionTypeName);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }


    }
}

