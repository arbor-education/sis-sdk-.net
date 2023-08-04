using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class SchoolworkAspect : ModelBase
    {
        protected new string resourceType = ResourceType.SCHOOLWORK_ASPECT;
        public const string SCHOOLWORK = "schoolwork";
        public const string ASPECT_NAME = "aspectName";
        public const string ASPECT_DATA_TYPE = "aspectDataType";
        public const string GRADE_SET = "gradeSet";
        public const string MARK_MIN_VALUE = "markMinValue";
        public const string MARK_MAX_VALUE = "markMaxValue";
        public const string SCALE_DIRECTION = "scaleDirection";

        public SchoolworkAspect()
        {
            base.resourceType = this.resourceType;
        }

        public SchoolworkAspect(string resourceType = "SchoolworkAspect", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<SchoolworkAspect> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("SchoolworkAspect");
            RestGateway gateway = (RestGateway)SchoolworkAspect.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<SchoolworkAspect> schoolworkaspectCollection = new ModelCollection<SchoolworkAspect>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                schoolworkaspectCollection.add((SchoolworkAspect)model);
            }

            return schoolworkaspectCollection;
        }

        public static SchoolworkAspect retrieve(string id)
        {
            RestGateway gateway = (RestGateway)SchoolworkAspect.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (SchoolworkAspect)gateway.retrieve(ResourceType.SCHOOLWORK_ASPECT, id);
        }

        public Schoolwork getSchoolwork()
        {
            return (Schoolwork)this.getProperty("schoolwork");
        }

        public void setSchoolwork(Schoolwork schoolwork)
        {
            this.setProperty("schoolwork", schoolwork);
        }

        public string getAspectName()
        {
            return this.getProperty("aspectName").ToString();
        }

        public void setAspectName(string aspectName)
        {
            this.setProperty("aspectName", aspectName);
        }

        public string getAspectDataType()
        {
            return this.getProperty("aspectDataType").ToString();
        }

        public void setAspectDataType(string aspectDataType)
        {
            this.setProperty("aspectDataType", aspectDataType);
        }

        public GradeSet getGradeSet()
        {
            return (GradeSet)this.getProperty("gradeSet");
        }

        public void setGradeSet(GradeSet gradeSet)
        {
            this.setProperty("gradeSet", gradeSet);
        }

        public float getMarkMinValue()
        {
            return (float)this.getProperty("markMinValue");
        }

        public void setMarkMinValue(float markMinValue)
        {
            this.setProperty("markMinValue", markMinValue);
        }

        public float getMarkMaxValue()
        {
            return (float)this.getProperty("markMaxValue");
        }

        public void setMarkMaxValue(float markMaxValue)
        {
            this.setProperty("markMaxValue", markMaxValue);
        }

        public string getScaleDirection()
        {
            return this.getProperty("scaleDirection").ToString();
        }

        public void setScaleDirection(string scaleDirection)
        {
            this.setProperty("scaleDirection", scaleDirection);
        }


    }
}

