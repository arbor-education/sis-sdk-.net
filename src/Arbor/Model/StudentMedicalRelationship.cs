using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentMedicalRelationship : ModelBase
    {
        protected new string resourceType = ResourceType.STUDENT_MEDICAL_RELATIONSHIP;
        public const string STUDENT = "student";
        public const string MEDICAL_INSTITUTION = "medicalInstitution";
        public const string MEDICAL_INSTITUTION_STAFF = "medicalInstitutionStaff";
        public const string MEDICAL_RELATIONSHIP_TYPE = "medicalRelationshipType";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";
        public const string NOTES = "notes";

        public StudentMedicalRelationship ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentMedicalRelationship (string resourceType = "StudentMedicalRelationship", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentMedicalRelationship> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentMedicalRelationship");
        	RestGateway gateway = (RestGateway) StudentMedicalRelationship.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentMedicalRelationship> studentmedicalrelationshipCollection = new ModelCollection<StudentMedicalRelationship> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentmedicalrelationshipCollection.add((StudentMedicalRelationship) model);
        	}
        
        	return studentmedicalrelationshipCollection;
        }

        public static StudentMedicalRelationship retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentMedicalRelationship.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentMedicalRelationship) gateway.retrieve(ResourceType.STUDENT_MEDICAL_RELATIONSHIP, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public MedicalInstitution getMedicalInstitution ()
        {
            return (MedicalInstitution) this.getProperty("medicalInstitution");
        }

        public void setMedicalInstitution (MedicalInstitution medicalInstitution)
        {
            this.setProperty("medicalInstitution", medicalInstitution);
        }

        public MedicalInstitutionStaff getMedicalInstitutionStaff ()
        {
            return (MedicalInstitutionStaff) this.getProperty("medicalInstitutionStaff");
        }

        public void setMedicalInstitutionStaff (MedicalInstitutionStaff medicalInstitutionStaff)
        {
            this.setProperty("medicalInstitutionStaff", medicalInstitutionStaff);
        }

        public MedicalRelationshipType getMedicalRelationshipType ()
        {
            return (MedicalRelationshipType) this.getProperty("medicalRelationshipType");
        }

        public void setMedicalRelationshipType (MedicalRelationshipType medicalRelationshipType)
        {
            this.setProperty("medicalRelationshipType", medicalRelationshipType);
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

        public string getNotes ()
        {
            return this.getProperty("notes").ToString();
        }

        public void setNotes (string notes)
        {
            this.setProperty("notes", notes);
        }


    }
}

