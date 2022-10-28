using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PositionBusinessRole : ModelBase
    {
        protected new string resourceType = ResourceType.POSITION_BUSINESS_ROLE;
        public const string POSITION = "position";
        public const string BUSINESS_ROLE = "businessRole";
        public const string RANKING = "ranking";

        public PositionBusinessRole()
        {
            base.resourceType = this.resourceType;
        }

        public PositionBusinessRole(string resourceType = "PositionBusinessRole", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<PositionBusinessRole> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("PositionBusinessRole");
            RestGateway gateway = (RestGateway)PositionBusinessRole.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<PositionBusinessRole> positionbusinessroleCollection = new ModelCollection<PositionBusinessRole>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                positionbusinessroleCollection.add((PositionBusinessRole)model);
            }

            return positionbusinessroleCollection;
        }

        public static PositionBusinessRole retrieve(string id)
        {
            RestGateway gateway = (RestGateway)PositionBusinessRole.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (PositionBusinessRole)gateway.retrieve(ResourceType.POSITION_BUSINESS_ROLE, id);
        }

        public Position getPosition()
        {
            return (Position)this.getProperty("position");
        }

        public void setPosition(Position position)
        {
            this.setProperty("position", position);
        }

        public BusinessRole getBusinessRole()
        {
            return (BusinessRole)this.getProperty("businessRole");
        }

        public void setBusinessRole(BusinessRole businessRole)
        {
            this.setProperty("businessRole", businessRole);
        }

        public int getRanking()
        {
            return Convert.ToInt32(this.getProperty("ranking"));
        }

        public void setRanking(int ranking)
        {
            this.setProperty("ranking", ranking);
        }


    }
}

