using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationResultEmbargoViewer : ModelBase
    {
        protected string resourceType = ResourceType.QUALIFICATION_RESULT_EMBARGO_VIEWER;
        public const string VIEWER = "viewer";

        public QualificationResultEmbargoViewer()
        {
            base.resourceType = this.resourceType;
        }

        public QualificationResultEmbargoViewer(string resourceType = "QualificationResultEmbargoViewer", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<QualificationResultEmbargoViewer> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("QualificationResultEmbargoViewer");
            RestGateway gateway = (RestGateway)QualificationResultEmbargoViewer.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<QualificationResultEmbargoViewer> qualificationresultembargoviewerCollection = new ModelCollection<QualificationResultEmbargoViewer>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                qualificationresultembargoviewerCollection.add((QualificationResultEmbargoViewer)model);
            }

            return qualificationresultembargoviewerCollection;
        }

        public static QualificationResultEmbargoViewer retrieve(string id)
        {
            RestGateway gateway = (RestGateway)QualificationResultEmbargoViewer.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (QualificationResultEmbargoViewer)gateway.retrieve(ResourceType.QUALIFICATION_RESULT_EMBARGO_VIEWER, id);
        }

        public ModelBase getViewer()
        {
            return (ModelBase)this.getProperty("viewer");
        }

        public void setViewer(ModelBase viewer)
        {
            this.setProperty("viewer", viewer);
        }


    }
}

