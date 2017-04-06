using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PointAwardTotal : ModelBase
    {
        protected string resourceType = ResourceType.POINT_AWARD_TOTAL;
        public const string STUDENT = "student";
        public const string POINT_AWARD_SCALE = "pointAwardScale";
        public const string PERIOD_TYPE = "periodType";
        public const string PERIOD_START_DATE = "periodStartDate";
        public const string PERIOD_END_DATE = "periodEndDate";
        public const string TOTAL_POINTS = "totalPoints";

        public PointAwardTotal ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PointAwardTotal (string resourceType = "PointAwardTotal", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PointAwardTotal> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("PointAwardTotal");
        	RestGateway gateway = (RestGateway) PointAwardTotal.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PointAwardTotal> pointawardtotalCollection = new ModelCollection<PointAwardTotal> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    pointawardtotalCollection.add((PointAwardTotal) model);
        	}
        
        	return pointawardtotalCollection;
        }

        public static PointAwardTotal retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PointAwardTotal.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PointAwardTotal) gateway.retrieve(ResourceType.POINT_AWARD_TOTAL, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public PointAwardScale getPointAwardScale ()
        {
            return (PointAwardScale) this.getProperty("pointAwardScale");
        }

        public void setPointAwardScale (PointAwardScale pointAwardScale)
        {
            this.setProperty("pointAwardScale", pointAwardScale);
        }

        public string getPeriodType ()
        {
            return this.getProperty("periodType").ToString();
        }

        public void setPeriodType (string periodType)
        {
            this.setProperty("periodType", periodType);
        }

        public DateTime getPeriodStartDate ()
        {
            return (DateTime) this.getProperty("periodStartDate");
        }

        public void setPeriodStartDate (DateTime periodStartDate)
        {
            this.setProperty("periodStartDate", periodStartDate);
        }

        public DateTime getPeriodEndDate ()
        {
            return (DateTime) this.getProperty("periodEndDate");
        }

        public void setPeriodEndDate (DateTime periodEndDate)
        {
            this.setProperty("periodEndDate", periodEndDate);
        }

        public float getTotalPoints ()
        {
            return (float) this.getProperty("totalPoints");
        }

        public void setTotalPoints (float totalPoints)
        {
            this.setProperty("totalPoints", totalPoints);
        }


    }
}

