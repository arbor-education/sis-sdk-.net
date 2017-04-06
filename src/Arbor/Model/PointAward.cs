using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PointAward : ModelBase
    {
        protected string resourceType = ResourceType.POINT_AWARD;
        public const string POINT_AWARD_SCALE = "pointAwardScale";
        public const string STUDENT = "student";
        public const string SESSION = "session";
        public const string POINT_AWARD_CATEGORY = "pointAwardCategory";
        public const string POINTS = "points";
        public const string AWARDED_DATETIME = "awardedDatetime";
        public const string NARRATIVE = "narrative";

        public PointAward ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PointAward (string resourceType = "PointAward", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PointAward> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("PointAward");
        	RestGateway gateway = (RestGateway) PointAward.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PointAward> pointawardCollection = new ModelCollection<PointAward> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    pointawardCollection.add((PointAward) model);
        	}
        
        	return pointawardCollection;
        }

        public static PointAward retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PointAward.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PointAward) gateway.retrieve(ResourceType.POINT_AWARD, id);
        }

        public PointAwardScale getPointAwardScale ()
        {
            return (PointAwardScale) this.getProperty("pointAwardScale");
        }

        public void setPointAwardScale (PointAwardScale pointAwardScale)
        {
            this.setProperty("pointAwardScale", pointAwardScale);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public Session getSession ()
        {
            return (Session) this.getProperty("session");
        }

        public void setSession (Session session)
        {
            this.setProperty("session", session);
        }

        public PointAwardCategory getPointAwardCategory ()
        {
            return (PointAwardCategory) this.getProperty("pointAwardCategory");
        }

        public void setPointAwardCategory (PointAwardCategory pointAwardCategory)
        {
            this.setProperty("pointAwardCategory", pointAwardCategory);
        }

        public float getPoints ()
        {
            return (float) this.getProperty("points");
        }

        public void setPoints (float points)
        {
            this.setProperty("points", points);
        }

        public DateTime getAwardedDatetime ()
        {
            return (DateTime) this.getProperty("awardedDatetime");
        }

        public void setAwardedDatetime (DateTime awardedDatetime)
        {
            this.setProperty("awardedDatetime", awardedDatetime);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }


    }
}

