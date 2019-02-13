using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DeliveryAddress : ModelBase
    {
        protected string resourceType = ResourceType.DELIVERY_ADDRESS;
        public const string DELIVERY_ADDRESS_NAME = "deliveryAddressName";
        public const string OWNER = "owner";
        public const string POSTAL_ADDRESS = "postalAddress";
        public const string DELIVERY_CONTACT_NAME = "deliveryContactName";
        public const string DELIVERY_CONTACT_NUMBER = "deliveryContactNumber";
        public const string DELIVERY_INSTRUCTIONS = "deliveryInstructions";
        public const string IS_DEFAULT = "isDefault";
        public const string IS_ADDRESS_FOR_REUSE = "isAddressForReuse";

        public DeliveryAddress ()
        {
            base.resourceType = this.resourceType;
        }
        
        public DeliveryAddress (string resourceType = "DeliveryAddress", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<DeliveryAddress> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("DeliveryAddress");
        	RestGateway gateway = (RestGateway) DeliveryAddress.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<DeliveryAddress> deliveryaddressCollection = new ModelCollection<DeliveryAddress> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    deliveryaddressCollection.add((DeliveryAddress) model);
        	}
        
        	return deliveryaddressCollection;
        }

        public static DeliveryAddress retrieve (string id)
        {
            RestGateway gateway = (RestGateway) DeliveryAddress.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (DeliveryAddress) gateway.retrieve(ResourceType.DELIVERY_ADDRESS, id);
        }

        public string getDeliveryAddressName ()
        {
            return this.getProperty("deliveryAddressName").ToString();
        }

        public void setDeliveryAddressName (string deliveryAddressName)
        {
            this.setProperty("deliveryAddressName", deliveryAddressName);
        }

        public ModelBase getOwner ()
        {
            return (ModelBase) this.getProperty("owner");
        }

        public void setOwner (ModelBase owner)
        {
            this.setProperty("owner", owner);
        }

        public PostalAddress getPostalAddress ()
        {
            return (PostalAddress) this.getProperty("postalAddress");
        }

        public void setPostalAddress (PostalAddress postalAddress)
        {
            this.setProperty("postalAddress", postalAddress);
        }

        public string getDeliveryContactName ()
        {
            return this.getProperty("deliveryContactName").ToString();
        }

        public void setDeliveryContactName (string deliveryContactName)
        {
            this.setProperty("deliveryContactName", deliveryContactName);
        }

        public string getDeliveryContactNumber ()
        {
            return this.getProperty("deliveryContactNumber").ToString();
        }

        public void setDeliveryContactNumber (string deliveryContactNumber)
        {
            this.setProperty("deliveryContactNumber", deliveryContactNumber);
        }

        public string getDeliveryInstructions ()
        {
            return this.getProperty("deliveryInstructions").ToString();
        }

        public void setDeliveryInstructions (string deliveryInstructions)
        {
            this.setProperty("deliveryInstructions", deliveryInstructions);
        }

        public bool getIsDefault ()
        {
            return Convert.ToBoolean(this.getProperty("isDefault"))
        }

        public void setIsDefault (bool isDefault)
        {
            this.setProperty("isDefault", isDefault);
        }

        public bool getIsAddressForReuse ()
        {
            return Convert.ToBoolean(this.getProperty("isAddressForReuse"))
        }

        public void setIsAddressForReuse (bool isAddressForReuse)
        {
            this.setProperty("isAddressForReuse", isAddressForReuse);
        }


    }
}

