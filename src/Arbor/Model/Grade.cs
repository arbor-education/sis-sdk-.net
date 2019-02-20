using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Grade : ModelBase
    {
        protected string resourceType = ResourceType.GRADE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string GRADE_SET = "gradeSet";
        public const string SHORT_NAME = "shortName";
        public const string LONG_NAME = "longName";
        public const string USER_DEFINED_SHORT_NAME = "userDefinedShortName";
        public const string USER_DEFINED_LONG_NAME = "userDefinedLongName";
        public const string USER_DEFINED_GRADE_DESCRIPTION = "userDefinedGradeDescription";
        public const string GRADE_IDENTIFIER = "gradeIdentifier";
        public const string GRADE_VALUE = "gradeValue";
        public const string LOWER_GRADE_POINT_SCALE_VALUE = "lowerGradePointScaleValue";
        public const string UPPER_GRADE_POINT_SCALE_VALUE = "upperGradePointScaleValue";
        public const string STATISTICAL_GRADE_POINT_SCALE_VALUE = "statisticalGradePointScaleValue";
        public const string GRADE_ORDER = "gradeOrder";

        public Grade ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Grade (string resourceType = "Grade", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Grade> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Grade");
        	RestGateway gateway = (RestGateway) Grade.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Grade> gradeCollection = new ModelCollection<Grade> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    gradeCollection.add((Grade) model);
        	}
        
        	return gradeCollection;
        }

        public static Grade retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Grade.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Grade) gateway.retrieve(ResourceType.GRADE, id);
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

        public GradeSet getGradeSet ()
        {
            return (GradeSet) this.getProperty("gradeSet");
        }

        public void setGradeSet (GradeSet gradeSet)
        {
            this.setProperty("gradeSet", gradeSet);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public string getLongName ()
        {
            return this.getProperty("longName").ToString();
        }

        public void setLongName (string longName)
        {
            this.setProperty("longName", longName);
        }

        public string getUserDefinedShortName ()
        {
            return this.getProperty("userDefinedShortName").ToString();
        }

        public void setUserDefinedShortName (string userDefinedShortName)
        {
            this.setProperty("userDefinedShortName", userDefinedShortName);
        }

        public string getUserDefinedLongName ()
        {
            return this.getProperty("userDefinedLongName").ToString();
        }

        public void setUserDefinedLongName (string userDefinedLongName)
        {
            this.setProperty("userDefinedLongName", userDefinedLongName);
        }

        public string getUserDefinedGradeDescription ()
        {
            return this.getProperty("userDefinedGradeDescription").ToString();
        }

        public void setUserDefinedGradeDescription (string userDefinedGradeDescription)
        {
            this.setProperty("userDefinedGradeDescription", userDefinedGradeDescription);
        }

        public string getGradeIdentifier ()
        {
            return this.getProperty("gradeIdentifier").ToString();
        }

        public void setGradeIdentifier (string gradeIdentifier)
        {
            this.setProperty("gradeIdentifier", gradeIdentifier);
        }

        public float getGradeValue ()
        {
            return (float) this.getProperty("gradeValue");
        }

        public void setGradeValue (float gradeValue)
        {
            this.setProperty("gradeValue", gradeValue);
        }

        public float getLowerGradePointScaleValue ()
        {
            return (float) this.getProperty("lowerGradePointScaleValue");
        }

        public void setLowerGradePointScaleValue (float lowerGradePointScaleValue)
        {
            this.setProperty("lowerGradePointScaleValue", lowerGradePointScaleValue);
        }

        public float getUpperGradePointScaleValue ()
        {
            return (float) this.getProperty("upperGradePointScaleValue");
        }

        public void setUpperGradePointScaleValue (float upperGradePointScaleValue)
        {
            this.setProperty("upperGradePointScaleValue", upperGradePointScaleValue);
        }

        public float getStatisticalGradePointScaleValue ()
        {
            return (float) this.getProperty("statisticalGradePointScaleValue");
        }

        public void setStatisticalGradePointScaleValue (float statisticalGradePointScaleValue)
        {
            this.setProperty("statisticalGradePointScaleValue", statisticalGradePointScaleValue);
        }

        public int getGradeOrder ()
        {
            return Convert.ToInt32(this.getProperty("gradeOrder"));
        }

        public void setGradeOrder (int gradeOrder)
        {
            this.setProperty("gradeOrder", gradeOrder);
        }


    }
}

