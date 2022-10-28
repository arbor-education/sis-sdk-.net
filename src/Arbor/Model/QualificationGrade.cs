using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationGrade : ModelBase
    {
        protected new string resourceType = ResourceType.QUALIFICATION_GRADE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string QUALIFICATION_GRADE_SET = "qualificationGradeSet";
        public const string SHORT_NAME = "shortName";
        public const string NAME = "name";
        public const string GRADE_IDENTIFIER = "gradeIdentifier";
        public const string GRADE_VALUE = "gradeValue";
        public const string GRADE_DESCRIPTION = "gradeDescription";
        public const string GRADE_LETTER = "gradeLetter";
        public const string GRADE_ORDER = "gradeOrder";

        public QualificationGrade ()
        {
            base.resourceType = this.resourceType;
        }
        
        public QualificationGrade (string resourceType = "QualificationGrade", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<QualificationGrade> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("QualificationGrade");
        	RestGateway gateway = (RestGateway) QualificationGrade.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<QualificationGrade> qualificationgradeCollection = new ModelCollection<QualificationGrade> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    qualificationgradeCollection.add((QualificationGrade) model);
        	}
        
        	return qualificationgradeCollection;
        }

        public static QualificationGrade retrieve (string id)
        {
            RestGateway gateway = (RestGateway) QualificationGrade.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (QualificationGrade) gateway.retrieve(ResourceType.QUALIFICATION_GRADE, id);
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

        public QualificationGradeSet getQualificationGradeSet ()
        {
            return (QualificationGradeSet) this.getProperty("qualificationGradeSet");
        }

        public void setQualificationGradeSet (QualificationGradeSet qualificationGradeSet)
        {
            this.setProperty("qualificationGradeSet", qualificationGradeSet);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
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

        public string getGradeDescription ()
        {
            return this.getProperty("gradeDescription").ToString();
        }

        public void setGradeDescription (string gradeDescription)
        {
            this.setProperty("gradeDescription", gradeDescription);
        }

        public string getGradeLetter ()
        {
            return this.getProperty("gradeLetter").ToString();
        }

        public void setGradeLetter (string gradeLetter)
        {
            this.setProperty("gradeLetter", gradeLetter);
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

