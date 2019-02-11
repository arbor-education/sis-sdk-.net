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
        public const string NAME = "name";
        public const string FIRST_PAGE_HEADER_HTML = "firstPageHeaderHtml";
        public const string FIRST_PAGE_HEADER_HEIGHT = "firstPageHeaderHeight";
        public const string FIRST_PAGE_FOOTER_HTML = "firstPageFooterHtml";
        public const string FIRST_PAGE_FOOTER_HEIGHT = "firstPageFooterHeight";
        public const string OTHER_PAGES_HEADER_HTML = "otherPagesHeaderHtml";
        public const string OTHER_PAGES_HEADER_HEIGHT = "otherPagesHeaderHeight";
        public const string OTHER_PAGES_FOOTER_HTML = "otherPagesFooterHtml";
        public const string OTHER_PAGES_FOOTER_HEIGHT = "otherPagesFooterHeight";
        public const string LEFT_MARGIN = "leftMargin";
        public const string RIGHT_MARGIN = "rightMargin";
        public const string PAPER_SIZE = "paperSize";
        public const string ORIENTATION = "orientation";
        public const string DEFAULT_FONT_FAMILY = "defaultFontFamily";
        public const string DEFAULT_FONT_SIZE = "defaultFontSize";
        public const string SHOW_ADDRESS_ENVELOPE_SIZE = "showAddressEnvelopeSize";
        public const string ARCHIVED = "archived";

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

        public string getName ()
        {
            return this.getProperty("name").ToString();
        }

        public void setName (string name)
        {
            this.setProperty("name", name);
        }

        public string getFirstPageHeaderHtml ()
        {
            return this.getProperty("firstPageHeaderHtml").ToString();
        }

        public void setFirstPageHeaderHtml (string firstPageHeaderHtml)
        {
            this.setProperty("firstPageHeaderHtml", firstPageHeaderHtml);
        }

        public float getFirstPageHeaderHeight ()
        {
            return (float) this.getProperty("firstPageHeaderHeight");
        }

        public void setFirstPageHeaderHeight (float firstPageHeaderHeight)
        {
            this.setProperty("firstPageHeaderHeight", firstPageHeaderHeight);
        }

        public string getFirstPageFooterHtml ()
        {
            return this.getProperty("firstPageFooterHtml").ToString();
        }

        public void setFirstPageFooterHtml (string firstPageFooterHtml)
        {
            this.setProperty("firstPageFooterHtml", firstPageFooterHtml);
        }

        public float getFirstPageFooterHeight ()
        {
            return (float) this.getProperty("firstPageFooterHeight");
        }

        public void setFirstPageFooterHeight (float firstPageFooterHeight)
        {
            this.setProperty("firstPageFooterHeight", firstPageFooterHeight);
        }

        public string getOtherPagesHeaderHtml ()
        {
            return this.getProperty("otherPagesHeaderHtml").ToString();
        }

        public void setOtherPagesHeaderHtml (string otherPagesHeaderHtml)
        {
            this.setProperty("otherPagesHeaderHtml", otherPagesHeaderHtml);
        }

        public float getOtherPagesHeaderHeight ()
        {
            return (float) this.getProperty("otherPagesHeaderHeight");
        }

        public void setOtherPagesHeaderHeight (float otherPagesHeaderHeight)
        {
            this.setProperty("otherPagesHeaderHeight", otherPagesHeaderHeight);
        }

        public string getOtherPagesFooterHtml ()
        {
            return this.getProperty("otherPagesFooterHtml").ToString();
        }

        public void setOtherPagesFooterHtml (string otherPagesFooterHtml)
        {
            this.setProperty("otherPagesFooterHtml", otherPagesFooterHtml);
        }

        public float getOtherPagesFooterHeight ()
        {
            return (float) this.getProperty("otherPagesFooterHeight");
        }

        public void setOtherPagesFooterHeight (float otherPagesFooterHeight)
        {
            this.setProperty("otherPagesFooterHeight", otherPagesFooterHeight);
        }

        public float getLeftMargin ()
        {
            return (float) this.getProperty("leftMargin");
        }

        public void setLeftMargin (float leftMargin)
        {
            this.setProperty("leftMargin", leftMargin);
        }

        public float getRightMargin ()
        {
            return (float) this.getProperty("rightMargin");
        }

        public void setRightMargin (float rightMargin)
        {
            this.setProperty("rightMargin", rightMargin);
        }

        public string getPaperSize ()
        {
            return this.getProperty("paperSize").ToString();
        }

        public void setPaperSize (string paperSize)
        {
            this.setProperty("paperSize", paperSize);
        }

        public string getOrientation ()
        {
            return this.getProperty("orientation").ToString();
        }

        public void setOrientation (string orientation)
        {
            this.setProperty("orientation", orientation);
        }

        public string getDefaultFontFamily ()
        {
            return this.getProperty("defaultFontFamily").ToString();
        }

        public void setDefaultFontFamily (string defaultFontFamily)
        {
            this.setProperty("defaultFontFamily", defaultFontFamily);
        }

        public float getDefaultFontSize ()
        {
            return (float) this.getProperty("defaultFontSize");
        }

        public void setDefaultFontSize (float defaultFontSize)
        {
            this.setProperty("defaultFontSize", defaultFontSize);
        }

        public string getShowAddressEnvelopeSize ()
        {
            return this.getProperty("showAddressEnvelopeSize").ToString();
        }

        public void setShowAddressEnvelopeSize (string showAddressEnvelopeSize)
        {
            this.setProperty("showAddressEnvelopeSize", showAddressEnvelopeSize);
        }

        public bool getArchived ()
        {
            return Convert.ToBoolean( this.getProperty("archived"));
        }

        public void setArchived (bool archived)
        {
            this.setProperty("archived", archived);
        }


    }
}

