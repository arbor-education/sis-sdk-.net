using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class NewsFeedMapping : ModelBase
    {
        protected string resourceType = ResourceType.NEWS_FEED_MAPPING;
        public const string PERSON = "person";
        public const string NEWS_STORY = "newsStory";
        public const string RANK = "rank";
        public const string RANK_VALID_UNTIL = "rankValidUntil";

        public NewsFeedMapping ()
        {
            base.resourceType = this.resourceType;
        }
        
        public NewsFeedMapping (string resourceType = "NewsFeedMapping", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<NewsFeedMapping> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("NewsFeedMapping");
        	RestGateway gateway = (RestGateway) NewsFeedMapping.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<NewsFeedMapping> newsfeedmappingCollection = new ModelCollection<NewsFeedMapping> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    newsfeedmappingCollection.add((NewsFeedMapping) model);
        	}
        
        	return newsfeedmappingCollection;
        }

        public static NewsFeedMapping retrieve (string id)
        {
            RestGateway gateway = (RestGateway) NewsFeedMapping.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (NewsFeedMapping) gateway.retrieve(ResourceType.NEWS_FEED_MAPPING, id);
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

        public float getRank ()
        {
            return (float) this.getProperty("rank");
        }

        public void setRank (float rank)
        {
            this.setProperty("rank", rank);
        }

        public DateTime getRankValidUntil ()
        {
            return (DateTime) this.getProperty("rankValidUntil");
        }

        public void setRankValidUntil (DateTime rankValidUntil)
        {
            this.setProperty("rankValidUntil", rankValidUntil);
        }


    }
}

