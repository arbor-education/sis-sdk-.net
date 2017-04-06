using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class ReportCardTemplateSection : ModelBase
    {
        protected string resourceType = ResourceType.REPORT_CARD_TEMPLATE_SECTION;
        public const string REPORT_CARD_TEMPLATE = "reportCardTemplate";
        public const string PARENT_SECTION = "parentSection";
        public const string SECTION_NAME = "sectionName";
        public const string CODE = "code";
        public const string DEFAULT_SECTION_TITLE = "defaultSectionTitle";
        public const string INCLUDE_ONLY_IF_ENROLLED_ON_ACADEMIC_UNIT = "includeOnlyIfEnrolledOnAcademicUnit";
        public const string REPEAT_PER_ENROLLED_ACADEMIC_UNIT = "repeatPerEnrolledAcademicUnit";
        public const string INCLUDE_ONLY_IF_SEN_STATUS_EXISTS = "includeOnlyIfSenStatusExists";
        public const string ASPECT_SET = "aspectSet";
        public const string SECTION_ORDER = "sectionOrder";

        public ReportCardTemplateSection ()
        {
            base.resourceType = this.resourceType;
        }
        
        public ReportCardTemplateSection (string resourceType = "ReportCardTemplateSection", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<ReportCardTemplateSection> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("ReportCardTemplateSection");
        	RestGateway gateway = (RestGateway) ReportCardTemplateSection.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<ReportCardTemplateSection> reportcardtemplatesectionCollection = new ModelCollection<ReportCardTemplateSection> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    reportcardtemplatesectionCollection.add((ReportCardTemplateSection) model);
        	}
        
        	return reportcardtemplatesectionCollection;
        }

        public static ReportCardTemplateSection retrieve (string id)
        {
            RestGateway gateway = (RestGateway) ReportCardTemplateSection.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (ReportCardTemplateSection) gateway.retrieve(ResourceType.REPORT_CARD_TEMPLATE_SECTION, id);
        }

        public ReportCardTemplate getReportCardTemplate ()
        {
            return (ReportCardTemplate) this.getProperty("reportCardTemplate");
        }

        public void setReportCardTemplate (ReportCardTemplate reportCardTemplate)
        {
            this.setProperty("reportCardTemplate", reportCardTemplate);
        }

        public ReportCardTemplateSection getParentSection ()
        {
            return (ReportCardTemplateSection) this.getProperty("parentSection");
        }

        public void setParentSection (ReportCardTemplateSection parentSection)
        {
            this.setProperty("parentSection", parentSection);
        }

        public string getSectionName ()
        {
            return this.getProperty("sectionName").ToString();
        }

        public void setSectionName (string sectionName)
        {
            this.setProperty("sectionName", sectionName);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public string getDefaultSectionTitle ()
        {
            return this.getProperty("defaultSectionTitle").ToString();
        }

        public void setDefaultSectionTitle (string defaultSectionTitle)
        {
            this.setProperty("defaultSectionTitle", defaultSectionTitle);
        }

        public AcademicUnit getIncludeOnlyIfEnrolledOnAcademicUnit ()
        {
            return (AcademicUnit) this.getProperty("includeOnlyIfEnrolledOnAcademicUnit");
        }

        public void setIncludeOnlyIfEnrolledOnAcademicUnit (AcademicUnit includeOnlyIfEnrolledOnAcademicUnit)
        {
            this.setProperty("includeOnlyIfEnrolledOnAcademicUnit", includeOnlyIfEnrolledOnAcademicUnit);
        }

        public bool getRepeatPerEnrolledAcademicUnit ()
        {
            return (bool) this.getProperty("repeatPerEnrolledAcademicUnit");
        }

        public void setRepeatPerEnrolledAcademicUnit (bool repeatPerEnrolledAcademicUnit)
        {
            this.setProperty("repeatPerEnrolledAcademicUnit", repeatPerEnrolledAcademicUnit);
        }

        public bool getIncludeOnlyIfSenStatusExists ()
        {
            return (bool) this.getProperty("includeOnlyIfSenStatusExists");
        }

        public void setIncludeOnlyIfSenStatusExists (bool includeOnlyIfSenStatusExists)
        {
            this.setProperty("includeOnlyIfSenStatusExists", includeOnlyIfSenStatusExists);
        }

        public AspectSet getAspectSet ()
        {
            return (AspectSet) this.getProperty("aspectSet");
        }

        public void setAspectSet (AspectSet aspectSet)
        {
            this.setProperty("aspectSet", aspectSet);
        }

        public int getSectionOrder ()
        {
            return Convert.ToInt32(this.getProperty("sectionOrder"));
        }

        public void setSectionOrder (int sectionOrder)
        {
            this.setProperty("sectionOrder", sectionOrder);
        }


    }
}

