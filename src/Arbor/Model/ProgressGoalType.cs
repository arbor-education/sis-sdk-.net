using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProgressGoalType : ModelBase
    {
        protected string resourceType = ResourceType.PROGRESS_GOAL_TYPE;
        public const string CODE = "code";
        public const string NAME = "name";

        public ProgressGoalType()
        {
            base.resourceType = this.resourceType;
        }

        public ProgressGoalType(string resourceType = "ProgressGoalType", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<ProgressGoalType> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("ProgressGoalType");
            RestGateway gateway = (RestGateway)ProgressGoalType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<ProgressGoalType> progressgoaltypeCollection = new ModelCollection<ProgressGoalType>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                progressgoaltypeCollection.add((ProgressGoalType)model);
            }

            return progressgoaltypeCollection;
        }

        public static ProgressGoalType retrieve(string id)
        {
            RestGateway gateway = (RestGateway)ProgressGoalType.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (ProgressGoalType)gateway.retrieve(ResourceType.PROGRESS_GOAL_TYPE, id);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }

        public string getName()
        {
            return this.getProperty("name").ToString();
        }

        public void setName(string name)
        {
            this.setProperty("name", name);
        }


    }
}

