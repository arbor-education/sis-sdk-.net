using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class TeachingGroupTutor : ModelBase
    {
        protected string resourceType = ResourceType.TEACHING_GROUP_TUTOR;
        public const string TEACHING_GROUP = "teachingGroup";
        public const string STAFF = "staff";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public TeachingGroupTutor ()
        {
            base.resourceType = this.resourceType;
        }
        
        public TeachingGroupTutor (string resourceType = "TeachingGroupTutor", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<TeachingGroupTutor> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("TeachingGroupTutor");
        	RestGateway gateway = (RestGateway) TeachingGroupTutor.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<TeachingGroupTutor> teachinggrouptutorCollection = new ModelCollection<TeachingGroupTutor> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    teachinggrouptutorCollection.add((TeachingGroupTutor) model);
        	}
        
        	return teachinggrouptutorCollection;
        }

        public static TeachingGroupTutor retrieve (string id)
        {
            RestGateway gateway = (RestGateway) TeachingGroupTutor.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (TeachingGroupTutor) gateway.retrieve(ResourceType.TEACHING_GROUP_TUTOR, id);
        }

        public TeachingGroup getTeachingGroup ()
        {
            return (TeachingGroup) this.getProperty("teachingGroup");
        }

        public void setTeachingGroup (TeachingGroup teachingGroup)
        {
            this.setProperty("teachingGroup", teachingGroup);
        }

        public Staff getStaff ()
        {
            return (Staff) this.getProperty("staff");
        }

        public void setStaff (Staff staff)
        {
            this.setProperty("staff", staff);
        }

        public DateTime getStartDate ()
        {
            return Convert.ToDateTime(this.getProperty("startDate"))
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return Convert.ToDateTime(this.getProperty("endDate"))
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

