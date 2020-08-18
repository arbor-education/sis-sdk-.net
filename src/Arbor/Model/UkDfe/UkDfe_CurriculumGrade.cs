using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_CurriculumGrade : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_CURRICULUM_GRADE;
        public const string D00020 = "d00020";
        public const string D00020_ORDER = "d00020Order";

        public UkDfe_CurriculumGrade ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_CurriculumGrade (string resourceType = "UkDfe_CurriculumGrade", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_CurriculumGrade> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_CurriculumGrade");
        	RestGateway gateway = (RestGateway) UkDfe_CurriculumGrade.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_CurriculumGrade> ukdfe_curriculumgradeCollection = new ModelCollection<UkDfe_CurriculumGrade> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_curriculumgradeCollection.add((UkDfe_CurriculumGrade) model);
        	}
        
        	return ukdfe_curriculumgradeCollection;
        }

        public static UkDfe_CurriculumGrade retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_CurriculumGrade.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_CurriculumGrade) gateway.retrieve(ResourceType.UK_DFE_CURRICULUM_GRADE, id);
        }

        public string getD00020 ()
        {
            return this.getProperty("d00020").ToString();
        }

        public void setD00020 (string d00020)
        {
            this.setProperty("d00020", d00020);
        }

        public int getD00020Order ()
        {
            return Convert.ToInt32(this.getProperty("d00020Order"));
        }

        public void setD00020Order (int d00020Order)
        {
            this.setProperty("d00020Order", d00020Order);
        }


    }
}

