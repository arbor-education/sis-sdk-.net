using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffAbsenceCategory : ModelBase
    {
        protected string resourceType = ResourceType.STAFF_ABSENCE_CATEGORY;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string CATEGORY_NAME = "categoryName";
        public const string IS_PAID_SICK_LEAVE = "isPaidSickLeave";
        public const string IS_UNPAID_SICK_LEAVE = "isUnpaidSickLeave";
        public const string IS_PAID_HOLIDAY = "isPaidHoliday";
        public const string IS_UNPAID_HOLIDAY = "isUnpaidHoliday";
        public const string IS_PAID_MATERNITY = "isPaidMaternity";
        public const string IS_UNPAID_MATERNITY = "isUnpaidMaternity";
        public const string IS_PAID_PATERNITY = "isPaidPaternity";
        public const string IS_UNPAID_PATERNITY = "isUnpaidPaternity";
        public const string IS_AUTHORIZED_ABSENCE = "isAuthorizedAbsence";

        public StaffAbsenceCategory ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StaffAbsenceCategory (string resourceType = "StaffAbsenceCategory", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StaffAbsenceCategory> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StaffAbsenceCategory");
        	RestGateway gateway = (RestGateway) StaffAbsenceCategory.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StaffAbsenceCategory> staffabsencecategoryCollection = new ModelCollection<StaffAbsenceCategory> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    staffabsencecategoryCollection.add((StaffAbsenceCategory) model);
        	}
        
        	return staffabsencecategoryCollection;
        }

        public static StaffAbsenceCategory retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StaffAbsenceCategory.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StaffAbsenceCategory) gateway.retrieve(ResourceType.STAFF_ABSENCE_CATEGORY, id);
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
            return Convert.ToBoolean( this.getProperty("active"));
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

        public string getCategoryName ()
        {
            return this.getProperty("categoryName").ToString();
        }

        public void setCategoryName (string categoryName)
        {
            this.setProperty("categoryName", categoryName);
        }

        public bool getIsPaidSickLeave ()
        {
            return Convert.ToBoolean( this.getProperty("isPaidSickLeave"));
        }

        public void setIsPaidSickLeave (bool isPaidSickLeave)
        {
            this.setProperty("isPaidSickLeave", isPaidSickLeave);
        }

        public bool getIsUnpaidSickLeave ()
        {
            return Convert.ToBoolean( this.getProperty("isUnpaidSickLeave"));
        }

        public void setIsUnpaidSickLeave (bool isUnpaidSickLeave)
        {
            this.setProperty("isUnpaidSickLeave", isUnpaidSickLeave);
        }

        public bool getIsPaidHoliday ()
        {
            return Convert.ToBoolean( this.getProperty("isPaidHoliday"));
        }

        public void setIsPaidHoliday (bool isPaidHoliday)
        {
            this.setProperty("isPaidHoliday", isPaidHoliday);
        }

        public bool getIsUnpaidHoliday ()
        {
            return Convert.ToBoolean( this.getProperty("isUnpaidHoliday"));
        }

        public void setIsUnpaidHoliday (bool isUnpaidHoliday)
        {
            this.setProperty("isUnpaidHoliday", isUnpaidHoliday);
        }

        public bool getIsPaidMaternity ()
        {
            return Convert.ToBoolean( this.getProperty("isPaidMaternity"));
        }

        public void setIsPaidMaternity (bool isPaidMaternity)
        {
            this.setProperty("isPaidMaternity", isPaidMaternity);
        }

        public bool getIsUnpaidMaternity ()
        {
            return Convert.ToBoolean( this.getProperty("isUnpaidMaternity"));
        }

        public void setIsUnpaidMaternity (bool isUnpaidMaternity)
        {
            this.setProperty("isUnpaidMaternity", isUnpaidMaternity);
        }

        public bool getIsPaidPaternity ()
        {
            return Convert.ToBoolean( this.getProperty("isPaidPaternity"));
        }

        public void setIsPaidPaternity (bool isPaidPaternity)
        {
            this.setProperty("isPaidPaternity", isPaidPaternity);
        }

        public bool getIsUnpaidPaternity ()
        {
            return Convert.ToBoolean( this.getProperty("isUnpaidPaternity"));
        }

        public void setIsUnpaidPaternity (bool isUnpaidPaternity)
        {
            this.setProperty("isUnpaidPaternity", isUnpaidPaternity);
        }

        public bool getIsAuthorizedAbsence ()
        {
            return Convert.ToBoolean( this.getProperty("isAuthorizedAbsence"));
        }

        public void setIsAuthorizedAbsence (bool isAuthorizedAbsence)
        {
            this.setProperty("isAuthorizedAbsence", isAuthorizedAbsence);
        }


    }
}

