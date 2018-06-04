using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProfilePictureImportJobFileMatch : ModelBase
    {
        protected string resourceType = ResourceType.PROFILE_PICTURE_IMPORT_JOB_FILE_MATCH;
        public const string PROFILE_PICTURE_IMPORT_JOB_FILE = "profilePictureImportJobFile";
        public const string PERSON = "person";

        public ProfilePictureImportJobFileMatch ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ProfilePictureImportJobFileMatch (string resourceType = "ProfilePictureImportJobFileMatch", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ProfilePictureImportJobFileMatch> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ProfilePictureImportJobFileMatch");
        	RestGateway gateway = (RestGateway) ProfilePictureImportJobFileMatch.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ProfilePictureImportJobFileMatch> profilepictureimportjobfilematchCollection = new ModelCollection<ProfilePictureImportJobFileMatch> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    profilepictureimportjobfilematchCollection.add((ProfilePictureImportJobFileMatch) model);
        	}
        
        	return profilepictureimportjobfilematchCollection;
        }

        public static ProfilePictureImportJobFileMatch retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ProfilePictureImportJobFileMatch.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ProfilePictureImportJobFileMatch) gateway.retrieve(ResourceType.PROFILE_PICTURE_IMPORT_JOB_FILE_MATCH, id);
        }

        public ProfilePictureImportJobFile getProfilePictureImportJobFile ()
        {
            return (ProfilePictureImportJobFile) this.getProperty("profilePictureImportJobFile");
        }

        public void setProfilePictureImportJobFile (ProfilePictureImportJobFile profilePictureImportJobFile)
        {
            this.setProperty("profilePictureImportJobFile", profilePictureImportJobFile);
        }

        public ModelBase getPerson ()
        {
            return (ModelBase) this.getProperty("person");
        }

        public void setPerson (ModelBase person)
        {
            this.setProperty("person", person);
        }


    }
}

