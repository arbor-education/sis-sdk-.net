using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Kpi : ModelBase
    {
        protected string resourceType = ResourceType.KPI;
        public const string CODE = "code";
        public const string KPI_NAME = "kpiName";
        public const string DESCRIPTION = "description";
        public const string CATEGORY = "category";
        public const string CALCULATION_CLASS = "calculationClass";
        public const string CALCULATION_CLASS_PARAMS = "calculationClassParams";
        public const string DIRECTION = "direction";
        public const string VALUE_TYPE = "valueType";
        public const string DATE_RANGE_PERIOD_TYPE = "dateRangePeriodType";
        public const string DATE_RANGE_PERIOD_COUNT = "dateRangePeriodCount";
        public const string DATE_RANGE_PERIOD_OFFSET = "dateRangePeriodOffset";
        public const string DECIMAL_PLACES = "decimalPlaces";
        public const string SIGNIFICANT_FIGURES = "significantFigures";
        public const string CALCULATE_FOR_SCHOOL = "calculateForSchool";
        public const string CALCULATE_FOR_GROUPS = "calculateForGroups";
        public const string CALCULATE_FOR_ACADEMIC_UNITS = "calculateForAcademicUnits";
        public const string CALCULATE_FOR_STUDENTS = "calculateForStudents";
        public const string CALCULATE_FOR_STUDENT_ACADEMIC_UNIT_ENROLMENTS = "calculateForStudentAcademicUnitEnrolments";

        public Kpi()
        {
            base.resourceType = this.resourceType;
        }

        public Kpi(string resourceType = "Kpi", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Kpi> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Kpi");
            RestGateway gateway = (RestGateway)Kpi.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Kpi> kpiCollection = new ModelCollection<Kpi>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                kpiCollection.add((Kpi)model);
            }

            return kpiCollection;
        }

        public static Kpi retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Kpi.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Kpi)gateway.retrieve(ResourceType.KPI, id);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }

        public string getKpiName()
        {
            return this.getProperty("kpiName").ToString();
        }

        public void setKpiName(string kpiName)
        {
            this.setProperty("kpiName", kpiName);
        }

        public string getDescription()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription(string description)
        {
            this.setProperty("description", description);
        }

        public string getCategory()
        {
            return this.getProperty("category").ToString();
        }

        public void setCategory(string category)
        {
            this.setProperty("category", category);
        }

        public string getCalculationClass()
        {
            return this.getProperty("calculationClass").ToString();
        }

        public void setCalculationClass(string calculationClass)
        {
            this.setProperty("calculationClass", calculationClass);
        }

        public string getCalculationClassParams()
        {
            return this.getProperty("calculationClassParams").ToString();
        }

        public void setCalculationClassParams(string calculationClassParams)
        {
            this.setProperty("calculationClassParams", calculationClassParams);
        }

        public string getDirection()
        {
            return this.getProperty("direction").ToString();
        }

        public void setDirection(string direction)
        {
            this.setProperty("direction", direction);
        }

        public string getValueType()
        {
            return this.getProperty("valueType").ToString();
        }

        public void setValueType(string valueType)
        {
            this.setProperty("valueType", valueType);
        }

        public string getDateRangePeriodType()
        {
            return this.getProperty("dateRangePeriodType").ToString();
        }

        public void setDateRangePeriodType(string dateRangePeriodType)
        {
            this.setProperty("dateRangePeriodType", dateRangePeriodType);
        }

        public int getDateRangePeriodCount()
        {
            return Convert.ToInt32(this.getProperty("dateRangePeriodCount"));
        }

        public void setDateRangePeriodCount(int dateRangePeriodCount)
        {
            this.setProperty("dateRangePeriodCount", dateRangePeriodCount);
        }

        public int getDateRangePeriodOffset()
        {
            return Convert.ToInt32(this.getProperty("dateRangePeriodOffset"));
        }

        public void setDateRangePeriodOffset(int dateRangePeriodOffset)
        {
            this.setProperty("dateRangePeriodOffset", dateRangePeriodOffset);
        }

        public int getDecimalPlaces()
        {
            return Convert.ToInt32(this.getProperty("decimalPlaces"));
        }

        public void setDecimalPlaces(int decimalPlaces)
        {
            this.setProperty("decimalPlaces", decimalPlaces);
        }

        public int getSignificantFigures()
        {
            return Convert.ToInt32(this.getProperty("significantFigures"));
        }

        public void setSignificantFigures(int significantFigures)
        {
            this.setProperty("significantFigures", significantFigures);
        }

        public bool getCalculateForSchool()
        {
            return Convert.ToBoolean(this.getProperty("calculateForSchool"));
        }

        public void setCalculateForSchool(bool calculateForSchool)
        {
            this.setProperty("calculateForSchool", calculateForSchool);
        }

        public bool getCalculateForGroups()
        {
            return Convert.ToBoolean(this.getProperty("calculateForGroups"));
        }

        public void setCalculateForGroups(bool calculateForGroups)
        {
            this.setProperty("calculateForGroups", calculateForGroups);
        }

        public bool getCalculateForAcademicUnits()
        {
            return Convert.ToBoolean(this.getProperty("calculateForAcademicUnits"));
        }

        public void setCalculateForAcademicUnits(bool calculateForAcademicUnits)
        {
            this.setProperty("calculateForAcademicUnits", calculateForAcademicUnits);
        }

        public bool getCalculateForStudents()
        {
            return Convert.ToBoolean(this.getProperty("calculateForStudents"));
        }

        public void setCalculateForStudents(bool calculateForStudents)
        {
            this.setProperty("calculateForStudents", calculateForStudents);
        }

        public bool getCalculateForStudentAcademicUnitEnrolments()
        {
            return Convert.ToBoolean(this.getProperty("calculateForStudentAcademicUnitEnrolments"));
        }

        public void setCalculateForStudentAcademicUnitEnrolments(bool calculateForStudentAcademicUnitEnrolments)
        {
            this.setProperty("calculateForStudentAcademicUnitEnrolments", calculateForStudentAcademicUnitEnrolments);
        }


    }
}

