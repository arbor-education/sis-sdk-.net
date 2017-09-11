using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Term : ModelBase
    {
        protected string resourceType = ResourceType.TERM;
        public const string ACADEMIC_YEAR = "academicYear";
        public const string TERM_NAME = "termName";
        public const string SHORT_TERM_NAME = "shortTermName";
        public const string CODE = "code";
        public const string START_DATE = "startDate";
        public const string END_DATE = "endDate";

        public Term ()
        {
            base.resourceType = this.resourceType;
        }
        
        public Term (string resourceType = "Term", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<Term> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("Term");
        	RestGateway gateway = (RestGateway) Term.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<Term> termCollection = new ModelCollection<Term> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    termCollection.add((Term) model);
        	}
        
        	return termCollection;
        }

        public static Term retrieve (string id)
        {
            RestGateway gateway = (RestGateway) Term.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (Term) gateway.retrieve(ResourceType.TERM, id);
        }

        public AcademicYear getAcademicYear ()
        {
            return (AcademicYear) this.getProperty("academicYear");
        }

        public void setAcademicYear (AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }

        public string getTermName ()
        {
            return this.getProperty("termName").ToString();
        }

        public void setTermName (string termName)
        {
            this.setProperty("termName", termName);
        }

        public string getShortTermName ()
        {
            return this.getProperty("shortTermName").ToString();
        }

        public void setShortTermName (string shortTermName)
        {
            this.setProperty("shortTermName", shortTermName);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public DateTime getStartDate ()
        {
            return (DateTime) this.getProperty("startDate");
        }

        public void setStartDate (DateTime startDate)
        {
            this.setProperty("startDate", startDate);
        }

        public DateTime getEndDate ()
        {
            return (DateTime) this.getProperty("endDate");
        }

        public void setEndDate (DateTime endDate)
        {
            this.setProperty("endDate", endDate);
        }


    }
}

