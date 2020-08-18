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
        public const string CML_REMOVAL_GROUNDS = "cmlRemovalGrounds";

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

        public CtfExportJob getCtfExportJob ()
        {
            return (CtfExportJob) this.getProperty("ctfExportJob");
        }

        public void setCtfExportJob (CtfExportJob ctfExportJob)
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

        public string getCmlRemovalGrounds ()
        {
            return this.getProperty("cmlRemovalGrounds").ToString();
        }

        public void setCmlRemovalGrounds (string cmlRemovalGrounds)
        {
            this.setProperty("cmlRemovalGrounds", cmlRemovalGrounds);
        }


    }
}

