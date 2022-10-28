using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class IdentityCardReader : ModelBase
    {
        protected new string resourceType = ResourceType.IDENTITY_CARD_READER;
        public const string READER_NUMBER = "readerNumber";
        public const string ROOM = "room";

        public IdentityCardReader()
        {
            base.resourceType = this.resourceType;
        }

        public IdentityCardReader(string resourceType = "IdentityCardReader", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<IdentityCardReader> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("IdentityCardReader");
            RestGateway gateway = (RestGateway)IdentityCardReader.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<IdentityCardReader> identitycardreaderCollection = new ModelCollection<IdentityCardReader>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                identitycardreaderCollection.add((IdentityCardReader)model);
            }

            return identitycardreaderCollection;
        }

        public static IdentityCardReader retrieve(string id)
        {
            RestGateway gateway = (RestGateway)IdentityCardReader.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (IdentityCardReader)gateway.retrieve(ResourceType.IDENTITY_CARD_READER, id);
        }

        public string getReaderNumber()
        {
            return this.getProperty("readerNumber").ToString();
        }

        public void setReaderNumber(string readerNumber)
        {
            this.setProperty("readerNumber", readerNumber);
        }

        public Room getRoom()
        {
            return (Room)this.getProperty("room");
        }

        public void setRoom(Room room)
        {
            this.setProperty("room", room);
        }


    }
}

