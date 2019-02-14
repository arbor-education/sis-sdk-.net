using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProgrammeInstance : ModelBase
    {
        protected string resourceType = ResourceType.PROGRAMME_INSTANCE;
        public const string PROGRAMME = "programme";
        public const string NAME = "name";
        public const string PLANNED_START_DATE = "plannedStartDate";
        public const string PLANNED_END_DATE = "plannedEndDate";

        public ProgrammeInstance ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ProgrammeInstance (string resourceType = "ProgrammeInstance", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ProgrammeInstance> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ProgrammeInstance");
        	RestGateway gateway = (RestGateway) ProgrammeInstance.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ProgrammeInstance> programmeinstanceCollection = new ModelCollection<ProgrammeInstance> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    programmeinstanceCollection.add((ProgrammeInstance) model);
        	}
        
        	return programmeinstanceCollection;
        }

        public static ProgrammeInstance retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ProgrammeInstance.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ProgrammeInstance) gateway.retrieve(ResourceType.PROGRAMME_INSTANCE, id);
        }

        public Programme getProgramme ()
        {
            return (Programme) this.getProperty("programme");
        }

        public void setProgramme (Programme programme)
        {
            this.setProperty("programme", programme);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public DateTime getPlannedStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("plannedStartDate"))
        }

        public void setPlannedStartDate (DateTime plannedStartDate)
        {
            this.setProperty("plannedStartDate", plannedStartDate);
        }

        public DateTime getPlannedEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("plannedEndDate"))
        }

        public void setPlannedEndDate (DateTime plannedEndDate)
        {
            this.setProperty("plannedEndDate", plannedEndDate);
        }


    }
}

