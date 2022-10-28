using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MotorVehicleMake : ModelBase
    {
        protected new string resourceType = ResourceType.MOTOR_VEHICLE_MAKE;
        public const string CODE = "code";
        public const string ACTIVE = "active";
        public const string DATA_ORDER = "dataOrder";
        public const string MOTOR_VEHICLE_MAKE = "motorVehicleMake";

        public MotorVehicleMake ()
        {
            base.resourceType = this.resourceType;
        }
        
        public MotorVehicleMake (string resourceType = "MotorVehicleMake", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<MotorVehicleMake> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("MotorVehicleMake");
        	RestGateway gateway = (RestGateway) MotorVehicleMake.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<MotorVehicleMake> motorvehiclemakeCollection = new ModelCollection<MotorVehicleMake> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    motorvehiclemakeCollection.add((MotorVehicleMake) model);
        	}
        
        	return motorvehiclemakeCollection;
        }

        public static MotorVehicleMake retrieve (string id)
        {
            RestGateway gateway = (RestGateway) MotorVehicleMake.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (MotorVehicleMake) gateway.retrieve(ResourceType.MOTOR_VEHICLE_MAKE, id);
        }

        public string getCode ()
        {
            return this.getProperty("code").ToString();
        }

        public void setCode (string code)
        {
            this.setProperty("code", code);
        }

        public bool getActive ()
        {
            return Convert.ToBoolean(this.getProperty("active"));
        }

        public void setActive (bool active)
        {
            this.setProperty("active", active);
        }

        public int getDataOrder ()
        {
            return Convert.ToInt32(this.getProperty("dataOrder"));
        }

        public void setDataOrder (int dataOrder)
        {
            this.setProperty("dataOrder", dataOrder);
        }

        public string getMotorVehicleMake ()
        {
            return this.getProperty("motorVehicleMake").ToString();
        }

        public void setMotorVehicleMake (string motorVehicleMake)
        {
            this.setProperty("motorVehicleMake", motorVehicleMake);
        }


    }
}

