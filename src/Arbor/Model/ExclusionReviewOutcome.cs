using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ExclusionReviewOutcome : ModelBase
    {
        protected string resourceType = ResourceType.EXCLUSION_REVIEW_OUTCOME;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string LABEL = "label";
        public const string EXPORT_CODE = "exportCode";
        public const string IS_EXCLUSION_UPHELD = "isExclusionUpheld";
        public const string IS_STUDENT_REINSTATED = "isStudentReinstated";

        public ExclusionReviewOutcome ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ExclusionReviewOutcome (string resourceType = "ExclusionReviewOutcome", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ExclusionReviewOutcome> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ExclusionReviewOutcome");
        	RestGateway gateway = (RestGateway) ExclusionReviewOutcome.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ExclusionReviewOutcome> exclusionreviewoutcomeCollection = new ModelCollection<ExclusionReviewOutcome> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    exclusionreviewoutcomeCollection.add((ExclusionReviewOutcome) model);
        	}
        
        	return exclusionreviewoutcomeCollection;
        }

        public static ExclusionReviewOutcome retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ExclusionReviewOutcome.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ExclusionReviewOutcome) gateway.retrieve(ResourceType.EXCLUSION_REVIEW_OUTCOME, id);
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

        public string getLabel ()
        {
            return this.getProperty("label").ToString();
        }

        public void setLabel (string label)
        {
            this.setProperty("label", label);
        }

        public string getExportCode ()
        {
            return this.getProperty("exportCode").ToString();
        }

        public void setExportCode (string exportCode)
        {
            this.setProperty("exportCode", exportCode);
        }

        public bool getIsExclusionUpheld ()
        {
            return Convert.ToBoolean(this.getProperty("isExclusionUpheld"));
        }

        public void setIsExclusionUpheld (bool isExclusionUpheld)
        {
            this.setProperty("isExclusionUpheld", isExclusionUpheld);
        }

        public bool getIsStudentReinstated ()
        {
            return Convert.ToBoolean(this.getProperty("isStudentReinstated"));
        }

        public void setIsStudentReinstated (bool isStudentReinstated)
        {
            this.setProperty("isStudentReinstated", isStudentReinstated);
        }


    }
}

