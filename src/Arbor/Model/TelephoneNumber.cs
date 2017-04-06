using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TelephoneNumber : ModelBase
    {
        protected string resourceType = ResourceType.TELEPHONE_NUMBER;
        public const string NUMBER_OWNER = "numberOwner";
        public const string TELEPHONE_NUMBER_TYPE = "telephoneNumberType";
        public const string NUMBER = "number";
        public const string EXTENSION_NUMBER = "extension_number";
        public const string NOTES = "notes";
        public const string TELEPHONE_NUMBER_RANKING = "telephoneNumberRanking";

        public TelephoneNumber ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TelephoneNumber (string resourceType = "TelephoneNumber", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TelephoneNumber> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("TelephoneNumber");
        	RestGateway gateway = (RestGateway) TelephoneNumber.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TelephoneNumber> telephonenumberCollection = new ModelCollection<TelephoneNumber> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    telephonenumberCollection.add((TelephoneNumber) model);
        	}
        
        	return telephonenumberCollection;
        }

        public static TelephoneNumber retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TelephoneNumber.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TelephoneNumber) gateway.retrieve(ResourceType.TELEPHONE_NUMBER, id);
        }

        public ModelBase getNumberOwner ()
        {
            return (ModelBase) this.getProperty("numberOwner");
        }

        public void setNumberOwner (ModelBase numberOwner)
        {
            this.setProperty("numberOwner", numberOwner);
        }

        public string getTelephoneNumberType ()
        {
            return this.getProperty("telephoneNumberType").ToString();
        }

        public void setTelephoneNumberType (string telephoneNumberType)
        {
            this.setProperty("telephoneNumberType", telephoneNumberType);
        }

        public string getNumber ()
        {
            return this.getProperty("number").ToString();
        }

        public void setNumber (string number)
        {
            this.setProperty("number", number);
        }

        public string getExtension_number ()
        {
            return this.getProperty("extension_number").ToString();
        }

        public void setExtension_number (string extension_number)
        {
            this.setProperty("extension_number", extension_number);
        }

        public string getNotes ()
        {
            return this.getProperty("notes").ToString();
        }

        public void setNotes (string notes)
        {
            this.setProperty("notes", notes);
        }

        public int getTelephoneNumberRanking ()
        {
            return Convert.ToInt32(this.getProperty("telephoneNumberRanking"));
        }

        public void setTelephoneNumberRanking (int telephoneNumberRanking)
        {
            this.setProperty("telephoneNumberRanking", telephoneNumberRanking);
        }


    }
}

