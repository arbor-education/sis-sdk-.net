using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TargetJudgement : ModelBase
    {
        protected string resourceType = ResourceType.TARGET_JUDGEMENT;
        public const string NAME = "name";
        public const string COLOR = "color";
        public const string TYPE = "type";
        public const string ORDER = "order";

        public TargetJudgement ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TargetJudgement (string resourceType = "TargetJudgement", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TargetJudgement> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("TargetJudgement");
        	RestGateway gateway = (RestGateway) TargetJudgement.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TargetJudgement> targetjudgementCollection = new ModelCollection<TargetJudgement> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    targetjudgementCollection.add((TargetJudgement) model);
        	}
        
        	return targetjudgementCollection;
        }

        public static TargetJudgement retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TargetJudgement.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TargetJudgement) gateway.retrieve(ResourceType.TARGET_JUDGEMENT, id);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public string getColor ()
        {
            return this.getProperty("color").ToString();
        }

        public void setColor (string color)
        {
            this.setProperty("color", color);
        }

        public string getType ()
        {
            return this.getProperty("type").ToString();
        }

        public void setType (string type)
        {
            this.setProperty("type", type);
        }

        public int getOrder ()
        {
            return Convert.ToInt32(this.getProperty("order"));
        }

        public void setOrder (int order)
        {
            this.setProperty("order", order);
        }


    }
}

