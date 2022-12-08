using System;
using System.Collections;
using Arbor.Resource.UkDfe;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model.UkDfe
{
    public class EnrolmentMode : ModelBase
    {
        protected string resourceType = ResourceType.UK_DFE_ENROLMENT_MODE;
        public const string D00018 = "d00018";

        public EnrolmentMode()
        {
            base.resourceType = this.resourceType;
        }

        public EnrolmentMode(string resourceType = "EnrolmentMode", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<EnrolmentMode> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("UkDfe_EnrolmentMode");
            RestGateway gateway = (RestGateway)EnrolmentMode.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<EnrolmentMode> enrolmentmodeCollection = new ModelCollection<EnrolmentMode>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                enrolmentmodeCollection.add((EnrolmentMode)model);
            }

            return enrolmentmodeCollection;
        }

        public static EnrolmentMode retrieve(string id)
        {
            RestGateway gateway = (RestGateway)EnrolmentMode.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (EnrolmentMode)gateway.retrieve(ResourceType.UK_DFE_ENROLMENT_MODE, id);
        }

        public string getD00018()
        {
            return this.getProperty("d00018").ToString();
        }

        public void setD00018(string d00018)
        {
            this.setProperty("d00018", d00018);
        }


    }
}

