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
        public const string SICKNESS_CATEGORY = "sicknessCategory";
        public const string SICKNESS_SUBCATEGORY = "sicknessSubcategory";
        public const string APPROVED_DATETIME = "approvedDatetime";
        public const string APPROVED_BY_STAFF = "approvedByStaff";
        public const string CALCULATED_WORKING_DAYS = "calculatedWorkingDays";
        public const string ACTUAL_WORKING_DAYS = "actualWorkingDays";
        public const string WORKING_DAYS = "workingDays";
        public const string CALCULATED_WORKING_HOURS = "calculatedWorkingHours";
        public const string ACTUAL_WORKING_HOURS = "actualWorkingHours";
        public const string WORKING_HOURS = "workingHours";
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
            return Convert.ToDateTime(this.getProperty("startDatetime"))
        }

        public void setStartDatetime (DateTime startDatetime)
        {
            this.setProperty("startDatetime", startDatetime);
        }

        public DateTime getEndDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("endDatetime"))
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

        public StaffAbsenceSicknessCategory getSicknessCategory ()
        {
            return (StaffAbsenceSicknessCategory) this.getProperty("sicknessCategory");
        }

        public void setSicknessCategory (StaffAbsenceSicknessCategory sicknessCategory)
        {
            this.setProperty("sicknessCategory", sicknessCategory);
        }

        public StaffAbsenceSicknessSubcategory getSicknessSubcategory ()
        {
            return (StaffAbsenceSicknessSubcategory) this.getProperty("sicknessSubcategory");
        }

        public void setSicknessSubcategory (StaffAbsenceSicknessSubcategory sicknessSubcategory)
        {
            this.setProperty("sicknessSubcategory", sicknessSubcategory);
        }

        public DateTime getApprovedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("approvedDatetime"))
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

        public float getCalculatedWorkingDays ()
        {
            return (float) this.getProperty("calculatedWorkingDays");
        }

        public void setCalculatedWorkingDays (float calculatedWorkingDays)
        {
            this.setProperty("calculatedWorkingDays", calculatedWorkingDays);
        }

        public float getActualWorkingDays ()
        {
            return (float) this.getProperty("actualWorkingDays");
        }

        public void setActualWorkingDays (float actualWorkingDays)
        {
            this.setProperty("actualWorkingDays", actualWorkingDays);
        }

        public float getWorkingDays ()
        {
            return (float) this.getProperty("workingDays");
        }

        public void setWorkingDays (float workingDays)
        {
            this.setProperty("workingDays", workingDays);
        }

        public float getCalculatedWorkingHours ()
        {
            return (float) this.getProperty("calculatedWorkingHours");
        }

        public void setCalculatedWorkingHours (float calculatedWorkingHours)
        {
            this.setProperty("calculatedWorkingHours", calculatedWorkingHours);
        }

        public float getActualWorkingHours ()
        {
            return (float) this.getProperty("actualWorkingHours");
        }

        public void setActualWorkingHours (float actualWorkingHours)
        {
            this.setProperty("actualWorkingHours", actualWorkingHours);
        }

        public float getWorkingHours ()
        {
            return (float) this.getProperty("workingHours");
        }

        public void setWorkingHours (float workingHours)
        {
            this.setProperty("workingHours", workingHours);
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

