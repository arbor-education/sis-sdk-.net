using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MotorVehicle : ModelBase
    {
        protected string resourceType = ResourceType.MOTOR_VEHICLE;
        public const string OWNER = "owner";
        public const string MOTOR_VEHICLE_TYPE = "motorVehicleType";
        public const string MOTOR_VEHICLE_MAKE = "motorVehicleMake";
        public const string MODEL = "model";
        public const string COLOUR = "colour";
        public const string REGISTRATION_NUMBER = "registrationNumber";
        public const string PARKING_ALLOCATION_PROVIDED = "parkingAllocationProvided";

        public MotorVehicle ()
        {
            base.resourceType = this.resourceType;
        }
        
        public MotorVehicle (string resourceType = "MotorVehicle", Hashtable properties = null, IGateway apiGateway = null) 
        			: base (resourceType, properties, apiGateway)
        {
        
        }
        

        public static ModelCollection<MotorVehicle> query (SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery ();
        	query.setResourceType ("MotorVehicle");
        	RestGateway gateway = (RestGateway) MotorVehicle.getDefaultGateway ();
        	if(gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");
        
        	ModelCollection<MotorVehicle> motorvehicleCollection = new ModelCollection<MotorVehicle> ();
        	ModelCollection<ModelBase> collection = gateway.query (query);
        
        	foreach (ModelBase model in collection) {
        	    motorvehicleCollection.add((MotorVehicle) model);
        	}
        
        	return motorvehicleCollection;
        }

        public static MotorVehicle retrieve (string id)
        {
            RestGateway gateway = (RestGateway) MotorVehicle.getDefaultGateway();
        	if(gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
        	return (MotorVehicle) gateway.retrieve(ResourceType.MOTOR_VEHICLE, id);
        }

        public ModelBase getOwner ()
        {
            return (ModelBase) this.getProperty("owner");
        }

        public void setOwner (ModelBase owner)
        {
            this.setProperty("owner", owner);
        }

        public string getMotorVehicleType ()
        {
            return this.getProperty("motorVehicleType").ToString();
        }

        public void setMotorVehicleType (string motorVehicleType)
        {
            this.setProperty("motorVehicleType", motorVehicleType);
        }

        public MotorVehicleMake getMotorVehicleMake ()
        {
            return (MotorVehicleMake) this.getProperty("motorVehicleMake");
        }

        public void setMotorVehicleMake (MotorVehicleMake motorVehicleMake)
        {
            this.setProperty("motorVehicleMake", motorVehicleMake);
        }

        public string getModel ()
        {
            return this.getProperty("model").ToString();
        }

        public void setModel (string model)
        {
            this.setProperty("model", model);
        }

        public string getColour ()
        {
            return this.getProperty("colour").ToString();
        }

        public void setColour (string colour)
        {
            this.setProperty("colour", colour);
        }

        public string getRegistrationNumber ()
        {
            return this.getProperty("registrationNumber").ToString();
        }

        public void setRegistrationNumber (string registrationNumber)
        {
            this.setProperty("registrationNumber", registrationNumber);
        }

        public bool getParkingAllocationProvided ()
        {
            return Convert.ToBoolean( this.getProperty("parkingAllocationProvided"));
        }

        public void setParkingAllocationProvided (bool parkingAllocationProvided)
        {
            this.setProperty("parkingAllocationProvided", parkingAllocationProvided);
        }


    }
}

