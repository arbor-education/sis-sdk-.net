using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class DocumentLayout : ModelBase
    {
        protected string resourceType = ResourceType.DOCUMENT_LAYOUT;
        public const string LAYOUT_NAME = "layoutName";
        public const string PAGE_FORMAT = "pageFormat";
        public const string PAGE_NUMBER_STYLE = "pageNumberStyle";
        public const string HEADER_HTML = "headerHtml";
        public const string HEADER_PAGE1HTML = "headerPage1html";
        public const string FOOTER_HTML = "footerHtml";
        public const string FOOTER_PAGE1HTML = "footerPage1html";
        public const string MARGIN_TOP = "marginTop";
        public const string MARGIN_BOTTOM = "marginBottom";
        public const string MARGIN_HEADER = "marginHeader";
        public const string MARGIN_FOOTER = "marginFooter";
        public const string MARGIN_LEFT = "marginLeft";
        public const string MARGIN_RIGHT = "marginRight";
        public const string MARGIN_PAGE1TOP = "marginPage1top";
        public const string MARGIN_PAGE1BOTTOM = "marginPage1bottom";
        public const string MARGIN_PAGE1HEADER = "marginPage1header";
        public const string MARGIN_PAGE1FOOTER = "marginPage1footer";

        public DocumentLayout ()
        {
            base.resourceType = this.resourceType;
        }
        
        public DocumentLayout (string resourceType = "DocumentLayout", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<DocumentLayout> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("DocumentLayout");
        	RestGateway gateway = (RestGateway) DocumentLayout.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<DocumentLayout> documentlayoutCollection = new ModelCollection<DocumentLayout> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    documentlayoutCollection.add((DocumentLayout) model);
        	}
        
        	return documentlayoutCollection;
        }

        public static DocumentLayout retrieve (string id)
        {
            RestGateway gateway = (RestGateway) DocumentLayout.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (DocumentLayout) gateway.retrieve(ResourceType.DOCUMENT_LAYOUT, id);
        }

        public string getLayoutName ()
        {
            return this.getProperty("layoutName").ToString();
        }

        public void setLayoutName (string layoutName)
        {
            this.setProperty("layoutName", layoutName);
        }

        public string getPageFormat ()
        {
            return this.getProperty("pageFormat").ToString();
        }

        public void setPageFormat (string pageFormat)
        {
            this.setProperty("pageFormat", pageFormat);
        }

        public string getPageNumberStyle ()
        {
            return this.getProperty("pageNumberStyle").ToString();
        }

        public void setPageNumberStyle (string pageNumberStyle)
        {
            this.setProperty("pageNumberStyle", pageNumberStyle);
        }

        public string getHeaderHtml ()
        {
            return this.getProperty("headerHtml").ToString();
        }

        public void setHeaderHtml (string headerHtml)
        {
            this.setProperty("headerHtml", headerHtml);
        }

        public string getHeaderPage1html ()
        {
            return this.getProperty("headerPage1html").ToString();
        }

        public void setHeaderPage1html (string headerPage1html)
        {
            this.setProperty("headerPage1html", headerPage1html);
        }

        public string getFooterHtml ()
        {
            return this.getProperty("footerHtml").ToString();
        }

        public void setFooterHtml (string footerHtml)
        {
            this.setProperty("footerHtml", footerHtml);
        }

        public string getFooterPage1html ()
        {
            return this.getProperty("footerPage1html").ToString();
        }

        public void setFooterPage1html (string footerPage1html)
        {
            this.setProperty("footerPage1html", footerPage1html);
        }

        public int getMarginTop ()
        {
            return Convert.ToInt32(this.getProperty("marginTop"));
        }

        public void setMarginTop (int marginTop)
        {
            this.setProperty("marginTop", marginTop);
        }

        public int getMarginBottom ()
        {
            return Convert.ToInt32(this.getProperty("marginBottom"));
        }

        public void setMarginBottom (int marginBottom)
        {
            this.setProperty("marginBottom", marginBottom);
        }

        public int getMarginHeader ()
        {
            return Convert.ToInt32(this.getProperty("marginHeader"));
        }

        public void setMarginHeader (int marginHeader)
        {
            this.setProperty("marginHeader", marginHeader);
        }

        public int getMarginFooter ()
        {
            return Convert.ToInt32(this.getProperty("marginFooter"));
        }

        public void setMarginFooter (int marginFooter)
        {
            this.setProperty("marginFooter", marginFooter);
        }

        public int getMarginLeft ()
        {
            return Convert.ToInt32(this.getProperty("marginLeft"));
        }

        public void setMarginLeft (int marginLeft)
        {
            this.setProperty("marginLeft", marginLeft);
        }

        public int getMarginRight ()
        {
            return Convert.ToInt32(this.getProperty("marginRight"));
        }

        public void setMarginRight (int marginRight)
        {
            this.setProperty("marginRight", marginRight);
        }

        public int getMarginPage1top ()
        {
            return Convert.ToInt32(this.getProperty("marginPage1top"));
        }

        public void setMarginPage1top (int marginPage1top)
        {
            this.setProperty("marginPage1top", marginPage1top);
        }

        public int getMarginPage1bottom ()
        {
            return Convert.ToInt32(this.getProperty("marginPage1bottom"));
        }

        public void setMarginPage1bottom (int marginPage1bottom)
        {
            this.setProperty("marginPage1bottom", marginPage1bottom);
        }

        public int getMarginPage1header ()
        {
            return Convert.ToInt32(this.getProperty("marginPage1header"));
        }

        public void setMarginPage1header (int marginPage1header)
        {
            this.setProperty("marginPage1header", marginPage1header);
        }

        public int getMarginPage1footer ()
        {
            return Convert.ToInt32(this.getProperty("marginPage1footer"));
        }

        public void setMarginPage1footer (int marginPage1footer)
        {
            this.setProperty("marginPage1footer", marginPage1footer);
        }


    }
}

