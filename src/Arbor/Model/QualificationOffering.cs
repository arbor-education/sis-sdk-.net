using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class QualificationOffering : ModelBase
    {
        protected new string resourceType = ResourceType.QUALIFICATION_OFFERING;
        public const string QUALIFICATION_ELEMENT = "qualificationElement";
        public const string ACADEMIC_YEAR = "academicYear";

        public QualificationOffering()
        {
            base.resourceType = this.resourceType;
        }

        public QualificationOffering(string resourceType = "QualificationOffering", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<QualificationOffering> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("QualificationOffering");
            RestGateway gateway = (RestGateway)QualificationOffering.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<QualificationOffering> qualificationofferingCollection = new ModelCollection<QualificationOffering>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                qualificationofferingCollection.add((QualificationOffering)model);
            }

            return qualificationofferingCollection;
        }

        public static QualificationOffering retrieve(string id)
        {
            RestGateway gateway = (RestGateway)QualificationOffering.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (QualificationOffering)gateway.retrieve(ResourceType.QUALIFICATION_OFFERING, id);
        }

        public ModelBase getQualificationElement()
        {
            return (ModelBase)this.getProperty("qualificationElement");
        }

        public void setQualificationElement(ModelBase qualificationElement)
        {
            this.setProperty("qualificationElement", qualificationElement);
        }

        public AcademicYear getAcademicYear()
        {
            return (AcademicYear)this.getProperty("academicYear");
        }

        public void setAcademicYear(AcademicYear academicYear)
        {
            this.setProperty("academicYear", academicYear);
        }


    }
}

