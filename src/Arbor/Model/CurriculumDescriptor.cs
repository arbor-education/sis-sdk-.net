using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CurriculumDescriptor : ModelBase
    {
        protected string resourceType = ResourceType.CURRICULUM_DESCRIPTOR;
        public const string CURRICULUM_SECTION = "curriculumSection";
        public const string CODE = "code";
        public const string NAME = "name";
        public const string SHORT_NAME = "shortName";
        public const string DESCRIPTION = "description";
        public const string EXAMPLES = "examples";
        public const string LOWER_GRADE_POINT_VALUE = "lowerGradePointValue";
        public const string UPPER_GRADE_POINT_VALUE = "upperGradePointValue";
        public const string WEIGHTING = "weighting";
        public const string REQUIREMENT_FOR_HIGHER = "requirementForHigher";

        public CurriculumDescriptor ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CurriculumDescriptor (string resourceType = "CurriculumDescriptor", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CurriculumDescriptor> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CurriculumDescriptor");
        	RestGateway gateway = (RestGateway) CurriculumDescriptor.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CurriculumDescriptor> curriculumdescriptorCollection = new ModelCollection<CurriculumDescriptor> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    curriculumdescriptorCollection.add((CurriculumDescriptor) model);
        	}
        
        	return curriculumdescriptorCollection;
        }

        public static CurriculumDescriptor retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CurriculumDescriptor.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CurriculumDescriptor) gateway.retrieve(ResourceType.CURRICULUM_DESCRIPTOR, id);
        }

        public CurriculumSection getCurriculumSection ()
        {
            return (CurriculumSection) this.getProperty("curriculumSection");
        }

        public void setCurriculumSection (CurriculumSection curriculumSection)
        {
            this.setProperty("curriculumSection", curriculumSection);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public string getShortName ()
        {
            return this.getProperty("shortName").ToString();
        }

        public void setShortName (string shortName)
        {
            this.setProperty("shortName", shortName);
        }

        public string getDescription ()
        {
            return this.getProperty("description").ToString();
        }

        public void setDescription (string description)
        {
            this.setProperty("description", description);
        }

        public string getExamples ()
        {
            return this.getProperty("examples").ToString();
        }

        public void setExamples (string examples)
        {
            this.setProperty("examples", examples);
        }

        public float getLowerGradePointValue ()
        {
            return (float) this.getProperty("lowerGradePointValue");
        }

        public void setLowerGradePointValue (float lowerGradePointValue)
        {
            this.setProperty("lowerGradePointValue", lowerGradePointValue);
        }

        public float getUpperGradePointValue ()
        {
            return (float) this.getProperty("upperGradePointValue");
        }

        public void setUpperGradePointValue (float upperGradePointValue)
        {
            this.setProperty("upperGradePointValue", upperGradePointValue);
        }

        public float getWeighting ()
        {
            return (float) this.getProperty("weighting");
        }

        public void setWeighting (float weighting)
        {
            this.setProperty("weighting", weighting);
        }

        public bool getRequirementForHigher ()
        {
            return (bool) this.getProperty("requirementForHigher");
        }

        public void setRequirementForHigher (bool requirementForHigher)
        {
            this.setProperty("requirementForHigher", requirementForHigher);
        }


    }
}

