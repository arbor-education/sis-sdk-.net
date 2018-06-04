using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ProfilePictureImportJobFile : ModelBase
    {
        protected string resourceType = ResourceType.PROFILE_PICTURE_IMPORT_JOB_FILE;
        public const string PROFILE_PICTURE_IMPORT_JOB = "profilePictureImportJob";
        public const string VALID_IMAGE = "validImage";
        public const string VALID_IDENTIFIER = "validIdentifier";
        public const string PERSON = "person";
        public const string CONFIRMED_DATETIME = "confirmedDatetime";

        public ProfilePictureImportJobFile ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ProfilePictureImportJobFile (string resourceType = "ProfilePictureImportJobFile", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ProfilePictureImportJobFile> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ProfilePictureImportJobFile");
        	RestGateway gateway = (RestGateway) ProfilePictureImportJobFile.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ProfilePictureImportJobFile> profilepictureimportjobfileCollection = new ModelCollection<ProfilePictureImportJobFile> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    profilepictureimportjobfileCollection.add((ProfilePictureImportJobFile) model);
        	}
        
        	return profilepictureimportjobfileCollection;
        }

        public static ProfilePictureImportJobFile retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ProfilePictureImportJobFile.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ProfilePictureImportJobFile) gateway.retrieve(ResourceType.PROFILE_PICTURE_IMPORT_JOB_FILE, id);
        }

        public ProfilePictureImportJob getProfilePictureImportJob ()
        {
            return (ProfilePictureImportJob) this.getProperty("profilePictureImportJob");
        }

        public void setProfilePictureImportJob (ProfilePictureImportJob profilePictureImportJob)
        {
            this.setProperty("profilePictureImportJob", profilePictureImportJob);
        }

        public bool getValidImage ()
        {
            return (bool) this.getProperty("validImage");
        }

        public void setValidImage (bool validImage)
        {
            this.setProperty("validImage", validImage);
        }

        public bool getValidIdentifier ()
        {
            return (bool) this.getProperty("validIdentifier");
        }

        public void setValidIdentifier (bool validIdentifier)
        {
            this.setProperty("validIdentifier", validIdentifier);
        }

        public ModelBase getPerson ()
        {
            return (ModelBase) this.getProperty("person");
        }

        public void setPerson (ModelBase person)
        {
            this.setProperty("person", person);
        }

        public DateTime getConfirmedDatetime ()
        {
            return (DateTime) this.getProperty("confirmedDatetime");
        }

        public void setConfirmedDatetime (DateTime confirmedDatetime)
        {
            this.setProperty("confirmedDatetime", confirmedDatetime);
        }


    }
}

