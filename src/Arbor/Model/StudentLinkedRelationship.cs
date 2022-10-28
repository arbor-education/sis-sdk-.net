using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class StudentLinkedRelationship : ModelBase
    {
        protected new string resourceType = ResourceType.STUDENT_LINKED_RELATIONSHIP;
        public const string STUDENT = "student";
        public const string LINKED_OBJECT = "linkedObject";
        public const string STUDENT_LINKED_RELATIONSHIP_TYPE = "studentLinkedRelationshipType";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public StudentLinkedRelationship ()
        {
            base.resourceType = this.resourceType;
        }
        
        public StudentLinkedRelationship (string resourceType = "StudentLinkedRelationship", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<StudentLinkedRelationship> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("StudentLinkedRelationship");
        	RestGateway gateway = (RestGateway) StudentLinkedRelationship.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<StudentLinkedRelationship> studentlinkedrelationshipCollection = new ModelCollection<StudentLinkedRelationship> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    studentlinkedrelationshipCollection.add((StudentLinkedRelationship) model);
        	}
        
        	return studentlinkedrelationshipCollection;
        }

        public static StudentLinkedRelationship retrieve (string id)
        {
            RestGateway gateway = (RestGateway) StudentLinkedRelationship.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (StudentLinkedRelationship) gateway.retrieve(ResourceType.STUDENT_LINKED_RELATIONSHIP, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public ModelBase getLinkedObject ()
        {
            return (ModelBase) this.getProperty("linkedObject");
        }

        public void setLinkedObject (ModelBase linkedObject)
        {
            this.setProperty("linkedObject", linkedObject);
        }

        public StudentLinkedRelationshipType getStudentLinkedRelationshipType ()
        {
            return (StudentLinkedRelationshipType) this.getProperty("studentLinkedRelationshipType");
        }

        public void setStudentLinkedRelationshipType (StudentLinkedRelationshipType studentLinkedRelationshipType)
        {
            this.setProperty("studentLinkedRelationshipType", studentLinkedRelationshipType);
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


    }
}

