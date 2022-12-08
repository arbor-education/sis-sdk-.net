using System;
using System.Collections;
using Arbor.Resource;
using Arbor.Api.Gateway;
using Arbor.Query;
using Arbor.Model.UkDfe;

namespace Arbor.Model
{
    public class Notice : ModelBase
    {
        protected string resourceType = ResourceType.NOTICE;
        public const string NOTICE_HTML = "noticeHtml";
        public const string NOTICE_DATETIME = "noticeDatetime";
        public const string END_DATETIME = "endDatetime";

        public Notice()
        {
            base.resourceType = this.resourceType;
        }

        public Notice(string resourceType = "Notice", Hashtable properties = null, IGateway apiGateway = null)
                    : base(resourceType, properties, apiGateway)
        {

        }


        public static ModelCollection<Notice> query(SimpleQuery query = null)
        {
            if (query == null) query = new SimpleQuery();
            query.setResourceType("Notice");
            RestGateway gateway = (RestGateway)Notice.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase.setDefaultGateway() prior to calling query()");

            ModelCollection<Notice> noticeCollection = new ModelCollection<Notice>();
            ModelCollection<ModelBase> collection = gateway.query(query);

            foreach (ModelBase model in collection)
            {
                noticeCollection.add((Notice)model);
            }

            return noticeCollection;
        }

        public static Notice retrieve(string id)
        {
            RestGateway gateway = (RestGateway)Notice.getDefaultGateway();
            if (gateway == null) throw new Exception("You must call ModelBase::setDefaultGateway() prior to calling query()");
            return (Notice)gateway.retrieve(ResourceType.NOTICE, id);
        }

        public string getNoticeHtml()
        {
            return this.getProperty("noticeHtml").ToString();
        }

        public void setNoticeHtml(string noticeHtml)
        {
            this.setProperty("noticeHtml", noticeHtml);
        }

        public DateTime getNoticeDatetime()
        {
            return Convert.ToDateTime(this.getProperty("noticeDatetime"));
        }

        public void setNoticeDatetime(DateTime noticeDatetime)
        {
            this.setProperty("noticeDatetime", noticeDatetime);
        }

        public DateTime getEndDatetime()
        {
            return Convert.ToDateTime(this.getProperty("endDatetime"));
        }

        public void setEndDatetime(DateTime endDatetime)
        {
            this.setProperty("endDatetime", endDatetime);
        }


    }
}

