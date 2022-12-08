using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DetentionType : ModelBase
    {
        protected string resourceType = ResourceType.DETENTION_TYPE;
        public const string DETENTION_TYPE_NAME = "detentionTypeName";
        public const string ACADEMIC_YEAR = "academicYear";

        public DetentionType()
        {
            base.resourceType = this.resourceType;
        }

        public DetentionType(string resourceType = "DetentionType", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<DetentionType> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("DetentionType");
            RestGateway gateway = (RestGateway)DetentionType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<DetentionType> detentiontypeCollection = new ModelCollection<DetentionType>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                detentiontypeCollection.add((DetentionType)model);
            }

            return detentiontypeCollection;
        }

        public static DetentionType retrieve(string id)
        {
            RestGateway gateway = (RestGateway)DetentionType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (DetentionType)gateway.retrieve(ResourceType.DETENTION_TYPE, id);
        }

        public string getDetentionTypeName()
        {
            return this.getProperty("detentionTypeName").ToString();
        }

        public void setDetentionTypeName(string detentionTypeName)
        {
            this.setProperty("detentionTypeName", detentionTypeName);
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

