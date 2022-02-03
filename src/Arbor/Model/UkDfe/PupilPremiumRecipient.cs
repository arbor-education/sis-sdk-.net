using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class PupilPremiumRecipient : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_PUPIL_PREMIUM_RECIPIENT;
        public const string STUDENT = "student";
        public const string CURRICULUM_GRADE = "curriculumGrade";
        public const string FTE = "fte";
        public const string FTE_CASH_AMOUNT = "fteCashAmount";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";
        public const string LAST_FSM = "lastFsm";

        public PupilPremiumRecipient ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PupilPremiumRecipient (string resourceType = "PupilPremiumRecipient", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PupilPremiumRecipient> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_PupilPremiumRecipient");
        	RestGateway gateway = (RestGateway) PupilPremiumRecipient.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PupilPremiumRecipient> pupilpremiumrecipientCollection = new ModelCollection<PupilPremiumRecipient> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    pupilpremiumrecipientCollection.add((PupilPremiumRecipient) model);
        	}
        
        	return pupilpremiumrecipientCollection;
        }

        public static PupilPremiumRecipient retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PupilPremiumRecipient.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PupilPremiumRecipient) gateway.retrieve(ResourceType.UK_DFE_PUPIL_PREMIUM_RECIPIENT, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public CurriculumGrade getCurriculumGrade ()
        {
            return (CurriculumGrade) this.getProperty("curriculumGrade");
        }

        public void setCurriculumGrade (CurriculumGrade curriculumGrade)
        {
            this.setProperty("curriculumGrade", curriculumGrade);
        }

        public float getFte ()
        {
            return (float) this.getProperty("fte");
        }

        public void setFte (float fte)
        {
            this.setProperty("fte", fte);
        }

        public string getFteCashAmount ()
        {
            return this.getProperty("fteCashAmount").ToString();
        }

        public void setFteCashAmount (string fteCashAmount)
        {
            this.setProperty("fteCashAmount", fteCashAmount);
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

        public string getLastFsm ()
        {
            return this.getProperty("lastFsm").ToString();
        }

        public void setLastFsm (string lastFsm)
        {
            this.setProperty("lastFsm", lastFsm);
        }


    }
}

