using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffAbsence : ModelBase
    {
        protected string resourceType = ResourceType.STAFF_ABSENCE;
        public const string STAFF = "staff";
        public const string START_DATETIME = "startDatetime";
        public const string END_DATETIME = "endDatetime";
        public const string STAFF_ABSENCE_CATEGORY = "staffAbsenceCategory";
        public const string APPROVED_DATETIME = "approvedDatetime";
        public const string APPROVED_BY_STAFF = "approvedByStaff";
        public const string PAID_SICK_LEAVE_USED = "paidSickLeaveUsed";
        public const string UN_PAID_SICK_LEAVE_USED = "unPaidSickLeaveUsed";
        public const string PAID_HOLIDAY_USED = "paidHolidayUsed";
        public const string UN_PAID_HOLIDAY_USED = "unPaidHolidayUsed";
        public const string PAID_OTHER_LEAVE = "paidOtherLeave";
        public const string UN_PAID_OTHER_LEAVE = "unPaidOtherLeave";
        public const string NARRATIVE = "narrative";

        public StaffAbsence ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StaffAbsence (string resourceType = "StaffAbsence", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StaffAbsence> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StaffAbsence");
        	RestGateway gateway = (RestGateway) StaffAbsence.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StaffAbsence> staffabsenceCollection = new ModelCollection<StaffAbsence> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    staffabsenceCollection.add((StaffAbsence) model);
        	}
        
        	return staffabsenceCollection;
        }

        public static StaffAbsence retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StaffAbsence.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StaffAbsence) gateway.retrieve(ResourceType.STAFF_ABSENCE, id);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public DateTime getStartDatetime ()
        {
            return (DateTime) this.getProperty("startDatetime");
        }

        public void setStartDatetime (DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime ()
        {
            return (DateTime) this.getProperty("endDatetime");
        }

        public void setEndDatetime (DateTime endDatetime)
        {
            this.setProperty("endDatetime", endDatetime);
        }

        public StaffAbsenceCategory getStaffAbsenceCategory ()
        {
            return (StaffAbsenceCategory) this.getProperty("staffAbsenceCategory");
        }

        public void setStaffAbsenceCategory (StaffAbsenceCategory staffAbsenceCategory)
        {
            this.setProperty("staffAbsenceCategory", staffAbsenceCategory);
        }

        public DateTime getApprovedDatetime ()
        {
            return (DateTime) this.getProperty("approvedDatetime");
        }

        public void setApprovedDatetime (DateTime approvedDatetime)
        {
            this.setProperty("approvedDatetime", approvedDatetime);
        }

        public Staff getApprovedByStaff ()
        {
            return (Staff) this.getProperty("approvedByStaff");
        }

        public void setApprovedByStaff (Staff approvedByStaff)
        {
            this.setProperty("approvedByStaff", approvedByStaff);
        }

        public float getPaidSickLeaveUsed ()
        {
            return (float) this.getProperty("paidSickLeaveUsed");
        }

        public void setPaidSickLeaveUsed (float paidSickLeaveUsed)
        {
            this.setProperty("paidSickLeaveUsed", paidSickLeaveUsed);
        }

        public float getUnPaidSickLeaveUsed ()
        {
            return (float) this.getProperty("unPaidSickLeaveUsed");
        }

        public void setUnPaidSickLeaveUsed (float unPaidSickLeaveUsed)
        {
            this.setProperty("unPaidSickLeaveUsed", unPaidSickLeaveUsed);
        }

        public float getPaidHolidayUsed ()
        {
            return (float) this.getProperty("paidHolidayUsed");
        }

        public void setPaidHolidayUsed (float paidHolidayUsed)
        {
            this.setProperty("paidHolidayUsed", paidHolidayUsed);
        }

        public float getUnPaidHolidayUsed ()
        {
            return (float) this.getProperty("unPaidHolidayUsed");
        }

        public void setUnPaidHolidayUsed (float unPaidHolidayUsed)
        {
            this.setProperty("unPaidHolidayUsed", unPaidHolidayUsed);
        }

        public float getPaidOtherLeave ()
        {
            return (float) this.getProperty("paidOtherLeave");
        }

        public void setPaidOtherLeave (float paidOtherLeave)
        {
            this.setProperty("paidOtherLeave", paidOtherLeave);
        }

        public float getUnPaidOtherLeave ()
        {
            return (float) this.getProperty("unPaidOtherLeave");
        }

        public void setUnPaidOtherLeave (float unPaidOtherLeave)
        {
            this.setProperty("unPaidOtherLeave", unPaidOtherLeave);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }


    }
}

