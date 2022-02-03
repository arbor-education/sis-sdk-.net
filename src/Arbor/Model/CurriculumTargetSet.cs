using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CurriculumTargetSet : ModelBase
    {
        protected string resourceType = ResourceType.CURRICULUM_TARGET_SET;
        public const string CURRICULUM = "curriculum";
        public const string TYPE = "type";
        public const string NAME = "name";
        public const string EFFECTIVE_DATE = "effectiveDate";
        public const string END_DATE = "endDate";

        public CurriculumTargetSet ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CurriculumTargetSet (string resourceType = "CurriculumTargetSet", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CurriculumTargetSet> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CurriculumTargetSet");
        	RestGateway gateway = (RestGateway) CurriculumTargetSet.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CurriculumTargetSet> curriculumtargetsetCollection = new ModelCollection<CurriculumTargetSet> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    curriculumtargetsetCollection.add((CurriculumTargetSet) model);
        	}
        
        	return curriculumtargetsetCollection;
        }

        public static CurriculumTargetSet retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CurriculumTargetSet.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CurriculumTargetSet) gateway.retrieve(ResourceType.CURRICULUM_TARGET_SET, id);
        }

        public Curriculum getCurriculum ()
        {
            return (Curriculum) this.getProperty("curriculum");
        }

        public void setCurriculum (Curriculum curriculum)
        {
            this.setProperty("curriculum", curriculum);
        }

        public string getType ()
        {
            return this.getProperty("type").ToString();
        }

        public void setType (string type)
        {
            this.setProperty("type", type);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
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

