using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IdentityCard : ModelBase
    {
        protected new string resourceType = ResourceType.IDENTITY_CARD;
        public const string OWNER = "owner";
        public const string CARD_NUMBER = "cardNumber";
        public const string ACTIVE = "active";
        public const string ISSUED_DATETIME = "issuedDatetime";
        public const string LOST_DATETIME = "lostDatetime";

        public IdentityCard ()
        {
            base.resourceType = this.resourceType;
        }
        
        public IdentityCard (string resourceType = "IdentityCard", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<IdentityCard> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("IdentityCard");
        	RestGateway gateway = (RestGateway) IdentityCard.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<IdentityCard> identitycardCollection = new ModelCollection<IdentityCard> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    identitycardCollection.add((IdentityCard) model);
        	}
        
        	return identitycardCollection;
        }

        public static IdentityCard retrieve (string id)
        {
            RestGateway gateway = (RestGateway) IdentityCard.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (IdentityCard) gateway.retrieve(ResourceType.IDENTITY_CARD, id);
        }

        public ModelBase getOwner ()
        {
            return (ModelBase) this.getProperty("owner");
        }

        public void setOwner (ModelBase owner)
        {
            this.setProperty("owner", owner);
        }

        public string getCardNumber ()
        {
            return this.getProperty("cardNumber").ToString();
        }

        public void setCardNumber (string cardNumber)
        {
            this.setProperty("cardNumber", cardNumber);
        }

        public bool getActive ()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public DateTime getIssuedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("issuedDatetime"));
        }

        public void setIssuedDatetime (DateTime issuedDatetime)
        {
            this.setProperty("issuedDatetime", issuedDatetime);
        }

        public DateTime getLostDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("lostDatetime"));
        }

        public void setLostDatetime (DateTime lostDatetime)
        {
            this.setProperty("lostDatetime", lostDatetime);
        }


    }
}

