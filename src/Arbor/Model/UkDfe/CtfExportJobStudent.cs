using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class CtfExportJobStudent : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_CTF_EXPORT_JOB_STUDENT;
        public const string CTF_EXPORT_JOB = "ctfExportJob";
        public const string STUDENT = "student";

        public CtfExportJobStudent ()
        {
            base.resourceType = this.resourceType;
        }
        
        public CtfExportJobStudent (string resourceType = "CtfExportJobStudent", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<CtfExportJobStudent> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("UkDfe_CtfExportJobStudent");
        	RestGateway gateway = (RestGateway) CtfExportJobStudent.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<CtfExportJobStudent> ctfexportjobstudentCollection = new ModelCollection<CtfExportJobStudent> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    ctfexportjobstudentCollection.add((CtfExportJobStudent) model);
        	}
        
        	return ctfexportjobstudentCollection;
        }

        public static CtfExportJobStudent retrieve (string id)
        {
            RestGateway gateway = (RestGateway) CtfExportJobStudent.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (CtfExportJobStudent) gateway.retrieve(ResourceType.UK_DFE_CTF_EXPORT_JOB_STUDENT, id);
        }

        public ModelBase getCtfExportJob ()
        {
            return (ModelBase) this.getProperty("ctfExportJob");
        }

        public void setCtfExportJob (ModelBase ctfExportJob)
        {
            this.setProperty("ctfExportJob", ctfExportJob);
        }

        public Student getStudent ()
        {
            return (Student) this.getProperty("student");
        }

        public void setStudent (Student student)
        {
            this.setProperty("student", student);
        }


    }
}

