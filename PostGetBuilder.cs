using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentousSDK_.Net_Framework_
{
    public class PostGetBuilder
    {
        PostGet pg = new PostGet();
        public PostGetBuilder setUrlType(string urlType)
        {
            pg.urlType = urlType;
            return this;
        }
        public PostGetBuilder setMethod(string method)
        {
            pg.method = method;
            return this;
        }
        public PostGetBuilder setToken(string token)
        {
            pg.token = token;
            return this;
        }
        public PostGetBuilder setData(Dictionary<string, object> data)
        {
            pg.data = data;
            return this;
        }
        public PostGetBuilder setCompletionHandler(CompletionHandler completionHandler)
        {
            pg.completionHandler = completionHandler;
            return this;
        }
        public PostGet build()
        {
            return pg;
        }
    }
}
