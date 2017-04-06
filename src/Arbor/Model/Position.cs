using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Position : ModelBase
    {
        protected string resourceType = ResourceType.POSITION;
        public const string POSITION_CATEGORY = "positionCategory";
        public const string WORKFORCE_VACANCY_POST = "workforceVacancyPost";
        public const string START_DATE = "startDate";
        public const string EXPECTED_END_DATE = "expectedEndDate";
        public const string END_DATE = "endDate";
        public const string POSITION_NAME = "positionName";
        public const string POSITION_REFERENCE = "positionReference";
        public const string SUPERVISOR_POSITION = "supervisorPosition";
        public const string EXPECTED_HOURS_PER_WEEK = "expectedHoursPerWeek";
        public const string EXPECTED_WEEKS_PER_YEAR = "expectedWeeksPerYear";
        public const string FTE_HOURS_PER_WEEK = "fteHoursPerWeek";

        public Position ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Position (string resourceType = "Position", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Position> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Position");
        	RestGateway gateway = (RestGateway) Position.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Position> positionCollection = new ModelCollection<Position> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    positionCollection.add((Position) model);
        	}
        
        	return positionCollection;
        }

        public static Position retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Position.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Position) gateway.retrieve(ResourceType.POSITION, id);
        }

        public ModelBase getPositionCategory ()
        {
            return (ModelBase) this.getProperty("positionCategory");
        }

        public void setPositionCategory (ModelBase positionCategory)
        {
            this.setProperty("positionCategory", positionCategory);
        }

        public ModelBase getWorkforceVacancyPost ()
        {
            return (ModelBase) this.getProperty("workforceVacancyPost");
        }

        public void setWorkforceVacancyPost (ModelBase workforceVacancyPost)
        {
            this.setProperty("workforceVacancyPost", workforceVacancyPost);
        }

        public DateTime getStartDate ()
        {
            return (DateTime) this.getProperty("startDate");
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getExpectedEndDate ()
        {
            return (DateTime) this.getProperty("expectedEndDate");
        }

        public void setExpectedEndDate (DateTime expectedEndDate)
        {
            this.setProperty("expectedEndDate", expectedEndDate);
        }

        public DateTime getEndDate ()
        {
            return (DateTime) this.getProperty("endDate");
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getPositionName ()
        {
            return this.getProperty("positionName").ToString();
        }

        public void setPositionName (string positionName)
        {
            this.setProperty("positionName", positionName);
        }

        public string getPositionReference ()
        {
            return this.getProperty("positionReference").ToString();
        }

        public void setPositionReference (string positionReference)
        {
            this.setProperty("positionReference", positionReference);
        }

        public Position getSupervisorPosition ()
        {
            return (Position) this.getProperty("supervisorPosition");
        }

        public void setSupervisorPosition (Position supervisorPosition)
        {
            this.setProperty("supervisorPosition", supervisorPosition);
        }

        public string getExpectedHoursPerWeek ()
        {
            return this.getProperty("expectedHoursPerWeek").ToString();
        }

        public void setExpectedHoursPerWeek (string expectedHoursPerWeek)
        {
            this.setProperty("expectedHoursPerWeek", expectedHoursPerWeek);
        }

        public float getExpectedWeeksPerYear ()
        {
            return (float) this.getProperty("expectedWeeksPerYear");
        }

        public void setExpectedWeeksPerYear (float expectedWeeksPerYear)
        {
            this.setProperty("expectedWeeksPerYear", expectedWeeksPerYear);
        }

        public string getFteHoursPerWeek ()
        {
            return this.getProperty("fteHoursPerWeek").ToString();
        }

        public void setFteHoursPerWeek (string fteHoursPerWeek)
        {
            this.setProperty("fteHoursPerWeek", fteHoursPerWeek);
        }


    }
}

