using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class BoardingPattern : ModelBase
    {
        protected string resourceType = ResourceType.BOARDING_PATTERN;
        public const string STUDENT = "student";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string MONDAY_BOARDING_STATUS = "mondayBoardingStatus";
        public const string TUESDAY_BOARDING_STATUS = "tuesdayBoardingStatus";
        public const string WEDNESDAY_BOARDING_STATUS = "wednesdayBoardingStatus";
        public const string THURSDAY_BOARDING_STATUS = "thursdayBoardingStatus";
        public const string FRIDAY_BOARDING_STATUS = "fridayBoardingStatus";
        public const string SATURDAY_BOARDING_STATUS = "saturdayBoardingStatus";
        public const string SUNDAY_BOARDING_STATUS = "sundayBoardingStatus";
        public const string ACCOMMODATION_ROOM = "accommodationRoom";

        public BoardingPattern ()
        {
            base.resourceType = this.resourceType;
        }
        
        public BoardingPattern (string resourceType = "BoardingPattern", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<BoardingPattern> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("BoardingPattern");
        	RestGateway gateway = (RestGateway) BoardingPattern.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<BoardingPattern> boardingpatternCollection = new ModelCollection<BoardingPattern> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    boardingpatternCollection.add((BoardingPattern) model);
        	}
        
        	return boardingpatternCollection;
        }

        public static BoardingPattern retrieve (string id)
        {
            RestGateway gateway = (RestGateway) BoardingPattern.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (BoardingPattern) gateway.retrieve(ResourceType.BOARDING_PATTERN, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"))
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public BoardingStatus getMondayBoardingStatus ()
        {
            return (BoardingStatus) this.getProperty("mondayBoardingStatus");
        }

        public void setMondayBoardingStatus (BoardingStatus mondayBoardingStatus)
        {
            this.setProperty("mondayBoardingStatus", mondayBoardingStatus);
        }

        public BoardingStatus getTuesdayBoardingStatus ()
        {
            return (BoardingStatus) this.getProperty("tuesdayBoardingStatus");
        }

        public void setTuesdayBoardingStatus (BoardingStatus tuesdayBoardingStatus)
        {
            this.setProperty("tuesdayBoardingStatus", tuesdayBoardingStatus);
        }

        public BoardingStatus getWednesdayBoardingStatus ()
        {
            return (BoardingStatus) this.getProperty("wednesdayBoardingStatus");
        }

        public void setWednesdayBoardingStatus (BoardingStatus wednesdayBoardingStatus)
        {
            this.setProperty("wednesdayBoardingStatus", wednesdayBoardingStatus);
        }

        public BoardingStatus getThursdayBoardingStatus ()
        {
            return (BoardingStatus) this.getProperty("thursdayBoardingStatus");
        }

        public void setThursdayBoardingStatus (BoardingStatus thursdayBoardingStatus)
        {
            this.setProperty("thursdayBoardingStatus", thursdayBoardingStatus);
        }

        public BoardingStatus getFridayBoardingStatus ()
        {
            return (BoardingStatus) this.getProperty("fridayBoardingStatus");
        }

        public void setFridayBoardingStatus (BoardingStatus fridayBoardingStatus)
        {
            this.setProperty("fridayBoardingStatus", fridayBoardingStatus);
        }

        public BoardingStatus getSaturdayBoardingStatus ()
        {
            return (BoardingStatus) this.getProperty("saturdayBoardingStatus");
        }

        public void setSaturdayBoardingStatus (BoardingStatus saturdayBoardingStatus)
        {
            this.setProperty("saturdayBoardingStatus", saturdayBoardingStatus);
        }

        public BoardingStatus getSundayBoardingStatus ()
        {
            return (BoardingStatus) this.getProperty("sundayBoardingStatus");
        }

        public void setSundayBoardingStatus (BoardingStatus sundayBoardingStatus)
        {
            this.setProperty("sundayBoardingStatus", sundayBoardingStatus);
        }

        public Room getAccommodationRoom ()
        {
            return (Room) this.getProperty("accommodationRoom");
        }

        public void setAccommodationRoom (Room accommodationRoom)
        {
            this.setProperty("accommodationRoom", accommodationRoom);
        }


    }
}

