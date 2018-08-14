using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProfilePictureImportJob : ModelBase
    {
        protected string resourceType = ResourceType.PROFILE_PICTURE_IMPORT_JOB;
        public const string NAME = "name";
        public const string IMPORT_TYPE = "importType";
        public const string IDENTIFIER_CLASS = "identifierClass";
        public const string COMPLETED_DATETIME = "completedDatetime";

        public ProfilePictureImportJob ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ProfilePictureImportJob (string resourceType = "ProfilePictureImportJob", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ProfilePictureImportJob> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ProfilePictureImportJob");
        	RestGateway gateway = (RestGateway) ProfilePictureImportJob.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ProfilePictureImportJob> profilepictureimportjobCollection = new ModelCollection<ProfilePictureImportJob> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    profilepictureimportjobCollection.add((ProfilePictureImportJob) model);
        	}
        
        	return profilepictureimportjobCollection;
        }

        public static ProfilePictureImportJob retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ProfilePictureImportJob.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ProfilePictureImportJob) gateway.retrieve(ResourceType.PROFILE_PICTURE_IMPORT_JOB, id);
        }

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public string getImportType ()
        {
            return this.getProperty("importType").ToString();
        }

        public void setImportType (string importType)
        {
            this.setProperty("importType", importType);
        }

        public string getIdentifierClass ()
        {
            return this.getProperty("identifierClass").ToString();
        }

        public void setIdentifierClass (string identifierClass)
        {
            this.setProperty("identifierClass", identifierClass);
        }

        public DateTime getCompletedDatetime ()
        {
            Convert.ToDateTime(this.getProperty("completedDatetime"))
        }

        public void setCompletedDatetime (DateTime completedDatetime)
        {
            this.setProperty("completedDatetime", completedDatetime);
        }


    }
}

