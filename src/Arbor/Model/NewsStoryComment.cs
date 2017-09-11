using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class NewsStoryComment : ModelBase
    {
        protected string resourceType = ResourceType.NEWS_STORY_COMMENT;
        public const string NEWS_STORY = "newsStory";
        public const string TEXT = "text";

        public NewsStoryComment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public NewsStoryComment (string resourceType = "NewsStoryComment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<NewsStoryComment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("NewsStoryComment");
        	RestGateway gateway = (RestGateway) NewsStoryComment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<NewsStoryComment> newsstorycommentCollection = new ModelCollection<NewsStoryComment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    newsstorycommentCollection.add((NewsStoryComment) model);
        	}
        
        	return newsstorycommentCollection;
        }

        public static NewsStoryComment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) NewsStoryComment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (NewsStoryComment) gateway.retrieve(ResourceType.NEWS_STORY_COMMENT, id);
        }

        public NewsStory getNewsStory ()
        {
            return (NewsStory) this.getProperty("newsStory");
        }

        public void setNewsStory (NewsStory newsStory)
        {
            this.setProperty("newsStory", newsStory);
        }

        public string getText ()
        {
            return this.getProperty("text").ToString();
        }

        public void setText (string text)
        {
            this.setProperty("text", text);
        }


    }
}

