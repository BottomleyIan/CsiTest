using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace CsiTest.ActionResults
{
    public class XmlResult : ActionResult
    {
        private readonly object _data;
        public XmlResult(object data)
        {
            _data = data;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (_data != null)
            {
                var response = context.HttpContext.Response;
                response.ContentType = "text/xml";
                var serializer = new XmlSerializer(_data.GetType());
                serializer.Serialize(response.OutputStream, _data);
            }
        }
    }
}