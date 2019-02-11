using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ItemUnit : ModelBase
    {
        protected string resourceType = ResourceType.ITEM_UNIT;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string ITEM_UNIT_NAME = "itemUnitName";

        public ItemUnit ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ItemUnit (string resourceType = "ItemUnit", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ItemUnit> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ItemUnit");
        	RestGateway gateway = (RestGateway) ItemUnit.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ItemUnit> itemunitCollection = new ModelCollection<ItemUnit> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    itemunitCollection.add((ItemUnit) model);
        	}
        
        	return itemunitCollection;
        }

        public static ItemUnit retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ItemUnit.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ItemUnit) gateway.retrieve(ResourceType.ITEM_UNIT, id);
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
            return Convert.ToBoolean( this.getProperty("active"));
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

        public string getItemUnitName ()
        {
            return this.getProperty("itemUnitName").ToString();
        }

        public void setItemUnitName (string itemUnitName)
        {
            this.setProperty("itemUnitName", itemUnitName);
        }


    }
}

