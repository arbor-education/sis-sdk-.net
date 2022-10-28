using System;
using Arbor.Model;
using Arbor.Query;
using System.Net;
using Newtonsoft.Json.Linq;
using Arbor.ChangeLog;
using System.Collections.Generic;

namespace Arbor.Api.Gateway
{
    public interface IGateway
    {
        ModelBase create(ModelBase model);
        ModelBase retrieve(string resource, string id);
        ModelBase update(ModelBase model);
        HttpWebResponse delete(ModelBase model);
        ModelCollection<ModelBase> query(SimpleQuery query);
        ModelBase refresh(ModelBase model);
        object instantiateModel(string resourceType);
        JObject sendRequest(string method, string url, string body = null, string headers = null);
        object castCollection<T>(ModelCollection<ModelBase> genericCollection);
        List<Change> getChanges(string resourceType, int fromRevision, int toRevision);
    }
}

