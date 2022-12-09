using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class MeetingNote : ModelBase
    {
        protected new string resourceType = ResourceType.MEETING_NOTE;
        public const string MEETING = "meeting";
        public const string NOTE_TEXT = "noteText";
        public const string NOTE_CREATED_DATETIME = "noteCreatedDatetime";
        public const string IS_SHARED_WITH_GUARDIANS = "isSharedWithGuardians";

        public MeetingNote()
        {
            base.resourceType = this.resourceType;
        }

        public MeetingNote(string resourceType = "MeetingNote", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<MeetingNote> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("MeetingNote");
            RestGateway gateway = (RestGateway)MeetingNote.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<MeetingNote> meetingnoteCollection = new ModelCollection<MeetingNote>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                meetingnoteCollection.add((MeetingNote)model);
            }

            return meetingnoteCollection;
        }

        public static MeetingNote retrieve(string id)
        {
            RestGateway gateway = (RestGateway)MeetingNote.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (MeetingNote)gateway.retrieve(ResourceType.MEETING_NOTE, id);
        }

        public Meeting getMeeting()
        {
            return (Meeting)this.getProperty("meeting");
        }

        public void setMeeting(Meeting meeting)
        {
            this.setProperty("meeting", meeting);
        }

        public string getNoteText()
        {
            return this.getProperty("noteText").ToString();
        }

        public void setNoteText(string noteText)
        {
            this.setProperty("noteText", noteText);
        }

        public DateTime getNoteCreatedDatetime()
        {
            return Convert.ToDateTime(this.getProperty("noteCreatedDatetime"));
        }

        public void setNoteCreatedDatetime(DateTime noteCreatedDatetime)
        {
            this.setProperty("noteCreatedDatetime", noteCreatedDatetime);
        }

        public bool getIsSharedWithGuardians()
        {
            return Convert.ToBoolean(this.getProperty("isSharedWithGuardians"));
        }

        public void setIsSharedWithGuardians(bool isSharedWithGuardians)
        {
            this.setProperty("isSharedWithGuardians", isSharedWithGuardians);
        }


    }
}

