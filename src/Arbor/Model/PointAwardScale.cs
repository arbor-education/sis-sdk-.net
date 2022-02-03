using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PointAwardScale : ModelBase
    {
        protected string resourceType = ResourceType.POINT_AWARD_SCALE;
        public const string POINT_AWARD_SCALE_NAME = "pointAwardScaleName";
        public const string SINGULAR_POINT_NAME = "singularPointName";
        public const string PLURAL_POINT_NAME = "pluralPointName";
        public const string CYCLE_OPENING_POINTS_BALANCE = "cycleOpeningPointsBalance";
        public const string TERM_OPENING_POINTS_BALANCE = "termOpeningPointsBalance";
        public const string ACADEMIC_YEAR_OPENING_POINTS_BALANCE = "academicYearOpeningPointsBalance";
        public const string LIFETIME_OPENING_POINTS_BALANCE = "lifetimeOpeningPointsBalance";
        public const string MIN_POINT_AWARD = "minPointAward";
        public const string MAX_POINT_AWARD = "maxPointAward";
        public const string DIRECTIONALITY = "directionality";
        public const string SHOW_IN_PARENT_PORTAL = "showInParentPortal";
        public const string SHOW_NARRATIVE_IN_PARENT_PORTAL = "showNarrativeInParentPortal";
        public const string SHOW_AWARDED_BY_IN_PARENT_PORTAL = "showAwardedByInParentPortal";
        public const string SHOW_EVENT_IN_PARENT_PORTAL = "showEventInParentPortal";

        public PointAwardScale ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PointAwardScale (string resourceType = "PointAwardScale", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PointAwardScale> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("PointAwardScale");
        	RestGateway gateway = (RestGateway) PointAwardScale.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PointAwardScale> pointawardscaleCollection = new ModelCollection<PointAwardScale> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    pointawardscaleCollection.add((PointAwardScale) model);
        	}
        
        	return pointawardscaleCollection;
        }

        public static PointAwardScale retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PointAwardScale.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PointAwardScale) gateway.retrieve(ResourceType.POINT_AWARD_SCALE, id);
        }

        public string getPointAwardScaleName ()
        {
            return this.getProperty("pointAwardScaleName").ToString();
        }

        public void setPointAwardScaleName (string pointAwardScaleName)
        {
            this.setProperty("pointAwardScaleName", pointAwardScaleName);
        }

        public string getSingularPointName ()
        {
            return this.getProperty("singularPointName").ToString();
        }

        public void setSingularPointName (string singularPointName)
        {
            this.setProperty("singularPointName", singularPointName);
        }

        public string getPluralPointName ()
        {
            return this.getProperty("pluralPointName").ToString();
        }

        public void setPluralPointName (string pluralPointName)
        {
            this.setProperty("pluralPointName", pluralPointName);
        }

        public float getCycleOpeningPointsBalance ()
        {
            return (float) this.getProperty("cycleOpeningPointsBalance");
        }

        public void setCycleOpeningPointsBalance (float cycleOpeningPointsBalance)
        {
            this.setProperty("cycleOpeningPointsBalance", cycleOpeningPointsBalance);
        }

        public float getTermOpeningPointsBalance ()
        {
            return (float) this.getProperty("termOpeningPointsBalance");
        }

        public void setTermOpeningPointsBalance (float termOpeningPointsBalance)
        {
            this.setProperty("termOpeningPointsBalance", termOpeningPointsBalance);
        }

        public float getAcademicYearOpeningPointsBalance ()
        {
            return (float) this.getProperty("academicYearOpeningPointsBalance");
        }

        public void setAcademicYearOpeningPointsBalance (float academicYearOpeningPointsBalance)
        {
            this.setProperty("academicYearOpeningPointsBalance", academicYearOpeningPointsBalance);
        }

        public float getLifetimeOpeningPointsBalance ()
        {
            return (float) this.getProperty("lifetimeOpeningPointsBalance");
        }

        public void setLifetimeOpeningPointsBalance (float lifetimeOpeningPointsBalance)
        {
            this.setProperty("lifetimeOpeningPointsBalance", lifetimeOpeningPointsBalance);
        }

        public float getMinPointAward ()
        {
            return (float) this.getProperty("minPointAward");
        }

        public void setMinPointAward (float minPointAward)
        {
            this.setProperty("minPointAward", minPointAward);
        }

        public float getMaxPointAward ()
        {
            return (float) this.getProperty("maxPointAward");
        }

        public void setMaxPointAward (float maxPointAward)
        {
            this.setProperty("maxPointAward", maxPointAward);
        }

        public string getDirectionality ()
        {
            return this.getProperty("directionality").ToString();
        }

        public void setDirectionality (string directionality)
        {
            this.setProperty("directionality", directionality);
        }

        public bool getShowInParentPortal ()
        {
            return Convert.ToBoolean(this.getProperty("showInParentPortal"));
        }

        public void setShowInParentPortal (bool showInParentPortal)
        {
            this.setProperty("showInParentPortal", showInParentPortal);
        }

        public bool getShowNarrativeInParentPortal ()
        {
            return Convert.ToBoolean(this.getProperty("showNarrativeInParentPortal"));
        }

        public void setShowNarrativeInParentPortal (bool showNarrativeInParentPortal)
        {
            this.setProperty("showNarrativeInParentPortal", showNarrativeInParentPortal);
        }

        public bool getShowAwardedByInParentPortal ()
        {
            return Convert.ToBoolean(this.getProperty("showAwardedByInParentPortal"));
        }

        public void setShowAwardedByInParentPortal (bool showAwardedByInParentPortal)
        {
            this.setProperty("showAwardedByInParentPortal", showAwardedByInParentPortal);
        }

        public bool getShowEventInParentPortal ()
        {
            return Convert.ToBoolean(this.getProperty("showEventInParentPortal"));
        }

        public void setShowEventInParentPortal (bool showEventInParentPortal)
        {
            this.setProperty("showEventInParentPortal", showEventInParentPortal);
        }


    }
}

