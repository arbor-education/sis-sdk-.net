using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_Subject : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_SUBJECT;
        public const string USED_IN_SWF_ONLY = "usedInSwfOnly";
        public const string USED_IN_CBDS_ONLY = "usedInCbdsOnly";
        public const string D00115 = "d00115";
        public const string D00220 = "d00220";

        public UkDfe_Subject ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_Subject (string resourceType = "UkDfe_Subject", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_Subject> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_Subject");
        	RestGateway gateway = (RestGateway) UkDfe_Subject.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_Subject> ukdfe_subjectCollection = new ModelCollection<UkDfe_Subject> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_subjectCollection.add((UkDfe_Subject) model);
        	}
        
        	return ukdfe_subjectCollection;
        }

        public static UkDfe_Subject retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_Subject.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_Subject) gateway.retrieve(ResourceType.UK_DFE_SUBJECT, id);
        }

        public bool getUsedInSwfOnly ()
        {
            return Convert.ToBoolean(this.getProperty("usedInSwfOnly"))
        }

        public void setUsedInSwfOnly (bool usedInSwfOnly)
        {
            this.setProperty("usedInSwfOnly", usedInSwfOnly);
        }

        public bool getUsedInCbdsOnly ()
        {
            return Convert.ToBoolean(this.getProperty("usedInCbdsOnly"))
        }

        public void setUsedInCbdsOnly (bool usedInCbdsOnly)
        {
            this.setProperty("usedInCbdsOnly", usedInCbdsOnly);
        }

        public string getD00115 ()
        {
            return this.getProperty("d00115").ToString();
        }

        public void setD00115 (string d00115)
        {
            this.setProperty("d00115", d00115);
        }

        public string getD00220 ()
        {
            return this.getProperty("d00220").ToString();
        }

        public void setD00220 (string d00220)
        {
            this.setProperty("d00220", d00220);
        }


    }
}

