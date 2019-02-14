using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffAttendanceMark : ModelBase
    {
        protected string resourceType = ResourceType.STAFF_ATTENDANCE_MARK;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string ATTENDANCE_MARK = "attendanceMark";
        public const string MARK_DESCRIPTION = "markDescription";
        public const string MARK_SHORT_DESCRIPTION = "markShortDescription";
        public const string IS_DEFAULT_PRESENT = "isDefaultPresent";
        public const string IS_DEFAULT_ABSENT = "isDefaultAbsent";
        public const string IS_DEFAULT_LATE = "isDefaultLate";
        public const string IS_LEGAL_PRESENT = "isLegalPresent";
        public const string IS_LEGAL_HOLIDAY_LEAVE = "isLegalHolidayLeave";
        public const string IS_LEGAL_MEDICAL_LEAVE = "isLegalMedicalLeave";
        public const string IS_LEGAL_ILLNESS = "isLegalIllness";
        public const string IS_PHYSICAL_PRESENT = "isPhysicalPresent";
        public const string IS_PHYSICAL_LATE = "isPhysicalLate";
        public const string IS_PHYSICAL_ABSENT = "isPhysicalAbsent";
        public const string IS_PHYSICAL_NOT_REQUIRED = "isPhysicalNotRequired";

        public StaffAttendanceMark ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StaffAttendanceMark (string resourceType = "StaffAttendanceMark", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StaffAttendanceMark> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StaffAttendanceMark");
        	RestGateway gateway = (RestGateway) StaffAttendanceMark.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StaffAttendanceMark> staffattendancemarkCollection = new ModelCollection<StaffAttendanceMark> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    staffattendancemarkCollection.add((StaffAttendanceMark) model);
        	}
        
        	return staffattendancemarkCollection;
        }

        public static StaffAttendanceMark retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StaffAttendanceMark.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StaffAttendanceMark) gateway.retrieve(ResourceType.STAFF_ATTENDANCE_MARK, id);
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
            return Convert.ToBoolean(this.getProperty("active"))
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

        public string getAttendanceMark ()
        {
            return this.getProperty("attendanceMark").ToString();
        }

        public void setAttendanceMark (string attendanceMark)
        {
            this.setProperty("attendanceMark", attendanceMark);
        }

        public string getMarkDescription ()
        {
            return this.getProperty("markDescription").ToString();
        }

        public void setMarkDescription (string markDescription)
        {
            this.setProperty("markDescription", markDescription);
        }

        public string getMarkShortDescription ()
        {
            return this.getProperty("markShortDescription").ToString();
        }

        public void setMarkShortDescription (string markShortDescription)
        {
            this.setProperty("markShortDescription", markShortDescription);
        }

        public bool getIsDefaultPresent ()
        {
            return Convert.ToBoolean(this.getProperty("isDefaultPresent"))
        }

        public void setIsDefaultPresent (bool isDefaultPresent)
        {
            this.setProperty("isDefaultPresent", isDefaultPresent);
        }

        public bool getIsDefaultAbsent ()
        {
            return Convert.ToBoolean(this.getProperty("isDefaultAbsent"))
        }

        public void setIsDefaultAbsent (bool isDefaultAbsent)
        {
            this.setProperty("isDefaultAbsent", isDefaultAbsent);
        }

        public bool getIsDefaultLate ()
        {
            return Convert.ToBoolean(this.getProperty("isDefaultLate"))
        }

        public void setIsDefaultLate (bool isDefaultLate)
        {
            this.setProperty("isDefaultLate", isDefaultLate);
        }

        public bool getIsLegalPresent ()
        {
            return Convert.ToBoolean(this.getProperty("isLegalPresent"))
        }

        public void setIsLegalPresent (bool isLegalPresent)
        {
            this.setProperty("isLegalPresent", isLegalPresent);
        }

        public bool getIsLegalHolidayLeave ()
        {
            return Convert.ToBoolean(this.getProperty("isLegalHolidayLeave"))
        }

        public void setIsLegalHolidayLeave (bool isLegalHolidayLeave)
        {
            this.setProperty("isLegalHolidayLeave", isLegalHolidayLeave);
        }

        public bool getIsLegalMedicalLeave ()
        {
            return Convert.ToBoolean(this.getProperty("isLegalMedicalLeave"))
        }

        public void setIsLegalMedicalLeave (bool isLegalMedicalLeave)
        {
            this.setProperty("isLegalMedicalLeave", isLegalMedicalLeave);
        }

        public bool getIsLegalIllness ()
        {
            return Convert.ToBoolean(this.getProperty("isLegalIllness"))
        }

        public void setIsLegalIllness (bool isLegalIllness)
        {
            this.setProperty("isLegalIllness", isLegalIllness);
        }

        public bool getIsPhysicalPresent ()
        {
            return Convert.ToBoolean(this.getProperty("isPhysicalPresent"))
        }

        public void setIsPhysicalPresent (bool isPhysicalPresent)
        {
            this.setProperty("isPhysicalPresent", isPhysicalPresent);
        }

        public bool getIsPhysicalLate ()
        {
            return Convert.ToBoolean(this.getProperty("isPhysicalLate"))
        }

        public void setIsPhysicalLate (bool isPhysicalLate)
        {
            this.setProperty("isPhysicalLate", isPhysicalLate);
        }

        public bool getIsPhysicalAbsent ()
        {
            return Convert.ToBoolean(this.getProperty("isPhysicalAbsent"))
        }

        public void setIsPhysicalAbsent (bool isPhysicalAbsent)
        {
            this.setProperty("isPhysicalAbsent", isPhysicalAbsent);
        }

        public bool getIsPhysicalNotRequired ()
        {
            return Convert.ToBoolean(this.getProperty("isPhysicalNotRequired"))
        }

        public void setIsPhysicalNotRequired (bool isPhysicalNotRequired)
        {
            this.setProperty("isPhysicalNotRequired", isPhysicalNotRequired);
        }


    }
}

