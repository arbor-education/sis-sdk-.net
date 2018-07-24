using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProgrammeEnrolment : ModelBase
    {
        protected string resourceType = ResourceType.PROGRAMME_ENROLMENT;
        public const string PROGRAMME_INSTANCE = "programmeInstance";
        public const string STUDENT = "student";
        public const string MAIN_PROGRAMME = "mainProgramme";
        public const string PLANNED_START_DATE = "plannedStartDate";
        public const string PLANNED_END_DATE = "plannedEndDate";
        public const string ACTUAL_END_DATE = "actualEndDate";
        public const string COMPLETION_STATUS = "completionStatus";
        public const string WITHDRAWAL_REASON = "withdrawalReason";

        public ProgrammeEnrolment ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ProgrammeEnrolment (string resourceType = "ProgrammeEnrolment", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ProgrammeEnrolment> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ProgrammeEnrolment");
        	RestGateway gateway = (RestGateway) ProgrammeEnrolment.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ProgrammeEnrolment> programmeenrolmentCollection = new ModelCollection<ProgrammeEnrolment> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    programmeenrolmentCollection.add((ProgrammeEnrolment) model);
        	}
        
        	return programmeenrolmentCollection;
        }

        public static ProgrammeEnrolment retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ProgrammeEnrolment.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ProgrammeEnrolment) gateway.retrieve(ResourceType.PROGRAMME_ENROLMENT, id);
        }

        public ProgrammeInstance getProgrammeInstance ()
        {
            return (ProgrammeInstance) this.getProperty("programmeInstance");
        }

        public void setProgrammeInstance (ProgrammeInstance programmeInstance)
        {
            this.setProperty("programmeInstance", programmeInstance);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public bool getMainProgramme ()
        {
            return (bool) this.getProperty("mainProgramme");
        }

        public void setMainProgramme (bool mainProgramme)
        {
            this.setProperty("mainProgramme", mainProgramme);
        }

        public DateTime getPlannedStartDate (){
            return Convert.ToDateTime(this.getProperty("plannedStartDate"));
        }

        public void setPlannedStartDate (DateTime plannedStartDate)
        {
            this.setProperty("plannedStartDate", plannedStartDate);
        }

        public DateTime getPlannedEndDate (){
            return Convert.ToDateTime(this.getProperty("plannedEndDate"));
        }

        public void setPlannedEndDate (DateTime plannedEndDate)
        {
            this.setProperty("plannedEndDate", plannedEndDate);
        }

        public DateTime getActualEndDate (){
            return Convert.ToDateTime(this.getProperty("actualEndDate"));
        }

        public void setActualEndDate (DateTime actualEndDate)
        {
            this.setProperty("actualEndDate", actualEndDate);
        }

        public string getCompletionStatus ()
        {
            return this.getProperty("completionStatus").ToString();
        }

        public void setCompletionStatus (string completionStatus)
        {
            this.setProperty("completionStatus", completionStatus);
        }

        public ProgrammeWithdrawalReason getWithdrawalReason ()
        {
            return (ProgrammeWithdrawalReason) this.getProperty("withdrawalReason");
        }

        public void setWithdrawalReason (ProgrammeWithdrawalReason withdrawalReason)
        {
            this.setProperty("withdrawalReason", withdrawalReason);
        }


    }
}

