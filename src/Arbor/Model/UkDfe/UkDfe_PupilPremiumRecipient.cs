using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_PupilPremiumRecipient : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_PUPIL_PREMIUM_RECIPIENT;
        public const string STUDENT = "student";
        public const string CURRICULUM_GRADE = "curriculumGrade";
        public const string FTE = "fte";
        public const string FTE_CASH_AMOUNT = "fteCashAmount";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public UkDfe_PupilPremiumRecipient ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_PupilPremiumRecipient (string resourceType = "UkDfe_PupilPremiumRecipient", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_PupilPremiumRecipient> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_PupilPremiumRecipient");
        	RestGateway gateway = (RestGateway) UkDfe_PupilPremiumRecipient.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_PupilPremiumRecipient> ukdfe_pupilpremiumrecipientCollection = new ModelCollection<UkDfe_PupilPremiumRecipient> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_pupilpremiumrecipientCollection.add((UkDfe_PupilPremiumRecipient) model);
        	}
        
        	return ukdfe_pupilpremiumrecipientCollection;
        }

        public static UkDfe_PupilPremiumRecipient retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_PupilPremiumRecipient.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_PupilPremiumRecipient) gateway.retrieve(ResourceType.UK_DFE_PUPIL_PREMIUM_RECIPIENT, id);
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


    }
}

