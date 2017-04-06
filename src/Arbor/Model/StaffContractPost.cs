using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffContractPost : ModelBase
    {
        protected string resourceType = ResourceType.STAFF_CONTRACT_POST;
        public const string STAFF_CONTRACT = "staffContract";
        public const string POSITION = "position";
        public const string POST_REFERENCE = "postReference";
        public const string JOB_TITLE = "jobTitle";
        public const string OFFERED_DATE = "offeredDate";
        public const string ACCEPTED_DATE = "acceptedDate";
        public const string START_DATE = "startDate";
        public const string START_REASON = "startReason";
        public const string EXPECTED_END_DATE = "expectedEndDate";
        public const string EXPECTED_END_REASON = "expectedEndReason";
        public const string END_DATE = "endDate";
        public const string END_REASON = "endReason";

        public StaffContractPost ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StaffContractPost (string resourceType = "StaffContractPost", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StaffContractPost> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StaffContractPost");
        	RestGateway gateway = (RestGateway) StaffContractPost.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StaffContractPost> staffcontractpostCollection = new ModelCollection<StaffContractPost> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    staffcontractpostCollection.add((StaffContractPost) model);
        	}
        
        	return staffcontractpostCollection;
        }

        public static StaffContractPost retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StaffContractPost.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StaffContractPost) gateway.retrieve(ResourceType.STAFF_CONTRACT_POST, id);
        }

        public StaffContract getStaffContract ()
        {
            return (StaffContract) this.getProperty("staffContract");
        }

        public void setStaffContract (StaffContract staffContract)
        {
            this.setProperty("staffContract", staffContract);
        }

        public Position getPosition ()
        {
            return (Position) this.getProperty("position");
        }

        public void setPosition (Position position)
        {
            this.setProperty("position", position);
        }

        public string getPostReference ()
        {
            return this.getProperty("postReference").ToString();
        }

        public void setPostReference (string postReference)
        {
            this.setProperty("postReference", postReference);
        }

        public string getJobTitle ()
        {
            return this.getProperty("jobTitle").ToString();
        }

        public void setJobTitle (string jobTitle)
        {
            this.setProperty("jobTitle", jobTitle);
        }

        public DateTime getOfferedDate ()
        {
            return (DateTime) this.getProperty("offeredDate");
        }

        public void setOfferedDate (DateTime offeredDate)
        {
            this.setProperty("offeredDate", offeredDate);
        }

        public DateTime getAcceptedDate ()
        {
            return (DateTime) this.getProperty("acceptedDate");
        }

        public void setAcceptedDate (DateTime acceptedDate)
        {
            this.setProperty("acceptedDate", acceptedDate);
        }

        public DateTime getStartDate ()
        {
            return (DateTime) this.getProperty("startDate");
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public StaffContractPostStartReason getStartReason ()
        {
            return (StaffContractPostStartReason) this.getProperty("startReason");
        }

        public void setStartReason (StaffContractPostStartReason startReason)
        {
            this.setProperty("startReason", startReason);
        }

        public DateTime getExpectedEndDate ()
        {
            return (DateTime) this.getProperty("expectedEndDate");
        }

        public void setExpectedEndDate (DateTime expectedEndDate)
        {
            this.setProperty("expectedEndDate", expectedEndDate);
        }

        public StaffContractPostEndReason getExpectedEndReason ()
        {
            return (StaffContractPostEndReason) this.getProperty("expectedEndReason");
        }

        public void setExpectedEndReason (StaffContractPostEndReason expectedEndReason)
        {
            this.setProperty("expectedEndReason", expectedEndReason);
        }

        public DateTime getEndDate ()
        {
            return (DateTime) this.getProperty("endDate");
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public StaffContractPostEndReason getEndReason ()
        {
            return (StaffContractPostEndReason) this.getProperty("endReason");
        }

        public void setEndReason (StaffContractPostEndReason endReason)
        {
            this.setProperty("endReason", endReason);
        }


    }
}

