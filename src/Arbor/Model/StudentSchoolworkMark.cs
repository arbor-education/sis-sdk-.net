using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentSchoolworkMark : ModelBase
    {
        protected string resourceType = ResourceType.STUDENT_SCHOOLWORK_MARK;
        public const string STUDENT_SCHOOLWORK = "studentSchoolwork";
        public const string SCHOOLWORK_DEFINITION_ASPECT = "schoolworkDefinitionAspect";
        public const string MARK_INTEGER = "markInteger";
        public const string MARK_DECIMAL = "markDecimal";
        public const string MARK_GRADE = "markGrade";
        public const string MARK_DATE = "markDate";

        public StudentSchoolworkMark ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentSchoolworkMark (string resourceType = "StudentSchoolworkMark", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentSchoolworkMark> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentSchoolworkMark");
        	RestGateway gateway = (RestGateway) StudentSchoolworkMark.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentSchoolworkMark> studentschoolworkmarkCollection = new ModelCollection<StudentSchoolworkMark> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentschoolworkmarkCollection.add((StudentSchoolworkMark) model);
        	}
        
        	return studentschoolworkmarkCollection;
        }

        public static StudentSchoolworkMark retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentSchoolworkMark.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentSchoolworkMark) gateway.retrieve(ResourceType.STUDENT_SCHOOLWORK_MARK, id);
        }

        public StudentSchoolwork getStudentSchoolwork ()
        {
            return (StudentSchoolwork) this.getProperty("studentSchoolwork");
        }

        public void setStudentSchoolwork (StudentSchoolwork studentSchoolwork)
        {
            this.setProperty("studentSchoolwork", studentSchoolwork);
        }

        public SchoolworkDefinitionAspect getSchoolworkDefinitionAspect ()
        {
            return (SchoolworkDefinitionAspect) this.getProperty("schoolworkDefinitionAspect");
        }

        public void setSchoolworkDefinitionAspect (SchoolworkDefinitionAspect schoolworkDefinitionAspect)
        {
            this.setProperty("schoolworkDefinitionAspect", schoolworkDefinitionAspect);
        }

        public int getMarkInteger ()
        {
            return Convert.ToInt32(this.getProperty("markInteger"));
        }

        public void setMarkInteger (int markInteger)
        {
            this.setProperty("markInteger", markInteger);
        }

        public float getMarkDecimal ()
        {
            return (float) this.getProperty("markDecimal");
        }

        public void setMarkDecimal (float markDecimal)
        {
            this.setProperty("markDecimal", markDecimal);
        }

        public Grade getMarkGrade ()
        {
            return (Grade) this.getProperty("markGrade");
        }

        public void setMarkGrade (Grade markGrade)
        {
            this.setProperty("markGrade", markGrade);
        }

        public DateTime getMarkDate ()
        {
            return (DateTime) this.getProperty("markDate");
        }

        public void setMarkDate (DateTime markDate)
        {
            this.setProperty("markDate", markDate);
        }


    }
}

