using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_StudentFundingType : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_STUDENT_FUNDING_TYPE;
        public const string D00209 = "d00209";

        public UkDfe_StudentFundingType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_StudentFundingType (string resourceType = "UkDfe_StudentFundingType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_StudentFundingType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_StudentFundingType");
        	RestGateway gateway = (RestGateway) UkDfe_StudentFundingType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_StudentFundingType> ukdfe_studentfundingtypeCollection = new ModelCollection<UkDfe_StudentFundingType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_studentfundingtypeCollection.add((UkDfe_StudentFundingType) model);
        	}
        
        	return ukdfe_studentfundingtypeCollection;
        }

        public static UkDfe_StudentFundingType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_StudentFundingType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_StudentFundingType) gateway.retrieve(ResourceType.UK_DFE_STUDENT_FUNDING_TYPE, id);
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

