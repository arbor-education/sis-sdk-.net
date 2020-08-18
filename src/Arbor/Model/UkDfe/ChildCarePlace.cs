using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class ChildCarePlace : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_CHILD_CARE_PLACE;
        public const string NAME = "name";
        public const string CHILD_CARE_ON_SITE = "childCareOnSite";
        public const string CHILD_CARE_SIGNPOSTING = "childCareSignposting";
        public const string CHILD_CARE_TYPE = "childCareType";
        public const string CHILD_CARE_OPENING_TIME = "childCareOpeningTime";
        public const string CHILD_CARE_CLOSING_TIME = "childCareClosingTime";
        public const string CHILD_CARE_NUMBER_OF_PLACES = "childCareNumberOfPlaces";
        public const string CHILD_CARE_PROVIDER = "childCareProvider";
        public const string CHILD_CARE_OTHER_SCHOOLS = "childCareOtherSchools";
        public const string CHILD_CARE_WEEKS_OPEN = "childCareWeeksOpen";

        public ChildCarePlace ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ChildCarePlace (string resourceType = "ChildCarePlace", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ChildCarePlace> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_ChildCarePlace");
        	RestGateway gateway = (RestGateway) ChildCarePlace.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ChildCarePlace> childcareplaceCollection = new ModelCollection<ChildCarePlace> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    childcareplaceCollection.add((ChildCarePlace) model);
        	}
        
        	return childcareplaceCollection;
        }

        public static ChildCarePlace retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ChildCarePlace.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ChildCarePlace) gateway.retrieve(ResourceType.UK_DFE_CHILD_CARE_PLACE, id);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public bool getChildCareOnSite ()
        {
            return (bool) this.getProperty("childCareOnSite");
        }

        public void setChildCareOnSite (bool childCareOnSite)
        {
            this.setProperty("childCareOnSite", childCareOnSite);
        }

        public string getChildCareSignposting ()
        {
            return this.getProperty("childCareSignposting").ToString();
        }

        public void setChildCareSignposting (string childCareSignposting)
        {
            this.setProperty("childCareSignposting", childCareSignposting);
        }

        public string getChildCareType ()
        {
            return this.getProperty("childCareType").ToString();
        }

        public void setChildCareType (string childCareType)
        {
            this.setProperty("childCareType", childCareType);
        }

        public string getChildCareOpeningTime ()
        {
            return this.getProperty("childCareOpeningTime").ToString();
        }

        public void setChildCareOpeningTime (string childCareOpeningTime)
        {
            this.setProperty("childCareOpeningTime", childCareOpeningTime);
        }

        public string getChildCareClosingTime ()
        {
            return this.getProperty("childCareClosingTime").ToString();
        }

        public void setChildCareClosingTime (string childCareClosingTime)
        {
            this.setProperty("childCareClosingTime", childCareClosingTime);
        }

        public int getChildCareNumberOfPlaces ()
        {
            return Convert.ToInt32(this.getProperty("childCareNumberOfPlaces"));
        }

        public void setChildCareNumberOfPlaces (int childCareNumberOfPlaces)
        {
            this.setProperty("childCareNumberOfPlaces", childCareNumberOfPlaces);
        }

        public string getChildCareProvider ()
        {
            return this.getProperty("childCareProvider").ToString();
        }

        public void setChildCareProvider (string childCareProvider)
        {
            this.setProperty("childCareProvider", childCareProvider);
        }

        public string getChildCareOtherSchools ()
        {
            return this.getProperty("childCareOtherSchools").ToString();
        }

        public void setChildCareOtherSchools (string childCareOtherSchools)
        {
            this.setProperty("childCareOtherSchools", childCareOtherSchools);
        }

        public int getChildCareWeeksOpen ()
        {
            return Convert.ToInt32(this.getProperty("childCareWeeksOpen"));
        }

        public void setChildCareWeeksOpen (int childCareWeeksOpen)
        {
            this.setProperty("childCareWeeksOpen", childCareWeeksOpen);
        }


    }
}

