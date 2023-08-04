using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ClubSessionIntervalPrice : ModelBase
    {
        protected new string resourceType = ResourceType.CLUB_SESSION_INTERVAL_PRICE;
        public const string CLUB_SESSION_INTERVAL = "clubSessionInterval";
        public const string GROUP = "group";
        public const string PRICE_EX_VAT = "priceExVat";
        public const string VAT_RATE = "vatRate";

        public ClubSessionIntervalPrice ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ClubSessionIntervalPrice (string resourceType = "ClubSessionIntervalPrice", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ClubSessionIntervalPrice> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ClubSessionIntervalPrice");
        	RestGateway gateway = (RestGateway) ClubSessionIntervalPrice.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ClubSessionIntervalPrice> clubsessionintervalpriceCollection = new ModelCollection<ClubSessionIntervalPrice> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    clubsessionintervalpriceCollection.add((ClubSessionIntervalPrice) model);
        	}
        
        	return clubsessionintervalpriceCollection;
        }

        public static ClubSessionIntervalPrice retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ClubSessionIntervalPrice.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ClubSessionIntervalPrice) gateway.retrieve(ResourceType.CLUB_SESSION_INTERVAL_PRICE, id);
        }

        public ClubSessionInterval getClubSessionInterval ()
        {
            return (ClubSessionInterval) this.getProperty("clubSessionInterval");
        }

        public void setClubSessionInterval (ClubSessionInterval clubSessionInterval)
        {
            this.setProperty("clubSessionInterval", clubSessionInterval);
        }

        public ModelBase getGroup ()
        {
            return (ModelBase) this.getProperty("group");
        }

        public void setGroup (ModelBase group)
        {
            this.setProperty("group", group);
        }

        public string getPriceExVat ()
        {
            return this.getProperty("priceExVat").ToString();
        }

        public void setPriceExVat (string priceExVat)
        {
            this.setProperty("priceExVat", priceExVat);
        }

        public VatRate getVatRate ()
        {
            return (VatRate) this.getProperty("vatRate");
        }

        public void setVatRate (VatRate vatRate)
        {
            this.setProperty("vatRate", vatRate);
        }


    }
}

