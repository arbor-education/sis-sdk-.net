using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class NewsStory : ModelBase
    {
        protected string resourceType = ResourceType.NEWS_STORY;
        public const string REFERENCE_DATETIME = "referenceDatetime";
        public const string TITLE = "title";
        public const string PROFILE_PICTURE = "profilePicture";
        public const string IMAGE = "image";
        public const string CATEGORY = "category";
        public const string BODY = "body";
        public const string TYPE_SPECIFIC_RATING_FACTOR = "typeSpecificRatingFactor";
        public const string ORIGIN = "origin";
        public const string IDENTIFIER = "identifier";
        public const string TYPE = "type";
        public const string DATA = "data";
        public const string MAPPED_TO_NEWS_FEED = "mappedToNewsFeed";
        public const string COMMENT_COUNT = "commentCount";

        public NewsStory()
        {
            base.resourceType = this.resourceType;
        }

        public NewsStory(string resourceType = "NewsStory", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<NewsStory> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("NewsStory");
            RestGateway gateway = (RestGateway)NewsStory.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<NewsStory> newsstoryCollection = new ModelCollection<NewsStory>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                newsstoryCollection.add((NewsStory)model);
            }

            return newsstoryCollection;
        }

        public static NewsStory retrieve(string id)
        {
            RestGateway gateway = (RestGateway)NewsStory.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (NewsStory)gateway.retrieve(ResourceType.NEWS_STORY, id);
        }

        public DateTime getReferenceDatetime()
        {
            return (DateTime)this.getProperty("referenceDatetime");
        }

        public void setReferenceDatetime(DateTime referenceDatetime)
        {
            this.setProperty("referenceDatetime", referenceDatetime);
        }

        public string getTitle()
        {
            return this.getProperty("title").ToString();
        }

        public void setTitle(string title)
        {
            this.setProperty("title", title);
        }

        public Content getProfilePicture()
        {
            return (Content)this.getProperty("profilePicture");
        }

        public void setProfilePicture(Content profilePicture)
        {
            this.setProperty("profilePicture", profilePicture);
        }

        public string getImage()
        {
            return this.getProperty("image").ToString();
        }

        public void setImage(string image)
        {
            this.setProperty("image", image);
        }

        public string getCategory()
        {
            return this.getProperty("category").ToString();
        }

        public void setCategory(string category)
        {
            this.setProperty("category", category);
        }

        public string getBody()
        {
            return this.getProperty("body").ToString();
        }

        public void setBody(string body)
        {
            this.setProperty("body", body);
        }

        public float getTypeSpecificRatingFactor()
        {
            return (float)this.getProperty("typeSpecificRatingFactor");
        }

        public void setTypeSpecificRatingFactor(float typeSpecificRatingFactor)
        {
            this.setProperty("typeSpecificRatingFactor", typeSpecificRatingFactor);
        }

        public ModelBase getOrigin()
        {
            return (ModelBase)this.getProperty("origin");
        }

        public void setOrigin(ModelBase origin)
        {
            this.setProperty("origin", origin);
        }

        public string getIdentifier()
        {
            return this.getProperty("identifier").ToString();
        }

        public void setIdentifier(string identifier)
        {
            this.setProperty("identifier", identifier);
        }

        public string getType()
        {
            return this.getProperty("type").ToString();
        }

        public void setType(string type)
        {
            this.setProperty("type", type);
        }

        public string getData()
        {
            return this.getProperty("data").ToString();
        }

        public void setData(string data)
        {
            this.setProperty("data", data);
        }

        public bool getMappedToNewsFeed()
        {
            return (bool)this.getProperty("mappedToNewsFeed");
        }

        public void setMappedToNewsFeed(bool mappedToNewsFeed)
        {
            this.setProperty("mappedToNewsFeed", mappedToNewsFeed);
        }

        public int getCommentCount()
        {
            return Convert.ToInt32(this.getProperty("commentCount"));
        }

        public void setCommentCount(int commentCount)
        {
            this.setProperty("commentCount", commentCount);
        }


    }
}

