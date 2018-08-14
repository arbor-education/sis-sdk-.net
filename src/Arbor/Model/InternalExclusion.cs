using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class InternalExclusion : ModelBase
    {
        protected string resourceType = ResourceType.INTERNAL_EXCLUSION;
        public const string STUDENT = "student";
        public const string ISSUED_BY_STAFF = "issuedByStaff";
        public const string INTERNAL_EXCLUSION_SESSION = "internalExclusionSession";
        public const string INTERNAL_EXCLUSION_TYPE = "internalExclusionType";
        public const string EXCLUSION_REASON = "exclusionReason";
        public const string ISSUED_DATETIME = "issuedDatetime";
        public const string NARRATIVE = "narrative";

        public InternalExclusion ()
        {
            base.resourceType = this.resourceType;
        }
        
        public InternalExclusion (string resourceType = "InternalExclusion", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<InternalExclusion> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("InternalExclusion");
        	RestGateway gateway = (RestGateway) InternalExclusion.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<InternalExclusion> internalexclusionCollection = new ModelCollection<InternalExclusion> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    internalexclusionCollection.add((InternalExclusion) model);
        	}
        
        	return internalexclusionCollection;
        }

        public static InternalExclusion retrieve (string id)
        {
            RestGateway gateway = (RestGateway) InternalExclusion.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (InternalExclusion) gateway.retrieve(ResourceType.INTERNAL_EXCLUSION, id);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }

        public Staff getIssuedByStaff ()
        {
            return (Staff) this.getProperty("issuedByStaff");
        }

        public void setIssuedByStaff (Staff issuedByStaff)
        {
            this.setProperty("issuedByStaff", issuedByStaff);
        }

        public InternalExclusionSession getInternalExclusionSession ()
        {
            return (InternalExclusionSession) this.getProperty("internalExclusionSession");
        }

        public void setInternalExclusionSession (InternalExclusionSession internalExclusionSession)
        {
            this.setProperty("internalExclusionSession", internalExclusionSession);
        }

        public InternalExclusionType getInternalExclusionType ()
        {
            return (InternalExclusionType) this.getProperty("internalExclusionType");
        }

        public void setInternalExclusionType (InternalExclusionType internalExclusionType)
        {
            this.setProperty("internalExclusionType", internalExclusionType);
        }

        public ExclusionReason getExclusionReason ()
        {
            return (ExclusionReason) this.getProperty("exclusionReason");
        }

        public void setExclusionReason (ExclusionReason exclusionReason)
        {
            this.setProperty("exclusionReason", exclusionReason);
        }

        public DateTime getIssuedDatetime (){
            return Convert.ToDateTime(this.getProperty("issuedDatetime"));
        }

        public void setIssuedDatetime (DateTime issuedDatetime)
        {
            this.setProperty("issuedDatetime", issuedDatetime);
        }

        public string getNarrative ()
        {
            return this.getProperty("narrative").ToString();
        }

        public void setNarrative (string narrative)
        {
            this.setProperty("narrative", narrative);
        }


    }
}

