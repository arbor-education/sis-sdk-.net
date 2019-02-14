using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class CoverArrangement : ModelBase
    {
        protected string resourceType = ResourceType.COVER_ARRANGEMENT;
        public const string COVER_REQUIREMENT = "coverRequirement";
        public const string COVERING_STAFF = "coveringStaff";
        public const string COVER_START_DATETIME = "coverStartDatetime";
        public const string COVER_END_DATETIME = "coverEndDatetime";
        public const string AGREED_DATETIME = "agreedDatetime";
        public const string NOT_AGREED_DATETIME = "notAgreedDatetime";

        public CoverArrangement ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CoverArrangement (string resourceType = "CoverArrangement", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CoverArrangement> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("CoverArrangement");
        	RestGateway gateway = (RestGateway) CoverArrangement.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CoverArrangement> coverarrangementCollection = new ModelCollection<CoverArrangement> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    coverarrangementCollection.add((CoverArrangement) model);
        	}
        
        	return coverarrangementCollection;
        }

        public static CoverArrangement retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CoverArrangement.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CoverArrangement) gateway.retrieve(ResourceType.COVER_ARRANGEMENT, id);
        }

        public CoverRequirement getCoverRequirement ()
        {
            return (CoverRequirement) this.getProperty("coverRequirement");
        }

        public void setCoverRequirement (CoverRequirement coverRequirement)
        {
            this.setProperty("coverRequirement", coverRequirement);
        }

        public Staff getCoveringStaff ()
        {
            return (Staff) this.getProperty("coveringStaff");
        }

        public void setCoveringStaff (Staff coveringStaff)
        {
            this.setProperty("coveringStaff", coveringStaff);
        }

        public DateTime getCoverStartDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("coverStartDatetime"))
        }

        public void setCoverStartDatetime (DateTime coverStartDatetime)
        {
            this.setProperty("coverStartDatetime", coverStartDatetime);
        }

        public DateTime getCoverEndDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("coverEndDatetime"))
        }

        public void setCoverEndDatetime (DateTime coverEndDatetime)
        {
            this.setProperty("coverEndDatetime", coverEndDatetime);
        }

        public DateTime getAgreedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("agreedDatetime"))
        }

        public void setAgreedDatetime (DateTime agreedDatetime)
        {
            this.setProperty("agreedDatetime", agreedDatetime);
        }

        public DateTime getNotAgreedDatetime ()
        {
            return Convert.ToDateTime(this.getProperty("notAgreedDatetime"))
        }

        public void setNotAgreedDatetime (DateTime notAgreedDatetime)
        {
            this.setProperty("notAgreedDatetime", notAgreedDatetime);
        }


    }
}

