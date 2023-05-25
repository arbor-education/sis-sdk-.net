using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AiRequest : ModelBase
    {
        protected new string resourceType = ResourceType.AI_REQUEST;
        public const string PROVIDER = "provider";
        public const string MODEL = "model";
        public const string FEATURE = "feature";
        public const string USER_INPUT = "userInput";
        public const string LINKED_ENTITY = "linkedEntity";
        public const string REQUEST_PAYLOAD = "requestPayload";
        public const string RESPONSE_PAYLOAD = "responsePayload";
        public const string CLEANED_RESPONSE = "cleanedResponse";
        public const string RESPONSE_IDENTIFIER = "responseIdentifier";
        public const string PARENT_RESPONSE_IDENTIFIER = "parentResponseIdentifier";
        public const string COST_UNIT = "costUnit";
        public const string COST = "cost";
        public const string CUSTOMER_RATING = "customerRating";
        public const string CUSTOMER_RESPONSE = "customerResponse";

        public AiRequest()
        {
            base.resourceType = this.resourceType;
        }

        public AiRequest(string resourceType = "AiRequest", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<AiRequest> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("AiRequest");
            RestGateway gateway = (RestGateway)AiRequest.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<AiRequest> airequestCollection = new ModelCollection<AiRequest>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                airequestCollection.add((AiRequest)model);
            }

            return airequestCollection;
        }

        public static AiRequest retrieve(string id)
        {
            RestGateway gateway = (RestGateway)AiRequest.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (AiRequest)gateway.retrieve(ResourceType.AI_REQUEST, id);
        }

        public string getProvider()
        {
            return this.getProperty("provider").ToString();
        }

        public void setProvider(string provider)
        {
            this.setProperty("provider", provider);
        }

        public string getModel()
        {
            return this.getProperty("model").ToString();
        }

        public void setModel(string model)
        {
            this.setProperty("model", model);
        }

        public string getFeature()
        {
            return this.getProperty("feature").ToString();
        }

        public void setFeature(string feature)
        {
            this.setProperty("feature", feature);
        }

        public string getUserInput()
        {
            return this.getProperty("userInput").ToString();
        }

        public void setUserInput(string userInput)
        {
            this.setProperty("userInput", userInput);
        }

        public ModelBase getLinkedEntity()
        {
            return (ModelBase)this.getProperty("linkedEntity");
        }

        public void setLinkedEntity(ModelBase linkedEntity)
        {
            this.setProperty("linkedEntity", linkedEntity);
        }

        public string getRequestPayload()
        {
            return this.getProperty("requestPayload").ToString();
        }

        public void setRequestPayload(string requestPayload)
        {
            this.setProperty("requestPayload", requestPayload);
        }

        public string getResponsePayload()
        {
            return this.getProperty("responsePayload").ToString();
        }

        public void setResponsePayload(string responsePayload)
        {
            this.setProperty("responsePayload", responsePayload);
        }

        public string getCleanedResponse()
        {
            return this.getProperty("cleanedResponse").ToString();
        }

        public void setCleanedResponse(string cleanedResponse)
        {
            this.setProperty("cleanedResponse", cleanedResponse);
        }

        public string getResponseIdentifier()
        {
            return this.getProperty("responseIdentifier").ToString();
        }

        public void setResponseIdentifier(string responseIdentifier)
        {
            this.setProperty("responseIdentifier", responseIdentifier);
        }

        public string getParentResponseIdentifier()
        {
            return this.getProperty("parentResponseIdentifier").ToString();
        }

        public void setParentResponseIdentifier(string parentResponseIdentifier)
        {
            this.setProperty("parentResponseIdentifier", parentResponseIdentifier);
        }

        public string getCostUnit()
        {
            return this.getProperty("costUnit").ToString();
        }

        public void setCostUnit(string costUnit)
        {
            this.setProperty("costUnit", costUnit);
        }

        public float getCost()
        {
            return (float)this.getProperty("cost");
        }

        public void setCost(float cost)
        {
            this.setProperty("cost", cost);
        }

        public string getCustomerRating()
        {
            return this.getProperty("customerRating").ToString();
        }

        public void setCustomerRating(string customerRating)
        {
            this.setProperty("customerRating", customerRating);
        }

        public string getCustomerResponse()
        {
            return this.getProperty("customerResponse").ToString();
        }

        public void setCustomerResponse(string customerResponse)
        {
            this.setProperty("customerResponse", customerResponse);
        }


    }
}

