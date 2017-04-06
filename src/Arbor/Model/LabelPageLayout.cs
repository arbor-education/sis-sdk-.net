using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class LabelPageLayout : ModelBase
    {
        protected string resourceType = ResourceType.LABEL_PAGE_LAYOUT;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string LAYOUT_NAME = "layoutName";
        public const string PAGE_HEIGHT = "pageHeight";
        public const string PAGE_WIDTH = "pageWidth";
        public const string ROWS = "rows";
        public const string COLUMNS = "columns";
        public const string PAGE_MARGIN_TOP = "pageMarginTop";
        public const string PAGE_MARGIN_RIGHT = "pageMarginRight";
        public const string PAGE_MARGIN_BOTTOM = "pageMarginBottom";
        public const string PAGE_MARGIN_LEFT = "pageMarginLeft";
        public const string LABEL_PADDING_TOP = "labelPaddingTop";
        public const string LABEL_PADDING_LEFT = "labelPaddingLeft";
        public const string LABEL_PADDING_BOTTOM = "labelPaddingBottom";
        public const string LABEL_PADDING_RIGHT = "labelPaddingRight";
        public const string HORIZONTAL_SPACING = "horizontalSpacing";
        public const string VERTICAL_SPACING = "verticalSpacing";

        public LabelPageLayout ()
        {
            base.resourceType = this.resourceType;
        }
        
        public LabelPageLayout (string resourceType = "LabelPageLayout", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<LabelPageLayout> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("LabelPageLayout");
        	RestGateway gateway = (RestGateway) LabelPageLayout.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<LabelPageLayout> labelpagelayoutCollection = new ModelCollection<LabelPageLayout> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    labelpagelayoutCollection.add((LabelPageLayout) model);
        	}
        
        	return labelpagelayoutCollection;
        }

        public static LabelPageLayout retrieve (string id)
        {
            RestGateway gateway = (RestGateway) LabelPageLayout.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (LabelPageLayout) gateway.retrieve(ResourceType.LABEL_PAGE_LAYOUT, id);
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
            return (bool) this.getProperty("active");
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

        public string getLayoutName ()
        {
            return this.getProperty("layoutName").ToString();
        }

        public void setLayoutName (string layoutName)
        {
            this.setProperty("layoutName", layoutName);
        }

        public float getPageHeight ()
        {
            return (float) this.getProperty("pageHeight");
        }

        public void setPageHeight (float pageHeight)
        {
            this.setProperty("pageHeight", pageHeight);
        }

        public float getPageWidth ()
        {
            return (float) this.getProperty("pageWidth");
        }

        public void setPageWidth (float pageWidth)
        {
            this.setProperty("pageWidth", pageWidth);
        }

        public int getRows ()
        {
            return Convert.ToInt32(this.getProperty("rows"));
        }

        public void setRows (int rows)
        {
            this.setProperty("rows", rows);
        }

        public int getColumns ()
        {
            return Convert.ToInt32(this.getProperty("columns"));
        }

        public void setColumns (int columns)
        {
            this.setProperty("columns", columns);
        }

        public float getPageMarginTop ()
        {
            return (float) this.getProperty("pageMarginTop");
        }

        public void setPageMarginTop (float pageMarginTop)
        {
            this.setProperty("pageMarginTop", pageMarginTop);
        }

        public float getPageMarginRight ()
        {
            return (float) this.getProperty("pageMarginRight");
        }

        public void setPageMarginRight (float pageMarginRight)
        {
            this.setProperty("pageMarginRight", pageMarginRight);
        }

        public float getPageMarginBottom ()
        {
            return (float) this.getProperty("pageMarginBottom");
        }

        public void setPageMarginBottom (float pageMarginBottom)
        {
            this.setProperty("pageMarginBottom", pageMarginBottom);
        }

        public float getPageMarginLeft ()
        {
            return (float) this.getProperty("pageMarginLeft");
        }

        public void setPageMarginLeft (float pageMarginLeft)
        {
            this.setProperty("pageMarginLeft", pageMarginLeft);
        }

        public float getLabelPaddingTop ()
        {
            return (float) this.getProperty("labelPaddingTop");
        }

        public void setLabelPaddingTop (float labelPaddingTop)
        {
            this.setProperty("labelPaddingTop", labelPaddingTop);
        }

        public float getLabelPaddingLeft ()
        {
            return (float) this.getProperty("labelPaddingLeft");
        }

        public void setLabelPaddingLeft (float labelPaddingLeft)
        {
            this.setProperty("labelPaddingLeft", labelPaddingLeft);
        }

        public float getLabelPaddingBottom ()
        {
            return (float) this.getProperty("labelPaddingBottom");
        }

        public void setLabelPaddingBottom (float labelPaddingBottom)
        {
            this.setProperty("labelPaddingBottom", labelPaddingBottom);
        }

        public float getLabelPaddingRight ()
        {
            return (float) this.getProperty("labelPaddingRight");
        }

        public void setLabelPaddingRight (float labelPaddingRight)
        {
            this.setProperty("labelPaddingRight", labelPaddingRight);
        }

        public float getHorizontalSpacing ()
        {
            return (float) this.getProperty("horizontalSpacing");
        }

        public void setHorizontalSpacing (float horizontalSpacing)
        {
            this.setProperty("horizontalSpacing", horizontalSpacing);
        }

        public float getVerticalSpacing ()
        {
            return (float) this.getProperty("verticalSpacing");
        }

        public void setVerticalSpacing (float verticalSpacing)
        {
            this.setProperty("verticalSpacing", verticalSpacing);
        }


    }
}

