using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Ethnicity : ModelBase
    {
        protected new string resourceType = ResourceType.ETHNICITY;
        public const string DFES_MAIN_CODE = "dfesMainCode";
        public const string D00005 = "d00005";
        public const string ONS_CODE = "onsCode";
        public const string D00250 = "d00250";
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string ETHNICITY_NAME = "ethnicityName";
        public const string ETHNICITY_CATEGORY = "ethnicityCategory";
        public const string APPLIES_TO_STUDENTS = "appliesToStudents";
        public const string APPLIES_TO_STAFF = "appliesToStaff";
        public const string NOTES = "notes";

        public Ethnicity ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Ethnicity (string resourceType = "Ethnicity", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Ethnicity> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Ethnicity");
        	RestGateway gateway = (RestGateway) Ethnicity.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Ethnicity> ethnicityCollection = new ModelCollection<Ethnicity> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ethnicityCollection.add((Ethnicity) model);
        	}
        
        	return ethnicityCollection;
        }

        public static Ethnicity retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Ethnicity.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Ethnicity) gateway.retrieve(ResourceType.ETHNICITY, id);
        }

        public string getDfesMainCode ()
        {
            return this.getProperty("dfesMainCode").ToString();
        }

        public void setDfesMainCode (string dfesMainCode)
        {
            this.setProperty("dfesMainCode", dfesMainCode);
        }

        public string getD00005 ()
        {
            return this.getProperty("d00005").ToString();
        }

        public void setD00005 (string d00005)
        {
            this.setProperty("d00005", d00005);
        }

        public string getOnsCode ()
        {
            return this.getProperty("onsCode").ToString();
        }

        public void setOnsCode (string onsCode)
        {
            this.setProperty("onsCode", onsCode);
        }

        public string getD00250 ()
        {
            return this.getProperty("d00250").ToString();
        }

        public void setD00250 (string d00250)
        {
            this.setProperty("d00250", d00250);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getEthnicityName ()
        {
            return this.getProperty("ethnicityName").ToString();
        }

        public void setEthnicityName (string ethnicityName)
        {
            this.setProperty("ethnicityName", ethnicityName);
        }

        public EthnicityCategory getEthnicityCategory ()
        {
            return (EthnicityCategory) this.getProperty("ethnicityCategory");
        }

        public void setEthnicityCategory (EthnicityCategory ethnicityCategory)
        {
            this.setProperty("ethnicityCategory", ethnicityCategory);
        }

        public bool getAppliesToStudents ()
        {
            return Convert.ToBoolean(this.getProperty("appliesToStudents"));
        }

        public void setAppliesToStudents (bool appliesToStudents)
        {
            this.setProperty("appliesToStudents", appliesToStudents);
        }

        public bool getAppliesToStaff ()
        {
            return Convert.ToBoolean(this.getProperty("appliesToStaff"));
        }

        public void setAppliesToStaff (bool appliesToStaff)
        {
            this.setProperty("appliesToStaff", appliesToStaff);
        }

        public string getNotes ()
        {
            return this.getProperty("notes").ToString();
        }

        public void setNotes (string notes)
        {
            this.setProperty("notes", notes);
        }


    }
}

