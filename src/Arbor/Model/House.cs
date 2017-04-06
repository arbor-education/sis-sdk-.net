using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class House : ModelBase
    {
        protected string resourceType = ResourceType.HOUSE;
        public const string CODE = "code";
        public const string HOUSE_NAME = "houseName";
        public const string SHORT_NAME = "shortName";
        public const string ACADEMIC_YEAR = "academicYear";
        public const string DISPLAY_ORDER = "displayOrder";

        public House ()
        {
            base.resourceType = this.resourceType;
        }
        
        public House (string resourceType = "House", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<House> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("House");
        	RestGateway gateway = (RestGateway) House.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<House> houseCollection = new ModelCollection<House> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    houseCollection.add((House) model);
        	}
        
        	return houseCollection;
        }

        public static House retrieve (string id)
        {
            RestGateway gateway = (RestGateway) House.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (House) gateway.retrieve(ResourceType.HOUSE, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public string getHouseName ()
        {
            return this.getProperty("houseName").ToString();
        }

        public void setHouseName (string houseName)
        {
            this.setProperty("houseName", houseName);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public int getDisplayOrder ()
        {
            return Convert.ToInt32(this.getProperty("displayOrder"));
        }

        public void setDisplayOrder (int displayOrder)
        {
            this.setProperty("displayOrder", displayOrder);
        }


    }
}

