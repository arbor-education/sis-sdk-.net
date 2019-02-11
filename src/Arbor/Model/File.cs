using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class File : ModelBase
    {
        protected string resourceType = ResourceType.FILE;
        public const string CONTENT = "content";
        public const string URL = "url";
        public const string FILE_SIZE = "fileSize";
        public const string MIME_TYPE = "mimeType";
        public const string FILE_IDENTIFIER = "fileIdentifier";
        public const string FILE_METADATA = "fileMetadata";
        public const string FILE_NAME = "fileName";
        public const string COMPRESSED = "compressed";

        public File ()
        {
            base.resourceType = this.resourceType;
        }
        
        public File (string resourceType = "File", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<File> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("File");
        	RestGateway gateway = (RestGateway) File.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<File> fileCollection = new ModelCollection<File> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    fileCollection.add((File) model);
        	}
        
        	return fileCollection;
        }

        public static File retrieve (string id)
        {
            RestGateway gateway = (RestGateway) File.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (File) gateway.retrieve(ResourceType.FILE, id);
        }

        public Content getContent ()
        {
            return (Content) this.getProperty("content");
        }

        public void setContent (Content content)
        {
            this.setProperty("content", content);
        }

        public string getUrl ()
        {
            return this.getProperty("url").ToString();
        }

        public void setUrl (string url)
        {
            this.setProperty("url", url);
        }

        public int getFileSize ()
        {
            return Convert.ToInt32(this.getProperty("fileSize"));
        }

        public void setFileSize (int fileSize)
        {
            this.setProperty("fileSize", fileSize);
        }

        public string getMimeType ()
        {
            return this.getProperty("mimeType").ToString();
        }

        public void setMimeType (string mimeType)
        {
            this.setProperty("mimeType", mimeType);
        }

        public string getFileIdentifier ()
        {
            return this.getProperty("fileIdentifier").ToString();
        }

        public void setFileIdentifier (string fileIdentifier)
        {
            this.setProperty("fileIdentifier", fileIdentifier);
        }

        public string getFileMetadata ()
        {
            return this.getProperty("fileMetadata").ToString();
        }

        public void setFileMetadata (string fileMetadata)
        {
            this.setProperty("fileMetadata", fileMetadata);
        }

        public string getFileName ()
        {
            return this.getProperty("fileName").ToString();
        }

        public void setFileName (string fileName)
        {
            this.setProperty("fileName", fileName);
        }

        public bool getCompressed ()
        {
            return Convert.ToBoolean( this.getProperty("compressed"));
        }

        public void setCompressed (bool compressed)
        {
            this.setProperty("compressed", compressed);
        }


    }
}

