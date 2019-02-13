using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Tagging : ModelBase
    {
        protected string resourceType = ResourceType.TAGGING;
        public const string TAG = "tag";
        public const string TAGGED_OBJECT = "taggedObject";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string LINK1 = "link1";
        public const string LINK2 = "link2";

        public Tagging ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Tagging (string resourceType = "Tagging", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Tagging> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Tagging");
        	RestGateway gateway = (RestGateway) Tagging.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Tagging> taggingCollection = new ModelCollection<Tagging> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    taggingCollection.add((Tagging) model);
        	}
        
        	return taggingCollection;
        }

        public static Tagging retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Tagging.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Tagging) gateway.retrieve(ResourceType.TAGGING, id);
        }

        public Tag getTag ()
        {
            return (Tag) this.getProperty("tag");
        }

        public void setTag (Tag tag)
        {
            this.setProperty("tag", tag);
        }

        public ModelBase getTaggedObject ()
        {
            return (ModelBase) this.getProperty("taggedObject");
        }

        public void setTaggedObject (ModelBase taggedObject)
        {
            this.setProperty("taggedObject", taggedObject);
        }

        public DateTime getStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("startDate"))
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public ModelBase getLink1 ()
        {
            return (ModelBase) this.getProperty("link1");
        }

        public void setLink1 (ModelBase link1)
        {
            this.setProperty("link1", link1);
        }

        public ModelBase getLink2 ()
        {
            return (ModelBase) this.getProperty("link2");
        }

        public void setLink2 (ModelBase link2)
        {
            this.setProperty("link2", link2);
        }


    }
}

