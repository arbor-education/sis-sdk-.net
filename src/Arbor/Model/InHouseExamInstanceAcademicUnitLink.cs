using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InHouseExamInstanceAcademicUnitLink : ModelBase
    {
        protected new string resourceType = ResourceType.IN_HOUSE_EXAM_INSTANCE_ACADEMIC_UNIT_LINK;
        public const string IN_HOUSE_EXAM_INSTANCE = "inHouseExamInstance";
        public const string ACADEMIC_UNIT = "academicUnit";

        public InHouseExamInstanceAcademicUnitLink ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InHouseExamInstanceAcademicUnitLink (string resourceType = "InHouseExamInstanceAcademicUnitLink", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InHouseExamInstanceAcademicUnitLink> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InHouseExamInstanceAcademicUnitLink");
        	RestGateway gateway = (RestGateway) InHouseExamInstanceAcademicUnitLink.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InHouseExamInstanceAcademicUnitLink> inhouseexaminstanceacademicunitlinkCollection = new ModelCollection<InHouseExamInstanceAcademicUnitLink> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    inhouseexaminstanceacademicunitlinkCollection.add((InHouseExamInstanceAcademicUnitLink) model);
        	}
        
        	return inhouseexaminstanceacademicunitlinkCollection;
        }

        public static InHouseExamInstanceAcademicUnitLink retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InHouseExamInstanceAcademicUnitLink.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InHouseExamInstanceAcademicUnitLink) gateway.retrieve(ResourceType.IN_HOUSE_EXAM_INSTANCE_ACADEMIC_UNIT_LINK, id);
        }

        public InHouseExamInstance getInHouseExamInstance ()
        {
            return (InHouseExamInstance) this.getProperty("inHouseExamInstance");
        }

        public void setInHouseExamInstance (InHouseExamInstance inHouseExamInstance)
        {
            this.setProperty("inHouseExamInstance", inHouseExamInstance);
        }

        public AcademicUnit getAcademicUnit ()
        {
            return (AcademicUnit) this.getProperty("academicUnit");
        }

        public void setAcademicUnit (AcademicUnit academicUnit)
        {
            this.setProperty("academicUnit", academicUnit);
        }


    }
}

