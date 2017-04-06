using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class LayoutObjectType : ModelBase
    {
        protected string resourceType = ResourceType.LAYOUT_OBJECT_TYPE;
        public const string LAYOUT_OBJECT_TYPE_NAME = "layoutObjectTypeName";
        public const string WIDTH = "width";
        public const string HEIGHT = "height";

        public LayoutObjectType ()
        {
            base.resourceType = this.resourceType;
        }
        
        public LayoutObjectType (string resourceType = "LayoutObjectType", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<LayoutObjectType> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("LayoutObjectType");
        	RestGateway gateway = (RestGateway) LayoutObjectType.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<LayoutObjectType> layoutobjecttypeCollection = new ModelCollection<LayoutObjectType> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    layoutobjecttypeCollection.add((LayoutObjectType) model);
        	}
        
        	return layoutobjecttypeCollection;
        }

        public static LayoutObjectType retrieve (string id)
        {
            RestGateway gateway = (RestGateway) LayoutObjectType.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (LayoutObjectType) gateway.retrieve(ResourceType.LAYOUT_OBJECT_TYPE, id);
        }

        public string getLayoutObjectTypeName ()
        {
            return this.getProperty("layoutObjectTypeName").ToString();
        }

        public void setLayoutObjectTypeName (string layoutObjectTypeName)
        {
            this.setProperty("layoutObjectTypeName", layoutObjectTypeName);
        }

        public int getWidth ()
        {
            return Convert.ToInt32(this.getProperty("width"));
        }

        public void setWidth (int width)
        {
            this.setProperty("width", width);
        }

        public int getHeight ()
        {
            return Convert.ToInt32(this.getProperty("height"));
        }

        public void setHeight (int height)
        {
            this.setProperty("height", height);
        }


    }
}

