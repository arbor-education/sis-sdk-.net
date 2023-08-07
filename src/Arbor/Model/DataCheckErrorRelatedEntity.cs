using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DataCheckErrorRelatedEntity : ModelBase
    {
        protected string resourceType = ResourceType.DATA_CHECK_ERROR_RELATED_ENTITY;
        public const string DATA_CHECK_ERROR = "dataCheckError";
        public const string RELATED_ENTITY = "relatedEntity";

        public DataCheckErrorRelatedEntity()
        {
            base.resourceType = this.resourceType;
        }

        public DataCheckErrorRelatedEntity(string resourceType = "DataCheckErrorRelatedEntity", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<DataCheckErrorRelatedEntity> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("DataCheckErrorRelatedEntity");
            RestGateway gateway = (RestGateway)DataCheckErrorRelatedEntity.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<DataCheckErrorRelatedEntity> datacheckerrorrelatedentityCollection = new ModelCollection<DataCheckErrorRelatedEntity>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                datacheckerrorrelatedentityCollection.add((DataCheckErrorRelatedEntity)model);
            }

            return datacheckerrorrelatedentityCollection;
        }

        public static DataCheckErrorRelatedEntity retrieve(string id)
        {
            RestGateway gateway = (RestGateway)DataCheckErrorRelatedEntity.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (DataCheckErrorRelatedEntity)gateway.retrieve(ResourceType.DATA_CHECK_ERROR_RELATED_ENTITY, id);
        }

        public DataCheckError getDataCheckError()
        {
            return (DataCheckError)this.getProperty("dataCheckError");
        }

        public void setDataCheckError(DataCheckError dataCheckError)
        {
            this.setProperty("dataCheckError", dataCheckError);
        }

        public ModelBase getRelatedEntity()
        {
            return (ModelBase)this.getProperty("relatedEntity");
        }

        public void setRelatedEntity(ModelBase relatedEntity)
        {
            this.setProperty("relatedEntity", relatedEntity);
        }


    }
}

