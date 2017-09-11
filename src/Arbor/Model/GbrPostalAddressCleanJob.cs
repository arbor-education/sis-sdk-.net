using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class GbrPostalAddressCleanJob : ModelBase
    {
        protected string resourceType = ResourceType.GBR_POSTAL_ADDRESS_CLEAN_JOB;
        public const string POSTAL_ADDRESS = "postalAddress";
        public const string EXECUTED_DATETIME = "executedDatetime";
        public const string CLEAN_ADDRESS_1 = "cleanAddress_1";
        public const string CLEAN_ADDRESS_2 = "cleanAddress_2";
        public const string CLEAN_ADDRESS_3 = "cleanAddress_3";
        public const string CLEAN_TOWN = "cleanTown";
        public const string CLEAN_STATE = "cleanState";
        public const string CLEAN_POSTAL_CODE = "cleanPostalCode";
        public const string UPDRN = "updrn";
        public const string OUTCOME = "outcome";
        public const string RESPONSE_CODE = "responseCode";
        public const string ERROR_DESCRIPTION = "errorDescription";

        public GbrPostalAddressCleanJob ()
        {
            base.resourceType = this.resourceType;
        }
        
        public GbrPostalAddressCleanJob (string resourceType = "GbrPostalAddressCleanJob", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<GbrPostalAddressCleanJob> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("GbrPostalAddressCleanJob");
        	RestGateway gateway = (RestGateway) GbrPostalAddressCleanJob.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<GbrPostalAddressCleanJob> gbrpostaladdresscleanjobCollection = new ModelCollection<GbrPostalAddressCleanJob> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    gbrpostaladdresscleanjobCollection.add((GbrPostalAddressCleanJob) model);
        	}
        
        	return gbrpostaladdresscleanjobCollection;
        }

        public static GbrPostalAddressCleanJob retrieve (string id)
        {
            RestGateway gateway = (RestGateway) GbrPostalAddressCleanJob.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (GbrPostalAddressCleanJob) gateway.retrieve(ResourceType.GBR_POSTAL_ADDRESS_CLEAN_JOB, id);
        }

        public PostalAddress getPostalAddress ()
        {
            return (PostalAddress) this.getProperty("postalAddress");
        }

        public void setPostalAddress (PostalAddress postalAddress)
        {
            this.setProperty("postalAddress", postalAddress);
        }

        public DateTime getExecutedDatetime ()
        {
            return (DateTime) this.getProperty("executedDatetime");
        }

        public void setExecutedDatetime (DateTime executedDatetime)
        {
            this.setProperty("executedDatetime", executedDatetime);
        }

        public string getCleanAddress_1 ()
        {
            return this.getProperty("cleanAddress_1").ToString();
        }

        public void setCleanAddress_1 (string cleanAddress_1)
        {
            this.setProperty("cleanAddress_1", cleanAddress_1);
        }

        public string getCleanAddress_2 ()
        {
            return this.getProperty("cleanAddress_2").ToString();
        }

        public void setCleanAddress_2 (string cleanAddress_2)
        {
            this.setProperty("cleanAddress_2", cleanAddress_2);
        }

        public string getCleanAddress_3 ()
        {
            return this.getProperty("cleanAddress_3").ToString();
        }

        public void setCleanAddress_3 (string cleanAddress_3)
        {
            this.setProperty("cleanAddress_3", cleanAddress_3);
        }

        public string getCleanTown ()
        {
            return this.getProperty("cleanTown").ToString();
        }

        public void setCleanTown (string cleanTown)
        {
            this.setProperty("cleanTown", cleanTown);
        }

        public string getCleanState ()
        {
            return this.getProperty("cleanState").ToString();
        }

        public void setCleanState (string cleanState)
        {
            this.setProperty("cleanState", cleanState);
        }

        public string getCleanPostalCode ()
        {
            return this.getProperty("cleanPostalCode").ToString();
        }

        public void setCleanPostalCode (string cleanPostalCode)
        {
            this.setProperty("cleanPostalCode", cleanPostalCode);
        }

        public int getUpdrn ()
        {
            return Convert.ToInt32(this.getProperty("updrn"));
        }

        public void setUpdrn (int updrn)
        {
            this.setProperty("updrn", updrn);
        }

        public string getOutcome ()
        {
            return this.getProperty("outcome").ToString();
        }

        public void setOutcome (string outcome)
        {
            this.setProperty("outcome", outcome);
        }

        public int getResponseCode ()
        {
            return Convert.ToInt32(this.getProperty("responseCode"));
        }

        public void setResponseCode (int responseCode)
        {
            this.setProperty("responseCode", responseCode);
        }

        public string getErrorDescription ()
        {
            return this.getProperty("errorDescription").ToString();
        }

        public void setErrorDescription (string errorDescription)
        {
            this.setProperty("errorDescription", errorDescription);
        }


    }
}

