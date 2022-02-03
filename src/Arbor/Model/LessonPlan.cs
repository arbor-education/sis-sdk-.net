using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class LessonPlan : ModelBase
    {
        protected string resourceType = ResourceType.LESSON_PLAN;
        public const string TITLE = "title";
        public const string SUMMARY = "summary";

        public LessonPlan ()
        {
            base.resourceType = this.resourceType;
        }
        
        public LessonPlan (string resourceType = "LessonPlan", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<LessonPlan> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("LessonPlan");
        	RestGateway gateway = (RestGateway) LessonPlan.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<LessonPlan> lessonplanCollection = new ModelCollection<LessonPlan> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    lessonplanCollection.add((LessonPlan) model);
        	}
        
        	return lessonplanCollection;
        }

        public static LessonPlan retrieve (string id)
        {
            RestGateway gateway = (RestGateway) LessonPlan.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (LessonPlan) gateway.retrieve(ResourceType.LESSON_PLAN, id);
        }

        public string getTitle ()
        {
            return this.getProperty("title").ToString();
        }

        public void setTitle (string title)
        {
            this.setProperty("title", title);
        }

        public string getSummary ()
        {
            return this.getProperty("summary").ToString();
        }

        public void setSummary (string summary)
        {
            this.setProperty("summary", summary);
        }


    }
}

