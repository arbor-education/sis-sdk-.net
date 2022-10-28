using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class AttendanceMark : ModelBase
    {
        protected new string resourceType = ResourceType.ATTENDANCE_MARK;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string ATTENDANCE_MARK = "attendanceMark";
        public const string MARK_INDEX = "markIndex";
        public const string MARK_DESCRIPTION = "markDescription";
        public const string MARK_SHORT_DESCRIPTION = "markShortDescription";
        public const string IS_LEGAL_PRESENT = "isLegalPresent";
        public const string IS_LEGAL_APPROVED_EDUCATIONAL_ACTIVITY = "isLegalApprovedEducationalActivity";
        public const string IS_LEGAL_NOT_REQUIRED = "isLegalNotRequired";
        public const string IS_LEGAL_ABSENT = "isLegalAbsent";
        public const string IS_STATISTICAL_PRESENT = "isStatisticalPresent";
        public const string IS_STATISTICAL_AUTHORIZED_ABSENT = "isStatisticalAuthorizedAbsent";
        public const string IS_STATISTICAL_UNAUTHORIZED_ABSENT = "isStatisticalUnauthorizedAbsent";
        public const string IS_STATISTICAL_APPROVED_EDUCATIONAL_ACTIVITY = "isStatisticalApprovedEducationalActivity";
        public const string IS_STATISTICAL_POSSIBLE_ATTENDANCE = "isStatisticalPossibleAttendance";
        public const string IS_DEFAULT_PRESENT = "isDefaultPresent";
        public const string IS_DEFAULT_LATE = "isDefaultLate";
        public const string IS_DEFAULT_LATE_AFTER_REGISTER_CLOSED = "isDefaultLateAfterRegisterClosed";
        public const string IS_DEFAULT_ABSENT = "isDefaultAbsent";
        public const string IS_PHYSICAL_PRESENT = "isPhysicalPresent";
        public const string IS_PHYSICAL_LATE = "isPhysicalLate";
        public const string IS_PHYSICAL_ABSENT = "isPhysicalAbsent";
        public const string IS_PHYSICAL_NOT_REQUIRED = "isPhysicalNotRequired";
        public const string IS_PRESUMED_ABSENT = "isPresumedAbsent";
        public const string IS_EXCLUDED = "isExcluded";
        public const string SHOW_IN_REGISTER = "showInRegister";

        public AttendanceMark ()
        {
            base.resourceType = this.resourceType;
        }
        
        public AttendanceMark (string resourceType = "AttendanceMark", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<AttendanceMark> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("AttendanceMark");
        	RestGateway gateway = (RestGateway) AttendanceMark.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<AttendanceMark> attendancemarkCollection = new ModelCollection<AttendanceMark> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    attendancemarkCollection.add((AttendanceMark) model);
        	}
        
        	return attendancemarkCollection;
        }

        public static AttendanceMark retrieve (string id)
        {
            RestGateway gateway = (RestGateway) AttendanceMark.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (AttendanceMark) gateway.retrieve(ResourceType.ATTENDANCE_MARK, id);
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

        public string getAttendanceMark ()
        {
            return this.getProperty("attendanceMark").ToString();
        }

        public void setAttendanceMark (string attendanceMark)
        {
            this.setProperty("attendanceMark", attendanceMark);
        }

        public int getMarkIndex ()
        {
            return Convert.ToInt32(this.getProperty("markIndex"));
        }

        public void setMarkIndex (int markIndex)
        {
            this.setProperty("markIndex", markIndex);
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

        public bool getIsLegalPresent ()
        {
            return Convert.ToBoolean(this.getProperty("isLegalPresent"));
        }

        public void setIsLegalPresent (bool isLegalPresent)
        {
            this.setProperty("isLegalPresent", isLegalPresent);
        }

        public bool getIsLegalApprovedEducationalActivity ()
        {
            return Convert.ToBoolean(this.getProperty("isLegalApprovedEducationalActivity"));
        }

        public void setIsLegalApprovedEducationalActivity (bool isLegalApprovedEducationalActivity)
        {
            this.setProperty("isLegalApprovedEducationalActivity", isLegalApprovedEducationalActivity);
        }

        public bool getIsLegalNotRequired ()
        {
            return Convert.ToBoolean(this.getProperty("isLegalNotRequired"));
        }

        public void setIsLegalNotRequired (bool isLegalNotRequired)
        {
            this.setProperty("isLegalNotRequired", isLegalNotRequired);
        }

        public bool getIsLegalAbsent ()
        {
            return Convert.ToBoolean(this.getProperty("isLegalAbsent"));
        }

        public void setIsLegalAbsent (bool isLegalAbsent)
        {
            this.setProperty("isLegalAbsent", isLegalAbsent);
        }

        public bool getIsStatisticalPresent ()
        {
            return Convert.ToBoolean(this.getProperty("isStatisticalPresent"));
        }

        public void setIsStatisticalPresent (bool isStatisticalPresent)
        {
            this.setProperty("isStatisticalPresent", isStatisticalPresent);
        }

        public bool getIsStatisticalAuthorizedAbsent ()
        {
            return Convert.ToBoolean(this.getProperty("isStatisticalAuthorizedAbsent"));
        }

        public void setIsStatisticalAuthorizedAbsent (bool isStatisticalAuthorizedAbsent)
        {
            this.setProperty("isStatisticalAuthorizedAbsent", isStatisticalAuthorizedAbsent);
        }

        public bool getIsStatisticalUnauthorizedAbsent ()
        {
            return Convert.ToBoolean(this.getProperty("isStatisticalUnauthorizedAbsent"));
        }

        public void setIsStatisticalUnauthorizedAbsent (bool isStatisticalUnauthorizedAbsent)
        {
            this.setProperty("isStatisticalUnauthorizedAbsent", isStatisticalUnauthorizedAbsent);
        }

        public bool getIsStatisticalApprovedEducationalActivity ()
        {
            return Convert.ToBoolean(this.getProperty("isStatisticalApprovedEducationalActivity"));
        }

        public void setIsStatisticalApprovedEducationalActivity (bool isStatisticalApprovedEducationalActivity)
        {
            this.setProperty("isStatisticalApprovedEducationalActivity", isStatisticalApprovedEducationalActivity);
        }

        public bool getIsStatisticalPossibleAttendance ()
        {
            return Convert.ToBoolean(this.getProperty("isStatisticalPossibleAttendance"));
        }

        public void setIsStatisticalPossibleAttendance (bool isStatisticalPossibleAttendance)
        {
            this.setProperty("isStatisticalPossibleAttendance", isStatisticalPossibleAttendance);
        }

        public bool getIsDefaultPresent ()
        {
            return Convert.ToBoolean(this.getProperty("isDefaultPresent"));
        }

        public void setIsDefaultPresent (bool isDefaultPresent)
        {
            this.setProperty("isDefaultPresent", isDefaultPresent);
        }

        public bool getIsDefaultLate ()
        {
            return Convert.ToBoolean(this.getProperty("isDefaultLate"));
        }

        public void setIsDefaultLate (bool isDefaultLate)
        {
            this.setProperty("isDefaultLate", isDefaultLate);
        }

        public bool getIsDefaultLateAfterRegisterClosed ()
        {
            return Convert.ToBoolean(this.getProperty("isDefaultLateAfterRegisterClosed"));
        }

        public void setIsDefaultLateAfterRegisterClosed (bool isDefaultLateAfterRegisterClosed)
        {
            this.setProperty("isDefaultLateAfterRegisterClosed", isDefaultLateAfterRegisterClosed);
        }

        public bool getIsDefaultAbsent ()
        {
            return Convert.ToBoolean(this.getProperty("isDefaultAbsent"));
        }

        public void setIsDefaultAbsent (bool isDefaultAbsent)
        {
            this.setProperty("isDefaultAbsent", isDefaultAbsent);
        }

        public bool getIsPhysicalPresent ()
        {
            return Convert.ToBoolean(this.getProperty("isPhysicalPresent"));
        }

        public void setIsPhysicalPresent (bool isPhysicalPresent)
        {
            this.setProperty("isPhysicalPresent", isPhysicalPresent);
        }

        public bool getIsPhysicalLate ()
        {
            return Convert.ToBoolean(this.getProperty("isPhysicalLate"));
        }

        public void setIsPhysicalLate (bool isPhysicalLate)
        {
            this.setProperty("isPhysicalLate", isPhysicalLate);
        }

        public bool getIsPhysicalAbsent ()
        {
            return Convert.ToBoolean(this.getProperty("isPhysicalAbsent"));
        }

        public void setIsPhysicalAbsent (bool isPhysicalAbsent)
        {
            this.setProperty("isPhysicalAbsent", isPhysicalAbsent);
        }

        public bool getIsPhysicalNotRequired ()
        {
            return Convert.ToBoolean(this.getProperty("isPhysicalNotRequired"));
        }

        public void setIsPhysicalNotRequired (bool isPhysicalNotRequired)
        {
            this.setProperty("isPhysicalNotRequired", isPhysicalNotRequired);
        }

        public bool getIsPresumedAbsent ()
        {
            return Convert.ToBoolean(this.getProperty("isPresumedAbsent"));
        }

        public void setIsPresumedAbsent (bool isPresumedAbsent)
        {
            this.setProperty("isPresumedAbsent", isPresumedAbsent);
        }

        public bool getIsExcluded ()
        {
            return Convert.ToBoolean(this.getProperty("isExcluded"));
        }

        public void setIsExcluded (bool isExcluded)
        {
            this.setProperty("isExcluded", isExcluded);
        }

        public bool getShowInRegister ()
        {
            return Convert.ToBoolean(this.getProperty("showInRegister"));
        }

        public void setShowInRegister (bool showInRegister)
        {
            this.setProperty("showInRegister", showInRegister);
        }


    }
}

