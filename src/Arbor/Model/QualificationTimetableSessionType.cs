using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationTimetableSessionType : ModelBase
    {
        protected new string resourceType = ResourceType.QUALIFICATION_TIMETABLE_SESSION_TYPE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string NAME = "name";
        public const string SHORT_NAME = "shortName";
        public const string START_TIME_FROM = "startTimeFrom";
        public const string START_TIME_UNTIL = "startTimeUntil";

        public QualificationTimetableSessionType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationTimetableSessionType (string resourceType = "QualificationTimetableSessionType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationTimetableSessionType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationTimetableSessionType");
        	RestGateway gateway = (RestGateway) QualificationTimetableSessionType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationTimetableSessionType> qualificationtimetablesessiontypeCollection = new ModelCollection<QualificationTimetableSessionType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationtimetablesessiontypeCollection.add((QualificationTimetableSessionType) model);
        	}
        
        	return qualificationtimetablesessiontypeCollection;
        }

        public static QualificationTimetableSessionType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationTimetableSessionType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationTimetableSessionType) gateway.retrieve(ResourceType.QUALIFICATION_TIMETABLE_SESSION_TYPE, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
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

        public string getStartTimeFrom ()
        {
            return this.getProperty("startTimeFrom").ToString();
        }

        public void setStartTimeFrom (string startTimeFrom)
        {
            this.setProperty("startTimeFrom", startTimeFrom);
        }

        public string getStartTimeUntil ()
        {
            return this.getProperty("startTimeUntil").ToString();
        }

        public void setStartTimeUntil (string startTimeUntil)
        {
            this.setProperty("startTimeUntil", startTimeUntil);
        }


    }
}

