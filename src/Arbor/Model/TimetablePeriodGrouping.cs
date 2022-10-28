using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TimetablePeriodGrouping : ModelBase
    {
        protected new string resourceType = ResourceType.TIMETABLE_PERIOD_GROUPING;
        public const string ACADEMIC_YEAR = "academicYear";
        public const string NAME = "name";
        public const string SHORT_NAME = "shortName";
        public const string DISPLAY_ORDER = "displayOrder";

        public TimetablePeriodGrouping ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TimetablePeriodGrouping (string resourceType = "TimetablePeriodGrouping", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TimetablePeriodGrouping> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("TimetablePeriodGrouping");
        	RestGateway gateway = (RestGateway) TimetablePeriodGrouping.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TimetablePeriodGrouping> timetableperiodgroupingCollection = new ModelCollection<TimetablePeriodGrouping> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    timetableperiodgroupingCollection.add((TimetablePeriodGrouping) model);
        	}
        
        	return timetableperiodgroupingCollection;
        }

        public static TimetablePeriodGrouping retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TimetablePeriodGrouping.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TimetablePeriodGrouping) gateway.retrieve(ResourceType.TIMETABLE_PERIOD_GROUPING, id);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public int getDisplayOrder ()
        {
            return Convert.ToInt32(this.getProperty("displayOrder"));
        }

        public void setDisplayOrder (int displayOrder)
        {
            this.setProperty("displayOrder", displayOrder);
        }


    }
}

