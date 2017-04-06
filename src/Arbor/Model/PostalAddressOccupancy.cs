using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class PostalAddressOccupancy : ModelBase
    {
        protected string resourceType = ResourceType.POSTAL_ADDRESS_OCCUPANCY;
        public const string POSTAL_ADDRESS = "postalAddress";
        public const string OCCUPANT = "occupant";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string POSTAL_ADDRESS_TYPE = "postalAddressType";
        public const string IS_CORRESPONDENCE_ADDRESS = "isCorrespondenceAddress";

        public PostalAddressOccupancy ()
        {
            base.resourceType = this.resourceType;
        }
        
        public PostalAddressOccupancy (string resourceType = "PostalAddressOccupancy", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<PostalAddressOccupancy> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("PostalAddressOccupancy");
        	RestGateway gateway = (RestGateway) PostalAddressOccupancy.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<PostalAddressOccupancy> postaladdressoccupancyCollection = new ModelCollection<PostalAddressOccupancy> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    postaladdressoccupancyCollection.add((PostalAddressOccupancy) model);
        	}
        
        	return postaladdressoccupancyCollection;
        }

        public static PostalAddressOccupancy retrieve (string id)
        {
            RestGateway gateway = (RestGateway) PostalAddressOccupancy.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (PostalAddressOccupancy) gateway.retrieve(ResourceType.POSTAL_ADDRESS_OCCUPANCY, id);
        }

        public PostalAddress getPostalAddress ()
        {
            return (PostalAddress) this.getProperty("postalAddress");
        }

        public void setPostalAddress (PostalAddress postalAddress)
        {
            this.setProperty("postalAddress", postalAddress);
        }

        public ModelBase getOccupant ()
        {
            return (ModelBase) this.getProperty("occupant");
        }

        public void setOccupant (ModelBase occupant)
        {
            this.setProperty("occupant", occupant);
        }

        public DateTime getEffectiveDate ()
        {
            return (DateTime) this.getProperty("effectiveDate");
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return (DateTime) this.getProperty("endDate");
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public string getPostalAddressType ()
        {
            return this.getProperty("postalAddressType").ToString();
        }

        public void setPostalAddressType (string postalAddressType)
        {
            this.setProperty("postalAddressType", postalAddressType);
        }

        public bool getIsCorrespondenceAddress ()
        {
            return (bool) this.getProperty("isCorrespondenceAddress");
        }

        public void setIsCorrespondenceAddress (bool isCorrespondenceAddress)
        {
            this.setProperty("isCorrespondenceAddress", isCorrespondenceAddress);
        }


    }
}

