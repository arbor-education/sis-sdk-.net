using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class UkDfe_LocalAuthority : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_LOCAL_AUTHORITY;
        public const string AUTHORITY_CODE = "authorityCode";
        public const string AUTHORITY_CODE_PRE2011 = "authorityCodePre2011";

        public UkDfe_LocalAuthority ()
        {
            base.resourceType = this.resourceType;
        }
        
        public UkDfe_LocalAuthority (string resourceType = "UkDfe_LocalAuthority", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<UkDfe_LocalAuthority> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_LocalAuthority");
        	RestGateway gateway = (RestGateway) UkDfe_LocalAuthority.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<UkDfe_LocalAuthority> ukdfe_localauthorityCollection = new ModelCollection<UkDfe_LocalAuthority> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ukdfe_localauthorityCollection.add((UkDfe_LocalAuthority) model);
        	}
        
        	return ukdfe_localauthorityCollection;
        }

        public static UkDfe_LocalAuthority retrieve (string id)
        {
            RestGateway gateway = (RestGateway) UkDfe_LocalAuthority.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (UkDfe_LocalAuthority) gateway.retrieve(ResourceType.UK_DFE_LOCAL_AUTHORITY, id);
        }

        public string getAuthorityCode ()
        {
            return this.getProperty("authorityCode").ToString();
        }

        public void setAuthorityCode (string authorityCode)
        {
            this.setProperty("authorityCode", authorityCode);
        }

        public string getAuthorityCodePre2011 ()
        {
            return this.getProperty("authorityCodePre2011").ToString();
        }

        public void setAuthorityCodePre2011 (string authorityCodePre2011)
        {
            this.setProperty("authorityCodePre2011", authorityCodePre2011);
        }


    }
}

