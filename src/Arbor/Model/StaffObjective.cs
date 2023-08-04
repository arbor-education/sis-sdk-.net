using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffObjective : ModelBase
    {
        protected new string resourceType = ResourceType.STAFF_OBJECTIVE;
        public const string STAFF = "staff";
        public const string APPRAISAL = "appraisal";
        public const string DESCRIPTION = "description";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string CRITERIA = "criteria";
        public const string WEIGHTING = "weighting";
        public const string EVIDENCE = "evidence";
        public const string COMMENTS = "comments";
        public const string OUTCOME = "outcome";

        public StaffObjective ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StaffObjective (string resourceType = "StaffObjective", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StaffObjective> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StaffObjective");
        	RestGateway gateway = (RestGateway) StaffObjective.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StaffObjective> staffobjectiveCollection = new ModelCollection<StaffObjective> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    staffobjectiveCollection.add((StaffObjective) model);
        	}
        
        	return staffobjectiveCollection;
        }

        public static StaffObjective retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StaffObjective.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StaffObjective) gateway.retrieve(ResourceType.STAFF_OBJECTIVE, id);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public Appraisal getAppraisal ()
        {
            return (Appraisal) this.getProperty("appraisal");
        }

        public void setAppraisal (Appraisal appraisal)
        {
            this.setProperty("appraisal", appraisal);
        }

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }

        public DateTime getStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("startDate"));
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getCriteria ()
        {
            return this.getProperty("criteria").ToString();
        }

        public void setCriteria (string criteria)
        {
            this.setProperty("criteria", criteria);
        }

        public string getWeighting ()
        {
            return this.getProperty("weighting").ToString();
        }

        public void setWeighting (string weighting)
        {
            this.setProperty("weighting", weighting);
        }

        public string getEvidence ()
        {
            return this.getProperty("evidence").ToString();
        }

        public void setEvidence (string evidence)
        {
            this.setProperty("evidence", evidence);
        }

        public string getComments ()
        {
            return this.getProperty("comments").ToString();
        }

        public void setComments (string comments)
        {
            this.setProperty("comments", comments);
        }

        public string getOutcome ()
        {
            return this.getProperty("outcome").ToString();
        }

        public void setOutcome (string outcome)
        {
            this.setProperty("outcome", outcome);
        }


    }
}

