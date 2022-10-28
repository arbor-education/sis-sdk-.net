using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class StudentFundingType : ModelBase
    {
        protected new string resourceType = ResourceType.UK_DFE_STUDENT_FUNDING_TYPE;
        public const string D00209 = "d00209";

        public StudentFundingType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentFundingType (string resourceType = "StudentFundingType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentFundingType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_StudentFundingType");
        	RestGateway gateway = (RestGateway) StudentFundingType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentFundingType> studentfundingtypeCollection = new ModelCollection<StudentFundingType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentfundingtypeCollection.add((StudentFundingType) model);
        	}
        
        	return studentfundingtypeCollection;
        }

        public static StudentFundingType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentFundingType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentFundingType) gateway.retrieve(ResourceType.UK_DFE_STUDENT_FUNDING_TYPE, id);
        }

        public string getD00209 ()
        {
            return this.getProperty("d00209").ToString();
        }

        public void setD00209 (string d00209)
        {
            this.setProperty("d00209", d00209);
        }


    }
}

