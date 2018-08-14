using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DataSharingRequest : ModelBase
    {
        protected string resourceType = ResourceType.DATA_SHARING_REQUEST;
        public const string GROUP_APPLICATION_ID = "groupApplicationId";
        public const string PERMISSION_LEVEL = "permissionLevel";
        public const string STATUS = "status";
        public const string REQUESTED_DATETIME = "requestedDatetime";
        public const string STATUS_UPDATED_BY_USER = "statusUpdatedByUser";
        public const string STATUS_UPDATED_DATETIME = "statusUpdatedDatetime";

        public DataSharingRequest ()
        {
            base.resourceType = this.resourceType;
        }
        
        public DataSharingRequest (string resourceType = "DataSharingRequest", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<DataSharingRequest> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("DataSharingRequest");
        	RestGateway gateway = (RestGateway) DataSharingRequest.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<DataSharingRequest> datasharingrequestCollection = new ModelCollection<DataSharingRequest> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    datasharingrequestCollection.add((DataSharingRequest) model);
        	}
        
        	return datasharingrequestCollection;
        }

        public static DataSharingRequest retrieve (string id)
        {
            RestGateway gateway = (RestGateway) DataSharingRequest.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (DataSharingRequest) gateway.retrieve(ResourceType.DATA_SHARING_REQUEST, id);
        }

        public string getGroupApplicationId ()
        {
            return this.getProperty("groupApplicationId").ToString();
        }

        public void setGroupApplicationId (string groupApplicationId)
        {
            this.setProperty("groupApplicationId", groupApplicationId);
        }

        public string getPermissionLevel ()
        {
            return this.getProperty("permissionLevel").ToString();
        }

        public void setPermissionLevel (string permissionLevel)
        {
            this.setProperty("permissionLevel", permissionLevel);
        }

        public string getStatus ()
        {
            return this.getProperty("status").ToString();
        }

        public void setStatus (string status)
        {
            this.setProperty("status", status);
        }

        public DateTime getRequestedDatetime (){
            return Convert.ToDateTime(this.getProperty("requestedDatetime"));
        }

        public void setRequestedDatetime (DateTime requestedDatetime)
        {
            this.setProperty("requestedDatetime", requestedDatetime);
        }

        public User getStatusUpdatedByUser ()
        {
            return (User) this.getProperty("statusUpdatedByUser");
        }

        public void setStatusUpdatedByUser (User statusUpdatedByUser)
        {
            this.setProperty("statusUpdatedByUser", statusUpdatedByUser);
        }

        public DateTime getStatusUpdatedDatetime (){
            return Convert.ToDateTime(this.getProperty("statusUpdatedDatetime"));
        }

        public void setStatusUpdatedDatetime (DateTime statusUpdatedDatetime)
        {
            this.setProperty("statusUpdatedDatetime", statusUpdatedDatetime);
        }


    }
}

