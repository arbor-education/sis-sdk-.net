using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TripPrice : ModelBase
    {
        protected string resourceType = ResourceType.TRIP_PRICE;
        public const string TRIP = "trip";
        public const string APPLICABLE = "applicable";
        public const string PRICE_EX_VAT = "priceExVat";
        public const string VAT_RATE = "vatRate";
        public const string VOLUNTARY_CONTRIBUTION = "voluntaryContribution";
        public const string INSTALMENTS_PERMITTED = "instalmentsPermitted";
        public const string MINIMUM_INSTALMENT_AMOUNT = "minimumInstalmentAmount";
        public const string AUTO_CONFIRM_INSTALMENT_THRESHOLD = "autoConfirmInstalmentThreshold";

        public TripPrice()
        {
            base.resourceType = this.resourceType;
        }

        public TripPrice(string resourceType = "TripPrice", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<TripPrice> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("TripPrice");
            RestGateway gateway = (RestGateway)TripPrice.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<TripPrice> trippriceCollection = new ModelCollection<TripPrice>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                trippriceCollection.add((TripPrice)model);
            }

            return trippriceCollection;
        }

        public static TripPrice retrieve(string id)
        {
            RestGateway gateway = (RestGateway)TripPrice.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (TripPrice)gateway.retrieve(ResourceType.TRIP_PRICE, id);
        }

        public Trip getTrip()
        {
            return (Trip)this.getProperty("trip");
        }

        public void setTrip(Trip trip)
        {
            this.setProperty("trip", trip);
        }

        public ModelBase getApplicable()
        {
            return (ModelBase)this.getProperty("applicable");
        }

        public void setApplicable(ModelBase applicable)
        {
            this.setProperty("applicable", applicable);
        }

        public string getPriceExVat()
        {
            return this.getProperty("priceExVat").ToString();
        }

        public void setPriceExVat(string priceExVat)
        {
            this.setProperty("priceExVat", priceExVat);
        }

        public VatRate getVatRate()
        {
            return (VatRate)this.getProperty("vatRate");
        }

        public void setVatRate(VatRate vatRate)
        {
            this.setProperty("vatRate", vatRate);
        }

        public bool getVoluntaryContribution()
        {
            return Convert.ToBoolean(this.getProperty("voluntaryContribution"));
        }

        public void setVoluntaryContribution(bool voluntaryContribution)
        {
            this.setProperty("voluntaryContribution", voluntaryContribution);
        }

        public bool getInstalmentsPermitted()
        {
            return Convert.ToBoolean(this.getProperty("instalmentsPermitted"));
        }

        public void setInstalmentsPermitted(bool instalmentsPermitted)
        {
            this.setProperty("instalmentsPermitted", instalmentsPermitted);
        }

        public string getMinimumInstalmentAmount()
        {
            return this.getProperty("minimumInstalmentAmount").ToString();
        }

        public void setMinimumInstalmentAmount(string minimumInstalmentAmount)
        {
            this.setProperty("minimumInstalmentAmount", minimumInstalmentAmount);
        }

        public string getAutoConfirmInstalmentThreshold()
        {
            return this.getProperty("autoConfirmInstalmentThreshold").ToString();
        }

        public void setAutoConfirmInstalmentThreshold(string autoConfirmInstalmentThreshold)
        {
            this.setProperty("autoConfirmInstalmentThreshold", autoConfirmInstalmentThreshold);
        }


    }
}

