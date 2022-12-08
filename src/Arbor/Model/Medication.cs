using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Medication : ModelBase
    {
        protected string resourceType = ResourceType.MEDICATION;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string MEDICATION_NAME = "medicationName";

        public Medication()
        {
            base.resourceType = this.resourceType;
        }

        public Medication(string resourceType = "Medication", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Medication> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Medication");
            RestGateway gateway = (RestGateway)Medication.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Medication> medicationCollection = new ModelCollection<Medication>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                medicationCollection.add((Medication)model);
            }

            return medicationCollection;
        }

        public static Medication retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Medication.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Medication)gateway.retrieve(ResourceType.MEDICATION, id);
        }

        public string getCode()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode(string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive(bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder(int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getMedicationName()
        {
            return this.getProperty("medicationName").ToString();
        }

        public void setMedicationName(string medicationName)
        {
            this.setProperty("medicationName", medicationName);
        }


    }
}

