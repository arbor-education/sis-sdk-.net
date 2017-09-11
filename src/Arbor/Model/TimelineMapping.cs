using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TimelineMapping : ModelBase
    {
        protected string resourceType = ResourceType.TIMELINE_MAPPING;
        public const string PERSON = "person";
        public const string NEWS_STORY = "newsStory";

        public TimelineMapping ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TimelineMapping (string resourceType = "TimelineMapping", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TimelineMapping> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("TimelineMapping");
        	RestGateway gateway = (RestGateway) TimelineMapping.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TimelineMapping> timelinemappingCollection = new ModelCollection<TimelineMapping> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    timelinemappingCollection.add((TimelineMapping) model);
        	}
        
        	return timelinemappingCollection;
        }

        public static TimelineMapping retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TimelineMapping.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TimelineMapping) gateway.retrieve(ResourceType.TIMELINE_MAPPING, id);
        }

        public ModelBase getPerson ()
        {
            return (ModelBase) this.getProperty("person");
        }

        public void setPerson (ModelBase person)
        {
            this.setProperty("person", person);
        }

        public NewsStory getNewsStory ()
        {
            return (NewsStory) this.getProperty("newsStory");
        }

        public void setNewsStory (NewsStory newsStory)
        {
            this.setProperty("newsStory", newsStory);
        }


    }
}

