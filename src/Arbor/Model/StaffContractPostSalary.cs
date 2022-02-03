using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StaffContractPostSalary : ModelBase
    {
        protected string resourceType = ResourceType.STAFF_CONTRACT_POST_SALARY;
        public const string STAFF_CONTRACT_POST = "staffContractPost";
        public const string GROSS_SALARY = "grossSalary";
        public const string PAY_SCALE = "payScale";
        public const string PAY_SCALE_GRADE = "payScaleGrade";
        public const string PAY_SCALE_SPINAL_POINT = "payScaleSpinalPoint";
        public const string HOURS_PER_WEEK = "hoursPerWeek";
        public const string WEEKS_PER_YEAR = "weeksPerYear";
        public const string FTE_HOURS_PER_WEEK = "fteHoursPerWeek";
        public const string FTE_WEEKS_PER_YEAR = "fteWeeksPerYear";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string SAFEGUARDED_PERIOD_START_DATE = "safeguardedPeriodStartDate";
        public const string SAFEGUARDED_PERIOD_END_DATE = "safeguardedPeriodEndDate";

        public StaffContractPostSalary ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StaffContractPostSalary (string resourceType = "StaffContractPostSalary", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StaffContractPostSalary> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StaffContractPostSalary");
        	RestGateway gateway = (RestGateway) StaffContractPostSalary.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StaffContractPostSalary> staffcontractpostsalaryCollection = new ModelCollection<StaffContractPostSalary> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    staffcontractpostsalaryCollection.add((StaffContractPostSalary) model);
        	}
        
        	return staffcontractpostsalaryCollection;
        }

        public static StaffContractPostSalary retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StaffContractPostSalary.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StaffContractPostSalary) gateway.retrieve(ResourceType.STAFF_CONTRACT_POST_SALARY, id);
        }

        public StaffContractPost getStaffContractPost ()
        {
            return (StaffContractPost) this.getProperty("staffContractPost");
        }

        public void setStaffContractPost (StaffContractPost staffContractPost)
        {
            this.setProperty("staffContractPost", staffContractPost);
        }

        public string getGrossSalary ()
        {
            return this.getProperty("grossSalary").ToString();
        }

        public void setGrossSalary (string grossSalary)
        {
            this.setProperty("grossSalary", grossSalary);
        }

        public PayScale getPayScale ()
        {
            return (PayScale) this.getProperty("payScale");
        }

        public void setPayScale (PayScale payScale)
        {
            this.setProperty("payScale", payScale);
        }

        public PayScaleGrade getPayScaleGrade ()
        {
            return (PayScaleGrade) this.getProperty("payScaleGrade");
        }

        public void setPayScaleGrade (PayScaleGrade payScaleGrade)
        {
            this.setProperty("payScaleGrade", payScaleGrade);
        }

        public PayScaleSpinalPoint getPayScaleSpinalPoint ()
        {
            return (PayScaleSpinalPoint) this.getProperty("payScaleSpinalPoint");
        }

        public void setPayScaleSpinalPoint (PayScaleSpinalPoint payScaleSpinalPoint)
        {
            this.setProperty("payScaleSpinalPoint", payScaleSpinalPoint);
        }

        public string getHoursPerWeek ()
        {
            return this.getProperty("hoursPerWeek").ToString();
        }

        public void setHoursPerWeek (string hoursPerWeek)
        {
            this.setProperty("hoursPerWeek", hoursPerWeek);
        }

        public float getWeeksPerYear ()
        {
            return (float) this.getProperty("weeksPerYear");
        }

        public void setWeeksPerYear (float weeksPerYear)
        {
            this.setProperty("weeksPerYear", weeksPerYear);
        }

        public string getFteHoursPerWeek ()
        {
            return this.getProperty("fteHoursPerWeek").ToString();
        }

        public void setFteHoursPerWeek (string fteHoursPerWeek)
        {
            this.setProperty("fteHoursPerWeek", fteHoursPerWeek);
        }

        public float getFteWeeksPerYear ()
        {
            return (float) this.getProperty("fteWeeksPerYear");
        }

        public void setFteWeeksPerYear (float fteWeeksPerYear)
        {
            this.setProperty("fteWeeksPerYear", fteWeeksPerYear);
        }

        public DateTime getEffectiveDate ()
        {
            return Convert.ToDateTime(this.getProperty("effectiveDate"));
        }

        public void setEffectiveDate (DateTime effectiveDate)
        {
            this.setProperty("effectiveDate", effectiveDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"));
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }

        public DateTime getSafeguardedPeriodStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("safeguardedPeriodStartDate"));
        }

        public void setSafeguardedPeriodStartDate (DateTime safeguardedPeriodStartDate)
        {
            this.setProperty("safeguardedPeriodStartDate", safeguardedPeriodStartDate);
        }

        public DateTime getSafeguardedPeriodEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("safeguardedPeriodEndDate"));
        }

        public void setSafeguardedPeriodEndDate (DateTime safeguardedPeriodEndDate)
        {
            this.setProperty("safeguardedPeriodEndDate", safeguardedPeriodEndDate);
        }


    }
}

